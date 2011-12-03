<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUserAgreement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUserAgreement))
        Me.PicBoxNW = New System.Windows.Forms.PictureBox
        Me.LblKinetics1 = New System.Windows.Forms.Label
        Me.LblLegal1 = New System.Windows.Forms.Label
        Me.LblLegal2 = New System.Windows.Forms.Label
        Me.LblLegal3 = New System.Windows.Forms.Label
        Me.LblLegal4 = New System.Windows.Forms.Label
        Me.LblLegal5 = New System.Windows.Forms.Label
        Me.LblDevelopment = New System.Windows.Forms.Label
        Me.CmdAgree = New System.Windows.Forms.Button
        Me.CmdDisagree = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.LblExpDate = New System.Windows.Forms.Label
        CType(Me.PicBoxNW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicBoxNW
        '
        Me.PicBoxNW.Image = Global.NWKinetics.My.Resources.Resources.nightwatch
        Me.PicBoxNW.Location = New System.Drawing.Point(112, 67)
        Me.PicBoxNW.Name = "PicBoxNW"
        Me.PicBoxNW.Size = New System.Drawing.Size(219, 172)
        Me.PicBoxNW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBoxNW.TabIndex = 0
        Me.PicBoxNW.TabStop = False
        '
        'LblKinetics1
        '
        Me.LblKinetics1.AutoSize = True
        Me.LblKinetics1.Font = New System.Drawing.Font("Calisto MT", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblKinetics1.ForeColor = System.Drawing.Color.White
        Me.LblKinetics1.Location = New System.Drawing.Point(25, 9)
        Me.LblKinetics1.Name = "LblKinetics1"
        Me.LblKinetics1.Size = New System.Drawing.Size(415, 55)
        Me.LblKinetics1.TabIndex = 1
        Me.LblKinetics1.Text = "Kinetics Calculator"
        '
        'LblLegal1
        '
        Me.LblLegal1.AutoSize = True
        Me.LblLegal1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLegal1.ForeColor = System.Drawing.Color.White
        Me.LblLegal1.Location = New System.Drawing.Point(34, 291)
        Me.LblLegal1.Name = "LblLegal1"
        Me.LblLegal1.Size = New System.Drawing.Size(366, 13)
        Me.LblLegal1.TabIndex = 2
        Me.LblLegal1.Text = "This calculator is for verification purposes only.  It is not meant to replace th" & _
            "e"
        '
        'LblLegal2
        '
        Me.LblLegal2.AutoSize = True
        Me.LblLegal2.ForeColor = System.Drawing.Color.White
        Me.LblLegal2.Location = New System.Drawing.Point(34, 304)
        Me.LblLegal2.Name = "LblLegal2"
        Me.LblLegal2.Size = New System.Drawing.Size(382, 13)
        Me.LblLegal2.TabIndex = 3
        Me.LblLegal2.Text = "professional judgment of a Licensed Pharmacist.  Always check reported values"
        '
        'LblLegal3
        '
        Me.LblLegal3.AutoSize = True
        Me.LblLegal3.ForeColor = System.Drawing.Color.White
        Me.LblLegal3.Location = New System.Drawing.Point(34, 317)
        Me.LblLegal3.Name = "LblLegal3"
        Me.LblLegal3.Size = New System.Drawing.Size(168, 13)
        Me.LblLegal3.TabIndex = 4
        Me.LblLegal3.Text = "and monitor patients appropriately."
        '
        'LblLegal4
        '
        Me.LblLegal4.AutoSize = True
        Me.LblLegal4.ForeColor = System.Drawing.Color.White
        Me.LblLegal4.Location = New System.Drawing.Point(34, 340)
        Me.LblLegal4.Name = "LblLegal4"
        Me.LblLegal4.Size = New System.Drawing.Size(383, 13)
        Me.LblLegal4.TabIndex = 5
        Me.LblLegal4.Text = "This calculator can not be redistributed without the expressed written consent of" & _
            ""
        '
        'LblLegal5
        '
        Me.LblLegal5.AutoSize = True
        Me.LblLegal5.ForeColor = System.Drawing.Color.White
        Me.LblLegal5.Location = New System.Drawing.Point(34, 353)
        Me.LblLegal5.Name = "LblLegal5"
        Me.LblLegal5.Size = New System.Drawing.Size(392, 13)
        Me.LblLegal5.TabIndex = 6
        Me.LblLegal5.Text = "Colony Consulting, Inc. and Night Watch Pharmacy Services Development Team."
        '
        'LblDevelopment
        '
        Me.LblDevelopment.AutoSize = True
        Me.LblDevelopment.Font = New System.Drawing.Font("Rage Italic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDevelopment.ForeColor = System.Drawing.Color.White
        Me.LblDevelopment.Location = New System.Drawing.Point(123, 232)
        Me.LblDevelopment.Name = "LblDevelopment"
        Me.LblDevelopment.Size = New System.Drawing.Size(196, 34)
        Me.LblDevelopment.TabIndex = 7
        Me.LblDevelopment.Text = "Development Team"
        '
        'CmdAgree
        '
        Me.CmdAgree.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdAgree.Location = New System.Drawing.Point(38, 385)
        Me.CmdAgree.Name = "CmdAgree"
        Me.CmdAgree.Size = New System.Drawing.Size(191, 42)
        Me.CmdAgree.TabIndex = 8
        Me.CmdAgree.Text = "Agree"
        Me.CmdAgree.UseVisualStyleBackColor = True
        '
        'CmdDisagree
        '
        Me.CmdDisagree.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdDisagree.Location = New System.Drawing.Point(240, 384)
        Me.CmdDisagree.Name = "CmdDisagree"
        Me.CmdDisagree.Size = New System.Drawing.Size(175, 42)
        Me.CmdDisagree.TabIndex = 9
        Me.CmdDisagree.Text = "Disagree"
        Me.CmdDisagree.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(90, 442)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "This program will expire after"
        '
        'LblExpDate
        '
        Me.LblExpDate.AutoSize = True
        Me.LblExpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblExpDate.ForeColor = System.Drawing.Color.White
        Me.LblExpDate.Location = New System.Drawing.Point(274, 439)
        Me.LblExpDate.Name = "LblExpDate"
        Me.LblExpDate.Size = New System.Drawing.Size(57, 20)
        Me.LblExpDate.TabIndex = 11
        Me.LblExpDate.Text = "Label2"
        '
        'FrmUserAgreement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(452, 475)
        Me.Controls.Add(Me.LblExpDate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmdDisagree)
        Me.Controls.Add(Me.CmdAgree)
        Me.Controls.Add(Me.LblDevelopment)
        Me.Controls.Add(Me.LblLegal5)
        Me.Controls.Add(Me.LblLegal4)
        Me.Controls.Add(Me.LblLegal3)
        Me.Controls.Add(Me.LblLegal2)
        Me.Controls.Add(Me.LblLegal1)
        Me.Controls.Add(Me.LblKinetics1)
        Me.Controls.Add(Me.PicBoxNW)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmUserAgreement"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Agreement"
        Me.TopMost = True
        CType(Me.PicBoxNW, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PicBoxNW As System.Windows.Forms.PictureBox
    Friend WithEvents LblKinetics1 As System.Windows.Forms.Label
    Friend WithEvents LblLegal1 As System.Windows.Forms.Label
    Friend WithEvents LblLegal2 As System.Windows.Forms.Label
    Friend WithEvents LblLegal3 As System.Windows.Forms.Label
    Friend WithEvents LblLegal4 As System.Windows.Forms.Label
    Friend WithEvents LblLegal5 As System.Windows.Forms.Label
    Friend WithEvents LblDevelopment As System.Windows.Forms.Label
    Friend WithEvents CmdAgree As System.Windows.Forms.Button
    Friend WithEvents CmdDisagree As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblExpDate As System.Windows.Forms.Label

End Class
