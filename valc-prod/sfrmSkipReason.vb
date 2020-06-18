Public Class sfrmSkipReason
    Public reason As String = ""

    Private Sub sfrmSkipReason_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbReason.Focus()
    End Sub

    Private Sub tbReason_KeyDown(sender As Object, e As KeyEventArgs) Handles tbReason.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                DialogResult = DialogResult.Cancel
            Case Keys.Enter
                DialogResult = DialogResult.OK
        End Select
    End Sub
End Class