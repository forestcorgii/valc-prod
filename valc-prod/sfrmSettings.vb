Public Class sfrmSettings
    Public Conf As clsConf
    Public ConfPath As IO.FileInfo

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Conf.ProductionPath = General.ConvertToUNCPath(tbProductionPath.Text)
        Conf.BackupPath = General.ConvertToUNCPath(tbBackupPath.Text)
        Conf.SwitchWindow = chbSwitchWindow.Checked
        XmlSerialization.WriteToFile(ConfPath.FullName, Conf)

        MsgBox("saved.")
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbProductionPath.Text = General.ConvertToUNCPath(Conf.ProductionPath)
        tbBackupPath.Text = General.ConvertToUNCPath(Conf.BackupPath)
        chbSwitchWindow.Checked = Conf.SwitchWindow
    End Sub

    Private Sub btnFindProdPath_Click(sender As Object, e As EventArgs) Handles btnFindProdPath.Click
        FBD.SelectedPath = Conf.ProductionPath
        If FBD.ShowDialog = DialogResult.OK Then
            tbProductionPath.Text = General.ConvertToUNCPath(FBD.SelectedPath)
        End If
    End Sub
    Private Sub btnFindBackupPath_Click(sender As Object, e As EventArgs) Handles btnFindBackupPath.Click
        FBD.SelectedPath = Conf.BackupPath
        If FBD.ShowDialog = DialogResult.OK Then
            tbBackupPath.Text = General.ConvertToUNCPath(FBD.SelectedPath)
        End If
    End Sub

    Private Sub tbProductionPath_TextChanged(sender As Object, e As EventArgs) Handles tbProductionPath.TextChanged
        tbProductionPath.Text = General.ConvertToUNCPath(tbProductionPath.Text)
    End Sub
    Private Sub tbBackupPath_TextChanged(sender As Object, e As EventArgs) Handles tbBackupPath.TextChanged
        tbBackupPath.Text = General.ConvertToUNCPath(tbBackupPath.Text)
    End Sub
End Class