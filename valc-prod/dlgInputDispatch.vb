Public Class dlgInputDispatch
    Public Bol As BOLInfo
    Private Sub dlgInputDispatch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtDispatchTime.Value = Bol.Batch.Time
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Bol.Batch.DispatchedTime = dtDispatchTime.Value.ToString("yyyy-MM-dd HHmmss")
        DialogResult = DialogResult.OK
    End Sub
End Class