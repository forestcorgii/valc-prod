Imports System.IO
Public Class frmMain
    Private productionPath As String
    Private currentIdx As Integer
    Private batchContainer As BatchInfos
    Private bolContainer As BOLInfos
    Private bolHolder As BOLInfo
    Private dateFolder As String
    Private confPath As FileInfo
    Private conf As clsConf
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Application.ProductName & " v" & Application.ProductVersion

        bolContainer = New BOLInfos
        batchContainer = New BatchInfos

        conf = New clsConf
        confPath = New FileInfo(String.Format("{0}\{1}.conf.xml", Application.StartupPath, Application.ProductName))
        If Not confPath.Exists Then
            MsgBox("Settings not found.")
            mnSettings.PerformClick()
            'Using formsettings As New sfrmSettings() With {.Conf = conf, .ConfPath = confPath}
            '    If formsettings.ShowDialog() = DialogResult.OK Then
            '        conf = formsettings.Conf
            '    End If
            'End Using
        End If

        If confPath.Exists Then
            conf = XmlSerialization.ReadFromFile(confPath.FullName, New clsConf)
            If Directory.Exists(conf.BackupPath) = False Or Directory.Exists(conf.ProductionPath) = False Then
                conf.ProductionPath = ""
                conf.BackupPath = ""
                mnSettings.PerformClick()
            End If

            productionPath = conf.ProductionPath
            clearFields()

            collectBatches()
            If batchContainer.Count > 0 Then
                If batchContainer(0).Time <> Nothing Then
                    userInfo = New clsUserInfo() 'With {.Username = "DDCUSER109", .Fullname = "FERNANDEZ, SEAN IVAN M."}
                    If login() = False Then
                        Close()
                        Exit Sub
                    Else
                        If userInfo.Rater Then
                            dgvBatches.Visible = False
                        End If
                    End If
                Else : MsgBox("Time Manager is not running")
                End If
            Else : MsgBox("No available batches found")
            End If

            tm_Tick(tm, Nothing)
            tm.Enabled = True
            tm.Interval = 1000
        Else
            Close()
        End If
    End Sub

    Private Sub collectPronumbers()
        If userInfo Is Nothing Then Exit Sub
        Dim pros As New List(Of BOLInfo)
        pros.AddRange(BOLInfos.collectProNumbers(userInfo.Username, dateFolder, BOLInfo.BOLStatus.FINISH))
        pros.AddRange(BOLInfos.collectProNumbers(userInfo.Username, dateFolder, BOLInfo.BOLStatus.QUERY))
        pros.AddRange(BOLInfos.collectProNumbers(userInfo.Username, dateFolder, BOLInfo.BOLStatus.ANSWERED))
        pros.AddRange(BOLInfos.collectProNumbers(userInfo.Username, dateFolder, BOLInfo.BOLStatus.SKIPPED))
        For i As Integer = 0 To pros.Count - 1
            Dim pro As BOLInfo = pros(i)
            If bolContainer.Find(pro.ProNo, pro.FBNo) Is Nothing Then
                With pro
                    .Batch = batchContainer.Find(.Batch.TripNo)
                    If .Batch IsNot Nothing Then
                        .ProductionRow = New DataGridViewRow
                        .ProductionRow.CreateCells(dgvProduction)
                        .ProductionRow.SetValues(.Batch.ClientEmailDateTime, .Batch.Folder, .Batch.TripNo, .ProNo, .FBNo, .Remarks, .Status, .Entry(.Entry.Count - 1).Start, .Entry(.Entry.Count - 1).Endd, .Remarks)
                        bolContainer.Add(pro)
                        dgvProduction.Rows.Add(.ProductionRow)
                    End If
                End With
            End If
        Next
    End Sub

    Private Sub collectBatches()
        dateFolder = Directory.GetDirectories(productionPath, Now.ToString("yyyyMMdd")).FirstOrDefault
        If dateFolder Is Nothing Then Exit Sub
        Dim batches As String() = Directory.GetFiles(dateFolder & "\BATCH")
        For Each _batch In batches
            If Not _batch.Contains("HOLD") Then
                Dim binf As BatchInfo = XmlSerialization.ReadFromFile(_batch, New BatchInfo)
                Dim oldBatch As BatchInfo = batchContainer.Find(binf.TripNo)
                With binf
                    .DateFolder = dateFolder
                    If oldBatch Is Nothing AndAlso (.ForEntry > 0 Or .BillCount = 0) Then
                        .BatchRow = New DataGridViewRow
                        .BatchRow.CreateCells(dgvBatches)
                        .BatchRow.SetValues(.Filename, binf.TripNo, .TA, .BillCount, .ForEntry, .Query.Count, .Billed.Count, .Reject.Count, .Ongoing.Count, .ClientEmailDateTime, .ClientEmail)
                        batchContainer.Add(binf)
                        dgvBatches.Rows.Add(.BatchRow)
                    ElseIf oldBatch IsNot Nothing Then
                        If oldBatch.Modified Then
                            oldBatch.BillCount = .BillCount
                            oldBatch.ClientEmail = .ClientEmail
                            oldBatch.ClientEmailDateTime = .ClientEmailDateTime
                            oldBatch.DDCSentEmailDateTime = .DDCSentEmailDateTime
                            oldBatch.Folder = .Folder
                            oldBatch.TripNo = .TripNo
                            oldBatch.Synergized = .Synergized
                            oldBatch.Remarks = .Remarks
                        End If
                    End If
                End With
            End If
        Next
    End Sub

    Private Sub collectFeedback()
        If userInfo Is Nothing Then Exit Sub
        dgvQueryAnswer.Rows.Clear()
        Dim _answeredQuery As String = dateFolder & "\PROCESSED\QUERY\ANSWERED\"
        If Directory.Exists(_answeredQuery) Then
            Dim bolpaths As String() = Directory.GetFiles(_answeredQuery, "*" & userInfo.Username & ".XML")
            Dim bols As New List(Of BOLInfo)
            For Each bolpath In bolpaths
                Dim bol As BOLInfo = XmlSerialization.ReadFromFile(bolpath, New BOLInfo)
                For Each query As QueryInfo In bol.Query
                    dgvQueryAnswer.Rows.Add(query.Endd, bol.Batch.TripNo, bol.ProNo, bol.FBNo, query.BillerQuery, query.QueryAnswer)
                Next
            Next
        End If
    End Sub

    Private Sub refreshBatches()
        Try
            For i As Integer = 0 To batchContainer.Count - 1
                Dim binf As BatchInfo = batchContainer(i)
                If (binf.ForEntry = 0 And binf.BillCount > 0) Or binf.Filename.Contains("HOLD") Or Not binf.BatchFileInfo.Exists Then
                    batchContainer.Remove(binf)
                    dgvBatches.Rows.RemoveAt(i)
                Else : binf.RefreshRow()
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub
    Private Sub refreshBOL()
        Dim forRemove As New List(Of BOLInfo)
        For Each pro In bolContainer
            If pro.Batch IsNot Nothing Then
                pro.RefreshProductionRow()
            Else : forRemove.Add(pro)
            End If
        Next
        forRemove.ForEach(Sub(p As BOLInfo)
                              dgvProduction.Rows.Remove(p.ProductionRow)
                              bolContainer.Remove(p)
                          End Sub)
    End Sub
    Private Function validateFields() As Boolean
        If userInfo Is Nothing Then
            Return login()
        End If

        If tbProNumber.Text = "" Then
            MsgBox("Pro Number should not be blank.")
            Return False
        End If

        If tbFBNumber.Text = "" Then
            MsgBox("FB Number should not be blank.")
            Return False
        End If
        If Not (bolHolder.Query.Count > 0 AndAlso bolHolder.Query(bolHolder.Query.Count - 1).QueryAnswer <> "" _
            AndAlso bolHolder.Status = "Answered") Then
            If bolContainer.Find(tbProNumber.Text, tbFBNumber.Text) IsNot Nothing Then
                MsgBox("Duplicate Pro Number or FB Number found")
                Return False
            End If
        End If

        'If tbFolder.Text = "" Then
        '    MsgBox("Folder is blank")
        '    Return False
        'End If

        'If Date.TryParse(tbStarttime.Text, New Date) = False Then
        '    MsgBox("Invalid Datetime format on Start Time")
        '    Return False
        'End If
        If bolHolder.Batch.CheckTimeManagerActivity(5) = False Then Return False
        Return True
    End Function
    Private Sub clearFields()
        tbProNumber.Text = ""
        tbFBNumber.Text = ""
    
        ' tbAudittime.Text = ""
        tbStarttime.Text = ""
        tbEndtime.Text = ""

        cbRemark.SelectedIndex = 0
    End Sub

    Private Sub mnSettings_Click(sender As Object, e As EventArgs) Handles mnSettings.Click
        Using formsettings As New sfrmSettings() With {.Conf = conf, .ConfPath = confPath}
            If formsettings.ShowDialog() = DialogResult.OK Then
                conf = formsettings.Conf
            End If
        End Using
    End Sub

    Private Sub dgv_CurrentCellChanged(sender As Object, e As EventArgs) Handles dgvBatches.CurrentCellChanged, dgvBatches.GotFocus
        If dgvBatches.CurrentCell IsNot Nothing Then
            clearFields()
            Dim _curridx As Integer = dgvBatches.CurrentCell.RowIndex
            bolHolder = New BOLInfo
            bolHolder.Batch = batchContainer.Find(dgvBatches.Rows(_curridx).Cells(1).Value)
            tbTripNumber.Text = bolHolder.Batch.TripNo
            tbFolder.Text = bolHolder.Batch.Folder

            If Not tbProNumber.Enabled Then
                tbProNumber.Enabled = True
                tbFBNumber.Enabled = True
            End If

            tbProNumber.Focus()
            tbProNumber.SelectAll()
        End If
    End Sub

    Private Sub dgvProduction_CurrentCellChanged(sender As Object, e As EventArgs) Handles dgvProduction.CurrentCellChanged, dgvProduction.GotFocus
        If dgvProduction.CurrentCell IsNot Nothing Then
            clearFields()
            Dim _curridx As Integer = dgvProduction.CurrentCell.RowIndex
            bolHolder = bolContainer.Find(dgvProduction.Rows(_curridx).Cells(3).Value, dgvProduction.Rows(_curridx).Cells(4).Value)
            bolHolder.Batch = batchContainer.Find(dgvProduction.Rows(_curridx).Cells(2).Value)
            If bolHolder.Batch IsNot Nothing Then
                tbTripNumber.Text = bolHolder.Batch.TripNo
                tbFolder.Text = bolHolder.Batch.Folder
                If Not userInfo.Rater Then
                    tbProNumber.Text = bolHolder.ProNo
                    tbFBNumber.Text = bolHolder.FBNo
                    cbRemark.Text = bolHolder.Remarks
                    tbStarttime.Text = bolHolder.Entry(0).Start
                End If
                tbProNumber.Focus()
                tbProNumber.SelectAll()

                If tbProNumber.Enabled And Not userInfo.Rater Then
                    tbProNumber.Enabled = False
                    tbFBNumber.Enabled = False
                End If
            End If
        End If
    End Sub
    Private Sub dgvProduction_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvProduction.CellMouseDoubleClick
        MsgBox(bolHolder.ProNo)
        Using editor As New sfrmUpdateBOL(bolHolder)
            If editor.ShowDialog = DialogResult.OK Then
                bolHolder.Delete(bolHolder.Status)
                bolHolder.ProNo = editor.tbProNumber.Text
                bolHolder.FBNo = editor.tbFBNumber.Text
                bolHolder.Write(bolHolder.Status)
            End If
        End Using
    End Sub

    Private Sub dgvQueryAnswer_CurrentCellChanged(sender As Object, e As EventArgs) Handles dgvQueryAnswer.CurrentCellChanged
        If dgvQueryAnswer.CurrentCell IsNot Nothing AndAlso bolContainer.Count > 0 Then
            clearFields()
            Dim _curridx As Integer = dgvQueryAnswer.CurrentCell.RowIndex
            bolHolder = bolContainer.Find(dgvQueryAnswer.Rows(_curridx).Cells(2).Value, dgvQueryAnswer.Rows(_curridx).Cells(3).Value)
            bolHolder.Batch = batchContainer.Find(dgvQueryAnswer.Rows(_curridx).Cells(1).Value)
            tbTripNumber.Text = bolHolder.Batch.TripNo
            tbFolder.Text = bolHolder.Batch.Folder
            tbProNumber.Text = bolHolder.ProNo
            tbFBNumber.Text = bolHolder.FBNo
            cbRemark.Text = bolHolder.Remarks
            tbProNumber.Focus()
            tbProNumber.SelectAll()
        End If
    End Sub
    Private Sub mnAddBill_Click(sender As Object, e As EventArgs) Handles mnAddBill.Click
        If validateFields() Then
            bolHolder = bolHolder.Clone
            With bolHolder
                .ProNo = tbProNumber.Text
                .FBNo = tbFBNumber.Text
                .Remarks = cbRemark.Text

                .Username = userInfo.Username
                .Fullname = userInfo.Fullname

                Dim startTime As String = Now.ToString("yyyy-MM-dd HH:mm:ss")
                If .Batch IsNot Nothing Then
                    .Batch.Time.ToString("yyyy-MM-dd HH:mm:ss")
                End If

                Using holder As New sfrmHolder(bolHolder, New TimeInfo With {.Start = startTime}, userInfo.Rater) 'Date.Parse(tbStarttime.Text)
                    .Write("ONGOING")
                    If holder.ShowDialog = DialogResult.OK Then
                        .Entry.Add(holder.TimeInf)
                        .Status = holder.TimeInf.Status
                        If holder.Query.BillerQuery <> "" Then
                            .Query.Add(holder.Query)
                            '.Write(BOLInfo.BOLStatus.QUERY)
                        Else
                            '.Write(BOLInfo.BOLStatus.FINISH)
                        End If
                        .Write(.Status)
                    End If
                    .Delete("ONGOING")
                    .Delete("ANSWERED")
                    captureScreen(.Filename, .Status)
                    clearFields()
                End Using

                .Query = New List(Of QueryInfo)
                .Entry = New List(Of TimeInfo)
            End With
        End If
    End Sub

    Public Sub captureScreen(filename As String, status As String)
        If conf.SwitchWindow Then
            System.Windows.Forms.SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(1000)
        End If

        SendKeys.Send("{PRTSC}")
        Dim Screenshot As Image = Clipboard.GetImage()

        Dim filepath As New FileInfo(String.Format("{0}\{1}\{2}_{3}.png", conf.BackupPath, Now.ToString("yyyyMMdd"), filename, status))
        filepath.Directory.Create()
        If Screenshot IsNot Nothing Then
            Screenshot.Save(filepath.FullName)
        Else : MsgBox("Sccreenshot failed.")
        End If

        'Using screenCapture As Bitmap = New Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
        '    Using g As Graphics = Graphics.FromImage(screenCapture)
        '        g.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
        '             Screen.PrimaryScreen.Bounds.Y,
        '             0, 0,
        '             screenCapture.Size,
        '             CopyPixelOperation.SourceCopy)

        '        Dim filepath As New FileInfo(String.Format("{0}\{1}\{2}_{3}.png", conf.BackupPath, Now.ToString("yyyyMMdd"), filename, status))
        '        filepath.Directory.Create()

        '        screenCapture.Save(filepath.FullName)
        '    End Using
        'End Using
    End Sub

    Private Sub tm_Tick(sender As Object, e As EventArgs) Handles tm.Tick
        tm.Enabled = False
        If Not bgRefresher.IsBusy Then bgRefresher.RunWorkerAsync()
    End Sub

    Private Sub bgRefresher_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgRefresher.DoWork
        Try
            Invoke(Sub()
                       refreshBOL()
                       collectBatches()
                       refreshBatches()
                       collectFeedback()
                       collectPronumbers()
                   End Sub)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub bgRefresher_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgRefresher.RunWorkerCompleted
        tm.Enabled = True
    End Sub

    Private userInfo As clsUserInfo
    Private Sub mnRelogin_Click(sender As Object, e As EventArgs) Handles mnRelogin.Click
        login()
    End Sub
    Private Function login() As Boolean
        Using userLogin As New sfrmLogin(userInfo)
            If userLogin.ShowDialog() = DialogResult.OK Then
                userInfo = userLogin.User
                lbFullname.Text = userInfo.Fullname
                lbUsername.Text = userInfo.Username
                Return True
            Else : Return False
            End If
        End Using
    End Function

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Enter
        dgv_CurrentCellChanged(dgvBatches, Nothing)

    End Sub

    Private Sub tbProNumber_KeyDown(sender As Object, e As KeyEventArgs) Handles tbProNumber.KeyDown, tbFBNumber.KeyDown, cbRemark.KeyDown
        Select Case sender.name.toupper
            Case "TBPRONUMBER"
                If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
                    tbFBNumber.Focus()
                    tbFBNumber.SelectAll()
                End If
            Case "TBFBNUMBER"
                If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
                    cbRemark.Focus()
                    cbRemark.SelectAll()
                ElseIf e.KeyCode = Keys.Up Then
                    tbProNumber.Focus()
                    tbProNumber.SelectAll()
                End If
            Case "CBREMARK"
                If e.KeyCode = Keys.Up And cbRemark.SelectedIndex = 0 Then
                    tbFBNumber.Focus()
                    tbFBNumber.SelectAll()
                End If
        End Select
    End Sub


End Class
