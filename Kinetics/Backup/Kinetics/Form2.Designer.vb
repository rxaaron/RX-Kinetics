<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCalculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCalculator))
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyAllText = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.BtnGo = New System.Windows.Forms.Button
        Me.BtnUnGo = New System.Windows.Forms.Button
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument
        Me.PrintDocument3 = New System.Drawing.Printing.PrintDocument
        Me.ToolTipEntry = New System.Windows.Forms.ToolTip(Me.components)
        Me.TxtActualInfTime = New System.Windows.Forms.TextBox
        Me.TxtActualPkTime = New System.Windows.Forms.TextBox
        Me.TxtActualTrTime = New System.Windows.Forms.TextBox
        Me.TxtInfusion = New System.Windows.Forms.TextBox
        Me.TxtDrawPeak = New System.Windows.Forms.TextBox
        Me.TxtDrawTrough = New System.Windows.Forms.TextBox
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.ToolTipHelp = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnOptions = New System.Windows.Forms.Button
        Me.TabPageNote = New System.Windows.Forms.TabPage
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.GrpBoxNoteType = New System.Windows.Forms.GroupBox
        Me.RadButFollow = New System.Windows.Forms.RadioButton
        Me.RadButExtInt = New System.Windows.Forms.RadioButton
        Me.RadButInitial = New System.Windows.Forms.RadioButton
        Me.BtnPrintNote = New System.Windows.Forms.Button
        Me.BtnViewNote = New System.Windows.Forms.Button
        Me.TabPageAdjust = New System.Windows.Forms.TabPage
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.LblPredictTr2 = New System.Windows.Forms.Label
        Me.LblPredictPk2 = New System.Windows.Forms.Label
        Me.Label56 = New System.Windows.Forms.Label
        Me.Label57 = New System.Windows.Forms.Label
        Me.TxtUseInterval = New System.Windows.Forms.TextBox
        Me.Label58 = New System.Windows.Forms.Label
        Me.TxtUseDose = New System.Windows.Forms.TextBox
        Me.Label59 = New System.Windows.Forms.Label
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.LblNewInterval = New System.Windows.Forms.Label
        Me.LblNewDose = New System.Windows.Forms.Label
        Me.Label62 = New System.Windows.Forms.Label
        Me.Label63 = New System.Windows.Forms.Label
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.Label44 = New System.Windows.Forms.Label
        Me.TxtDesTrough = New System.Windows.Forms.TextBox
        Me.TxtDesPeak = New System.Windows.Forms.TextBox
        Me.Label54 = New System.Windows.Forms.Label
        Me.Label55 = New System.Windows.Forms.Label
        Me.Label43 = New System.Windows.Forms.Label
        Me.Label89 = New System.Windows.Forms.Label
        Me.Label88 = New System.Windows.Forms.Label
        Me.TxtActualInterval = New System.Windows.Forms.TextBox
        Me.TxtActualDose = New System.Windows.Forms.TextBox
        Me.Label76 = New System.Windows.Forms.Label
        Me.Label53 = New System.Windows.Forms.Label
        Me.Label52 = New System.Windows.Forms.Label
        Me.Label51 = New System.Windows.Forms.Label
        Me.LblActualT05 = New System.Windows.Forms.Label
        Me.LblActualVd = New System.Windows.Forms.Label
        Me.LblActualK = New System.Windows.Forms.Label
        Me.Label50 = New System.Windows.Forms.Label
        Me.Label64 = New System.Windows.Forms.Label
        Me.Label65 = New System.Windows.Forms.Label
        Me.Label66 = New System.Windows.Forms.Label
        Me.Label67 = New System.Windows.Forms.Label
        Me.Label68 = New System.Windows.Forms.Label
        Me.Label69 = New System.Windows.Forms.Label
        Me.Label70 = New System.Windows.Forms.Label
        Me.Label71 = New System.Windows.Forms.Label
        Me.Label72 = New System.Windows.Forms.Label
        Me.Label73 = New System.Windows.Forms.Label
        Me.TxtActualTrough = New System.Windows.Forms.TextBox
        Me.TxtActualPeak = New System.Windows.Forms.TextBox
        Me.Label74 = New System.Windows.Forms.Label
        Me.Label75 = New System.Windows.Forms.Label
        Me.TabPageInit = New System.Windows.Forms.TabPage
        Me.GrpBoxExtInt = New System.Windows.Forms.GroupBox
        Me.LblExtIntInt = New System.Windows.Forms.Label
        Me.Label48 = New System.Windows.Forms.Label
        Me.LblExtIntDose = New System.Windows.Forms.Label
        Me.Label47 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.LblPredictTr = New System.Windows.Forms.Label
        Me.LblPredictPk = New System.Windows.Forms.Label
        Me.Label42 = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.TxtIntervalUse = New System.Windows.Forms.TextBox
        Me.Label40 = New System.Windows.Forms.Label
        Me.TxtDoseUse = New System.Windows.Forms.TextBox
        Me.Label39 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.LblIntervalEst = New System.Windows.Forms.Label
        Me.LblDoseEst = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.LblEstVd = New System.Windows.Forms.Label
        Me.CboXDrug = New System.Windows.Forms.ComboBox
        Me.Label87 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label86 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label49 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label46 = New System.Windows.Forms.Label
        Me.Label45 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.LblEstT05 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.LblEstK = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.TxtCV = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.TxtTroughDes = New System.Windows.Forms.TextBox
        Me.TxtPeakDes = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.LblVdtoUse = New System.Windows.Forms.Label
        Me.LblKtoUse = New System.Windows.Forms.Label
        Me.Label77 = New System.Windows.Forms.Label
        Me.Label78 = New System.Windows.Forms.Label
        Me.Label79 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.TabPageDemo = New System.Windows.Forms.TabPage
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.LblCrCl = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.LblBSA = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.LblCrClStd = New System.Windows.Forms.Label
        Me.LblIBW = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.TxtABW = New System.Windows.Forms.TextBox
        Me.TxtHeight = New System.Windows.Forms.TextBox
        Me.TxtAge = New System.Windows.Forms.TextBox
        Me.TxtSCr = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadButFemale = New System.Windows.Forms.RadioButton
        Me.RadButMale = New System.Windows.Forms.RadioButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.GrpBoxCrCl = New System.Windows.Forms.GroupBox
        Me.RadButJelliffe = New System.Windows.Forms.RadioButton
        Me.RadButCCG = New System.Windows.Forms.RadioButton
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.ContextMenuStrip1.SuspendLayout()
        Me.TabPageNote.SuspendLayout()
        Me.GrpBoxNoteType.SuspendLayout()
        Me.TabPageAdjust.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.TabPageInit.SuspendLayout()
        Me.GrpBoxExtInt.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPageDemo.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GrpBoxCrCl.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Tag = "NightWatch Kinetics"
        Me.NotifyIcon1.Text = "Kinetics Calculator"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyAllText})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(150, 26)
        '
        'CopyAllText
        '
        Me.CopyAllText.Image = Global.NWKinetics.My.Resources.Resources.scissors2
        Me.CopyAllText.Name = "CopyAllText"
        Me.CopyAllText.Size = New System.Drawing.Size(149, 22)
        Me.CopyAllText.Text = "Copy All Text"
        Me.CopyAllText.ToolTipText = "Copies Note to Clipboard"
        '
        'PrintDocument1
        '
        Me.PrintDocument1.DocumentName = "Initial PK Note"
        '
        'BtnGo
        '
        Me.BtnGo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnGo.Location = New System.Drawing.Point(10, 444)
        Me.BtnGo.Name = "BtnGo"
        Me.BtnGo.Size = New System.Drawing.Size(202, 23)
        Me.BtnGo.TabIndex = 6
        Me.BtnGo.Text = "Calculate"
        Me.BtnGo.UseVisualStyleBackColor = True
        '
        'BtnUnGo
        '
        Me.BtnUnGo.Location = New System.Drawing.Point(10, 473)
        Me.BtnUnGo.Name = "BtnUnGo"
        Me.BtnUnGo.Size = New System.Drawing.Size(202, 23)
        Me.BtnUnGo.TabIndex = 43
        Me.BtnUnGo.Text = "Clear All Fields"
        Me.BtnUnGo.UseVisualStyleBackColor = True
        '
        'PrintDocument2
        '
        Me.PrintDocument2.DocumentName = "Extended Interval PK Note"
        '
        'PrintDocument3
        '
        Me.PrintDocument3.DocumentName = "Follow-Up PK Note"
        '
        'ToolTipEntry
        '
        Me.ToolTipEntry.AutoPopDelay = 15000
        Me.ToolTipEntry.InitialDelay = 100
        Me.ToolTipEntry.IsBalloon = True
        Me.ToolTipEntry.ReshowDelay = 100
        Me.ToolTipEntry.ToolTipTitle = "Examples:"
        '
        'TxtActualInfTime
        '
        Me.TxtActualInfTime.Location = New System.Drawing.Point(106, 116)
        Me.TxtActualInfTime.Name = "TxtActualInfTime"
        Me.TxtActualInfTime.Size = New System.Drawing.Size(53, 20)
        Me.TxtActualInfTime.TabIndex = 5
        Me.ToolTipEntry.SetToolTip(Me.TxtActualInfTime, "0.5, 1, 2")
        '
        'TxtActualPkTime
        '
        Me.TxtActualPkTime.Location = New System.Drawing.Point(106, 159)
        Me.TxtActualPkTime.Name = "TxtActualPkTime"
        Me.TxtActualPkTime.Size = New System.Drawing.Size(53, 20)
        Me.TxtActualPkTime.TabIndex = 6
        Me.ToolTipEntry.SetToolTip(Me.TxtActualPkTime, "1, 3")
        '
        'TxtActualTrTime
        '
        Me.TxtActualTrTime.Location = New System.Drawing.Point(106, 202)
        Me.TxtActualTrTime.Name = "TxtActualTrTime"
        Me.TxtActualTrTime.Size = New System.Drawing.Size(52, 20)
        Me.TxtActualTrTime.TabIndex = 7
        Me.ToolTipEntry.SetToolTip(Me.TxtActualTrTime, "0.5")
        '
        'TxtInfusion
        '
        Me.TxtInfusion.Location = New System.Drawing.Point(103, 123)
        Me.TxtInfusion.Name = "TxtInfusion"
        Me.TxtInfusion.Size = New System.Drawing.Size(51, 20)
        Me.TxtInfusion.TabIndex = 5
        Me.ToolTipEntry.SetToolTip(Me.TxtInfusion, "0.5, 1, 2")
        '
        'TxtDrawPeak
        '
        Me.TxtDrawPeak.Location = New System.Drawing.Point(103, 163)
        Me.TxtDrawPeak.Name = "TxtDrawPeak"
        Me.TxtDrawPeak.Size = New System.Drawing.Size(58, 20)
        Me.TxtDrawPeak.TabIndex = 6
        Me.ToolTipEntry.SetToolTip(Me.TxtDrawPeak, "1, 3")
        '
        'TxtDrawTrough
        '
        Me.TxtDrawTrough.Location = New System.Drawing.Point(103, 202)
        Me.TxtDrawTrough.Name = "TxtDrawTrough"
        Me.TxtDrawTrough.Size = New System.Drawing.Size(51, 20)
        Me.TxtDrawTrough.TabIndex = 7
        Me.ToolTipEntry.SetToolTip(Me.TxtDrawTrough, "0.5")
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'ToolTipHelp
        '
        Me.ToolTipHelp.Active = False
        Me.ToolTipHelp.AutoPopDelay = 30000
        Me.ToolTipHelp.ForeColor = System.Drawing.Color.Black
        Me.ToolTipHelp.InitialDelay = 500
        Me.ToolTipHelp.IsBalloon = True
        Me.ToolTipHelp.ReshowDelay = 100
        Me.ToolTipHelp.ToolTipTitle = "Help"
        '
        'BtnOptions
        '
        Me.BtnOptions.Location = New System.Drawing.Point(10, 502)
        Me.BtnOptions.Name = "BtnOptions"
        Me.BtnOptions.Size = New System.Drawing.Size(202, 23)
        Me.BtnOptions.TabIndex = 44
        Me.BtnOptions.Text = "Options"
        Me.BtnOptions.UseVisualStyleBackColor = True
        '
        'TabPageNote
        '
        Me.TabPageNote.AutoScroll = True
        Me.TabPageNote.BackColor = System.Drawing.Color.Gainsboro
        Me.TabPageNote.Controls.Add(Me.RichTextBox1)
        Me.TabPageNote.Controls.Add(Me.GrpBoxNoteType)
        Me.TabPageNote.Controls.Add(Me.BtnPrintNote)
        Me.TabPageNote.Controls.Add(Me.BtnViewNote)
        Me.TabPageNote.Location = New System.Drawing.Point(4, 22)
        Me.TabPageNote.Name = "TabPageNote"
        Me.TabPageNote.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageNote.Size = New System.Drawing.Size(212, 410)
        Me.TabPageNote.TabIndex = 3
        Me.TabPageNote.Text = "PK Note"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.RichTextBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.RichTextBox1.Location = New System.Drawing.Point(3, 156)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(188, 371)
        Me.RichTextBox1.TabIndex = 4
        Me.RichTextBox1.Text = ""
        '
        'GrpBoxNoteType
        '
        Me.GrpBoxNoteType.Controls.Add(Me.RadButFollow)
        Me.GrpBoxNoteType.Controls.Add(Me.RadButExtInt)
        Me.GrpBoxNoteType.Controls.Add(Me.RadButInitial)
        Me.GrpBoxNoteType.Location = New System.Drawing.Point(7, 7)
        Me.GrpBoxNoteType.Name = "GrpBoxNoteType"
        Me.GrpBoxNoteType.Size = New System.Drawing.Size(184, 85)
        Me.GrpBoxNoteType.TabIndex = 3
        Me.GrpBoxNoteType.TabStop = False
        Me.GrpBoxNoteType.Text = "Note Type"
        '
        'RadButFollow
        '
        Me.RadButFollow.AutoSize = True
        Me.RadButFollow.Location = New System.Drawing.Point(6, 58)
        Me.RadButFollow.Name = "RadButFollow"
        Me.RadButFollow.Size = New System.Drawing.Size(72, 17)
        Me.RadButFollow.TabIndex = 2
        Me.RadButFollow.TabStop = True
        Me.RadButFollow.Text = "Follow-Up"
        Me.RadButFollow.UseVisualStyleBackColor = True
        '
        'RadButExtInt
        '
        Me.RadButExtInt.AutoSize = True
        Me.RadButExtInt.Location = New System.Drawing.Point(6, 35)
        Me.RadButExtInt.Name = "RadButExtInt"
        Me.RadButExtInt.Size = New System.Drawing.Size(108, 17)
        Me.RadButExtInt.TabIndex = 1
        Me.RadButExtInt.TabStop = True
        Me.RadButExtInt.Text = "Extended Interval"
        Me.RadButExtInt.UseVisualStyleBackColor = True
        '
        'RadButInitial
        '
        Me.RadButInitial.AutoSize = True
        Me.RadButInitial.Location = New System.Drawing.Point(6, 12)
        Me.RadButInitial.Name = "RadButInitial"
        Me.RadButInitial.Size = New System.Drawing.Size(85, 17)
        Me.RadButInitial.TabIndex = 0
        Me.RadButInitial.TabStop = True
        Me.RadButInitial.Text = "Initial Dosing"
        Me.RadButInitial.UseVisualStyleBackColor = True
        '
        'BtnPrintNote
        '
        Me.BtnPrintNote.Location = New System.Drawing.Point(3, 127)
        Me.BtnPrintNote.Name = "BtnPrintNote"
        Me.BtnPrintNote.Size = New System.Drawing.Size(188, 23)
        Me.BtnPrintNote.TabIndex = 2
        Me.BtnPrintNote.Text = "Print Note"
        Me.BtnPrintNote.UseVisualStyleBackColor = True
        '
        'BtnViewNote
        '
        Me.BtnViewNote.Location = New System.Drawing.Point(2, 98)
        Me.BtnViewNote.Name = "BtnViewNote"
        Me.BtnViewNote.Size = New System.Drawing.Size(189, 23)
        Me.BtnViewNote.TabIndex = 1
        Me.BtnViewNote.Text = "Enter Note Data"
        Me.BtnViewNote.UseVisualStyleBackColor = True
        '
        'TabPageAdjust
        '
        Me.TabPageAdjust.AutoScroll = True
        Me.TabPageAdjust.BackColor = System.Drawing.Color.Gainsboro
        Me.TabPageAdjust.Controls.Add(Me.GroupBox6)
        Me.TabPageAdjust.Controls.Add(Me.GroupBox7)
        Me.TabPageAdjust.Controls.Add(Me.GroupBox8)
        Me.TabPageAdjust.Location = New System.Drawing.Point(4, 22)
        Me.TabPageAdjust.Name = "TabPageAdjust"
        Me.TabPageAdjust.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageAdjust.Size = New System.Drawing.Size(212, 410)
        Me.TabPageAdjust.TabIndex = 2
        Me.TabPageAdjust.Text = "Dose Adjustment"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.LblPredictTr2)
        Me.GroupBox6.Controls.Add(Me.LblPredictPk2)
        Me.GroupBox6.Controls.Add(Me.Label56)
        Me.GroupBox6.Controls.Add(Me.Label57)
        Me.GroupBox6.Controls.Add(Me.TxtUseInterval)
        Me.GroupBox6.Controls.Add(Me.Label58)
        Me.GroupBox6.Controls.Add(Me.TxtUseDose)
        Me.GroupBox6.Controls.Add(Me.Label59)
        Me.GroupBox6.Location = New System.Drawing.Point(2, 406)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(191, 117)
        Me.GroupBox6.TabIndex = 6
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Predicted Peak and Trough"
        '
        'LblPredictTr2
        '
        Me.LblPredictTr2.AutoSize = True
        Me.LblPredictTr2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LblPredictTr2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPredictTr2.ForeColor = System.Drawing.Color.Black
        Me.LblPredictTr2.Location = New System.Drawing.Point(128, 94)
        Me.LblPredictTr2.Name = "LblPredictTr2"
        Me.LblPredictTr2.Size = New System.Drawing.Size(21, 13)
        Me.LblPredictTr2.TabIndex = 7
        Me.LblPredictTr2.Text = "00"
        '
        'LblPredictPk2
        '
        Me.LblPredictPk2.AutoSize = True
        Me.LblPredictPk2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LblPredictPk2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPredictPk2.ForeColor = System.Drawing.Color.Black
        Me.LblPredictPk2.Location = New System.Drawing.Point(128, 72)
        Me.LblPredictPk2.Name = "LblPredictPk2"
        Me.LblPredictPk2.Size = New System.Drawing.Size(21, 13)
        Me.LblPredictPk2.TabIndex = 6
        Me.LblPredictPk2.Text = "00"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.Location = New System.Drawing.Point(-3, 94)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(109, 13)
        Me.Label56.TabIndex = 5
        Me.Label56.Text = "Predicted Trough:"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.Location = New System.Drawing.Point(-3, 72)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(98, 13)
        Me.Label57.TabIndex = 4
        Me.Label57.Text = "Predicted Peak:"
        '
        'TxtUseInterval
        '
        Me.TxtUseInterval.Location = New System.Drawing.Point(106, 41)
        Me.TxtUseInterval.Name = "TxtUseInterval"
        Me.TxtUseInterval.Size = New System.Drawing.Size(73, 20)
        Me.TxtUseInterval.TabIndex = 9
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.Location = New System.Drawing.Point(-1, 44)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(95, 13)
        Me.Label58.TabIndex = 2
        Me.Label58.Text = "Interval to Use:"
        '
        'TxtUseDose
        '
        Me.TxtUseDose.Location = New System.Drawing.Point(106, 15)
        Me.TxtUseDose.Name = "TxtUseDose"
        Me.TxtUseDose.Size = New System.Drawing.Size(73, 20)
        Me.TxtUseDose.TabIndex = 8
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.Location = New System.Drawing.Point(-1, 18)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(81, 13)
        Me.Label59.TabIndex = 0
        Me.Label59.Text = "Dose to Use:"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.LblNewInterval)
        Me.GroupBox7.Controls.Add(Me.LblNewDose)
        Me.GroupBox7.Controls.Add(Me.Label62)
        Me.GroupBox7.Controls.Add(Me.Label63)
        Me.GroupBox7.Location = New System.Drawing.Point(2, 358)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(189, 33)
        Me.GroupBox7.TabIndex = 5
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "New Dose"
        '
        'LblNewInterval
        '
        Me.LblNewInterval.AutoSize = True
        Me.LblNewInterval.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LblNewInterval.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNewInterval.ForeColor = System.Drawing.Color.Black
        Me.LblNewInterval.Location = New System.Drawing.Point(106, 16)
        Me.LblNewInterval.Name = "LblNewInterval"
        Me.LblNewInterval.Size = New System.Drawing.Size(21, 13)
        Me.LblNewInterval.TabIndex = 0
        Me.LblNewInterval.Text = "00"
        '
        'LblNewDose
        '
        Me.LblNewDose.AutoSize = True
        Me.LblNewDose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LblNewDose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNewDose.ForeColor = System.Drawing.Color.Black
        Me.LblNewDose.Location = New System.Drawing.Point(6, 16)
        Me.LblNewDose.Name = "LblNewDose"
        Me.LblNewDose.Size = New System.Drawing.Size(35, 13)
        Me.LblNewDose.TabIndex = 4
        Me.LblNewDose.Text = "0000"
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Location = New System.Drawing.Point(133, 16)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(16, 13)
        Me.Label62.TabIndex = 3
        Me.Label62.Text = "hr"
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Location = New System.Drawing.Point(47, 16)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(53, 13)
        Me.Label63.TabIndex = 1
        Me.Label63.Text = "mg  every"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Label44)
        Me.GroupBox8.Controls.Add(Me.TxtDesTrough)
        Me.GroupBox8.Controls.Add(Me.TxtDesPeak)
        Me.GroupBox8.Controls.Add(Me.Label54)
        Me.GroupBox8.Controls.Add(Me.Label55)
        Me.GroupBox8.Controls.Add(Me.Label43)
        Me.GroupBox8.Controls.Add(Me.Label89)
        Me.GroupBox8.Controls.Add(Me.Label88)
        Me.GroupBox8.Controls.Add(Me.TxtActualInterval)
        Me.GroupBox8.Controls.Add(Me.TxtActualDose)
        Me.GroupBox8.Controls.Add(Me.Label76)
        Me.GroupBox8.Controls.Add(Me.Label53)
        Me.GroupBox8.Controls.Add(Me.Label52)
        Me.GroupBox8.Controls.Add(Me.Label51)
        Me.GroupBox8.Controls.Add(Me.LblActualT05)
        Me.GroupBox8.Controls.Add(Me.LblActualVd)
        Me.GroupBox8.Controls.Add(Me.LblActualK)
        Me.GroupBox8.Controls.Add(Me.Label50)
        Me.GroupBox8.Controls.Add(Me.Label64)
        Me.GroupBox8.Controls.Add(Me.Label65)
        Me.GroupBox8.Controls.Add(Me.TxtActualTrTime)
        Me.GroupBox8.Controls.Add(Me.Label66)
        Me.GroupBox8.Controls.Add(Me.Label67)
        Me.GroupBox8.Controls.Add(Me.Label68)
        Me.GroupBox8.Controls.Add(Me.TxtActualPkTime)
        Me.GroupBox8.Controls.Add(Me.Label69)
        Me.GroupBox8.Controls.Add(Me.Label70)
        Me.GroupBox8.Controls.Add(Me.TxtActualInfTime)
        Me.GroupBox8.Controls.Add(Me.Label71)
        Me.GroupBox8.Controls.Add(Me.Label72)
        Me.GroupBox8.Controls.Add(Me.Label73)
        Me.GroupBox8.Controls.Add(Me.TxtActualTrough)
        Me.GroupBox8.Controls.Add(Me.TxtActualPeak)
        Me.GroupBox8.Controls.Add(Me.Label74)
        Me.GroupBox8.Controls.Add(Me.Label75)
        Me.GroupBox8.Location = New System.Drawing.Point(2, 3)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(189, 349)
        Me.GroupBox8.TabIndex = 4
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Patient Specific Values"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(163, 20)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(21, 13)
        Me.Label44.TabIndex = 33
        Me.Label44.Text = "mg"
        '
        'TxtDesTrough
        '
        Me.TxtDesTrough.Location = New System.Drawing.Point(106, 326)
        Me.TxtDesTrough.Name = "TxtDesTrough"
        Me.TxtDesTrough.Size = New System.Drawing.Size(75, 20)
        Me.TxtDesTrough.TabIndex = 32
        '
        'TxtDesPeak
        '
        Me.TxtDesPeak.Location = New System.Drawing.Point(106, 300)
        Me.TxtDesPeak.Name = "TxtDesPeak"
        Me.TxtDesPeak.Size = New System.Drawing.Size(75, 20)
        Me.TxtDesPeak.TabIndex = 31
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.Location = New System.Drawing.Point(-1, 329)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(110, 13)
        Me.Label54.TabIndex = 30
        Me.Label54.Text = "New Trough Goal:"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.Location = New System.Drawing.Point(-1, 303)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(99, 13)
        Me.Label55.TabIndex = 29
        Me.Label55.Text = "New Peak Goal:"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(165, 44)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(16, 13)
        Me.Label43.TabIndex = 28
        Me.Label43.Text = "hr"
        '
        'Label89
        '
        Me.Label89.AutoSize = True
        Me.Label89.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label89.Location = New System.Drawing.Point(3, 44)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(94, 13)
        Me.Label89.TabIndex = 27
        Me.Label89.Text = "Actual Interval:"
        '
        'Label88
        '
        Me.Label88.AutoSize = True
        Me.Label88.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label88.Location = New System.Drawing.Point(6, 20)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(80, 13)
        Me.Label88.TabIndex = 26
        Me.Label88.Text = "Actual Dose:"
        '
        'TxtActualInterval
        '
        Me.TxtActualInterval.Location = New System.Drawing.Point(106, 41)
        Me.TxtActualInterval.Name = "TxtActualInterval"
        Me.TxtActualInterval.Size = New System.Drawing.Size(53, 20)
        Me.TxtActualInterval.TabIndex = 2
        '
        'TxtActualDose
        '
        Me.TxtActualDose.Location = New System.Drawing.Point(106, 17)
        Me.TxtActualDose.Name = "TxtActualDose"
        Me.TxtActualDose.Size = New System.Drawing.Size(52, 20)
        Me.TxtActualDose.TabIndex = 1
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.Location = New System.Drawing.Point(165, 273)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(16, 13)
        Me.Label76.TabIndex = 23
        Me.Label76.Text = "hr"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(165, 252)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(13, 13)
        Me.Label53.TabIndex = 22
        Me.Label53.Text = "L"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.Location = New System.Drawing.Point(178, 225)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(13, 12)
        Me.Label52.TabIndex = 5
        Me.Label52.Text = "-1"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(165, 231)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(16, 13)
        Me.Label51.TabIndex = 21
        Me.Label51.Text = "hr"
        '
        'LblActualT05
        '
        Me.LblActualT05.AutoSize = True
        Me.LblActualT05.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblActualT05.ForeColor = System.Drawing.Color.Red
        Me.LblActualT05.Location = New System.Drawing.Point(112, 273)
        Me.LblActualT05.Name = "LblActualT05"
        Me.LblActualT05.Size = New System.Drawing.Size(14, 13)
        Me.LblActualT05.TabIndex = 20
        Me.LblActualT05.Text = "5"
        '
        'LblActualVd
        '
        Me.LblActualVd.AutoSize = True
        Me.LblActualVd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblActualVd.ForeColor = System.Drawing.Color.Red
        Me.LblActualVd.Location = New System.Drawing.Point(112, 252)
        Me.LblActualVd.Name = "LblActualVd"
        Me.LblActualVd.Size = New System.Drawing.Size(14, 13)
        Me.LblActualVd.TabIndex = 19
        Me.LblActualVd.Text = "5"
        '
        'LblActualK
        '
        Me.LblActualK.AutoSize = True
        Me.LblActualK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblActualK.ForeColor = System.Drawing.Color.Red
        Me.LblActualK.Location = New System.Drawing.Point(112, 231)
        Me.LblActualK.Name = "LblActualK"
        Me.LblActualK.Size = New System.Drawing.Size(14, 13)
        Me.LblActualK.TabIndex = 18
        Me.LblActualK.Text = "5"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(-1, 273)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(79, 13)
        Me.Label50.TabIndex = 17
        Me.Label50.Text = "Actual t 1/2:"
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.Location = New System.Drawing.Point(3, 205)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(84, 13)
        Me.Label64.TabIndex = 1
        Me.Label64.Text = "Draw Trough:"
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Location = New System.Drawing.Point(165, 205)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(16, 13)
        Me.Label65.TabIndex = 16
        Me.Label65.Text = "hr"
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.Location = New System.Drawing.Point(-5, 186)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(186, 13)
        Me.Label66.TabIndex = 1
        Me.Label66.Text = "Time between draw and next infusion:"
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.Location = New System.Drawing.Point(3, 162)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(73, 13)
        Me.Label67.TabIndex = 14
        Me.Label67.Text = "Draw Peak:"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Location = New System.Drawing.Point(163, 162)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(16, 13)
        Me.Label68.TabIndex = 13
        Me.Label68.Text = "hr"
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Location = New System.Drawing.Point(17, 143)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(149, 13)
        Me.Label69.TabIndex = 11
        Me.Label69.Text = "Time from start of this infusion:"
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Location = New System.Drawing.Point(163, 119)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(16, 13)
        Me.Label70.TabIndex = 10
        Me.Label70.Text = "hr"
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.Location = New System.Drawing.Point(3, 119)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(87, 13)
        Me.Label71.TabIndex = 8
        Me.Label71.Text = "Infusion Time:"
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label72.Location = New System.Drawing.Point(3, 252)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(66, 13)
        Me.Label72.TabIndex = 7
        Me.Label72.Text = "Actual Vd:"
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label73.Location = New System.Drawing.Point(6, 231)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(58, 13)
        Me.Label73.TabIndex = 6
        Me.Label73.Text = "Actual k:"
        '
        'TxtActualTrough
        '
        Me.TxtActualTrough.Location = New System.Drawing.Point(106, 91)
        Me.TxtActualTrough.Name = "TxtActualTrough"
        Me.TxtActualTrough.Size = New System.Drawing.Size(75, 20)
        Me.TxtActualTrough.TabIndex = 4
        '
        'TxtActualPeak
        '
        Me.TxtActualPeak.Location = New System.Drawing.Point(106, 65)
        Me.TxtActualPeak.Name = "TxtActualPeak"
        Me.TxtActualPeak.Size = New System.Drawing.Size(75, 20)
        Me.TxtActualPeak.TabIndex = 3
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label74.Location = New System.Drawing.Point(4, 94)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(91, 13)
        Me.Label74.TabIndex = 1
        Me.Label74.Text = "Actual Trough:"
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label75.Location = New System.Drawing.Point(6, 68)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(80, 13)
        Me.Label75.TabIndex = 0
        Me.Label75.Text = "Actual Peak:"
        '
        'TabPageInit
        '
        Me.TabPageInit.AutoScroll = True
        Me.TabPageInit.BackColor = System.Drawing.Color.Gainsboro
        Me.TabPageInit.Controls.Add(Me.GrpBoxExtInt)
        Me.TabPageInit.Controls.Add(Me.GroupBox4)
        Me.TabPageInit.Controls.Add(Me.GroupBox3)
        Me.TabPageInit.Controls.Add(Me.GroupBox2)
        Me.TabPageInit.Location = New System.Drawing.Point(4, 22)
        Me.TabPageInit.Name = "TabPageInit"
        Me.TabPageInit.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageInit.Size = New System.Drawing.Size(212, 410)
        Me.TabPageInit.TabIndex = 1
        Me.TabPageInit.Text = "Initial Dosing"
        '
        'GrpBoxExtInt
        '
        Me.GrpBoxExtInt.Controls.Add(Me.LblExtIntInt)
        Me.GrpBoxExtInt.Controls.Add(Me.Label48)
        Me.GrpBoxExtInt.Controls.Add(Me.LblExtIntDose)
        Me.GrpBoxExtInt.Controls.Add(Me.Label47)
        Me.GrpBoxExtInt.Location = New System.Drawing.Point(4, 481)
        Me.GrpBoxExtInt.Name = "GrpBoxExtInt"
        Me.GrpBoxExtInt.Size = New System.Drawing.Size(185, 42)
        Me.GrpBoxExtInt.TabIndex = 3
        Me.GrpBoxExtInt.TabStop = False
        Me.GrpBoxExtInt.Text = "Extended Interval Dose"
        Me.GrpBoxExtInt.Visible = False
        '
        'LblExtIntInt
        '
        Me.LblExtIntInt.AutoSize = True
        Me.LblExtIntInt.BackColor = System.Drawing.Color.Salmon
        Me.LblExtIntInt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblExtIntInt.ForeColor = System.Drawing.Color.Black
        Me.LblExtIntInt.Location = New System.Drawing.Point(108, 20)
        Me.LblExtIntInt.Name = "LblExtIntInt"
        Me.LblExtIntInt.Size = New System.Drawing.Size(21, 13)
        Me.LblExtIntInt.TabIndex = 5
        Me.LblExtIntInt.Text = "00"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(49, 20)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(53, 13)
        Me.Label48.TabIndex = 6
        Me.Label48.Text = "mg  every"
        '
        'LblExtIntDose
        '
        Me.LblExtIntDose.AutoSize = True
        Me.LblExtIntDose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LblExtIntDose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblExtIntDose.ForeColor = System.Drawing.Color.Black
        Me.LblExtIntDose.Location = New System.Drawing.Point(8, 20)
        Me.LblExtIntDose.Name = "LblExtIntDose"
        Me.LblExtIntDose.Size = New System.Drawing.Size(35, 13)
        Me.LblExtIntDose.TabIndex = 8
        Me.LblExtIntDose.Text = "0000"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(135, 20)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(16, 13)
        Me.Label47.TabIndex = 7
        Me.Label47.Text = "hr"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.LblPredictTr)
        Me.GroupBox4.Controls.Add(Me.LblPredictPk)
        Me.GroupBox4.Controls.Add(Me.Label42)
        Me.GroupBox4.Controls.Add(Me.Label41)
        Me.GroupBox4.Controls.Add(Me.TxtIntervalUse)
        Me.GroupBox4.Controls.Add(Me.Label40)
        Me.GroupBox4.Controls.Add(Me.TxtDoseUse)
        Me.GroupBox4.Controls.Add(Me.Label39)
        Me.GroupBox4.Location = New System.Drawing.Point(2, 359)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(187, 116)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Predicted Peak and Trough"
        '
        'LblPredictTr
        '
        Me.LblPredictTr.AutoSize = True
        Me.LblPredictTr.BackColor = System.Drawing.Color.PaleGreen
        Me.LblPredictTr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPredictTr.ForeColor = System.Drawing.Color.Black
        Me.LblPredictTr.Location = New System.Drawing.Point(133, 75)
        Me.LblPredictTr.Name = "LblPredictTr"
        Me.LblPredictTr.Size = New System.Drawing.Size(21, 13)
        Me.LblPredictTr.TabIndex = 7
        Me.LblPredictTr.Text = "00"
        '
        'LblPredictPk
        '
        Me.LblPredictPk.AutoSize = True
        Me.LblPredictPk.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LblPredictPk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPredictPk.ForeColor = System.Drawing.Color.Black
        Me.LblPredictPk.Location = New System.Drawing.Point(133, 97)
        Me.LblPredictPk.Name = "LblPredictPk"
        Me.LblPredictPk.Size = New System.Drawing.Size(21, 13)
        Me.LblPredictPk.TabIndex = 6
        Me.LblPredictPk.Text = "00"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(3, 75)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(109, 13)
        Me.Label42.TabIndex = 5
        Me.Label42.Text = "Predicted Trough:"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(3, 97)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(98, 13)
        Me.Label41.TabIndex = 4
        Me.Label41.Text = "Predicted Peak:"
        '
        'TxtIntervalUse
        '
        Me.TxtIntervalUse.Location = New System.Drawing.Point(103, 45)
        Me.TxtIntervalUse.Name = "TxtIntervalUse"
        Me.TxtIntervalUse.Size = New System.Drawing.Size(73, 20)
        Me.TxtIntervalUse.TabIndex = 9
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(3, 48)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(95, 13)
        Me.Label40.TabIndex = 2
        Me.Label40.Text = "Interval to Use:"
        '
        'TxtDoseUse
        '
        Me.TxtDoseUse.Location = New System.Drawing.Point(103, 19)
        Me.TxtDoseUse.Name = "TxtDoseUse"
        Me.TxtDoseUse.Size = New System.Drawing.Size(73, 20)
        Me.TxtDoseUse.TabIndex = 8
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(3, 23)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(81, 13)
        Me.Label39.TabIndex = 0
        Me.Label39.Text = "Dose to Use:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LblIntervalEst)
        Me.GroupBox3.Controls.Add(Me.LblDoseEst)
        Me.GroupBox3.Controls.Add(Me.Label38)
        Me.GroupBox3.Controls.Add(Me.Label37)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 305)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(186, 48)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Estimated Dose"
        '
        'LblIntervalEst
        '
        Me.LblIntervalEst.AutoSize = True
        Me.LblIntervalEst.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LblIntervalEst.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIntervalEst.ForeColor = System.Drawing.Color.Black
        Me.LblIntervalEst.Location = New System.Drawing.Point(108, 20)
        Me.LblIntervalEst.Name = "LblIntervalEst"
        Me.LblIntervalEst.Size = New System.Drawing.Size(21, 13)
        Me.LblIntervalEst.TabIndex = 0
        Me.LblIntervalEst.Text = "00"
        '
        'LblDoseEst
        '
        Me.LblDoseEst.AutoSize = True
        Me.LblDoseEst.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LblDoseEst.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDoseEst.ForeColor = System.Drawing.Color.Black
        Me.LblDoseEst.Location = New System.Drawing.Point(8, 20)
        Me.LblDoseEst.Name = "LblDoseEst"
        Me.LblDoseEst.Size = New System.Drawing.Size(35, 13)
        Me.LblDoseEst.TabIndex = 4
        Me.LblDoseEst.Text = "0000"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(135, 20)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(16, 13)
        Me.Label38.TabIndex = 3
        Me.Label38.Text = "hr"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(49, 20)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(53, 13)
        Me.Label37.TabIndex = 1
        Me.Label37.Text = "mg  every"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LblEstVd)
        Me.GroupBox2.Controls.Add(Me.CboXDrug)
        Me.GroupBox2.Controls.Add(Me.Label87)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label86)
        Me.GroupBox2.Controls.Add(Me.Label36)
        Me.GroupBox2.Controls.Add(Me.Label49)
        Me.GroupBox2.Controls.Add(Me.Label35)
        Me.GroupBox2.Controls.Add(Me.Label46)
        Me.GroupBox2.Controls.Add(Me.TxtDrawTrough)
        Me.GroupBox2.Controls.Add(Me.Label45)
        Me.GroupBox2.Controls.Add(Me.Label34)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.Label33)
        Me.GroupBox2.Controls.Add(Me.LblEstT05)
        Me.GroupBox2.Controls.Add(Me.Label32)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.LblEstK)
        Me.GroupBox2.Controls.Add(Me.TxtDrawPeak)
        Me.GroupBox2.Controls.Add(Me.Label31)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Controls.Add(Me.TxtCV)
        Me.GroupBox2.Controls.Add(Me.TxtInfusion)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Controls.Add(Me.TxtTroughDes)
        Me.GroupBox2.Controls.Add(Me.TxtPeakDes)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(185, 299)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dose Estimation"
        '
        'LblEstVd
        '
        Me.LblEstVd.AutoSize = True
        Me.LblEstVd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEstVd.ForeColor = System.Drawing.Color.Red
        Me.LblEstVd.Location = New System.Drawing.Point(87, 280)
        Me.LblEstVd.Name = "LblEstVd"
        Me.LblEstVd.Size = New System.Drawing.Size(21, 13)
        Me.LblEstVd.TabIndex = 54
        Me.LblEstVd.Text = "25"
        '
        'CboXDrug
        '
        Me.CboXDrug.FormattingEnabled = True
        Me.CboXDrug.Items.AddRange(New Object() {"Vancomycin", "Gentamicin", "Tobramycin"})
        Me.CboXDrug.Location = New System.Drawing.Point(42, 16)
        Me.CboXDrug.Name = "CboXDrug"
        Me.CboXDrug.Size = New System.Drawing.Size(134, 21)
        Me.CboXDrug.TabIndex = 13
        Me.CboXDrug.Tag = "Drug"
        '
        'Label87
        '
        Me.Label87.AutoSize = True
        Me.Label87.Location = New System.Drawing.Point(160, 280)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(13, 13)
        Me.Label87.TabIndex = 53
        Me.Label87.Text = "L"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Drug:"
        '
        'Label86
        '
        Me.Label86.AutoSize = True
        Me.Label86.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label86.Location = New System.Drawing.Point(1, 280)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(52, 13)
        Me.Label86.TabIndex = 52
        Me.Label86.Text = "Est. Vd:"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(3, 205)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(84, 13)
        Me.Label36.TabIndex = 1
        Me.Label36.Text = "Draw Trough:"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(159, 257)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(16, 13)
        Me.Label49.TabIndex = 51
        Me.Label49.Text = "hr"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(160, 205)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(16, 13)
        Me.Label35.TabIndex = 16
        Me.Label35.Text = "hr"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(166, 219)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(13, 12)
        Me.Label46.TabIndex = 50
        Me.Label46.Text = "-1"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(157, 231)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(16, 13)
        Me.Label45.TabIndex = 49
        Me.Label45.Text = "hr"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(13, 186)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(153, 13)
        Me.Label34.TabIndex = 1
        Me.Label34.Text = "Time from start of next infusion:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(1, 257)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(65, 13)
        Me.Label25.TabIndex = 48
        Me.Label25.Text = "Est. t 1/2:"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(3, 166)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(73, 13)
        Me.Label33.TabIndex = 14
        Me.Label33.Text = "Draw Peak:"
        '
        'LblEstT05
        '
        Me.LblEstT05.AutoSize = True
        Me.LblEstT05.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEstT05.ForeColor = System.Drawing.Color.Red
        Me.LblEstT05.Location = New System.Drawing.Point(87, 257)
        Me.LblEstT05.Name = "LblEstT05"
        Me.LblEstT05.Size = New System.Drawing.Size(21, 13)
        Me.LblEstT05.TabIndex = 47
        Me.LblEstT05.Text = "12"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(160, 166)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(16, 13)
        Me.Label32.TabIndex = 13
        Me.Label32.Text = "hr"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(1, 231)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(44, 13)
        Me.Label24.TabIndex = 46
        Me.Label24.Text = "Est. k:"
        '
        'LblEstK
        '
        Me.LblEstK.AutoSize = True
        Me.LblEstK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEstK.ForeColor = System.Drawing.Color.Red
        Me.LblEstK.Location = New System.Drawing.Point(78, 231)
        Me.LblEstK.Name = "LblEstK"
        Me.LblEstK.Size = New System.Drawing.Size(39, 13)
        Me.LblEstK.TabIndex = 45
        Me.LblEstK.Text = "0.006"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(17, 146)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(149, 13)
        Me.Label31.TabIndex = 11
        Me.Label31.Text = "Time from start of this infusion:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(146, 46)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(30, 13)
        Me.Label23.TabIndex = 41
        Me.Label23.Text = "L/kg"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(160, 126)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(16, 13)
        Me.Label30.TabIndex = 10
        Me.Label30.Text = "hr"
        '
        'TxtCV
        '
        Me.TxtCV.Location = New System.Drawing.Point(42, 43)
        Me.TxtCV.Name = "TxtCV"
        Me.TxtCV.Size = New System.Drawing.Size(101, 20)
        Me.TxtCV.TabIndex = 39
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 13)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "CV:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(3, 126)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(87, 13)
        Me.Label29.TabIndex = 8
        Me.Label29.Text = "Infusion Time:"
        '
        'TxtTroughDes
        '
        Me.TxtTroughDes.Location = New System.Drawing.Point(103, 97)
        Me.TxtTroughDes.Name = "TxtTroughDes"
        Me.TxtTroughDes.Size = New System.Drawing.Size(73, 20)
        Me.TxtTroughDes.TabIndex = 2
        '
        'TxtPeakDes
        '
        Me.TxtPeakDes.Location = New System.Drawing.Point(103, 71)
        Me.TxtPeakDes.Name = "TxtPeakDes"
        Me.TxtPeakDes.Size = New System.Drawing.Size(73, 20)
        Me.TxtPeakDes.TabIndex = 1
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(1, 100)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(98, 13)
        Me.Label26.TabIndex = 1
        Me.Label26.Text = "Desired Trough:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Desired Peak:"
        '
        'LblVdtoUse
        '
        Me.LblVdtoUse.AutoSize = True
        Me.LblVdtoUse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVdtoUse.ForeColor = System.Drawing.Color.Red
        Me.LblVdtoUse.Location = New System.Drawing.Point(195, 512)
        Me.LblVdtoUse.Name = "LblVdtoUse"
        Me.LblVdtoUse.Size = New System.Drawing.Size(32, 13)
        Me.LblVdtoUse.TabIndex = 27
        Me.LblVdtoUse.Text = "25.2"
        Me.LblVdtoUse.Visible = False
        '
        'LblKtoUse
        '
        Me.LblKtoUse.AutoSize = True
        Me.LblKtoUse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblKtoUse.ForeColor = System.Drawing.Color.Red
        Me.LblKtoUse.Location = New System.Drawing.Point(183, 512)
        Me.LblKtoUse.Name = "LblKtoUse"
        Me.LblKtoUse.Size = New System.Drawing.Size(39, 13)
        Me.LblKtoUse.TabIndex = 26
        Me.LblKtoUse.Text = "0.004"
        Me.LblKtoUse.Visible = False
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.Location = New System.Drawing.Point(168, 497)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(13, 13)
        Me.Label77.TabIndex = 25
        Me.Label77.Text = "L"
        Me.Label77.Visible = False
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label78.Location = New System.Drawing.Point(181, 464)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(13, 12)
        Me.Label78.TabIndex = 23
        Me.Label78.Text = "-1"
        Me.Label78.Visible = False
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.Location = New System.Drawing.Point(168, 470)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(16, 13)
        Me.Label79.TabIndex = 24
        Me.Label79.Text = "hr"
        Me.Label79.Visible = False
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(15, 497)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(67, 13)
        Me.Label28.TabIndex = 7
        Me.Label28.Text = "Vd to Use:"
        Me.Label28.Visible = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(15, 470)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(59, 13)
        Me.Label27.TabIndex = 6
        Me.Label27.Text = "k to Use:"
        Me.Label27.Visible = False
        '
        'TabPageDemo
        '
        Me.TabPageDemo.BackColor = System.Drawing.Color.Gainsboro
        Me.TabPageDemo.Controls.Add(Me.GroupBox9)
        Me.TabPageDemo.Controls.Add(Me.GroupBox5)
        Me.TabPageDemo.Controls.Add(Me.GrpBoxCrCl)
        Me.TabPageDemo.Location = New System.Drawing.Point(4, 22)
        Me.TabPageDemo.Name = "TabPageDemo"
        Me.TabPageDemo.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageDemo.Size = New System.Drawing.Size(212, 410)
        Me.TabPageDemo.TabIndex = 0
        Me.TabPageDemo.Text = "Patient Demographics"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Label11)
        Me.GroupBox9.Controls.Add(Me.Label16)
        Me.GroupBox9.Controls.Add(Me.LblCrCl)
        Me.GroupBox9.Controls.Add(Me.Label17)
        Me.GroupBox9.Controls.Add(Me.LblBSA)
        Me.GroupBox9.Controls.Add(Me.Label19)
        Me.GroupBox9.Controls.Add(Me.Label14)
        Me.GroupBox9.Controls.Add(Me.LblCrClStd)
        Me.GroupBox9.Controls.Add(Me.LblIBW)
        Me.GroupBox9.Controls.Add(Me.Label21)
        Me.GroupBox9.Controls.Add(Me.Label1)
        Me.GroupBox9.Controls.Add(Me.Label12)
        Me.GroupBox9.Controls.Add(Me.Label10)
        Me.GroupBox9.Controls.Add(Me.Label22)
        Me.GroupBox9.Location = New System.Drawing.Point(4, 296)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(201, 110)
        Me.GroupBox9.TabIndex = 43
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Calculated Data"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(1, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "IBW:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(127, 41)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(15, 13)
        Me.Label16.TabIndex = 24
        Me.Label16.Text = "m"
        '
        'LblCrCl
        '
        Me.LblCrCl.AutoSize = True
        Me.LblCrCl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCrCl.ForeColor = System.Drawing.Color.Red
        Me.LblCrCl.Location = New System.Drawing.Point(71, 64)
        Me.LblCrCl.Name = "LblCrCl"
        Me.LblCrCl.Size = New System.Drawing.Size(28, 13)
        Me.LblCrCl.TabIndex = 26
        Me.LblCrCl.Text = "100"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(140, 35)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(10, 12)
        Me.Label17.TabIndex = 25
        Me.Label17.Text = "2"
        '
        'LblBSA
        '
        Me.LblBSA.AutoSize = True
        Me.LblBSA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBSA.ForeColor = System.Drawing.Color.Red
        Me.LblBSA.Location = New System.Drawing.Point(67, 41)
        Me.LblBSA.Name = "LblBSA"
        Me.LblBSA.Size = New System.Drawing.Size(32, 13)
        Me.LblBSA.TabIndex = 23
        Me.LblBSA.Text = "73.3"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(127, 64)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(38, 13)
        Me.Label19.TabIndex = 27
        Me.Label19.Text = "ml/min"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(127, 20)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(19, 13)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "kg"
        '
        'LblCrClStd
        '
        Me.LblCrClStd.AutoSize = True
        Me.LblCrClStd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCrClStd.ForeColor = System.Drawing.Color.Red
        Me.LblCrClStd.Location = New System.Drawing.Point(71, 89)
        Me.LblCrClStd.Name = "LblCrClStd"
        Me.LblCrClStd.Size = New System.Drawing.Size(28, 13)
        Me.LblCrClStd.TabIndex = 28
        Me.LblCrClStd.Text = "100"
        '
        'LblIBW
        '
        Me.LblIBW.AutoSize = True
        Me.LblIBW.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIBW.ForeColor = System.Drawing.Color.Red
        Me.LblIBW.Location = New System.Drawing.Point(67, 20)
        Me.LblIBW.Name = "LblIBW"
        Me.LblIBW.Size = New System.Drawing.Size(32, 13)
        Me.LblIBW.TabIndex = 21
        Me.LblIBW.Text = "96.3"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(104, 89)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(75, 13)
        Me.Label21.TabIndex = 29
        Me.Label21.Text = "ml/min/1.73 m"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "CrCl:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(1, 41)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "BSA:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(1, 89)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "CrCl Std:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(174, 79)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(10, 12)
        Me.Label22.TabIndex = 30
        Me.Label22.Text = "2"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TxtABW)
        Me.GroupBox5.Controls.Add(Me.TxtHeight)
        Me.GroupBox5.Controls.Add(Me.TxtAge)
        Me.GroupBox5.Controls.Add(Me.TxtSCr)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.GroupBox1)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Location = New System.Drawing.Point(4, 82)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(201, 208)
        Me.GroupBox5.TabIndex = 42
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Patient Data"
        '
        'TxtABW
        '
        Me.TxtABW.Cursor = System.Windows.Forms.Cursors.Default
        Me.TxtABW.Location = New System.Drawing.Point(49, 80)
        Me.TxtABW.Name = "TxtABW"
        Me.TxtABW.Size = New System.Drawing.Size(95, 20)
        Me.TxtABW.TabIndex = 1
        '
        'TxtHeight
        '
        Me.TxtHeight.Location = New System.Drawing.Point(49, 112)
        Me.TxtHeight.Name = "TxtHeight"
        Me.TxtHeight.Size = New System.Drawing.Size(95, 20)
        Me.TxtHeight.TabIndex = 2
        '
        'TxtAge
        '
        Me.TxtAge.Location = New System.Drawing.Point(49, 144)
        Me.TxtAge.Name = "TxtAge"
        Me.TxtAge.Size = New System.Drawing.Size(95, 20)
        Me.TxtAge.TabIndex = 3
        '
        'TxtSCr
        '
        Me.TxtSCr.Location = New System.Drawing.Point(49, 177)
        Me.TxtSCr.Name = "TxtSCr"
        Me.TxtSCr.Size = New System.Drawing.Size(95, 20)
        Me.TxtSCr.TabIndex = 4
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(145, 180)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(38, 13)
        Me.Label20.TabIndex = 37
        Me.Label20.Text = "mg/dL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(2, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Gender:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadButFemale)
        Me.GroupBox1.Controls.Add(Me.RadButMale)
        Me.GroupBox1.Location = New System.Drawing.Point(57, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(120, 56)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        '
        'RadButFemale
        '
        Me.RadButFemale.AutoSize = True
        Me.RadButFemale.Location = New System.Drawing.Point(31, 32)
        Me.RadButFemale.Name = "RadButFemale"
        Me.RadButFemale.Size = New System.Drawing.Size(59, 17)
        Me.RadButFemale.TabIndex = 32
        Me.RadButFemale.TabStop = True
        Me.RadButFemale.Text = "Female"
        Me.RadButFemale.UseVisualStyleBackColor = True
        '
        'RadButMale
        '
        Me.RadButMale.AutoSize = True
        Me.RadButMale.Location = New System.Drawing.Point(31, 9)
        Me.RadButMale.Name = "RadButMale"
        Me.RadButMale.Size = New System.Drawing.Size(48, 17)
        Me.RadButMale.TabIndex = 31
        Me.RadButMale.TabStop = True
        Me.RadButMale.Text = "Male"
        Me.RadButMale.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "ABW:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(2, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Height:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(149, 147)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(32, 13)
        Me.Label18.TabIndex = 36
        Me.Label18.Text = "years"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 147)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Age:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(145, 115)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(38, 13)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "inches"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 180)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "SCr:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(153, 83)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(19, 13)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "kg"
        '
        'GrpBoxCrCl
        '
        Me.GrpBoxCrCl.Controls.Add(Me.RadButJelliffe)
        Me.GrpBoxCrCl.Controls.Add(Me.RadButCCG)
        Me.GrpBoxCrCl.Location = New System.Drawing.Point(4, 6)
        Me.GrpBoxCrCl.Name = "GrpBoxCrCl"
        Me.GrpBoxCrCl.Size = New System.Drawing.Size(201, 70)
        Me.GrpBoxCrCl.TabIndex = 28
        Me.GrpBoxCrCl.TabStop = False
        Me.GrpBoxCrCl.Text = "CrCl Method"
        '
        'RadButJelliffe
        '
        Me.RadButJelliffe.AutoSize = True
        Me.RadButJelliffe.Location = New System.Drawing.Point(19, 42)
        Me.RadButJelliffe.Name = "RadButJelliffe"
        Me.RadButJelliffe.Size = New System.Drawing.Size(54, 17)
        Me.RadButJelliffe.TabIndex = 30
        Me.RadButJelliffe.TabStop = True
        Me.RadButJelliffe.Text = "Jelliffe"
        Me.RadButJelliffe.UseVisualStyleBackColor = True
        '
        'RadButCCG
        '
        Me.RadButCCG.AutoSize = True
        Me.RadButCCG.Location = New System.Drawing.Point(19, 19)
        Me.RadButCCG.Name = "RadButCCG"
        Me.RadButCCG.Size = New System.Drawing.Size(93, 17)
        Me.RadButCCG.TabIndex = 29
        Me.RadButCCG.TabStop = True
        Me.RadButCCG.Text = "Cockroft-Gault"
        Me.RadButCCG.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPageDemo)
        Me.TabControl1.Controls.Add(Me.TabPageInit)
        Me.TabControl1.Controls.Add(Me.TabPageAdjust)
        Me.TabControl1.Controls.Add(Me.TabPageNote)
        Me.TabControl1.Location = New System.Drawing.Point(2, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(220, 436)
        Me.TabControl1.TabIndex = 4
        '
        'FrmCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(223, 530)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.BtnGo)
        Me.Controls.Add(Me.LblVdtoUse)
        Me.Controls.Add(Me.BtnOptions)
        Me.Controls.Add(Me.LblKtoUse)
        Me.Controls.Add(Me.Label77)
        Me.Controls.Add(Me.BtnUnGo)
        Me.Controls.Add(Me.Label79)
        Me.Controls.Add(Me.Label78)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label28)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmCalculator"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Kinetics Calculator"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.TabPageNote.ResumeLayout(False)
        Me.GrpBoxNoteType.ResumeLayout(False)
        Me.GrpBoxNoteType.PerformLayout()
        Me.TabPageAdjust.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.TabPageInit.ResumeLayout(False)
        Me.GrpBoxExtInt.ResumeLayout(False)
        Me.GrpBoxExtInt.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPageDemo.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GrpBoxCrCl.ResumeLayout(False)
        Me.GrpBoxCrCl.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents BtnGo As System.Windows.Forms.Button
    Friend WithEvents BtnUnGo As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopyAllText As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintDocument2 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDocument3 As System.Drawing.Printing.PrintDocument
    Friend WithEvents ToolTipEntry As System.Windows.Forms.ToolTip
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents ToolTipHelp As System.Windows.Forms.ToolTip
    Friend WithEvents BtnOptions As System.Windows.Forms.Button
    Friend WithEvents TabPageNote As System.Windows.Forms.TabPage
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents GrpBoxNoteType As System.Windows.Forms.GroupBox
    Friend WithEvents RadButFollow As System.Windows.Forms.RadioButton
    Friend WithEvents RadButExtInt As System.Windows.Forms.RadioButton
    Friend WithEvents RadButInitial As System.Windows.Forms.RadioButton
    Friend WithEvents BtnPrintNote As System.Windows.Forms.Button
    Friend WithEvents BtnViewNote As System.Windows.Forms.Button
    Friend WithEvents TabPageAdjust As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents LblPredictTr2 As System.Windows.Forms.Label
    Friend WithEvents LblPredictPk2 As System.Windows.Forms.Label
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents TxtUseInterval As System.Windows.Forms.TextBox
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents TxtUseDose As System.Windows.Forms.TextBox
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents LblNewInterval As System.Windows.Forms.Label
    Friend WithEvents LblNewDose As System.Windows.Forms.Label
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtDesTrough As System.Windows.Forms.TextBox
    Friend WithEvents TxtDesPeak As System.Windows.Forms.TextBox
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label89 As System.Windows.Forms.Label
    Friend WithEvents Label88 As System.Windows.Forms.Label
    Friend WithEvents TxtActualInterval As System.Windows.Forms.TextBox
    Friend WithEvents TxtActualDose As System.Windows.Forms.TextBox
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents LblActualT05 As System.Windows.Forms.Label
    Friend WithEvents LblActualVd As System.Windows.Forms.Label
    Friend WithEvents LblActualK As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents TxtActualTrTime As System.Windows.Forms.TextBox
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents TxtActualPkTime As System.Windows.Forms.TextBox
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents TxtActualInfTime As System.Windows.Forms.TextBox
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents TxtActualTrough As System.Windows.Forms.TextBox
    Friend WithEvents TxtActualPeak As System.Windows.Forms.TextBox
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents TabPageInit As System.Windows.Forms.TabPage
    Friend WithEvents GrpBoxExtInt As System.Windows.Forms.GroupBox
    Friend WithEvents LblExtIntInt As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents LblExtIntDose As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents LblPredictTr As System.Windows.Forms.Label
    Friend WithEvents LblPredictPk As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents TxtIntervalUse As System.Windows.Forms.TextBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents TxtDoseUse As System.Windows.Forms.TextBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents LblIntervalEst As System.Windows.Forms.Label
    Friend WithEvents LblDoseEst As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LblVdtoUse As System.Windows.Forms.Label
    Friend WithEvents LblKtoUse As System.Windows.Forms.Label
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents Label78 As System.Windows.Forms.Label
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents TxtDrawTrough As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents TxtDrawPeak As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents TxtInfusion As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents TxtTroughDes As System.Windows.Forms.TextBox
    Friend WithEvents TxtPeakDes As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabPageDemo As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents LblCrCl As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents LblBSA As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents LblCrClStd As System.Windows.Forms.Label
    Friend WithEvents LblIBW As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtABW As System.Windows.Forms.TextBox
    Friend WithEvents TxtHeight As System.Windows.Forms.TextBox
    Friend WithEvents TxtAge As System.Windows.Forms.TextBox
    Friend WithEvents TxtSCr As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadButFemale As System.Windows.Forms.RadioButton
    Friend WithEvents RadButMale As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GrpBoxCrCl As System.Windows.Forms.GroupBox
    Friend WithEvents RadButJelliffe As System.Windows.Forms.RadioButton
    Friend WithEvents RadButCCG As System.Windows.Forms.RadioButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents TxtCV As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CboXDrug As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LblEstVd As System.Windows.Forms.Label
    Friend WithEvents Label87 As System.Windows.Forms.Label
    Friend WithEvents Label86 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents LblEstT05 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents LblEstK As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
End Class
