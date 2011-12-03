Public Class FrmDatePicker
    Private Sub MC1_DateSelected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MC1.DateSelected
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub FrmDatePicker_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MC1.SelectionStart = MC1.TodayDate
        MC1.SelectionEnd = MC1.TodayDate
    End Sub
End Class