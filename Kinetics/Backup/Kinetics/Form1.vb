Public Class FrmUserAgreement
    Dim ExpDate As String
    Dim CalcThis As New PharmCalc


    Private Sub CmdAgree_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAgree.Click
        If System.DateTime.Today > System.DateTime.Parse(ExpDate) Then
            MsgBox("This program has expired.  Please contact NightWatch at info@nightwatchrx.com for more information.", , "Expired program")
            Me.Close()
        Else
            My.Forms.FrmCalculator.Show()
        End If


    End Sub

    Private Sub CmdDisagree_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdDisagree.Click
        Me.Close()

    End Sub

    Private Sub FrmUserAgreement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ExpDate = "December 31, 2010"
        LblExpDate.Text = ExpDate
    End Sub

End Class
