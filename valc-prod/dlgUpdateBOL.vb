Public Class dlgUpdateBOL

    Sub New(bol As BOLInfo)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        tbFolder.Text = bol.Batch.Folder
        tbProNumber.Text = bol.ProNo
        tbFBNumber.Text = bol.FBNo
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        DialogResult = DialogResult.OK
    End Sub

    Private Sub sfrmUpdateBOL_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class