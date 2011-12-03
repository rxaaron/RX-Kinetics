Public Class FrmCustomTheme
    Dim BG As Boolean
    Dim Main As Boolean
    Dim TXT As Boolean
    Dim ANS As Boolean
    Dim BUT As Boolean
    Dim bgc As Color
    Dim maic As Color
    Dim txtc As Color
    Dim ansc As Color
    Dim butc As Color


    Private Sub BtnBGround_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBGround.Click
        Dim CDR As DialogResult = CDMain.ShowDialog()
        If CDR = Windows.Forms.DialogResult.OK Then
            Panel1.BackColor = CDMain.Color
            bgc = CDMain.Color
            BG = True
        End If
    End Sub

    Private Sub BtnMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMain.Click
        Dim CDR As DialogResult = CDMain.ShowDialog()
        If CDR = Windows.Forms.DialogResult.OK Then
            TabPageDemo.BackColor = CDMain.Color
            maic = CDMain.Color
            Main = True
        End If
    End Sub

    Private Sub BtnText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnText.Click
        Dim CDR As DialogResult = CDMain.ShowDialog()
        If CDR = Windows.Forms.DialogResult.OK Then
            Panel1.ForeColor = CDMain.Color
            txtc = CDMain.Color
            TXT = True
        End If
    End Sub

    Private Sub BtnAnswers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAnswers.Click
        Dim CDR As DialogResult = CDMain.ShowDialog()
        If CDR = Windows.Forms.DialogResult.OK Then
            LblIBW.ForeColor = CDMain.Color
            LblBSA.ForeColor = CDMain.Color
            LblCrCl.ForeColor = CDMain.Color
            LblCrClStd.ForeColor = CDMain.Color
            LblEstK.ForeColor = CDMain.Color
            LblEstT05.ForeColor = CDMain.Color
            LblEstVd.ForeColor = CDMain.Color
            ansc = CDMain.Color
            ANS = True
        End If
    End Sub

    Private Sub BtnButtons_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnButtons.Click
        Dim CDR As DialogResult = CDMain.ShowDialog()
        If CDR = Windows.Forms.DialogResult.OK Then
            BtnGo.BackColor = CDMain.Color
            BtnUnGo.BackColor = CDMain.Color
            BtnOptions.BackColor = CDMain.Color
            CmdHide.BackColor = CDMain.Color
            CmdClose.BackColor = CDMain.Color
            butc = CDMain.Color
            BUT = True
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If BG = True Then
            My.Settings.BGround = bgc
        End If
        If Main = True Then
            My.Settings.Main = maic
        End If
        If TXT = True Then
            My.Settings.Text = txtc
        End If
        If ANS = True Then
            My.Settings.Answers = ansc
        End If
        If BUT = True Then
            My.Settings.Buttons = butc
        End If
        My.Forms.FrmCalculator.SetSettings()
        My.Forms.FrmOptions.Themerator()
        Me.Close()
    End Sub

    Private Sub FrmCustomTheme_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BG = False
        Main = False
        BUT = False
        ANS = False
        TXT = False
        BtnGo.BackColor = My.Settings.Buttons
        BtnUnGo.BackColor = My.Settings.Buttons
        BtnOptions.BackColor = My.Settings.Buttons
        CmdHide.BackColor = My.Settings.Buttons
        CmdClose.BackColor = My.Settings.Buttons
        LblIBW.ForeColor = My.Settings.Answers
        LblBSA.ForeColor = My.Settings.Answers
        LblCrCl.ForeColor = My.Settings.Answers
        LblCrClStd.ForeColor = My.Settings.Answers
        LblEstK.ForeColor = My.Settings.Answers
        LblEstT05.ForeColor = My.Settings.Answers
        LblEstVd.ForeColor = My.Settings.Answers
        Panel1.ForeColor = My.Settings.Text
        TabPageDemo.BackColor = My.Settings.Main
        Panel1.BackColor = My.Settings.BGround
    End Sub
End Class