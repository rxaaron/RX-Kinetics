<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNoteData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNoteData))
        Me.TxtDiagnosis = New System.Windows.Forms.TextBox
        Me.TxtInitials = New System.Windows.Forms.TextBox
        Me.LblFirstDose2 = New System.Windows.Forms.Label
        Me.LblTroughDraw2 = New System.Windows.Forms.Label
        Me.LblTroughDraw = New System.Windows.Forms.Label
        Me.LblPeakDraw2 = New System.Windows.Forms.Label
        Me.LblPeakDraw = New System.Windows.Forms.Label
        Me.LblFirstDose = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PbTrough = New System.Windows.Forms.PictureBox
        Me.PbPeak = New System.Windows.Forms.PictureBox
        Me.PbFirst = New System.Windows.Forms.PictureBox
        Me.PbAdmit = New System.Windows.Forms.PictureBox
        Me.LblRandom2 = New System.Windows.Forms.Label
        Me.LblRandom = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.TxtTmax = New System.Windows.Forms.TextBox
        Me.TxtWBCs = New System.Windows.Forms.TextBox
        Me.TxtBUN = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.LblNextDose = New System.Windows.Forms.Label
        Me.LblNextDose2 = New System.Windows.Forms.Label
        Me.TxtAdmitDate = New System.Windows.Forms.MaskedTextBox
        Me.TxtFirstDoseDate = New System.Windows.Forms.MaskedTextBox
        Me.TxtFirstDoseTime = New System.Windows.Forms.MaskedTextBox
        Me.TxtDatePeakDraw = New System.Windows.Forms.MaskedTextBox
        Me.TxtTimePeakDraw = New System.Windows.Forms.MaskedTextBox
        Me.TxtDateTroughDraw = New System.Windows.Forms.MaskedTextBox
        Me.TxtTimeTroughDraw = New System.Windows.Forms.MaskedTextBox
        Me.BtnHide = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.PbTrough, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbPeak, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbFirst, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbAdmit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtDiagnosis
        '
        Me.TxtDiagnosis.Location = New System.Drawing.Point(139, 69)
        Me.TxtDiagnosis.MaxLength = 25
        Me.TxtDiagnosis.Name = "TxtDiagnosis"
        Me.TxtDiagnosis.Size = New System.Drawing.Size(111, 20)
        Me.TxtDiagnosis.TabIndex = 3
        '
        'TxtInitials
        '
        Me.TxtInitials.Location = New System.Drawing.Point(139, 17)
        Me.TxtInitials.Name = "TxtInitials"
        Me.TxtInitials.Size = New System.Drawing.Size(111, 20)
        Me.TxtInitials.TabIndex = 1
        '
        'LblFirstDose2
        '
        Me.LblFirstDose2.AutoSize = True
        Me.LblFirstDose2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFirstDose2.Location = New System.Drawing.Point(8, 124)
        Me.LblFirstDose2.Name = "LblFirstDose2"
        Me.LblFirstDose2.Size = New System.Drawing.Size(114, 13)
        Me.LblFirstDose2.TabIndex = 8
        Me.LblFirstDose2.Text = "Time of First Dose:"
        '
        'LblTroughDraw2
        '
        Me.LblTroughDraw2.AutoSize = True
        Me.LblTroughDraw2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTroughDraw2.Location = New System.Drawing.Point(3, 228)
        Me.LblTroughDraw2.Name = "LblTroughDraw2"
        Me.LblTroughDraw2.Size = New System.Drawing.Size(130, 13)
        Me.LblTroughDraw2.TabIndex = 7
        Me.LblTroughDraw2.Text = "Time of Trough Draw:"
        '
        'LblTroughDraw
        '
        Me.LblTroughDraw.AutoSize = True
        Me.LblTroughDraw.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTroughDraw.Location = New System.Drawing.Point(3, 202)
        Me.LblTroughDraw.Name = "LblTroughDraw"
        Me.LblTroughDraw.Size = New System.Drawing.Size(130, 13)
        Me.LblTroughDraw.TabIndex = 6
        Me.LblTroughDraw.Text = "Date of Trough Draw:"
        '
        'LblPeakDraw2
        '
        Me.LblPeakDraw2.AutoSize = True
        Me.LblPeakDraw2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPeakDraw2.Location = New System.Drawing.Point(6, 176)
        Me.LblPeakDraw2.Name = "LblPeakDraw2"
        Me.LblPeakDraw2.Size = New System.Drawing.Size(119, 13)
        Me.LblPeakDraw2.TabIndex = 5
        Me.LblPeakDraw2.Text = "Time of Peak Draw:"
        '
        'LblPeakDraw
        '
        Me.LblPeakDraw.AutoSize = True
        Me.LblPeakDraw.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPeakDraw.Location = New System.Drawing.Point(8, 150)
        Me.LblPeakDraw.Name = "LblPeakDraw"
        Me.LblPeakDraw.Size = New System.Drawing.Size(119, 13)
        Me.LblPeakDraw.TabIndex = 4
        Me.LblPeakDraw.Text = "Date of Peak Draw:"
        '
        'LblFirstDose
        '
        Me.LblFirstDose.AutoSize = True
        Me.LblFirstDose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFirstDose.Location = New System.Drawing.Point(8, 98)
        Me.LblFirstDose.Name = "LblFirstDose"
        Me.LblFirstDose.Size = New System.Drawing.Size(114, 13)
        Me.LblFirstDose.TabIndex = 3
        Me.LblFirstDose.Text = "Date of First Dose:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Abx Diagnosis:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(7, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Date of Admission:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(17, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Patient Initials:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox1.Controls.Add(Me.PbTrough)
        Me.GroupBox1.Controls.Add(Me.PbPeak)
        Me.GroupBox1.Controls.Add(Me.PbFirst)
        Me.GroupBox1.Controls.Add(Me.PbAdmit)
        Me.GroupBox1.Controls.Add(Me.LblRandom2)
        Me.GroupBox1.Controls.Add(Me.LblRandom)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.TxtTmax)
        Me.GroupBox1.Controls.Add(Me.TxtWBCs)
        Me.GroupBox1.Controls.Add(Me.TxtBUN)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TxtDiagnosis)
        Me.GroupBox1.Controls.Add(Me.TxtInitials)
        Me.GroupBox1.Controls.Add(Me.LblFirstDose2)
        Me.GroupBox1.Controls.Add(Me.LblTroughDraw2)
        Me.GroupBox1.Controls.Add(Me.LblTroughDraw)
        Me.GroupBox1.Controls.Add(Me.LblPeakDraw2)
        Me.GroupBox1.Controls.Add(Me.LblPeakDraw)
        Me.GroupBox1.Controls.Add(Me.LblFirstDose)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.LblNextDose)
        Me.GroupBox1.Controls.Add(Me.LblNextDose2)
        Me.GroupBox1.Controls.Add(Me.TxtAdmitDate)
        Me.GroupBox1.Controls.Add(Me.TxtFirstDoseDate)
        Me.GroupBox1.Controls.Add(Me.TxtFirstDoseTime)
        Me.GroupBox1.Controls.Add(Me.TxtDatePeakDraw)
        Me.GroupBox1.Controls.Add(Me.TxtTimePeakDraw)
        Me.GroupBox1.Controls.Add(Me.TxtDateTroughDraw)
        Me.GroupBox1.Controls.Add(Me.TxtTimeTroughDraw)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(258, 332)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Patient Note Data"
        '
        'PbTrough
        '
        Me.PbTrough.Image = Global.NWKinetics.My.Resources.Resources.calendar2
        Me.PbTrough.Location = New System.Drawing.Point(239, 205)
        Me.PbTrough.Name = "PbTrough"
        Me.PbTrough.Size = New System.Drawing.Size(11, 10)
        Me.PbTrough.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PbTrough.TabIndex = 31
        Me.PbTrough.TabStop = False
        '
        'PbPeak
        '
        Me.PbPeak.Image = Global.NWKinetics.My.Resources.Resources.calendar2
        Me.PbPeak.Location = New System.Drawing.Point(239, 153)
        Me.PbPeak.Name = "PbPeak"
        Me.PbPeak.Size = New System.Drawing.Size(11, 10)
        Me.PbPeak.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PbPeak.TabIndex = 30
        Me.PbPeak.TabStop = False
        '
        'PbFirst
        '
        Me.PbFirst.Image = Global.NWKinetics.My.Resources.Resources.calendar2
        Me.PbFirst.Location = New System.Drawing.Point(239, 101)
        Me.PbFirst.Name = "PbFirst"
        Me.PbFirst.Size = New System.Drawing.Size(11, 10)
        Me.PbFirst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PbFirst.TabIndex = 29
        Me.PbFirst.TabStop = False
        '
        'PbAdmit
        '
        Me.PbAdmit.Image = Global.NWKinetics.My.Resources.Resources.calendar2
        Me.PbAdmit.Location = New System.Drawing.Point(239, 49)
        Me.PbAdmit.Name = "PbAdmit"
        Me.PbAdmit.Size = New System.Drawing.Size(11, 10)
        Me.PbAdmit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PbAdmit.TabIndex = 28
        Me.PbAdmit.TabStop = False
        '
        'LblRandom2
        '
        Me.LblRandom2.AutoSize = True
        Me.LblRandom2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRandom2.Location = New System.Drawing.Point(0, 228)
        Me.LblRandom2.Name = "LblRandom2"
        Me.LblRandom2.Size = New System.Drawing.Size(136, 13)
        Me.LblRandom2.TabIndex = 25
        Me.LblRandom2.Text = "Time of Random Draw:"
        Me.LblRandom2.Visible = False
        '
        'LblRandom
        '
        Me.LblRandom.AutoSize = True
        Me.LblRandom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRandom.Location = New System.Drawing.Point(0, 202)
        Me.LblRandom.Name = "LblRandom"
        Me.LblRandom.Size = New System.Drawing.Size(136, 13)
        Me.LblRandom.TabIndex = 24
        Me.LblRandom.Text = "Date of Random Draw:"
        Me.LblRandom.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(21, 306)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 13)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Recent Tmax:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(40, 280)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "WBCs:"
        '
        'TxtTmax
        '
        Me.TxtTmax.Location = New System.Drawing.Point(139, 303)
        Me.TxtTmax.Name = "TxtTmax"
        Me.TxtTmax.Size = New System.Drawing.Size(111, 20)
        Me.TxtTmax.TabIndex = 12
        '
        'TxtWBCs
        '
        Me.TxtWBCs.Location = New System.Drawing.Point(139, 277)
        Me.TxtWBCs.Name = "TxtWBCs"
        Me.TxtWBCs.Size = New System.Drawing.Size(111, 20)
        Me.TxtWBCs.TabIndex = 11
        '
        'TxtBUN
        '
        Me.TxtBUN.Location = New System.Drawing.Point(139, 251)
        Me.TxtBUN.Name = "TxtBUN"
        Me.TxtBUN.Size = New System.Drawing.Size(111, 20)
        Me.TxtBUN.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(22, 254)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Serum BUN:"
        '
        'LblNextDose
        '
        Me.LblNextDose.AutoSize = True
        Me.LblNextDose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNextDose.Location = New System.Drawing.Point(8, 98)
        Me.LblNextDose.Name = "LblNextDose"
        Me.LblNextDose.Size = New System.Drawing.Size(116, 13)
        Me.LblNextDose.TabIndex = 26
        Me.LblNextDose.Text = "Date of Next Dose:"
        Me.LblNextDose.Visible = False
        '
        'LblNextDose2
        '
        Me.LblNextDose2.AutoSize = True
        Me.LblNextDose2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNextDose2.Location = New System.Drawing.Point(8, 124)
        Me.LblNextDose2.Name = "LblNextDose2"
        Me.LblNextDose2.Size = New System.Drawing.Size(116, 13)
        Me.LblNextDose2.TabIndex = 27
        Me.LblNextDose2.Text = "Time of Next Dose:"
        Me.LblNextDose2.Visible = False
        '
        'TxtAdmitDate
        '
        Me.TxtAdmitDate.Location = New System.Drawing.Point(139, 43)
        Me.TxtAdmitDate.Mask = "00/00/0000"
        Me.TxtAdmitDate.Name = "TxtAdmitDate"
        Me.TxtAdmitDate.Size = New System.Drawing.Size(94, 20)
        Me.TxtAdmitDate.TabIndex = 2
        Me.TxtAdmitDate.ValidatingType = GetType(Date)
        '
        'TxtFirstDoseDate
        '
        Me.TxtFirstDoseDate.Location = New System.Drawing.Point(139, 95)
        Me.TxtFirstDoseDate.Mask = "00/00/0000"
        Me.TxtFirstDoseDate.Name = "TxtFirstDoseDate"
        Me.TxtFirstDoseDate.Size = New System.Drawing.Size(94, 20)
        Me.TxtFirstDoseDate.TabIndex = 4
        Me.TxtFirstDoseDate.ValidatingType = GetType(Date)
        '
        'TxtFirstDoseTime
        '
        Me.TxtFirstDoseTime.Location = New System.Drawing.Point(139, 121)
        Me.TxtFirstDoseTime.Mask = "00:00"
        Me.TxtFirstDoseTime.Name = "TxtFirstDoseTime"
        Me.TxtFirstDoseTime.Size = New System.Drawing.Size(111, 20)
        Me.TxtFirstDoseTime.TabIndex = 5
        Me.TxtFirstDoseTime.ValidatingType = GetType(Date)
        '
        'TxtDatePeakDraw
        '
        Me.TxtDatePeakDraw.Location = New System.Drawing.Point(139, 147)
        Me.TxtDatePeakDraw.Mask = "00/00/0000"
        Me.TxtDatePeakDraw.Name = "TxtDatePeakDraw"
        Me.TxtDatePeakDraw.Size = New System.Drawing.Size(94, 20)
        Me.TxtDatePeakDraw.TabIndex = 6
        Me.TxtDatePeakDraw.ValidatingType = GetType(Date)
        '
        'TxtTimePeakDraw
        '
        Me.TxtTimePeakDraw.Location = New System.Drawing.Point(139, 173)
        Me.TxtTimePeakDraw.Mask = "00:00"
        Me.TxtTimePeakDraw.Name = "TxtTimePeakDraw"
        Me.TxtTimePeakDraw.Size = New System.Drawing.Size(111, 20)
        Me.TxtTimePeakDraw.TabIndex = 7
        Me.TxtTimePeakDraw.ValidatingType = GetType(Date)
        '
        'TxtDateTroughDraw
        '
        Me.TxtDateTroughDraw.Location = New System.Drawing.Point(139, 199)
        Me.TxtDateTroughDraw.Mask = "00/00/0000"
        Me.TxtDateTroughDraw.Name = "TxtDateTroughDraw"
        Me.TxtDateTroughDraw.Size = New System.Drawing.Size(94, 20)
        Me.TxtDateTroughDraw.TabIndex = 8
        Me.TxtDateTroughDraw.ValidatingType = GetType(Date)
        '
        'TxtTimeTroughDraw
        '
        Me.TxtTimeTroughDraw.Location = New System.Drawing.Point(139, 225)
        Me.TxtTimeTroughDraw.Mask = "00:00"
        Me.TxtTimeTroughDraw.Name = "TxtTimeTroughDraw"
        Me.TxtTimeTroughDraw.Size = New System.Drawing.Size(111, 20)
        Me.TxtTimeTroughDraw.TabIndex = 9
        Me.TxtTimeTroughDraw.ValidatingType = GetType(Date)
        '
        'BtnHide
        '
        Me.BtnHide.Location = New System.Drawing.Point(4, 340)
        Me.BtnHide.Name = "BtnHide"
        Me.BtnHide.Size = New System.Drawing.Size(258, 23)
        Me.BtnHide.TabIndex = 13
        Me.BtnHide.Text = "Generate Note"
        Me.BtnHide.UseVisualStyleBackColor = True
        '
        'FrmNoteData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GrayText
        Me.ClientSize = New System.Drawing.Size(266, 371)
        Me.Controls.Add(Me.BtnHide)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmNoteData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PK Note Data"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PbTrough, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbPeak, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbFirst, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbAdmit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxtDiagnosis As System.Windows.Forms.TextBox
    Friend WithEvents TxtInitials As System.Windows.Forms.TextBox
    Friend WithEvents LblFirstDose2 As System.Windows.Forms.Label
    Friend WithEvents LblTroughDraw2 As System.Windows.Forms.Label
    Friend WithEvents LblTroughDraw As System.Windows.Forms.Label
    Friend WithEvents LblPeakDraw2 As System.Windows.Forms.Label
    Friend WithEvents LblPeakDraw As System.Windows.Forms.Label
    Friend WithEvents LblFirstDose As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtTmax As System.Windows.Forms.TextBox
    Friend WithEvents TxtWBCs As System.Windows.Forms.TextBox
    Friend WithEvents TxtBUN As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents BtnHide As System.Windows.Forms.Button
    Friend WithEvents LblRandom2 As System.Windows.Forms.Label
    Friend WithEvents LblRandom As System.Windows.Forms.Label
    Friend WithEvents LblNextDose2 As System.Windows.Forms.Label
    Friend WithEvents LblNextDose As System.Windows.Forms.Label
    Friend WithEvents TxtAdmitDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TxtFirstDoseDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TxtFirstDoseTime As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TxtDatePeakDraw As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TxtTimePeakDraw As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TxtDateTroughDraw As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TxtTimeTroughDraw As System.Windows.Forms.MaskedTextBox
    Friend WithEvents PbAdmit As System.Windows.Forms.PictureBox
    Friend WithEvents PbTrough As System.Windows.Forms.PictureBox
    Friend WithEvents PbPeak As System.Windows.Forms.PictureBox
    Friend WithEvents PbFirst As System.Windows.Forms.PictureBox
End Class
