<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sfrmQueryDetail
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
        Me.dgvQueryDetails = New System.Windows.Forms.DataGridView()
        Me.lbType = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbFolder = New System.Windows.Forms.Label()
        Me.lbTrip = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbProNumber = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbFBNumber = New System.Windows.Forms.Label()
        Me.clShipper = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clConsignee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clStart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clEnd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clQuery = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clAnswer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvQueryDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvQueryDetails
        '
        Me.dgvQueryDetails.AllowUserToAddRows = False
        Me.dgvQueryDetails.AllowUserToDeleteRows = False
        Me.dgvQueryDetails.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvQueryDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvQueryDetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clShipper, Me.clConsignee, Me.clStart, Me.clEnd, Me.clQuery, Me.clAnswer})
        Me.dgvQueryDetails.Location = New System.Drawing.Point(12, 85)
        Me.dgvQueryDetails.Name = "dgvQueryDetails"
        Me.dgvQueryDetails.RowHeadersVisible = False
        Me.dgvQueryDetails.Size = New System.Drawing.Size(610, 249)
        Me.dgvQueryDetails.TabIndex = 0
        '
        'lbType
        '
        Me.lbType.AutoSize = True
        Me.lbType.Location = New System.Drawing.Point(65, 9)
        Me.lbType.Name = "lbType"
        Me.lbType.Size = New System.Drawing.Size(39, 13)
        Me.lbType.TabIndex = 1
        Me.lbType.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(138, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Trip Number"
        '
        'lbFolder
        '
        Me.lbFolder.AutoSize = True
        Me.lbFolder.Location = New System.Drawing.Point(395, 9)
        Me.lbFolder.Name = "lbFolder"
        Me.lbFolder.Size = New System.Drawing.Size(39, 13)
        Me.lbFolder.TabIndex = 4
        Me.lbFolder.Text = "Label4"
        '
        'lbTrip
        '
        Me.lbTrip.AutoSize = True
        Me.lbTrip.Location = New System.Drawing.Point(207, 9)
        Me.lbTrip.Name = "lbTrip"
        Me.lbTrip.Size = New System.Drawing.Size(39, 13)
        Me.lbTrip.TabIndex = 5
        Me.lbTrip.Text = "Label5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(350, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Folder"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Pro #"
        '
        'lbProNumber
        '
        Me.lbProNumber.AutoSize = True
        Me.lbProNumber.Location = New System.Drawing.Point(65, 38)
        Me.lbProNumber.Name = "lbProNumber"
        Me.lbProNumber.Size = New System.Drawing.Size(39, 13)
        Me.lbProNumber.TabIndex = 7
        Me.lbProNumber.Text = "Label8"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "FB #"
        '
        'lbFBNumber
        '
        Me.lbFBNumber.AutoSize = True
        Me.lbFBNumber.Location = New System.Drawing.Point(65, 60)
        Me.lbFBNumber.Name = "lbFBNumber"
        Me.lbFBNumber.Size = New System.Drawing.Size(45, 13)
        Me.lbFBNumber.TabIndex = 9
        Me.lbFBNumber.Text = "Label10"
        '
        'clShipper
        '
        Me.clShipper.HeaderText = "Shipper"
        Me.clShipper.Name = "clShipper"
        Me.clShipper.ReadOnly = True
        '
        'clConsignee
        '
        Me.clConsignee.HeaderText = "Consignee"
        Me.clConsignee.Name = "clConsignee"
        Me.clConsignee.ReadOnly = True
        '
        'clStart
        '
        Me.clStart.HeaderText = "Start Time"
        Me.clStart.Name = "clStart"
        Me.clStart.ReadOnly = True
        '
        'clEnd
        '
        Me.clEnd.HeaderText = "End Time"
        Me.clEnd.Name = "clEnd"
        Me.clEnd.ReadOnly = True
        '
        'clQuery
        '
        Me.clQuery.HeaderText = "Query"
        Me.clQuery.Name = "clQuery"
        Me.clQuery.ReadOnly = True
        '
        'clAnswer
        '
        Me.clAnswer.HeaderText = "Answer"
        Me.clAnswer.Name = "clAnswer"
        Me.clAnswer.ReadOnly = True
        '
        'sfrmQueryDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 346)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lbFBNumber)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbProNumber)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbTrip)
        Me.Controls.Add(Me.lbFolder)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbType)
        Me.Controls.Add(Me.dgvQueryDetails)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "sfrmQueryDetail"
        Me.Text = "Query Detail"
        CType(Me.dgvQueryDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvQueryDetails As DataGridView
    Friend WithEvents lbType As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbFolder As Label
    Friend WithEvents lbTrip As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbProNumber As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbFBNumber As Label
    Friend WithEvents clShipper As DataGridViewTextBoxColumn
    Friend WithEvents clConsignee As DataGridViewTextBoxColumn
    Friend WithEvents clStart As DataGridViewTextBoxColumn
    Friend WithEvents clEnd As DataGridViewTextBoxColumn
    Friend WithEvents clQuery As DataGridViewTextBoxColumn
    Friend WithEvents clAnswer As DataGridViewTextBoxColumn
End Class
