<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTibiMon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTibiMon))
        Me.txtHealth = New System.Windows.Forms.TextBox()
        Me.txtMana = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tmrMain = New System.Windows.Forms.Timer(Me.components)
        Me.pbarHealth = New System.Windows.Forms.ProgressBar()
        Me.pbarMana = New System.Windows.Forms.ProgressBar()
        Me.txtManaMax = New System.Windows.Forms.TextBox()
        Me.txtHPmax = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTargetID = New System.Windows.Forms.TextBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.tmrTarget = New System.Windows.Forms.Timer(Me.components)
        Me.btnOptions = New System.Windows.Forms.Button()
        Me.btnoptions2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkPlaySound = New System.Windows.Forms.CheckBox()
        Me.ActivateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkTopMost = New System.Windows.Forms.CheckBox()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTarget = New System.Windows.Forms.Label()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtX = New System.Windows.Forms.TextBox()
        Me.txtY = New System.Windows.Forms.TextBox()
        Me.txtZ = New System.Windows.Forms.TextBox()
        Me.chkPlayerPos = New System.Windows.Forms.CheckBox()
        Me.tmrXYZsound = New System.Windows.Forms.Timer(Me.components)
        Me.chkHealth = New System.Windows.Forms.CheckBox()
        Me.tmrLowHealth = New System.Windows.Forms.Timer(Me.components)
        Me.cmbSkills = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblSkill = New System.Windows.Forms.Label()
        Me.txtShield = New System.Windows.Forms.TextBox()
        Me.txtNextshield = New System.Windows.Forms.TextBox()
        Me.txtSkill = New System.Windows.Forms.TextBox()
        Me.txtNextskill = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.pbarSkills = New System.Windows.Forms.ProgressBar()
        Me.pbarShield = New System.Windows.Forms.ProgressBar()
        Me.tbarOpacity = New System.Windows.Forms.TrackBar()
        Me.grpSkills = New System.Windows.Forms.GroupBox()
        Me.grpHealth = New System.Windows.Forms.GroupBox()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.wbUpdate = New System.Windows.Forms.WebBrowser()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.chkSkills = New System.Windows.Forms.CheckBox()
        Me.grpMain = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.wbdownload = New System.Windows.Forms.WebBrowser()
        CType(Me.tbarOpacity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSkills.SuspendLayout()
        Me.grpHealth.SuspendLayout()
        Me.grpOptions.SuspendLayout()
        Me.grpMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtHealth
        '
        Me.txtHealth.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHealth.Location = New System.Drawing.Point(47, 33)
        Me.txtHealth.Name = "txtHealth"
        Me.txtHealth.ReadOnly = True
        Me.txtHealth.Size = New System.Drawing.Size(32, 13)
        Me.txtHealth.TabIndex = 0
        '
        'txtMana
        '
        Me.txtMana.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMana.Location = New System.Drawing.Point(47, 56)
        Me.txtMana.Name = "txtMana"
        Me.txtMana.ReadOnly = True
        Me.txtMana.Size = New System.Drawing.Size(32, 13)
        Me.txtMana.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Health:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Mana:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tmrMain
        '
        Me.tmrMain.Interval = 500
        '
        'pbarHealth
        '
        Me.pbarHealth.BackColor = System.Drawing.Color.Red
        Me.pbarHealth.Cursor = System.Windows.Forms.Cursors.Default
        Me.pbarHealth.Enabled = False
        Me.pbarHealth.ForeColor = System.Drawing.Color.Red
        Me.pbarHealth.Location = New System.Drawing.Point(85, 33)
        Me.pbarHealth.Maximum = 275
        Me.pbarHealth.Name = "pbarHealth"
        Me.pbarHealth.Size = New System.Drawing.Size(79, 13)
        Me.pbarHealth.Step = 2
        Me.pbarHealth.TabIndex = 4
        '
        'pbarMana
        '
        Me.pbarMana.Enabled = False
        Me.pbarMana.Location = New System.Drawing.Point(85, 56)
        Me.pbarMana.Maximum = 65
        Me.pbarMana.Name = "pbarMana"
        Me.pbarMana.Size = New System.Drawing.Size(79, 13)
        Me.pbarMana.Step = 2
        Me.pbarMana.TabIndex = 5
        '
        'txtManaMax
        '
        Me.txtManaMax.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtManaMax.Location = New System.Drawing.Point(170, 56)
        Me.txtManaMax.Name = "txtManaMax"
        Me.txtManaMax.ReadOnly = True
        Me.txtManaMax.Size = New System.Drawing.Size(32, 13)
        Me.txtManaMax.TabIndex = 7
        '
        'txtHPmax
        '
        Me.txtHPmax.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHPmax.Location = New System.Drawing.Point(170, 33)
        Me.txtHPmax.Name = "txtHPmax"
        Me.txtHPmax.ReadOnly = True
        Me.txtHPmax.Size = New System.Drawing.Size(32, 13)
        Me.txtHPmax.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Current"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(168, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Max"
        '
        'txtTargetID
        '
        Me.txtTargetID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTargetID.Location = New System.Drawing.Point(27, 347)
        Me.txtTargetID.Multiline = True
        Me.txtTargetID.Name = "txtTargetID"
        Me.txtTargetID.ReadOnly = True
        Me.txtTargetID.Size = New System.Drawing.Size(91, 18)
        Me.txtTargetID.TabIndex = 10
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "TibiMon"
        Me.NotifyIcon1.Visible = True
        '
        'tmrTarget
        '
        Me.tmrTarget.Interval = 10000
        '
        'btnOptions
        '
        Me.btnOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOptions.ForeColor = System.Drawing.Color.Black
        Me.btnOptions.Location = New System.Drawing.Point(304, 40)
        Me.btnOptions.Name = "btnOptions"
        Me.btnOptions.Size = New System.Drawing.Size(60, 23)
        Me.btnOptions.TabIndex = 12
        Me.btnOptions.Text = "Options >"
        Me.btnOptions.UseVisualStyleBackColor = True
        '
        'btnoptions2
        '
        Me.btnoptions2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnoptions2.ForeColor = System.Drawing.Color.Black
        Me.btnoptions2.Location = New System.Drawing.Point(304, 40)
        Me.btnoptions2.Name = "btnoptions2"
        Me.btnoptions2.Size = New System.Drawing.Size(60, 23)
        Me.btnoptions2.TabIndex = 13
        Me.btnoptions2.Text = "< Options"
        Me.btnoptions2.UseVisualStyleBackColor = True
        Me.btnoptions2.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Opacity"
        '
        'chkPlaySound
        '
        Me.chkPlaySound.AutoSize = True
        Me.chkPlaySound.Location = New System.Drawing.Point(121, 83)
        Me.chkPlaySound.Name = "chkPlaySound"
        Me.chkPlaySound.Size = New System.Drawing.Size(104, 17)
        Me.chkPlaySound.TabIndex = 16
        Me.chkPlaySound.Text = "Lost Target Alert"
        Me.chkPlaySound.UseVisualStyleBackColor = True
        '
        'ActivateToolStripMenuItem
        '
        Me.ActivateToolStripMenuItem.Enabled = False
        Me.ActivateToolStripMenuItem.Name = "ActivateToolStripMenuItem"
        Me.ActivateToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.ActivateToolStripMenuItem.Text = "Activate"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.ForeColor = System.Drawing.Color.Silver
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Target:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkTopMost
        '
        Me.chkTopMost.AutoSize = True
        Me.chkTopMost.Location = New System.Drawing.Point(121, 106)
        Me.chkTopMost.Name = "chkTopMost"
        Me.chkTopMost.Size = New System.Drawing.Size(84, 17)
        Me.chkTopMost.TabIndex = 19
        Me.chkTopMost.Text = "Stay on Top"
        Me.chkTopMost.UseVisualStyleBackColor = True
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'btnExit
        '
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Location = New System.Drawing.Point(329, 10)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(35, 24)
        Me.btnExit.TabIndex = 20
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblTarget
        '
        Me.lblTarget.AutoSize = True
        Me.lblTarget.Location = New System.Drawing.Point(66, 16)
        Me.lblTarget.Name = "lblTarget"
        Me.lblTarget.Size = New System.Drawing.Size(0, 13)
        Me.lblTarget.TabIndex = 21
        '
        'btnHide
        '
        Me.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHide.Location = New System.Drawing.Point(282, 11)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(41, 23)
        Me.btnHide.TabIndex = 22
        Me.btnHide.Text = "Hide"
        Me.btnHide.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(208, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(14, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "X"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(208, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(14, 13)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Y"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(208, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(14, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Z"
        '
        'txtX
        '
        Me.txtX.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtX.Location = New System.Drawing.Point(223, 27)
        Me.txtX.Name = "txtX"
        Me.txtX.ReadOnly = True
        Me.txtX.Size = New System.Drawing.Size(32, 13)
        Me.txtX.TabIndex = 28
        '
        'txtY
        '
        Me.txtY.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtY.Location = New System.Drawing.Point(223, 41)
        Me.txtY.Name = "txtY"
        Me.txtY.ReadOnly = True
        Me.txtY.Size = New System.Drawing.Size(32, 13)
        Me.txtY.TabIndex = 29
        '
        'txtZ
        '
        Me.txtZ.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtZ.Location = New System.Drawing.Point(223, 55)
        Me.txtZ.Name = "txtZ"
        Me.txtZ.ReadOnly = True
        Me.txtZ.Size = New System.Drawing.Size(32, 13)
        Me.txtZ.TabIndex = 30
        '
        'chkPlayerPos
        '
        Me.chkPlayerPos.AutoSize = True
        Me.chkPlayerPos.Location = New System.Drawing.Point(9, 83)
        Me.chkPlayerPos.Name = "chkPlayerPos"
        Me.chkPlayerPos.Size = New System.Drawing.Size(106, 17)
        Me.chkPlayerPos.TabIndex = 31
        Me.chkPlayerPos.Text = "Set Position Alert"
        Me.chkPlayerPos.UseVisualStyleBackColor = True
        '
        'tmrXYZsound
        '
        Me.tmrXYZsound.Interval = 10000
        '
        'chkHealth
        '
        Me.chkHealth.AutoSize = True
        Me.chkHealth.Location = New System.Drawing.Point(9, 106)
        Me.chkHealth.Name = "chkHealth"
        Me.chkHealth.Size = New System.Drawing.Size(81, 17)
        Me.chkHealth.TabIndex = 35
        Me.chkHealth.Text = "Health Alert"
        Me.chkHealth.UseVisualStyleBackColor = True
        '
        'tmrLowHealth
        '
        Me.tmrLowHealth.Interval = 10000
        '
        'cmbSkills
        '
        Me.cmbSkills.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSkills.FormattingEnabled = True
        Me.cmbSkills.Items.AddRange(New Object() {"Fist", "Club", "Sword", "Axe", "Distance"})
        Me.cmbSkills.Location = New System.Drawing.Point(104, 12)
        Me.cmbSkills.Name = "cmbSkills"
        Me.cmbSkills.Size = New System.Drawing.Size(76, 21)
        Me.cmbSkills.TabIndex = 36
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 62)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Shielding:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSkill
        '
        Me.lblSkill.AutoSize = True
        Me.lblSkill.Location = New System.Drawing.Point(6, 40)
        Me.lblSkill.Name = "lblSkill"
        Me.lblSkill.Size = New System.Drawing.Size(48, 13)
        Me.lblSkill.TabIndex = 38
        Me.lblSkill.Text = "Set Skill:"
        Me.lblSkill.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtShield
        '
        Me.txtShield.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtShield.Location = New System.Drawing.Point(151, 62)
        Me.txtShield.Name = "txtShield"
        Me.txtShield.ReadOnly = True
        Me.txtShield.Size = New System.Drawing.Size(29, 13)
        Me.txtShield.TabIndex = 39
        '
        'txtNextshield
        '
        Me.txtNextshield.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNextshield.Location = New System.Drawing.Point(220, 62)
        Me.txtNextshield.Name = "txtNextshield"
        Me.txtNextshield.ReadOnly = True
        Me.txtNextshield.Size = New System.Drawing.Size(29, 13)
        Me.txtNextshield.TabIndex = 40
        '
        'txtSkill
        '
        Me.txtSkill.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSkill.Location = New System.Drawing.Point(151, 40)
        Me.txtSkill.Name = "txtSkill"
        Me.txtSkill.ReadOnly = True
        Me.txtSkill.Size = New System.Drawing.Size(29, 13)
        Me.txtSkill.TabIndex = 41
        '
        'txtNextskill
        '
        Me.txtNextskill.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNextskill.Location = New System.Drawing.Point(220, 40)
        Me.txtNextskill.Name = "txtNextskill"
        Me.txtNextskill.ReadOnly = True
        Me.txtNextskill.Size = New System.Drawing.Size(29, 13)
        Me.txtNextskill.TabIndex = 42
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(186, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(28, 13)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "Until"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(186, 62)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(28, 13)
        Me.Label13.TabIndex = 44
        Me.Label13.Text = "Until"
        '
        'pbarSkills
        '
        Me.pbarSkills.Location = New System.Drawing.Point(66, 40)
        Me.pbarSkills.Name = "pbarSkills"
        Me.pbarSkills.Size = New System.Drawing.Size(79, 13)
        Me.pbarSkills.TabIndex = 45
        '
        'pbarShield
        '
        Me.pbarShield.Location = New System.Drawing.Point(66, 62)
        Me.pbarShield.Name = "pbarShield"
        Me.pbarShield.Size = New System.Drawing.Size(79, 13)
        Me.pbarShield.TabIndex = 46
        '
        'tbarOpacity
        '
        Me.tbarOpacity.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbarOpacity.Location = New System.Drawing.Point(6, 32)
        Me.tbarOpacity.Maximum = 100
        Me.tbarOpacity.Name = "tbarOpacity"
        Me.tbarOpacity.Size = New System.Drawing.Size(169, 45)
        Me.tbarOpacity.TabIndex = 14
        Me.tbarOpacity.Value = 100
        '
        'grpSkills
        '
        Me.grpSkills.BackColor = System.Drawing.Color.Transparent
        Me.grpSkills.Controls.Add(Me.Label6)
        Me.grpSkills.Controls.Add(Me.lblTarget)
        Me.grpSkills.Controls.Add(Me.pbarShield)
        Me.grpSkills.Controls.Add(Me.cmbSkills)
        Me.grpSkills.Controls.Add(Me.pbarSkills)
        Me.grpSkills.Controls.Add(Me.Label10)
        Me.grpSkills.Controls.Add(Me.Label13)
        Me.grpSkills.Controls.Add(Me.lblSkill)
        Me.grpSkills.Controls.Add(Me.Label12)
        Me.grpSkills.Controls.Add(Me.txtShield)
        Me.grpSkills.Controls.Add(Me.txtNextskill)
        Me.grpSkills.Controls.Add(Me.txtNextshield)
        Me.grpSkills.Controls.Add(Me.txtSkill)
        Me.grpSkills.ForeColor = System.Drawing.Color.Silver
        Me.grpSkills.Location = New System.Drawing.Point(6, 163)
        Me.grpSkills.Name = "grpSkills"
        Me.grpSkills.Size = New System.Drawing.Size(270, 84)
        Me.grpSkills.TabIndex = 48
        Me.grpSkills.TabStop = False
        Me.grpSkills.Text = "Skills"
        Me.grpSkills.Visible = False
        '
        'grpHealth
        '
        Me.grpHealth.BackColor = System.Drawing.Color.Transparent
        Me.grpHealth.Controls.Add(Me.Label3)
        Me.grpHealth.Controls.Add(Me.txtHealth)
        Me.grpHealth.Controls.Add(Me.txtMana)
        Me.grpHealth.Controls.Add(Me.Label1)
        Me.grpHealth.Controls.Add(Me.Label2)
        Me.grpHealth.Controls.Add(Me.txtZ)
        Me.grpHealth.Controls.Add(Me.pbarHealth)
        Me.grpHealth.Controls.Add(Me.txtY)
        Me.grpHealth.Controls.Add(Me.pbarMana)
        Me.grpHealth.Controls.Add(Me.txtX)
        Me.grpHealth.Controls.Add(Me.txtHPmax)
        Me.grpHealth.Controls.Add(Me.Label9)
        Me.grpHealth.Controls.Add(Me.txtManaMax)
        Me.grpHealth.Controls.Add(Me.Label8)
        Me.grpHealth.Controls.Add(Me.Label4)
        Me.grpHealth.Controls.Add(Me.Label7)
        Me.grpHealth.ForeColor = System.Drawing.Color.Silver
        Me.grpHealth.Location = New System.Drawing.Point(6, 34)
        Me.grpHealth.Name = "grpHealth"
        Me.grpHealth.Size = New System.Drawing.Size(270, 91)
        Me.grpHealth.TabIndex = 49
        Me.grpHealth.TabStop = False
        Me.grpHealth.Text = "Health, Mana, X,Y,Z"
        Me.grpHealth.Visible = False
        '
        'grpOptions
        '
        Me.grpOptions.BackColor = System.Drawing.Color.Transparent
        Me.grpOptions.Controls.Add(Me.wbdownload)
        Me.grpOptions.Controls.Add(Me.wbUpdate)
        Me.grpOptions.Controls.Add(Me.btnSave)
        Me.grpOptions.Controls.Add(Me.Label5)
        Me.grpOptions.Controls.Add(Me.tbarOpacity)
        Me.grpOptions.Controls.Add(Me.chkPlaySound)
        Me.grpOptions.Controls.Add(Me.chkTopMost)
        Me.grpOptions.Controls.Add(Me.chkHealth)
        Me.grpOptions.Controls.Add(Me.chkPlayerPos)
        Me.grpOptions.ForeColor = System.Drawing.Color.Silver
        Me.grpOptions.Location = New System.Drawing.Point(382, 19)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(322, 129)
        Me.grpOptions.TabIndex = 50
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Options"
        Me.grpOptions.Visible = False
        '
        'wbUpdate
        '
        Me.wbUpdate.Location = New System.Drawing.Point(-429, -19)
        Me.wbUpdate.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbUpdate.Name = "wbUpdate"
        Me.wbUpdate.Size = New System.Drawing.Size(20, 20)
        Me.wbUpdate.TabIndex = 49
        Me.wbUpdate.Visible = False
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(231, 100)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(83, 23)
        Me.btnSave.TabIndex = 48
        Me.btnSave.Text = "Save Settings"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'chkSkills
        '
        Me.chkSkills.AutoSize = True
        Me.chkSkills.Location = New System.Drawing.Point(6, 131)
        Me.chkSkills.Name = "chkSkills"
        Me.chkSkills.Size = New System.Drawing.Size(107, 17)
        Me.chkSkills.TabIndex = 51
        Me.chkSkills.Text = "Skills Show/Hide"
        Me.chkSkills.UseVisualStyleBackColor = True
        '
        'grpMain
        '
        Me.grpMain.BackColor = System.Drawing.Color.Transparent
        Me.grpMain.Controls.Add(Me.Label14)
        Me.grpMain.Controls.Add(Me.Label11)
        Me.grpMain.Controls.Add(Me.grpHealth)
        Me.grpMain.Controls.Add(Me.chkSkills)
        Me.grpMain.Controls.Add(Me.grpOptions)
        Me.grpMain.Controls.Add(Me.btnOptions)
        Me.grpMain.Controls.Add(Me.btnoptions2)
        Me.grpMain.Controls.Add(Me.grpSkills)
        Me.grpMain.Controls.Add(Me.btnExit)
        Me.grpMain.Controls.Add(Me.btnHide)
        Me.grpMain.Location = New System.Drawing.Point(3, 1)
        Me.grpMain.Name = "grpMain"
        Me.grpMain.Size = New System.Drawing.Size(711, 155)
        Me.grpMain.TabIndex = 52
        Me.grpMain.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label14.Font = New System.Drawing.Font("Motorwerk", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Orange
        Me.Label14.Location = New System.Drawing.Point(288, 119)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 36)
        Me.Label14.TabIndex = 53
        Me.Label14.Text = "TM"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Motorwerk", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Orange
        Me.Label11.Location = New System.Drawing.Point(13, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(153, 18)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "TibiMon v1.3"
        '
        'wbdownload
        '
        Me.wbdownload.Location = New System.Drawing.Point(240, 27)
        Me.wbdownload.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbdownload.Name = "wbdownload"
        Me.wbdownload.Size = New System.Drawing.Size(20, 20)
        Me.wbdownload.TabIndex = 51
        Me.wbdownload.Visible = False
        '
        'frmTibiMon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(720, 160)
        Me.Controls.Add(Me.grpMain)
        Me.Controls.Add(Me.txtTargetID)
        Me.ForeColor = System.Drawing.Color.Silver
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmTibiMon"
        Me.ShowInTaskbar = False
        Me.Text = "TibiMon v.1"
        CType(Me.tbarOpacity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSkills.ResumeLayout(False)
        Me.grpSkills.PerformLayout()
        Me.grpHealth.ResumeLayout(False)
        Me.grpHealth.PerformLayout()
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.grpMain.ResumeLayout(False)
        Me.grpMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtHealth As System.Windows.Forms.TextBox
    Friend WithEvents txtMana As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tmrMain As System.Windows.Forms.Timer
    Friend WithEvents pbarHealth As System.Windows.Forms.ProgressBar
    Friend WithEvents pbarMana As System.Windows.Forms.ProgressBar
    Friend WithEvents txtManaMax As System.Windows.Forms.TextBox
    Friend WithEvents txtHPmax As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTargetID As System.Windows.Forms.TextBox
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents tmrTarget As System.Windows.Forms.Timer
    Friend WithEvents btnOptions As System.Windows.Forms.Button
    Friend WithEvents btnoptions2 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chkPlaySound As System.Windows.Forms.CheckBox
    Friend WithEvents ActivateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chkTopMost As System.Windows.Forms.CheckBox
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblTarget As System.Windows.Forms.Label
    Friend WithEvents btnHide As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtX As System.Windows.Forms.TextBox
    Friend WithEvents txtY As System.Windows.Forms.TextBox
    Friend WithEvents txtZ As System.Windows.Forms.TextBox
    Friend WithEvents chkPlayerPos As System.Windows.Forms.CheckBox
    Friend WithEvents tmrXYZsound As System.Windows.Forms.Timer
    Friend WithEvents chkHealth As System.Windows.Forms.CheckBox
    Friend WithEvents tmrLowHealth As System.Windows.Forms.Timer
    Friend WithEvents cmbSkills As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblSkill As System.Windows.Forms.Label
    Friend WithEvents txtShield As System.Windows.Forms.TextBox
    Friend WithEvents txtNextshield As System.Windows.Forms.TextBox
    Friend WithEvents txtSkill As System.Windows.Forms.TextBox
    Friend WithEvents txtNextskill As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents pbarSkills As System.Windows.Forms.ProgressBar
    Friend WithEvents pbarShield As System.Windows.Forms.ProgressBar
    Friend WithEvents tbarOpacity As System.Windows.Forms.TrackBar
    Friend WithEvents grpSkills As System.Windows.Forms.GroupBox
    Friend WithEvents grpHealth As System.Windows.Forms.GroupBox
    Friend WithEvents grpOptions As System.Windows.Forms.GroupBox
    Friend WithEvents chkSkills As System.Windows.Forms.CheckBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents grpMain As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents wbUpdate As System.Windows.Forms.WebBrowser
    Friend WithEvents wbdownload As System.Windows.Forms.WebBrowser

End Class
