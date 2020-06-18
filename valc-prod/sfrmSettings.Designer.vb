<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sfrmSettings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbProductionPath = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnFindProdPath = New System.Windows.Forms.Button()
        Me.FBD = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnFindBackupPath = New System.Windows.Forms.Button()
        Me.tbBackupPath = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chbSwitchWindow = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Production Path"
        '
        'tbProductionPath
        '
        Me.tbProductionPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbProductionPath.Location = New System.Drawing.Point(114, 10)
        Me.tbProductionPath.Name = "tbProductionPath"
        Me.tbProductionPath.Size = New System.Drawing.Size(285, 21)
        Me.tbProductionPath.TabIndex = 1
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(349, 85)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(87, 23)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnFindProdPath
        '
        Me.btnFindProdPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFindProdPath.Location = New System.Drawing.Point(407, 9)
        Me.btnFindProdPath.Name = "btnFindProdPath"
        Me.btnFindProdPath.Size = New System.Drawing.Size(29, 23)
        Me.btnFindProdPath.TabIndex = 3
        Me.btnFindProdPath.Text = "..."
        Me.btnFindProdPath.UseVisualStyleBackColor = True
        '
        'btnFindBackupPath
        '
        Me.btnFindBackupPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFindBackupPath.Location = New System.Drawing.Point(407, 39)
        Me.btnFindBackupPath.Name = "btnFindBackupPath"
        Me.btnFindBackupPath.Size = New System.Drawing.Size(29, 23)
        Me.btnFindBackupPath.TabIndex = 6
        Me.btnFindBackupPath.Text = "..."
        Me.btnFindBackupPath.UseVisualStyleBackColor = True
        '
        'tbBackupPath
        '
        Me.tbBackupPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbBackupPath.Location = New System.Drawing.Point(114, 40)
        Me.tbBackupPath.Name = "tbBackupPath"
        Me.tbBackupPath.Size = New System.Drawing.Size(285, 21)
        Me.tbBackupPath.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Backup Path"
        '
        'chbSwitchWindow
        '
        Me.chbSwitchWindow.AutoSize = True
        Me.chbSwitchWindow.Location = New System.Drawing.Point(114, 67)
        Me.chbSwitchWindow.Name = "chbSwitchWindow"
        Me.chbSwitchWindow.Size = New System.Drawing.Size(73, 19)
        Me.chbSwitchWindow.TabIndex = 7
        Me.chbSwitchWindow.Text = "Alt + Tab"
        Me.chbSwitchWindow.UseVisualStyleBackColor = True
        '
        'sfrmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 120)
        Me.Controls.Add(Me.chbSwitchWindow)
        Me.Controls.Add(Me.btnFindBackupPath)
        Me.Controls.Add(Me.tbBackupPath)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnFindProdPath)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.tbProductionPath)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sfrmSettings"
        Me.Text = "Configuration.."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbProductionPath As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnFindProdPath As System.Windows.Forms.Button
    Friend WithEvents FBD As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnFindBackupPath As Button
    Friend WithEvents tbBackupPath As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents chbSwitchWindow As CheckBox
End Class
