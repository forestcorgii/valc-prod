<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ControlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnAddBill = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnRelogin = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lbFullname = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbUsername = New System.Windows.Forms.ToolStripStatusLabel()
        Me.cbRemark = New System.Windows.Forms.ComboBox()
        Me.tbEndtime = New System.Windows.Forms.TextBox()
        Me.tbStarttime = New System.Windows.Forms.TextBox()
        Me.tbFolder = New System.Windows.Forms.TextBox()
        Me.tbProNumber = New System.Windows.Forms.TextBox()
        Me.tbFBNumber = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvQueryAnswer = New System.Windows.Forms.DataGridView()
        Me.clSendTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clTrip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clProNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clFBNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clQueryContent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clQueryAnswer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clTotalQuery = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvQAFA = New System.Windows.Forms.DataGridView()
        Me.clFilename = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clsTripNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clsBillCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clsForEntry = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clQuery = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clsBilled = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clReject = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clsOngoing = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clsDatetime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clSender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clBatchRemarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tm = New System.Windows.Forms.Timer(Me.components)
        Me.bgRefresher = New System.ComponentModel.BackgroundWorker()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.dgvFullAudit = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dgvInterline = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvProduction = New System.Windows.Forms.DataGridView()
        Me.tbTripNumber = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cbType = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.clFilename_INT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clTripNo_INT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clTA_INT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clBillCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clXMLCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clPartner = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clFolder_INT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clIPTOZone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clCutTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clTimeNotified = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clNotifiedBy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clType_prod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clDatetime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clFolder = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clProdTripNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clProdProNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clProdFBNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clProdRemark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clStarttime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clEndtime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.dgvQueryAnswer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvQAFA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.dgvFullAudit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgvInterline, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvProduction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ControlsToolStripMenuItem, Me.mnSettings})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1035, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ControlsToolStripMenuItem
        '
        Me.ControlsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnAddBill, Me.mnRelogin})
        Me.ControlsToolStripMenuItem.Name = "ControlsToolStripMenuItem"
        Me.ControlsToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.ControlsToolStripMenuItem.Text = "Controls"
        '
        'mnAddBill
        '
        Me.mnAddBill.Name = "mnAddBill"
        Me.mnAddBill.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.mnAddBill.Size = New System.Drawing.Size(134, 22)
        Me.mnAddBill.Text = "Add Bill"
        '
        'mnRelogin
        '
        Me.mnRelogin.Name = "mnRelogin"
        Me.mnRelogin.Size = New System.Drawing.Size(134, 22)
        Me.mnRelogin.Text = "Re-Login"
        '
        'mnSettings
        '
        Me.mnSettings.Name = "mnSettings"
        Me.mnSettings.Size = New System.Drawing.Size(61, 20)
        Me.mnSettings.Text = "Settings"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbFullname, Me.lbUsername})
        Me.StatusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 396)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1035, 20)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lbFullname
        '
        Me.lbFullname.Name = "lbFullname"
        Me.lbFullname.Size = New System.Drawing.Size(71, 15)
        Me.lbFullname.Text = "USERNAME:"
        '
        'lbUsername
        '
        Me.lbUsername.Name = "lbUsername"
        Me.lbUsername.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbUsername.Size = New System.Drawing.Size(68, 15)
        Me.lbUsername.Text = "USERNAME"
        Me.lbUsername.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'cbRemark
        '
        Me.cbRemark.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRemark.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRemark.FormattingEnabled = True
        Me.cbRemark.Items.AddRange(New Object() {"", "Processed in Synergize", "Skipped Bills"})
        Me.cbRemark.Location = New System.Drawing.Point(66, 247)
        Me.cbRemark.Name = "cbRemark"
        Me.cbRemark.Size = New System.Drawing.Size(116, 24)
        Me.cbRemark.TabIndex = 3
        '
        'tbEndtime
        '
        Me.tbEndtime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEndtime.Location = New System.Drawing.Point(66, 241)
        Me.tbEndtime.Name = "tbEndtime"
        Me.tbEndtime.ReadOnly = True
        Me.tbEndtime.Size = New System.Drawing.Size(116, 22)
        Me.tbEndtime.TabIndex = 13
        Me.tbEndtime.Visible = False
        '
        'tbStarttime
        '
        Me.tbStarttime.Enabled = False
        Me.tbStarttime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbStarttime.Location = New System.Drawing.Point(66, 215)
        Me.tbStarttime.Name = "tbStarttime"
        Me.tbStarttime.Size = New System.Drawing.Size(116, 22)
        Me.tbStarttime.TabIndex = 7
        '
        'tbFolder
        '
        Me.tbFolder.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbFolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFolder.Location = New System.Drawing.Point(67, 106)
        Me.tbFolder.Name = "tbFolder"
        Me.tbFolder.Size = New System.Drawing.Size(116, 22)
        Me.tbFolder.TabIndex = 0
        '
        'tbProNumber
        '
        Me.tbProNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbProNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbProNumber.Location = New System.Drawing.Point(66, 147)
        Me.tbProNumber.MaxLength = 20
        Me.tbProNumber.Name = "tbProNumber"
        Me.tbProNumber.Size = New System.Drawing.Size(116, 22)
        Me.tbProNumber.TabIndex = 1
        '
        'tbFBNumber
        '
        Me.tbFBNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbFBNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFBNumber.Location = New System.Drawing.Point(66, 172)
        Me.tbFBNumber.MaxLength = 20
        Me.tbFBNumber.Name = "tbFBNumber"
        Me.tbFBNumber.Size = New System.Drawing.Size(116, 22)
        Me.tbFBNumber.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 247)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "End Time"
        Me.Label7.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Folder"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Pro #"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 221)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Start Time"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 253)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Remark"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 178)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FB #"
        '
        'dgvQueryAnswer
        '
        Me.dgvQueryAnswer.AllowUserToAddRows = False
        Me.dgvQueryAnswer.AllowUserToDeleteRows = False
        Me.dgvQueryAnswer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvQueryAnswer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvQueryAnswer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clSendTime, Me.clTrip, Me.clProNumber, Me.clFBNumber, Me.clQueryContent, Me.clQueryAnswer, Me.clTotalQuery})
        Me.dgvQueryAnswer.Location = New System.Drawing.Point(12, 298)
        Me.dgvQueryAnswer.MultiSelect = False
        Me.dgvQueryAnswer.Name = "dgvQueryAnswer"
        Me.dgvQueryAnswer.RowHeadersVisible = False
        Me.dgvQueryAnswer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvQueryAnswer.Size = New System.Drawing.Size(1016, 93)
        Me.dgvQueryAnswer.TabIndex = 14
        '
        'clSendTime
        '
        Me.clSendTime.HeaderText = "Time Sent"
        Me.clSendTime.Name = "clSendTime"
        Me.clSendTime.ReadOnly = True
        Me.clSendTime.Width = 140
        '
        'clTrip
        '
        Me.clTrip.HeaderText = "Trip #"
        Me.clTrip.Name = "clTrip"
        Me.clTrip.ReadOnly = True
        Me.clTrip.Width = 75
        '
        'clProNumber
        '
        Me.clProNumber.HeaderText = "Pro #"
        Me.clProNumber.Name = "clProNumber"
        Me.clProNumber.ReadOnly = True
        Me.clProNumber.Width = 75
        '
        'clFBNumber
        '
        Me.clFBNumber.HeaderText = "FB #"
        Me.clFBNumber.Name = "clFBNumber"
        Me.clFBNumber.ReadOnly = True
        Me.clFBNumber.Width = 75
        '
        'clQueryContent
        '
        Me.clQueryContent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.clQueryContent.HeaderText = "Most Recent Query"
        Me.clQueryContent.Name = "clQueryContent"
        Me.clQueryContent.ReadOnly = True
        '
        'clQueryAnswer
        '
        Me.clQueryAnswer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.clQueryAnswer.HeaderText = "Most Recent Query Answer"
        Me.clQueryAnswer.Name = "clQueryAnswer"
        Me.clQueryAnswer.ReadOnly = True
        '
        'clTotalQuery
        '
        Me.clTotalQuery.HeaderText = "Total Query"
        Me.clTotalQuery.Name = "clTotalQuery"
        Me.clTotalQuery.ReadOnly = True
        '
        'dgvQAFA
        '
        Me.dgvQAFA.AllowUserToAddRows = False
        Me.dgvQAFA.AllowUserToDeleteRows = False
        Me.dgvQAFA.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvQAFA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvQAFA.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clFilename, Me.clsTripNumber, Me.clTA, Me.clsBillCount, Me.clsForEntry, Me.clQuery, Me.clsBilled, Me.clReject, Me.clsOngoing, Me.clsDatetime, Me.clSender, Me.clBatchRemarks})
        Me.dgvQAFA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvQAFA.Location = New System.Drawing.Point(3, 3)
        Me.dgvQAFA.MultiSelect = False
        Me.dgvQAFA.Name = "dgvQAFA"
        Me.dgvQAFA.ReadOnly = True
        Me.dgvQAFA.RowHeadersVisible = False
        Me.dgvQAFA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvQAFA.Size = New System.Drawing.Size(830, 235)
        Me.dgvQAFA.TabIndex = 0
        '
        'clFilename
        '
        Me.clFilename.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clFilename.HeaderText = "Filename"
        Me.clFilename.Name = "clFilename"
        Me.clFilename.ReadOnly = True
        Me.clFilename.Width = 84
        '
        'clsTripNumber
        '
        Me.clsTripNumber.HeaderText = "Trip#"
        Me.clsTripNumber.Name = "clsTripNumber"
        Me.clsTripNumber.ReadOnly = True
        Me.clsTripNumber.Width = 50
        '
        'clTA
        '
        Me.clTA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.clTA.HeaderText = "TA"
        Me.clTA.Name = "clTA"
        Me.clTA.ReadOnly = True
        Me.clTA.Width = 46
        '
        'clsBillCount
        '
        Me.clsBillCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.clsBillCount.HeaderText = "Bill Count"
        Me.clsBillCount.Name = "clsBillCount"
        Me.clsBillCount.ReadOnly = True
        Me.clsBillCount.Width = 84
        '
        'clsForEntry
        '
        Me.clsForEntry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.clsForEntry.HeaderText = "For Entry"
        Me.clsForEntry.Name = "clsForEntry"
        Me.clsForEntry.ReadOnly = True
        Me.clsForEntry.Width = 80
        '
        'clQuery
        '
        Me.clQuery.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.clQuery.HeaderText = "Query"
        Me.clQuery.Name = "clQuery"
        Me.clQuery.ReadOnly = True
        Me.clQuery.Width = 64
        '
        'clsBilled
        '
        Me.clsBilled.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.clsBilled.HeaderText = "Billed"
        Me.clsBilled.Name = "clsBilled"
        Me.clsBilled.ReadOnly = True
        Me.clsBilled.Width = 63
        '
        'clReject
        '
        Me.clReject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.clReject.HeaderText = "Reject"
        Me.clReject.Name = "clReject"
        Me.clReject.ReadOnly = True
        Me.clReject.Width = 67
        '
        'clsOngoing
        '
        Me.clsOngoing.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.clsOngoing.HeaderText = "Ongoing"
        Me.clsOngoing.Name = "clsOngoing"
        Me.clsOngoing.ReadOnly = True
        Me.clsOngoing.Width = 79
        '
        'clsDatetime
        '
        Me.clsDatetime.HeaderText = "Datetime"
        Me.clsDatetime.Name = "clsDatetime"
        Me.clsDatetime.ReadOnly = True
        Me.clsDatetime.Width = 140
        '
        'clSender
        '
        Me.clSender.HeaderText = "Sent By"
        Me.clSender.Name = "clSender"
        Me.clSender.ReadOnly = True
        '
        'clBatchRemarks
        '
        Me.clBatchRemarks.HeaderText = "Remarks"
        Me.clBatchRemarks.Name = "clBatchRemarks"
        Me.clBatchRemarks.ReadOnly = True
        '
        'tm
        '
        '
        'bgRefresher
        '
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(191, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(844, 269)
        Me.TabControl1.TabIndex = 10
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.dgvFullAudit)
        Me.TabPage4.Location = New System.Drawing.Point(4, 24)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(836, 241)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Full Audit"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'dgvFullAudit
        '
        Me.dgvFullAudit.AllowUserToAddRows = False
        Me.dgvFullAudit.AllowUserToDeleteRows = False
        Me.dgvFullAudit.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvFullAudit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFullAudit.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.dgvFullAudit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvFullAudit.Location = New System.Drawing.Point(3, 3)
        Me.dgvFullAudit.MultiSelect = False
        Me.dgvFullAudit.Name = "dgvFullAudit"
        Me.dgvFullAudit.ReadOnly = True
        Me.dgvFullAudit.RowHeadersVisible = False
        Me.dgvFullAudit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFullAudit.Size = New System.Drawing.Size(830, 235)
        Me.dgvFullAudit.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn1.HeaderText = "Filename"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 84
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Trip#"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 50
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn3.HeaderText = "TA"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 46
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn4.HeaderText = "Bill Count"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 84
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn5.HeaderText = "For Entry"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 80
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn6.HeaderText = "Query"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 64
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn7.HeaderText = "Billed"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 63
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn8.HeaderText = "Reject"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 67
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn9.HeaderText = "Ongoing"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 79
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "Datetime"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 140
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "Sent By"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "Remarks"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgvQAFA)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(836, 241)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "QA-FA Batches"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.dgvInterline)
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(836, 241)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "INT Batches"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'dgvInterline
        '
        Me.dgvInterline.AllowUserToAddRows = False
        Me.dgvInterline.AllowUserToDeleteRows = False
        Me.dgvInterline.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInterline.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clFilename_INT, Me.clTripNo_INT, Me.clTA_INT, Me.clBillCount, Me.clXMLCount, Me.clPartner, Me.clCode, Me.clFolder_INT, Me.clIPTOZone, Me.clCutTime, Me.clTimeNotified, Me.clNotifiedBy})
        Me.dgvInterline.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvInterline.Location = New System.Drawing.Point(0, 0)
        Me.dgvInterline.Name = "dgvInterline"
        Me.dgvInterline.ReadOnly = True
        Me.dgvInterline.RowHeadersVisible = False
        Me.dgvInterline.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInterline.Size = New System.Drawing.Size(836, 241)
        Me.dgvInterline.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvProduction)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(836, 241)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Production"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvProduction
        '
        Me.dgvProduction.AllowUserToAddRows = False
        Me.dgvProduction.AllowUserToDeleteRows = False
        Me.dgvProduction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProduction.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clType_prod, Me.clDatetime, Me.clFolder, Me.clProdTripNumber, Me.clProdProNumber, Me.clProdFBNumber, Me.clProdRemark, Me.clStatus, Me.clStarttime, Me.clEndtime})
        Me.dgvProduction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProduction.Location = New System.Drawing.Point(3, 3)
        Me.dgvProduction.Name = "dgvProduction"
        Me.dgvProduction.ReadOnly = True
        Me.dgvProduction.RowHeadersVisible = False
        Me.dgvProduction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProduction.Size = New System.Drawing.Size(830, 235)
        Me.dgvProduction.TabIndex = 0
        '
        'tbTripNumber
        '
        Me.tbTripNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbTripNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTripNumber.Location = New System.Drawing.Point(67, 80)
        Me.tbTripNumber.Name = "tbTripNumber"
        Me.tbTripNumber.Size = New System.Drawing.Size(116, 22)
        Me.tbTripNumber.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(33, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Trip #"
        '
        'cbType
        '
        Me.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbType.Enabled = False
        Me.cbType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbType.FormattingEnabled = True
        Me.cbType.Items.AddRange(New Object() {"Full Audit", "QAFA", "Interline", "", "Rating"})
        Me.cbType.Location = New System.Drawing.Point(69, 41)
        Me.cbType.Name = "cbType"
        Me.cbType.Size = New System.Drawing.Size(116, 24)
        Me.cbType.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(36, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Type"
        '
        'clFilename_INT
        '
        Me.clFilename_INT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clFilename_INT.HeaderText = "Filename"
        Me.clFilename_INT.Name = "clFilename_INT"
        Me.clFilename_INT.ReadOnly = True
        Me.clFilename_INT.Width = 84
        '
        'clTripNo_INT
        '
        Me.clTripNo_INT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.clTripNo_INT.HeaderText = "Trip"
        Me.clTripNo_INT.Name = "clTripNo_INT"
        Me.clTripNo_INT.ReadOnly = True
        Me.clTripNo_INT.Width = 53
        '
        'clTA_INT
        '
        Me.clTA_INT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.clTA_INT.HeaderText = "TA"
        Me.clTA_INT.Name = "clTA_INT"
        Me.clTA_INT.ReadOnly = True
        Me.clTA_INT.Width = 46
        '
        'clBillCount
        '
        Me.clBillCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.clBillCount.HeaderText = "Bill Count"
        Me.clBillCount.Name = "clBillCount"
        Me.clBillCount.ReadOnly = True
        Me.clBillCount.Width = 84
        '
        'clXMLCount
        '
        Me.clXMLCount.HeaderText = "XML Count"
        Me.clXMLCount.Name = "clXMLCount"
        Me.clXMLCount.ReadOnly = True
        '
        'clPartner
        '
        Me.clPartner.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.clPartner.HeaderText = "Partner"
        Me.clPartner.Name = "clPartner"
        Me.clPartner.ReadOnly = True
        Me.clPartner.Width = 72
        '
        'clCode
        '
        Me.clCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.clCode.HeaderText = "Code"
        Me.clCode.Name = "clCode"
        Me.clCode.ReadOnly = True
        Me.clCode.Width = 61
        '
        'clFolder_INT
        '
        Me.clFolder_INT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.clFolder_INT.HeaderText = "Folder"
        Me.clFolder_INT.Name = "clFolder_INT"
        Me.clFolder_INT.ReadOnly = True
        Me.clFolder_INT.Width = 67
        '
        'clIPTOZone
        '
        Me.clIPTOZone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.clIPTOZone.HeaderText = "IP/TO Zone"
        Me.clIPTOZone.Name = "clIPTOZone"
        Me.clIPTOZone.ReadOnly = True
        Me.clIPTOZone.Width = 93
        '
        'clCutTime
        '
        Me.clCutTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.clCutTime.HeaderText = "Cut Time"
        Me.clCutTime.Name = "clCutTime"
        Me.clCutTime.ReadOnly = True
        Me.clCutTime.Width = 81
        '
        'clTimeNotified
        '
        Me.clTimeNotified.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.clTimeNotified.HeaderText = "Time Notified"
        Me.clTimeNotified.Name = "clTimeNotified"
        Me.clTimeNotified.ReadOnly = True
        Me.clTimeNotified.Width = 5
        '
        'clNotifiedBy
        '
        Me.clNotifiedBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.clNotifiedBy.HeaderText = "Notified By"
        Me.clNotifiedBy.Name = "clNotifiedBy"
        Me.clNotifiedBy.ReadOnly = True
        Me.clNotifiedBy.Width = 83
        '
        'clType_prod
        '
        Me.clType_prod.HeaderText = "Type"
        Me.clType_prod.Name = "clType_prod"
        Me.clType_prod.ReadOnly = True
        '
        'clDatetime
        '
        Me.clDatetime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clDatetime.HeaderText = "Datetime"
        Me.clDatetime.Name = "clDatetime"
        Me.clDatetime.ReadOnly = True
        Me.clDatetime.Width = 82
        '
        'clFolder
        '
        Me.clFolder.HeaderText = "Folder"
        Me.clFolder.Name = "clFolder"
        Me.clFolder.ReadOnly = True
        '
        'clProdTripNumber
        '
        Me.clProdTripNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clProdTripNumber.HeaderText = "Trip #"
        Me.clProdTripNumber.Name = "clProdTripNumber"
        Me.clProdTripNumber.ReadOnly = True
        Me.clProdTripNumber.Width = 63
        '
        'clProdProNumber
        '
        Me.clProdProNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clProdProNumber.HeaderText = "Pro #"
        Me.clProdProNumber.Name = "clProdProNumber"
        Me.clProdProNumber.ReadOnly = True
        Me.clProdProNumber.Width = 61
        '
        'clProdFBNumber
        '
        Me.clProdFBNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clProdFBNumber.HeaderText = "FB #"
        Me.clProdFBNumber.Name = "clProdFBNumber"
        Me.clProdFBNumber.ReadOnly = True
        Me.clProdFBNumber.Width = 57
        '
        'clProdRemark
        '
        Me.clProdRemark.HeaderText = "Remark"
        Me.clProdRemark.Name = "clProdRemark"
        Me.clProdRemark.ReadOnly = True
        '
        'clStatus
        '
        Me.clStatus.HeaderText = "Status"
        Me.clStatus.Name = "clStatus"
        Me.clStatus.ReadOnly = True
        '
        'clStarttime
        '
        Me.clStarttime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clStarttime.HeaderText = "Start Time"
        Me.clStarttime.Name = "clStarttime"
        Me.clStarttime.ReadOnly = True
        Me.clStarttime.Width = 88
        '
        'clEndtime
        '
        Me.clEndtime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.clEndtime.HeaderText = "End Time"
        Me.clEndtime.Name = "clEndtime"
        Me.clEndtime.ReadOnly = True
        Me.clEndtime.Width = 5
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1035, 416)
        Me.Controls.Add(Me.cbType)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbTripNumber)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dgvQueryAnswer)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.tbStarttime)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.tbFolder)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.tbProNumber)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbFBNumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbRemark)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbEndtime)
        Me.Controls.Add(Me.Label7)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.dgvQueryAnswer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvQAFA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        CType(Me.dgvFullAudit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dgvInterline, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvProduction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tbEndtime As System.Windows.Forms.TextBox
    Friend WithEvents tbStarttime As System.Windows.Forms.TextBox
    Friend WithEvents tbFolder As System.Windows.Forms.TextBox
    Friend WithEvents tbProNumber As System.Windows.Forms.TextBox
    Friend WithEvents tbFBNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ControlsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cbRemark As System.Windows.Forms.ComboBox
    Friend WithEvents dgvQAFA As System.Windows.Forms.DataGridView
    Friend WithEvents lbUsername As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents mnAddBill As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnSettings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tm As System.Windows.Forms.Timer
    Friend WithEvents bgRefresher As System.ComponentModel.BackgroundWorker
    Friend WithEvents lbFullname As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents mnRelogin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dgvQueryAnswer As System.Windows.Forms.DataGridView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents dgvProduction As System.Windows.Forms.DataGridView
    Friend WithEvents tbTripNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents clFilename As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clsTripNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clTA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clsBillCount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clsForEntry As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clQuery As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clsBilled As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clReject As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clsOngoing As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clsDatetime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clSender As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clBatchRemarks As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents dgvInterline As DataGridView
    Friend WithEvents clSendTime As DataGridViewTextBoxColumn
    Friend WithEvents clTrip As DataGridViewTextBoxColumn
    Friend WithEvents clProNumber As DataGridViewTextBoxColumn
    Friend WithEvents clFBNumber As DataGridViewTextBoxColumn
    Friend WithEvents clQueryContent As DataGridViewTextBoxColumn
    Friend WithEvents clQueryAnswer As DataGridViewTextBoxColumn
    Friend WithEvents clTotalQuery As DataGridViewTextBoxColumn
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents dgvFullAudit As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents cbType As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents clFilename_INT As DataGridViewTextBoxColumn
    Friend WithEvents clTripNo_INT As DataGridViewTextBoxColumn
    Friend WithEvents clTA_INT As DataGridViewTextBoxColumn
    Friend WithEvents clBillCount As DataGridViewTextBoxColumn
    Friend WithEvents clXMLCount As DataGridViewTextBoxColumn
    Friend WithEvents clPartner As DataGridViewTextBoxColumn
    Friend WithEvents clCode As DataGridViewTextBoxColumn
    Friend WithEvents clFolder_INT As DataGridViewTextBoxColumn
    Friend WithEvents clIPTOZone As DataGridViewTextBoxColumn
    Friend WithEvents clCutTime As DataGridViewTextBoxColumn
    Friend WithEvents clTimeNotified As DataGridViewTextBoxColumn
    Friend WithEvents clNotifiedBy As DataGridViewTextBoxColumn
    Friend WithEvents clType_prod As DataGridViewTextBoxColumn
    Friend WithEvents clDatetime As DataGridViewTextBoxColumn
    Friend WithEvents clFolder As DataGridViewTextBoxColumn
    Friend WithEvents clProdTripNumber As DataGridViewTextBoxColumn
    Friend WithEvents clProdProNumber As DataGridViewTextBoxColumn
    Friend WithEvents clProdFBNumber As DataGridViewTextBoxColumn
    Friend WithEvents clProdRemark As DataGridViewTextBoxColumn
    Friend WithEvents clStatus As DataGridViewTextBoxColumn
    Friend WithEvents clStarttime As DataGridViewTextBoxColumn
    Friend WithEvents clEndtime As DataGridViewTextBoxColumn
End Class
