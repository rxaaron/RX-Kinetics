Public Class FrmOptions
    Dim Theme As Integer
    Dim Helper As Integer


    Private Sub FrmOptions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Helper = 0
        ChkTop.Checked = My.Forms.FrmCalculator.AOT
        ChkTB.Checked = My.Forms.FrmCalculator.SIT
        ChkNA.Checked = My.Forms.FrmCalculator.SNI
        If My.Settings.MyTheme = 1 Then
            CboxTheme.Text = "NightWatch (default)"
        ElseIf My.Settings.MyTheme = 2 Then
            CboxTheme.Text = "Dark"
        ElseIf My.Settings.MyTheme = 3 Then
            CboxTheme.Text = "Mountaineer"
        ElseIf My.Settings.MyTheme = 4 Then
            CboxTheme.Text = "Custom..."
        End If
        TxtVInf.Text = My.Forms.FrmCalculator.VInf.ToString
        TxtVPDraw.Text = My.Forms.FrmCalculator.VPDraw.ToString
        TxtVTDraw.Text = My.Forms.FrmCalculator.VTDraw.ToString
        TxtVCV.Text = My.Forms.FrmCalculator.VCV.ToString
        TxtVP1.Text = My.Forms.FrmCalculator.VP1.ToString
        TxtVP2.Text = My.Forms.FrmCalculator.VP2.ToString
        TxtVT1.Text = My.Forms.FrmCalculator.VT1.ToString
        TxtVT2.Text = My.Forms.FrmCalculator.VT2.ToString
        TxtGInf.Text = My.Forms.FrmCalculator.GInf.ToString
        TxtGPDraw.Text = My.Forms.FrmCalculator.GPDraw.ToString
        TxtGTDraw.Text = My.Forms.FrmCalculator.GTDraw.ToString
        TxtGCV.Text = My.Forms.FrmCalculator.GCV.ToString
        TxtGP1.Text = My.Forms.FrmCalculator.GP1.ToString
        TxtGP2.Text = My.Forms.FrmCalculator.GP2.ToString
        TxtGT1.Text = My.Forms.FrmCalculator.GT1.ToString
        TxtGT2.Text = My.Forms.FrmCalculator.GT2.ToString
        TxtTInf.Text = My.Forms.FrmCalculator.TInf.ToString
        TxtTPDraw.Text = My.Forms.FrmCalculator.TPDraw.ToString
        TxtTTDraw.Text = My.Forms.FrmCalculator.TTDraw.ToString
        TxtTCV.Text = My.Forms.FrmCalculator.TCV.ToString
        TxtTP1.Text = My.Forms.FrmCalculator.TP1.ToString
        TxtTP2.Text = My.Forms.FrmCalculator.TP2.ToString
        TxtTT1.Text = My.Forms.FrmCalculator.TT1.ToString
        TxtTT2.Text = My.Forms.FrmCalculator.TT2.ToString
        TxtExtDose.Text = My.Forms.FrmCalculator.ExtInt.ToString
        TxtQ241.Text = My.Forms.FrmCalculator.Q241.ToString
        TxtQ242.Text = My.Forms.FrmCalculator.Q242.ToString
        TxtQ361.Text = My.Forms.FrmCalculator.Q361.ToString
        TxtQ362.Text = My.Forms.FrmCalculator.Q362.ToString
        TxtQ481.Text = My.Forms.FrmCalculator.Q481.ToString
        TxtQ482.Text = My.Forms.FrmCalculator.Q482.ToString
        Themerator()

    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOK.Click
        DetermineTheme()
        Themerator()
        My.Settings.MyTheme = Theme
        My.Settings.AlwaysOT = ChkTop.Checked
        My.Settings.ShowInTB = ChkTB.Checked
        My.Settings.ShowInNA = ChkNA.Checked
        My.Settings.VancInfuse = Val(TxtVInf.Text)
        My.Settings.VancPeakTime = Val(TxtVPDraw.Text)
        My.Settings.VancTroughTime = Val(TxtVTDraw.Text)
        My.Settings.VancCV = Val(TxtVCV.Text)
        My.Settings.VancP1 = Val(TxtVP1.Text)
        My.Settings.VancP2 = Val(TxtVP2.Text)
        My.Settings.VancT1 = Val(TxtVT1.Text)
        My.Settings.VancT2 = Val(TxtVT2.Text)
        My.Settings.TobInfuse = Val(TxtTInf.Text)
        My.Settings.TobPeakTime = Val(TxtTPDraw.Text)
        My.Settings.TobTroughTime = Val(TxtTTDraw.Text)
        My.Settings.TobCV = Val(TxtTCV.Text)
        My.Settings.TobP1 = Val(TxtTP1.Text)
        My.Settings.TobP2 = Val(TxtTP2.Text)
        My.Settings.TobT1 = Val(TxtTT1.Text)
        My.Settings.TobT2 = Val(TxtTT2.Text)
        My.Settings.GentInfuse = Val(TxtGInf.Text)
        My.Settings.GentPeakTime = Val(TxtGPDraw.Text)
        My.Settings.GentTroughTime = Val(TxtGTDraw.Text)
        My.Settings.GentCV = Val(TxtGCV.Text)
        My.Settings.GentP1 = Val(TxtGP1.Text)
        My.Settings.GentP2 = Val(TxtGP2.Text)
        My.Settings.GentT1 = Val(TxtGT1.Text)
        My.Settings.GentT2 = Val(TxtGT2.Text)
        My.Settings.ExtIntDose = Val(TxtExtDose.Text)
        My.Settings.Q241 = Val(TxtQ241.Text)
        My.Settings.Q242 = Val(TxtQ242.Text)
        My.Settings.Q361 = Val(TxtQ361.Text)
        My.Settings.Q362 = Val(TxtQ362.Text)
        My.Settings.Q481 = Val(TxtQ481.Text)
        My.Settings.Q482 = Val(TxtQ482.Text)
        My.Forms.FrmCalculator.SetSettings()
        Me.Close()
    End Sub

    Private Sub RestorePref()
        ChkTop.Checked = False
        ChkTB.Checked = True
        ChkNA.Checked = True
        CboxTheme.Text = "NightWatch (default)"
    End Sub

    Private Sub RestoreVanc()
        TxtVInf.Text = 1
        TxtVPDraw.Text = 3
        TxtVTDraw.Text = 0.5
        TxtVCV.Text = 0.7
        TxtVP1.Text = 20
        TxtVP2.Text = 40
        TxtVT1.Text = 5
        TxtVT2.Text = 20
    End Sub

    Private Sub RestoreGent()
        TxtGInf.Text = 0.5
        TxtGPDraw.Text = 1
        TxtGTDraw.Text = 0.5
        TxtGCV.Text = 0.25
        TxtGP1.Text = 4
        TxtGP2.Text = 10
        TxtGT1.Text = 0
        TxtGT2.Text = 2
    End Sub

    Private Sub RestoreTob()
        TxtTInf.Text = 0.5
        TxtTPDraw.Text = 1
        TxtTTDraw.Text = 0.5
        TxtTCV.Text = 0.25
        TxtTP1.Text = 4
        TxtTP2.Text = 10
        TxtTT1.Text = 0
        TxtTT2.Text = 2
    End Sub

    Private Sub RestoreExtInt()
        TxtExtDose.Text = 7
        TxtQ241.Text = 61
        TxtQ242.Text = 120
        TxtQ361.Text = 40
        TxtQ362.Text = 60
        TxtQ481.Text = 30
        TxtQ482.Text = 39
    End Sub

    Private Sub BtnRestorePref_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRestorePref.Click
        RestorePref()
    End Sub

    Private Sub BtnRestoreVanc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRestoreVanc.Click
        RestoreVanc()
    End Sub

    Private Sub BtnRestoreTob_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRestoreTob.Click
        RestoreTob()
    End Sub

    Private Sub BtnRestoreGent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRestoreGent.Click
        RestoreGent()
    End Sub

    Private Sub BtnRestoreAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRestoreAll.Click
        RestorePref()
        RestoreVanc()
        RestoreTob()
        RestoreGent()
        RestoreExtInt()
    End Sub

    Public Sub Themerator()
        Me.ForeColor = My.Forms.FrmCalculator.TextColor
        Me.BackColor = My.Forms.FrmCalculator.Main
        Me.Panel1.BackColor = My.Forms.FrmCalculator.BGround
        BtnRestoreGent.BackColor = My.Forms.FrmCalculator.Buttons
        BtnRestoreVanc.BackColor = My.Forms.FrmCalculator.Buttons
        BtnRestoreTob.BackColor = My.Forms.FrmCalculator.Buttons
        BtnRestoreAll.BackColor = My.Forms.FrmCalculator.Buttons
        BtnOK.BackColor = My.Forms.FrmCalculator.Buttons
        BtnCancel.BackColor = My.Forms.FrmCalculator.Buttons
        BtnRestorePref.BackColor = My.Forms.FrmCalculator.Buttons
        BtnHuh.BackColor = My.Forms.FrmCalculator.Buttons

    End Sub

    Private Sub DetermineTheme()
        If CboxTheme.Text = "NightWatch (default)" Then
            Theme = 1
            My.Settings.BGround = Color.DarkGray
            My.Settings.Main = Color.Gainsboro
            My.Settings.Buttons = Color.SeaShell
            My.Settings.Text = Color.Black
            My.Settings.Answers = Color.Red
        ElseIf CboxTheme.Text = "Dark" Then
            Theme = 2
            My.Settings.BGround = Color.Black
            My.Settings.Main = Color.Black
            My.Settings.Buttons = Color.Gray
            My.Settings.Text = Color.WhiteSmoke
            My.Settings.Answers = Color.Red
        ElseIf CboxTheme.Text = "Mountaineer" Then
            Theme = 3
            My.Settings.BGround = Color.MidnightBlue
            My.Settings.Main = Color.Gold
            My.Settings.Buttons = Color.SeaShell
            My.Settings.Text = Color.Blue
            My.Settings.Answers = Color.Red
        ElseIf CboxTheme.Text = "Custom..." Then
            Theme = 4
        End If
    End Sub

    Private Sub BtnHuh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHuh.Click
        If Helper = 0 Then
            Me.Cursor = Cursors.Help
            ToolTipOptions.Active = True
            Helper = 1
        ElseIf Helper = 1 Then
            Me.Cursor = Cursors.Default
            ToolTipOptions.Active = False
            Helper = 0
        End If

    End Sub

    Private Sub CboxTheme_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboxTheme.SelectedIndexChanged
        If CboxTheme.Text = "NightWatch (default)" Then
            Theme = 1
        ElseIf CboxTheme.Text = "Dark" Then
            Theme = 2
        ElseIf CboxTheme.Text = "Mountaineer" Then
            Theme = 3
        ElseIf CboxTheme.Text = "Custom..." Then
            Theme = 4
            My.Forms.FrmCustomTheme.ShowDialog()
        End If
    End Sub

    Private Sub BtnRestoreExtInt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRestoreExtInt.Click
        RestoreExtInt()
    End Sub
End Class