Public Class sfrmHolder
    Public BOL As BOLInfo
    Public TimeInf As TimeInfo
    Public Query As New QueryInfo
    Public QueryForVALC As New QueryInfo
    Private rater As Boolean
    Sub New(_bol As BOLInfo, _timeinf As TimeInfo, Optional isRater As Boolean = False)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TimeInf = _timeinf
        BOL = _bol
        With _bol
            lbUsername.Text = .Username
            lbFullname.Text = .Fullname

            lbProNumber.Text = .ProNo
            lbFBNumber.Text = .FBNo

            lbStarttime.Text = _timeinf.Start
            lbElapsetime.Text = _timeinf.Endd

            lbRemark.Text = .Remarks
        End With

        rater = isRater
        If isRater Then
            btnQuery.Enabled = False
            btnSkip.Enabled = False
        End If

        tmRefresher.Enabled = True
    End Sub
    Public ReadOnly Property AvailableDate As Date
        Get
            If rater Then
                Return Now
            Else : Return BOL.Batch.Time
            End If
        End Get
    End Property
    Private Sub tm_Tick(sender As Object, e As EventArgs) Handles tmRefresher.Tick
        tmRefresher.Enabled = False
        Dim tm As TimeSpan = (AvailableDate - Date.Parse(TimeInf.Start))
        If Not rater Then
            BOL.Batch.CheckTimeManagerActivity(30)
        End If

        lbElapsetime.Text = String.Format("{0:00}:{1:00}:{2:00}", tm.Hours, tm.Minutes, tm.Seconds)

        tmRefresher.Enabled = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If BOL.Batch.Type_accr = "INT" Then
            If BOL.Batch.ForEntry = 0 And (BOL.Batch.Query Is Nothing OrElse BOL.Batch.Query.Count = 0) Then
                Using inputDispatchTime As New dlgInputDispatch With {.Bol = BOL}
                    If inputDispatchTime.ShowDialog = DialogResult.OK Then
                        BOL = inputDispatchTime.Bol
                    Else Exit Sub
                    End If
                End Using
            End If
        End If

        If MsgBox("Are you sure you want to save?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            TimeInf.Endd = AvailableDate.ToString("yyyy-MM-dd HH:mm:ss")
            If BOL.Status.ToUpper = "ANSWERED" Then
                TimeInf.Status = "BILLED QUERY"
            Else
                TimeInf.Status = "BILLED"
            End If
            DialogResult = DialogResult.OK
            Close()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MsgBox("Are you sure you want to cancel?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            DialogResult = DialogResult.Cancel
            Close()
        End If
    End Sub

    Private Function enterQuery() As QueryInfo
        Using query As New sfrmQuery
            If query.ShowDialog() = DialogResult.OK Then
                Dim _qry As QueryInfo = New QueryInfo With {.BillerQuery = query.tbQuery.Text, .ShipperName = query.tbShipper.Text, .ConsigneeName = query.tbConsignee.Text}
                Return _qry
            End If
        End Using
        Return Nothing
    End Function

    Private Sub btnQuery_Click(sender As Object, e As EventArgs) Handles btnQuery.Click, btnQuerytoVALC.Click
        '    If MsgBox("Are you sure you want to save as query?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        Dim _query As QueryInfo = enterQuery()
        If _query IsNot Nothing Then
            _query.Start = AvailableDate.ToString("yyyy-MM-dd HH:mm:ss")
            If sender.Equals(btnQuery) Then
                Query = _query
            Else : QueryForVALC = _query
            End If
            TimeInf.Endd = AvailableDate.ToString("yyyy-MM-dd HH:mm:ss")
            TimeInf.Status = "QUERY"
            DialogResult = DialogResult.OK
            Close()
        End If
        '  End If
    End Sub

    Private Sub sfrmHolder_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                btnSave.PerformClick()
            Case Keys.F3
                btnQuery.PerformClick()
            Case Keys.F5
                btnSkip.PerformClick()
            Case Keys.Escape
                btnCancel.PerformClick()
        End Select
    End Sub

    Private Sub sfrmHolder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSkip_Click(sender As Object, e As EventArgs) Handles btnSkip.Click
        Using frmSkip As New dlgSkipReason
            If frmSkip.ShowDialog() = DialogResult.OK Then
                BOL.SkippedReason = frmSkip.tbReason.Text
                TimeInf.Endd = AvailableDate.ToString("yyyy-MM-dd HH:mm:ss")
                TimeInf.Status = "SKIPPED"
                DialogResult = DialogResult.OK
            End If
        End Using
    End Sub
End Class