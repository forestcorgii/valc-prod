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
    Private logTime As Date 'for raters
    Private raterBatchTemplate As BatchInfo
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Application.ProductName & " v" & Application.ProductVersion

        bolContainer = New BOLInfos
        batchContainer = New BatchInfos
        bolHolder = New BOLInfo
        raterBatchTemplate = New BatchInfo() With {.TripNo = "TRIP"}

        conf = New clsConf
        confPath = New FileInfo(String.Format("{0}\{1}.conf.xml", Application.StartupPath, Application.ProductName))
        If Not confPath.Exists Then
            MsgBox("Settings not found.")
            mnSettings.PerformClick()
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

            userInfo = New clsUserInfo() 'With {.Username = "DDCUSER109", .Fullname = "FERNANDEZ, SEAN IVAN M.", .Rater = True}
            If login() = False Then
                Close()
                Exit Sub
            Else
                If userInfo.Rater Then
                    TabControl1.SelectedIndex = 2
                Else TabControl1.SelectedIndex = 0
                End If
            End If

            tm_Tick(tm, Nothing)
            tm.Enabled = True
            tm.Interval = 500
        Else
            Close()
        End If
    End Sub

    Private Sub collectPronumbers_rater()
        If dgvProduction.Rows.Count > 0 AndAlso dgvProduction.Rows(0).Displayed = False Then
            Width += 1
        End If
        Dim pros As New List(Of String)
        pros.AddRange(Directory.GetFiles(dateFolder & "\PROCESSED\FINISH", "*_RA_*_" & userInfo.Username & ".XML"))
        For i As Integer = 0 To pros.Count - 1
            Dim pro As BOLInfo = XmlSerialization.ReadFromFile(pros(i), New BOLInfo).clone
            If bolContainer.Find(pro.ProNo, pro.FBNo) Is Nothing Then
                With pro
                    .Batch.DateFolder = dateFolder
                    .ProductionRow = New DataGridViewRow
                    .ProductionRow.CreateCells(dgvProduction)
                    .ProductionRow.SetValues(.Batch.Filename, .Batch.Folder, .Batch.TripNo, .ProNo, .FBNo, .Remarks, .Status, .Entry(.Entry.Count - 1).Start, .Entry(.Entry.Count - 1).Endd, .Remarks)
                    dgvProduction.Rows.Add(.ProductionRow)
                    bolContainer.Add(pro)
                End With
            End If
        Next

    End Sub

    Private Sub collectPronumbers()
        Dim pros As New List(Of BOLInfo)
        pros.AddRange(BOLInfos.collectProNumbers(userInfo.Username, dateFolder, BOLInfo.BOLStatus.FINISH))
        pros.AddRange(BOLInfos.collectProNumbers(userInfo.Username, dateFolder, BOLInfo.BOLStatus.QUERY))
        pros.AddRange(BOLInfos.collectProNumbers(userInfo.Username, dateFolder, BOLInfo.BOLStatus.ANSWERED))
        pros.AddRange(BOLInfos.collectProNumbers(userInfo.Username, dateFolder, BOLInfo.BOLStatus.SKIPPED))
        For i As Integer = 0 To pros.Count - 1
            Dim pro As BOLInfo = pros(i)
            If bolContainer.Find(pro.ProNo, pro.FBNo) Is Nothing And Not pro.Batch.Type = "RATER" Then

                With pro
                    'If .Batch Is Nothing Then .Batch = batchContainer.Find(.Batch.TripNo)
                    If .Batch IsNot Nothing Then
                        .Batch.DateFolder = dateFolder
                        .ProductionRow = New DataGridViewRow
                        .ProductionRow.CreateCells(dgvProduction)
                        .ProductionRow.SetValues(.Batch.Type, .Batch.DueTime, .Batch.Folder, .Batch.TripNo, .ProNo, .FBNo, .Remarks, .Status, .Entry(.Entry.Count - 1).Start, .Entry(.Entry.Count - 1).Endd, .Remarks)
                        dgvProduction.Rows.Add(.ProductionRow)
                        bolContainer.Add(pro)
                    End If
                End With
            End If
        Next
    End Sub

    Private Sub collectBatches()
        Dim batches As String() = Directory.GetFiles(dateFolder & "\BATCH")
        For Each _batch In batches
            Dim binf As BatchInfo = XmlSerialization.ReadFromFile(_batch, New BatchInfo)
            Dim oldBatch As BatchInfo = batchContainer.Find(binf.TripNo, binf.ClientEmailDateTime, binf.TimeNotified)
            With binf
                .DateFolder = dateFolder
                If oldBatch Is Nothing AndAlso (.ForEntry > 0 Or .BillCount = 0) Then
                    Select Case binf.Type_accr
                        Case "QA", "FA"
                            .BatchRow = New DataGridViewRow
                            .BatchRow.CreateCells(dgvQAFA)
                            .BatchRow.SetValues(.Filename, binf.TripNo, .TA, .BillCount, .ForEntry, .Query.Count, .Billed.Count, .Reject.Count, .Ongoing.Count, .ClientEmailDateTime, .ClientEmail)
                            batchContainer.Add(binf)
                            If binf.Type_accr = "QA" Then
                                dgvQAFA.Rows.Add(.BatchRow)
                            Else : dgvFullAudit.Rows.Add(.BatchRow)
                            End If
                        Case "INT"
                            .BatchRow = New DataGridViewRow
                            .BatchRow.CreateCells(dgvInterline)
                            .BatchRow.SetValues(.Filename, binf.TripNo, .TA, .BillCount, .XMLCount, .Partner, .Code, .Folder, .IPToZone, .CutTime, .TimeNotified, .NotifiedBy)
                            batchContainer.Add(binf)
                            dgvInterline.Rows.Add(.BatchRow)
                    End Select
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
        Next

        'If batchContainer.Count > 0 Then
        '    If batchContainer(0).Time = Nothing Then
        '        MsgBox("Time Manager is not running")
        '    End If
        'Else : MsgBox("No available batches found")
        'End If
    End Sub

    Private Sub collectFeedback()
        For Each bol As BOLInfo In bolContainer
            With bol
                If .Status = "Answered" AndAlso .QueryRow Is Nothing Then
                    .QueryRow = New DataGridViewRow
                    .QueryRow.CreateCells(dgvQueryAnswer)

                    .QueryRow.SetValues(.Query(.Query.Count - 1).Endd, .Batch.TripNo, .ProNo, .FBNo, .Query(.Query.Count - 1).BillerQuery, .Query(.Query.Count - 1).QueryAnswer, .Query.Count)
                    dgvQueryAnswer.Rows.Add(.QueryRow)
                End If
            End With
        Next
    End Sub

    Private Sub refreshBatches()
        Try
            For i As Integer = 0 To batchContainer.Count - 1
                Dim binf As BatchInfo = batchContainer(i)
                If (binf.ForEntry = 0 And binf.BillCount > 0) Or Not binf.BatchFileInfo.Exists Then
                    binf.BatchRow.DataGridView.Rows.Remove(binf.BatchRow)
                    batchContainer.Remove(binf)
                    'If binf.Type.ToUpper = "INTERLINE" Then
                    '    dgvInterline.Rows.RemoveAt(i)
                    'Else dgvQAFA.Rows.RemoveAt(i)
                    'End If
                Else : binf.RefreshRow()
                End If
            Next
        Catch ex As Exception
            '  MsgBox("on refreshBatches method - " & ex.Message)
        End Try
    End Sub
    Private Sub refreshBOL()
        Dim forRemove As New List(Of BOLInfo)
        For Each pro In bolContainer
            If pro.Batch IsNot Nothing And ((userInfo.Rater And pro.Batch.Type = "RATER") Or (Not userInfo.Rater And pro.Batch.Type <> "RATER")) Then
                If bolHolder Is Nothing Then Exit For
                pro.RefreshProductionRow(TabControl1.SelectedIndex)
            Else : forRemove.Add(pro)
            End If

            If pro.Status = "BILLED QUERY" AndAlso pro.QueryRow IsNot Nothing Then
                dgvQueryAnswer.Rows.Remove(pro.QueryRow)
                pro.QueryRow = Nothing
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

        If bolHolder.Batch.BillCount <> 0 And bolHolder.Batch.ForEntry = 0 And (bolHolder.Batch.Query Is Nothing OrElse bolHolder.Batch.Query.Count = 0) Then
            MsgBox("Batch already reached the maximum for entry.")
            Return False
        End If
        'If bolHolder.Batch.Type_accr = "INT" And (cbRemark.SelectedIndex = 0 Or cbRemark.SelectedIndex = 1) Then 'if on interline tab and has qafa or full audit remark
        '    MsgBox("You're using an Interline Batch")
        'cbRemark.SelectedIndex = 0
        '        Return False
        '    ElseIf Not bolHolder.Batch.Type_accr = "INT" And cbRemark.SelectedIndex = 2 Then 'if on qafa tab and has interline remark
        '        MsgBox("You're using a QA-FA Batch")
        '    cbRemark.SelectedIndex = 2
        '    Return False
        'End If

        If bolHolder.Batch.CheckTimeManagerActivity(30) = False Then Return False
        Return True
    End Function
    Private Function validateFields_rater() As Boolean
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

        If bolContainer.Find(tbProNumber.Text, tbFBNumber.Text) IsNot Nothing Then
            MsgBox("Duplicate Pro Number or FB Number found")
            Return False
        End If
        Return True
    End Function
    Private Sub clearFields()
        'tbFolder.Text = ""
        'tbTripNumber.Text = ""

        tbProNumber.Text = ""
        tbFBNumber.Text = ""


        tbStarttime.Text = ""
        tbEndtime.Text = ""

        If userInfo IsNot Nothing AndAlso userInfo.Rater Then
            tbProNumber.Focus()
            tbProNumber.SelectAll()
        Else
            tbTripNumber.Focus()
            tbTripNumber.SelectAll()
        End If
    End Sub

    Private Sub mnSettings_Click(sender As Object, e As EventArgs) Handles mnSettings.Click
        Using formsettings As New sfrmSettings() With {.Conf = conf, .ConfPath = confPath}
            If formsettings.ShowDialog() = DialogResult.OK Then
                conf = formsettings.Conf
            End If
        End Using
    End Sub

    Private Sub dgvBatches_CurrentCellChanged(sender As Object, e As EventArgs) Handles dgvQAFA.CurrentCellChanged, dgvQAFA.GotFocus,
                                                                                dgvInterline.CurrentCellChanged, dgvInterline.GotFocus,
                                                                                dgvFullAudit.CurrentCellChanged, dgvFullAudit.GotFocus

        If sender.CurrentCell IsNot Nothing Then
            clearFields()
            Dim _curridx As Integer = sender.CurrentCell.RowIndex
            bolHolder = New BOLInfo
            Dim colCnt As Short = sender.columns.count
            If sender.name.toupper = "DGVINTERLINE" Then
                bolHolder.Batch = batchContainer.Find(sender.Rows(_curridx).Cells(1).Value, timeNotified:=sender.Rows(_curridx).Cells(colCnt - 2).Value)
            Else bolHolder.Batch = batchContainer.Find(sender.Rows(_curridx).Cells(1).Value, clientEmailDate:=sender.Rows(_curridx).Cells(colCnt - 3).Value)
            End If

            If bolHolder.Batch IsNot Nothing Then
                tbTripNumber.Text = bolHolder.Batch.TripNo
                tbFolder.Text = bolHolder.Batch.Folder
            End If
        End If
    End Sub

    Private Sub dgvProduction_CurrentCellChanged(sender As Object, e As EventArgs) Handles dgvProduction.CurrentCellChanged, dgvProduction.GotFocus
        If dgvProduction.CurrentCell IsNot Nothing Then
            clearFields()
            Dim _curridx As Integer = dgvProduction.CurrentCell.RowIndex
            bolHolder = bolContainer.Find(dgvProduction.Rows(_curridx).Cells(3).Value, dgvProduction.Rows(_curridx).Cells(4).Value)
            If bolHolder IsNot Nothing Then
                If Not userInfo.Rater Then
                    If bolHolder.Batch IsNot Nothing Then
                        tbTripNumber.Text = bolHolder.Batch.TripNo
                        tbFolder.Text = bolHolder.Batch.Folder
                    End If
                    tbProNumber.Text = bolHolder.ProNo
                    tbFBNumber.Text = bolHolder.FBNo
                    cbRemark.Text = bolHolder.Remarks
                    tbStarttime.Text = bolHolder.Entry(0).Start
                End If
                cbRemark.Focus()
                cbRemark.SelectAll()
            End If
        End If
    End Sub
    Private Sub dgvProduction_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvProduction.CellMouseDoubleClick
        Using editor As New dlgUpdateBOL(bolHolder)
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
            If bolHolder.Batch Is Nothing Then
                bolHolder.Batch = batchContainer.Find(dgvQueryAnswer.Rows(_curridx).Cells(1).Value)
            End If
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
        If (userInfo.Rater AndAlso validateFields_rater()) OrElse (Not userInfo.Rater AndAlso validateFields()) Then
            If Not userInfo.Rater Then
                bolHolder = bolHolder.Clone
            Else
                bolHolder = New BOLInfo
            End If
        Else Exit Sub
        End If

        With bolHolder
            If Not userInfo.Rater Then
                .Batch.Folder = tbFolder.Text
                .Batch.TripNo = tbTripNumber.Text

                .Remarks = cbRemark.Text
            Else
                If .Batch Is Nothing Then
                    .Batch = raterBatchTemplate
                    .Batch.DateFolder = dateFolder
                    .Batch.Type = "RATER"
                    .Batch.BillDateAdded = logTime.ToString("yyyy-MM-dd HH:mm:ss")
                End If
                '       .LogTime = logTime.ToString("yyyy-MM-dd HH:mm:ss")
            End If
            .ProNo = tbProNumber.Text
            .FBNo = tbFBNumber.Text

            .Username = userInfo.Username
            .Fullname = userInfo.Fullname

            Dim startTime As String = Now.ToString("yyyy-MM-dd HH:mm:ss")
            If Not userInfo.Rater AndAlso .Batch IsNot Nothing Then
                startTime = .Batch.Time.ToString("yyyy-MM-dd HH:mm:ss")
            End If

            Using holder As New sfrmHolder(bolHolder, New TimeInfo With {.Start = startTime}, userInfo.Rater) 'Date.Parse(tbStarttime.Text)
                .Write("ONGOING")
                If holder.ShowDialog = DialogResult.OK Then
                    .Entry.Add(holder.TimeInf)
                    .Status = holder.TimeInf.Status
                    If holder.Query.BillerQuery <> "" Then
                        .Query.Add(holder.Query)
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

    End Sub

    Public Sub captureScreen(filename As String, status As String)
        If conf.SwitchWindow Then
            System.Windows.Forms.SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(1000)
        End If

        Dim tries As Integer
        While tries >= 3
            SendKeys.Send("{PRTSC}")
            System.Threading.Thread.Sleep(1000)
            Dim Screenshot As Image = Clipboard.GetImage()
            Dim filepath As New FileInfo(String.Format("{0}\{1}\{2}_{3}.png", conf.BackupPath, Now.ToString("yyyyMMdd"), filename, status))
            filepath.Directory.Create()
            If Screenshot IsNot Nothing Then
                Screenshot.Save(filepath.FullName)
                Exit While
            Else : MsgBox("Screenshot failed.")
                tries += 1
            End If
        End While

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
                       'dateFolder = Directory.GetDirectories(productionPath, Now.ToString("yyyyMMdd")).FirstOrDefault
                       If dateFolder IsNot Nothing And dateFolder <> "" And userInfo IsNot Nothing Then

                           If userInfo.Rater Then
                               collectPronumbers_rater()
                           Else
                               collectBatches()
                               refreshBatches()
                               collectFeedback()

                               collectPronumbers()
                           End If
                           refreshBOL()
                       Else
                           dateFolder = productionPath & "\" & Now.ToString("yyyyMMdd")
                           Directory.CreateDirectory(productionPath & "\" & Now.ToString("yyyyMMdd"))
                           SetupProduction()
                       End If
                   End Sub)
        Catch ex As Exception
            'MsgBox(ex.ToString)
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
        Using userLogin As New dlgLogin(userInfo)
            If userLogin.ShowDialog() = DialogResult.OK Then
                userInfo = userLogin.User
                lbFullname.Text = userInfo.Fullname
                lbUsername.Text = userInfo.Username
                logTime = Now

                Dim tabControl1_bottom As Integer = TabControl1.Top + TabControl1.Height
                Dim dgvQuery_bottom As Integer = dgvQueryAnswer.Top + dgvQueryAnswer.Height
                If userInfo.Rater Then
                    TabControl1.Height += dgvQuery_bottom - tabControl1_bottom
                    dgvQueryAnswer.Visible = False
                Else
                    If TabControl1.Height > 270 Then
                        TabControl1.Height = (dgvQueryAnswer.Top - TabControl1.Top)
                        dgvQueryAnswer.Visible = True
                    End If
                End If
                Return True
            Else : Return False
            End If
        End Using
    End Function


    Private Sub tbProNumber_KeyDown(sender As Object, e As KeyEventArgs) Handles tbFolder.KeyDown, tbTripNumber.KeyDown, tbProNumber.KeyDown, tbFBNumber.KeyDown, cbRemark.KeyDown
        Select Case sender.name
            'Case cbRemark.Name
            '    If e.KeyCode = Keys.Enter Then
            '        tbTripNumber.Focus()
            '        tbTripNumber.SelectAll()
            '    End If
            Case tbTripNumber.Name
                If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
                    tbFolder.Focus()
                    tbFolder.SelectAll()
                    'ElseIf e.KeyCode = Keys.Up Then
                    '    cbRemark.Focus()
                    '    cbRemark.SelectAll()
                End If
            Case tbFolder.Name
                If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
                    tbProNumber.Focus()
                    tbProNumber.SelectAll()
                ElseIf e.KeyCode = Keys.Up Then
                    tbTripNumber.Focus()
                    tbTripNumber.SelectAll()
                End If
            Case tbProNumber.Name
                If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
                    tbFBNumber.Focus()
                    tbFBNumber.SelectAll()
                ElseIf e.KeyCode = Keys.Up Then
                    tbFolder.Focus()
                    tbFolder.SelectAll()
                End If
            Case tbFBNumber.Name
                If e.KeyCode = Keys.Up Then
                    tbProNumber.Focus()
                    tbProNumber.SelectAll()
                End If
        End Select
    End Sub

    Private Sub cbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbType.SelectedIndexChanged
        If TabControl1.SelectedIndex <> 2 Then
            tbFolder.ReadOnly = cbType.SelectedIndex = 1
            tbTripNumber.ReadOnly = True ' (cbType.SelectedIndex = 0 Or cbType.SelectedIndex = 2)
        End If
    End Sub
    Private Sub disableFields(enable As Boolean)
        cbRemark.Enabled = enable
        tbFolder.Enabled = enable
        tbTripNumber.Enabled = enable
        tbProNumber.Enabled = enable
        tbFBNumber.Enabled = enable
    End Sub

    Private Sub TabControl1_TabIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged, TabControl1.TabIndexChanged
        'If userInfo Is Nothing Then Exit Sub
        If userInfo IsNot Nothing AndAlso userInfo.Rater Then TabControl1.SelectedIndex = 3 'to prevent going to batches tab
        disableFields(True)

        Try
            Select Case TabControl1.SelectedIndex
                Case 0
                    tbFolder.ReadOnly = False
                    tbTripNumber.ReadOnly = True
                    cbType.SelectedIndex = 0
                    dgvBatches_CurrentCellChanged(dgvFullAudit, Nothing)
                Case 1
                    tbFolder.ReadOnly = True
                    tbTripNumber.ReadOnly = False
                    cbType.SelectedIndex = 1
                    dgvBatches_CurrentCellChanged(dgvQAFA, Nothing)
                Case 2
                    tbFolder.ReadOnly = False
                    tbTripNumber.ReadOnly = True
                    cbType.SelectedIndex = 2
                    dgvBatches_CurrentCellChanged(dgvInterline, Nothing)
                Case 3
                    cbType.SelectedIndex = 3
                    dgvProduction_CurrentCellChanged(dgvProduction, Nothing)
                    disableFields(False)
                    If userInfo.Rater Then
                        cbType.SelectedIndex = 4
                        tbProNumber.Enabled = True
                        tbFBNumber.Enabled = True
                    Else
                        tbFolder.Enabled = False
                        tbTripNumber.Enabled = False
                    End If
                    cbRemark.Focus()
                    cbRemark.SelectAll()
            End Select
        Catch ex As Exception
        End Try
    End Sub

    Public Sub SetupProduction()
        Directory.CreateDirectory(dateFolder & "\BATCH\")
        Directory.CreateDirectory(dateFolder & "\ONGOING")
        Directory.CreateDirectory(dateFolder & "\PROCESSED\QUERY")
        Directory.CreateDirectory(dateFolder & "\PROCESSED\Skipped")
        Directory.CreateDirectory(dateFolder & "\PROCESSED\FINISH")
        Directory.CreateDirectory(dateFolder & "\PROCESSED\QUERY\ANSWERED")
    End Sub

    Private Sub dgvQueryAnswer_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvQueryAnswer.CellContentDoubleClick
        If bolHolder Is Nothing OrElse bolHolder.Query Is Nothing OrElse bolHolder.Query.Count = 0 Then
            MsgBox("Query Details not available.")
            Exit Sub
        End If
        Using queries As New sfrmQueryDetail With {.Bol = bolHolder}
            queries.ShowDialog()
        End Using
    End Sub
End Class
