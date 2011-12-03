Public Class FrmNoteData
    Dim KineticCalc As New PharmCalc
    Public Initials As String
    Public AdmitDate As String
    Public Diagnosis As String
    Public FirstDoseDate As String
    Public FirstDoseTime As String
    Public DatePeakDraw As String
    Public TimePeakDraw As String
    Public DateTroughDraw As String
    Public TimeTroughDraw As String
    Public BUN As String
    Public WBCs As String
    Public Tmax As String
    Public HasBeenGenerated As Integer
    Public Opened As Integer


    Private Sub BtnHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHide.Click
        Initials = Me.TxtInitials.Text
        AdmitDate = Me.TxtAdmitDate.Text
        Diagnosis = Me.TxtDiagnosis.Text
        FirstDoseDate = Me.TxtFirstDoseDate.Text
        FirstDoseTime = Me.TxtFirstDoseTime.Text
        DatePeakDraw = Me.TxtDatePeakDraw.Text
        TimePeakDraw = Me.TxtTimePeakDraw.Text
        DateTroughDraw = Me.TxtDateTroughDraw.Text
        TimeTroughDraw = Me.TxtTimeTroughDraw.Text
        BUN = Me.TxtBUN.Text
        WBCs = Me.TxtWBCs.Text
        Tmax = Me.TxtTmax.Text
        GenerateNote()
        Me.Visible = False
    End Sub

    Private Sub GenerateNote()

        HasBeenGenerated = 1
        My.Forms.FrmCalculator.NeedsRegenerated = 0

        If My.Forms.FrmCalculator.NoteType = 1 Then
            GenerateInitial()
        ElseIf My.Forms.FrmCalculator.NoteType = 2 Then
            GenerateExtInt()
        ElseIf My.Forms.FrmCalculator.NoteType = 3 Then
            GenerateFollowUp()
        ElseIf My.Forms.FrmCalculator.NoteType = 0 Then
            My.Forms.FrmCalculator.RTBoxText = "Please select Note Type before Entering Patient Data."
        End If

        My.Forms.FrmCalculator.RichTextBox1.Text = My.Forms.FrmCalculator.RTBoxText

    End Sub

    Private Sub GenerateInitial()
        My.Forms.FrmCalculator.RTBoxText = "Pharmacokinetics Consult Note" & Chr(13) & Chr(13) & _
        Initials & " is a " & My.Forms.FrmCalculator.Age & " year old " & My.Forms.FrmCalculator.GenderString & _
        " admitted on " & AdmitDate & ".  Pharmacy was consulted for dosing of " & My.Forms.FrmCalculator.CboXDrug.Text & _
        " for " & Diagnosis & "." & Chr(13) & Chr(13) & "Patient Demographics:  ABW: " & My.Forms.FrmCalculator.ABW & _
        " kg; Height: " & My.Forms.FrmCalculator.PtHeight & " in; IBW: " & My.Forms.FrmCalculator.IBW & " kg; SCr: " & _
        Format(My.Forms.FrmCalculator.SCr, "0.0") & " mg/dL; CrCl: " & Format(My.Forms.FrmCalculator.CrCl, "0.0") & " ml/min; CrCl Std: " & _
        Format(My.Forms.FrmCalculator.CrClStd, "0.0") & " ml/min/1.73m sq; BUN: " & BUN & " mg/dL; WBCs: " & WBCs & "; Recent Tmax: " & _
        Tmax & "." & Chr(13) & Chr(13) & "Estimated Kinetic Paramaters:  k: " & Format(My.Forms.FrmCalculator.EstK, "0.000") _
        & " 1/hr; Vd: " & Format(My.Forms.FrmCalculator.EstVd, "0.0") & " L; T 1/2: " & Format(My.Forms.FrmCalculator.EstT05, "0") & " h." & _
        Chr(13) & Chr(13) & "Recommend " & My.Forms.FrmCalculator.CboXDrug.Text & " dose of " & My.Forms.FrmCalculator.DoseToUse & _
        " mg every " & My.Forms.FrmCalculator.IntervalToUse & " hours, with a predicted Peak of " & Format(My.Forms.FrmCalculator.PredictPk, "0.0") & _
        " and a predicted Trough of " & Format(My.Forms.FrmCalculator.PredictTr, "0.0") & ".  First dose to be given on " & FirstDoseDate & _
        " at " & FirstDoseTime & ".  Peak should be drawn on " & DatePeakDraw & " at " & TimePeakDraw & " and trough should be drawn on " _
        & DateTroughDraw & " at " & TimeTroughDraw & ".  Pharmacy will continue to follow."

        My.Forms.FrmCalculator.PKline1 = Initials & " is a " & My.Forms.FrmCalculator.Age & " year old " & My.Forms.FrmCalculator.GenderString & _
               " admitted on " & AdmitDate & ".  Pharmacy was consulted for dosing of"
        My.Forms.FrmCalculator.PKline2 = My.Forms.FrmCalculator.CboXDrug.Text & " for " & Diagnosis & "."
        My.Forms.FrmCalculator.PKline3 = "Patient Demographics:  ABW: " & My.Forms.FrmCalculator.ABW & " kg; Height: " & My.Forms.FrmCalculator.PtHeight & " in; IBW: " & My.Forms.FrmCalculator.IBW & " kg; SCr: " & _
        Format(My.Forms.FrmCalculator.SCr, "0.0") & " mg/dL; CrCl: " & Format(My.Forms.FrmCalculator.CrCl, "0.0")
        My.Forms.FrmCalculator.PKline4 = "ml/min; CrCl Std: " & Format(My.Forms.FrmCalculator.CrClStd, "0.0") & " ml/min/1.73m sq; BUN: " & BUN & " mg/dL; WBCs: " & WBCs & "; Recent Tmax: " & Tmax & "."
        My.Forms.FrmCalculator.PKline5 = "Estimated Kinetic Paramaters:  k: " & Format(My.Forms.FrmCalculator.EstK, "0.000") _
        & " 1/hr; Vd: " & Format(My.Forms.FrmCalculator.EstVd, "0.0") & " L; T 1/2: " & Format(My.Forms.FrmCalculator.EstT05, "0") & " h."
        My.Forms.FrmCalculator.PKline6 = "Recommend " & My.Forms.FrmCalculator.CboXDrug.Text & " dose of " & My.Forms.FrmCalculator.DoseToUse & _
        " mg every " & My.Forms.FrmCalculator.IntervalToUse & " hours, with a predicted Peak of " & Format(My.Forms.FrmCalculator.PredictPk, "0.0") & " and a"
        My.Forms.FrmCalculator.PKline7 = "predicted Trough of " & Format(My.Forms.FrmCalculator.PredictTr, "0.0") & ".  First dose to be given on " & FirstDoseDate & _
        " at " & FirstDoseTime & ".  Peak should be drawn"
        My.Forms.FrmCalculator.PKline8 = "on " & DatePeakDraw & " at " & TimePeakDraw & " and trough should be drawn on " _
        & DateTroughDraw & " at " & TimeTroughDraw & "."
        My.Forms.FrmCalculator.PKline9 = "Pharmacy will continue to follow."

    End Sub

    Private Sub GenerateExtInt()

        If My.Forms.FrmCalculator.Drug = 1 Then
            My.Forms.FrmCalculator.RTBoxText = "Extended Interval dosing is only available for Gentamicin and Tobramycin."
            GoTo SkipExtIntNote
        End If

        If My.Forms.FrmCalculator.CrCl < My.Forms.FrmCalculator.Q481 Then
            My.Forms.FrmCalculator.RTBoxText = "Extended Interval dosing is not recommended in patients with a Creatinine Clearance less than " & My.Forms.FrmCalculator.Q481.ToString & " ml/min."
            GoTo SkipExtIntNote
        End If

        My.Forms.FrmCalculator.RTBoxText = "Pharmacokinetics Consult Note" & Chr(13) & Chr(13) & _
               Initials & " is a " & My.Forms.FrmCalculator.Age & " year old " & My.Forms.FrmCalculator.GenderString & _
               " admitted on " & AdmitDate & ".  Pharmacy was consulted for dosing of " & My.Forms.FrmCalculator.CboXDrug.Text & _
               " for " & Diagnosis & "." & Chr(13) & Chr(13) & "Patient Demographics:  ABW: " & My.Forms.FrmCalculator.ABW & _
               " kg; Height: " & My.Forms.FrmCalculator.PtHeight & " in; IBW: " & My.Forms.FrmCalculator.IBW & " kg; SCr: " & _
               Format(My.Forms.FrmCalculator.SCr, "0.0") & " mg/dL; CrCl: " & Format(My.Forms.FrmCalculator.CrCl, "0.0") & " ml/min; CrCl Std: " & _
               Format(My.Forms.FrmCalculator.CrClStd, "0.0") & " ml/min/1.73m sq; BUN: " & BUN & " mg/dL; WBCs: " & WBCs & "; Recent Tmax: " & _
               Tmax & "." & Chr(13) & Chr(13) & "Estimated Kinetic Paramaters:  k: " & Format(My.Forms.FrmCalculator.EstK, "0.000") _
               & " 1/hr; Vd: " & Format(My.Forms.FrmCalculator.EstVd, "0.0") & " L; T 1/2: " & Format(My.Forms.FrmCalculator.EstT05, "0") & " h." & _
               Chr(13) & Chr(13) & "Recommend Extended Interval dosing of " & My.Forms.FrmCalculator.CboXDrug.Text & _
               ".  Dose of " & KineticCalc.RoundToSignificance(My.Forms.FrmCalculator.ExtIntDose, 20) & " mg every " & _
               My.Forms.FrmCalculator.ExtIntInt & " hours, with dosing based on 7 mg/kg and the interval based on Creatinine Clearance.  " & _
               "First dose should be given on " & FirstDoseDate & " at " & FirstDoseTime & ".  " & _
                "Random level should be drawn on " & DateTroughDraw & " at " & TimeTroughDraw & " and interval re-evaluated " _
                & "based on the Hartford nomogram.  Pharmacy will continue to follow."

        My.Forms.FrmCalculator.PKline1 = Initials & " is a " & My.Forms.FrmCalculator.Age & " year old " & My.Forms.FrmCalculator.GenderString & _
               " admitted on " & AdmitDate & ".  Pharmacy was consulted for dosing of"
        My.Forms.FrmCalculator.PKline2 = My.Forms.FrmCalculator.CboXDrug.Text & " for " & Diagnosis & "."
        My.Forms.FrmCalculator.PKline3 = "Patient Demographics:  ABW: " & My.Forms.FrmCalculator.ABW & " kg; Height: " & My.Forms.FrmCalculator.PtHeight & " in; IBW: " & My.Forms.FrmCalculator.IBW & " kg; SCr: " & _
               Format(My.Forms.FrmCalculator.SCr, "0.0") & " mg/dL; CrCl: " & Format(My.Forms.FrmCalculator.CrCl, "0.0")
        My.Forms.FrmCalculator.PKline4 = "ml/min; CrCl Std: " & Format(My.Forms.FrmCalculator.CrClStd, "0.0") & " ml/min/1.73m sq; BUN: " & BUN & " mg/dL; WBCs: " & WBCs & "; Recent Tmax: " & Tmax & "."
        My.Forms.FrmCalculator.PKline5 = "Estimated Kinetic Paramaters:  k: " & Format(My.Forms.FrmCalculator.EstK, "0.000") _
               & " 1/hr; Vd: " & Format(My.Forms.FrmCalculator.EstVd, "0.0") & " L; T 1/2: " & Format(My.Forms.FrmCalculator.EstT05, "0") & " h."
        My.Forms.FrmCalculator.PKline6 = "Recommend Extended Interval dosing of " & My.Forms.FrmCalculator.CboXDrug.Text & _
               ".  Dose of " & KineticCalc.RoundToSignificance(My.Forms.FrmCalculator.ExtIntDose, 20) & " mg every " & _
               My.Forms.FrmCalculator.ExtIntInt & " hours, with dosing "
        My.Forms.FrmCalculator.PKline7 = "based on 7 mg/kg and the interval based on Creatinine Clearance.  " & "First dose should be given on "
        My.Forms.FrmCalculator.PKline8 = FirstDoseDate & " at " & FirstDoseTime & ".  " & "Random level should be drawn on " & DateTroughDraw & " at " & TimeTroughDraw & " and interval re-evaluated"
        My.Forms.FrmCalculator.PKline9 = "based on the Hartford nomogram.  Pharmacy will continue to follow."

SkipExtIntNote:
    End Sub

    Private Sub GenerateFollowUp()

        My.Forms.FrmCalculator.RTBoxText = "Pharmacokinetics Consult Note" & Chr(13) & Chr(13) & _
    Initials & " is a " & My.Forms.FrmCalculator.Age & " year old " & My.Forms.FrmCalculator.GenderString & _
    " admitted on " & AdmitDate & ".  Pharmacy was consulted for dosing of " & My.Forms.FrmCalculator.CboXDrug.Text & _
    " for " & Diagnosis & ".  The patient is currently receiving " & My.Forms.FrmCalculator.ActualDose & " mg of " & _
    My.Forms.FrmCalculator.CboXDrug.Text & " every " & My.Forms.FrmCalculator.ActualInterval & " hours." _
    & Chr(13) & Chr(13) & "Patient Demographics:  ABW: " & My.Forms.FrmCalculator.ABW & _
    " kg; Height: " & My.Forms.FrmCalculator.PtHeight & " in; IBW: " & My.Forms.FrmCalculator.IBW & " kg; SCr: " & _
    Format(My.Forms.FrmCalculator.SCr, "0.0") & " mg/dL; CrCl: " & Format(My.Forms.FrmCalculator.CrCl, "0.0") & " ml/min; CrCl Std: " & _
    Format(My.Forms.FrmCalculator.CrClStd, "0.0") & " ml/min/1.73m sq; BUN: " & BUN & " mg/dL; WBCs: " & WBCs & "; Recent Tmax: " & _
    Tmax & "." & Chr(13) & Chr(13) & "Patient Kinetic Paramaters:  Peak: " & My.Forms.FrmCalculator.ActualPeak & "; Trough: " & _
    My.Forms.FrmCalculator.ActualTrough & "; k: " & Format(My.Forms.FrmCalculator.ActualK, "0.000") _
    & " 1/hr; Vd: " & Format(My.Forms.FrmCalculator.ActualVd, "0.0") & " L; T 1/2: " & Format(My.Forms.FrmCalculator.ActualT05, "0") & " h." & _
    Chr(13) & Chr(13) & "Recommend new " & My.Forms.FrmCalculator.CboXDrug.Text & " dose of " & My.Forms.FrmCalculator.UseDose & _
    " mg every " & My.Forms.FrmCalculator.UseInterval & " hours, with a predicted Peak of " & Format(My.Forms.FrmCalculator.PredictPk2, "0.0") & _
    " and a predicted Trough of " & Format(My.Forms.FrmCalculator.PredictTr2, "0.0") & ".  First dose to be given on " & FirstDoseDate & _
    " at " & FirstDoseTime & ".  Peak should be drawn on " & DatePeakDraw & " at " & TimePeakDraw & " and trough should be drawn on " _
    & DateTroughDraw & " at " & TimeTroughDraw & ".  Pharmacy will continue to follow."

        My.Forms.FrmCalculator.PKline1 = Initials & " is a " & My.Forms.FrmCalculator.Age & " year old " & My.Forms.FrmCalculator.GenderString & _
               " admitted on " & AdmitDate & ".  Pharmacy was consulted for dosing of"
        My.Forms.FrmCalculator.PKline2 = My.Forms.FrmCalculator.CboXDrug.Text & " for " & Diagnosis & ".  The patient is currently receiving " & My.Forms.FrmCalculator.ActualDose & " mg of "
        My.Forms.FrmCalculator.PKline3 = My.Forms.FrmCalculator.CboXDrug.Text & " every " & My.Forms.FrmCalculator.ActualInterval & " hours."
        My.Forms.FrmCalculator.PKline4 = "Patient Demographics:  ABW: " & My.Forms.FrmCalculator.ABW & " kg; Height: " & My.Forms.FrmCalculator.PtHeight & " in; IBW: " & My.Forms.FrmCalculator.IBW & " kg; SCr: " & _
               Format(My.Forms.FrmCalculator.SCr, "0.0") & " mg/dL; CrCl: " & Format(My.Forms.FrmCalculator.CrCl, "0.0")
        My.Forms.FrmCalculator.PKline5 = "ml/min; CrCl Std: " & Format(My.Forms.FrmCalculator.CrClStd, "0.0") & " ml/min/1.73m sq; BUN: " & BUN & " mg/dL; WBCs: " & WBCs & "; Recent Tmax: " & Tmax & "."
        My.Forms.FrmCalculator.PKline6 = "Patient Kinetic Paramaters:  Peak: " & My.Forms.FrmCalculator.ActualPeak & "; Trough: " & _
        My.Forms.FrmCalculator.ActualTrough & "; k: " & Format(My.Forms.FrmCalculator.ActualK, "0.000") _
        & " 1/hr; Vd: " & Format(My.Forms.FrmCalculator.ActualVd, "0.0") & " L; T 1/2: " & Format(My.Forms.FrmCalculator.ActualT05, "0") & " h."
        My.Forms.FrmCalculator.PKline7 = "Recommend new " & My.Forms.FrmCalculator.CboXDrug.Text & " dose of " & My.Forms.FrmCalculator.UseDose & _
        " mg every " & My.Forms.FrmCalculator.UseInterval & " hours, with a predicted Peak of " & Format(My.Forms.FrmCalculator.PredictPk2, "0.0")
        My.Forms.FrmCalculator.PKline8 = "and a predicted Trough of " & Format(My.Forms.FrmCalculator.PredictTr2, "0.0") & ".  First dose to be given on " & FirstDoseDate & _
        " at " & FirstDoseTime & ".  Peak should be"
        My.Forms.FrmCalculator.PKline9 = "drawn on " & DatePeakDraw & " at " & TimePeakDraw & " and trough should be drawn on " _
        & DateTroughDraw & " at " & TimeTroughDraw & "."
        My.Forms.FrmCalculator.PKline10 = "Pharmacy will continue to follow."

    End Sub

    Private Sub FrmNoteData_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged

        Themerator()

        If My.Forms.FrmCalculator.NoteType = 2 Then
            TxtDatePeakDraw.Enabled = False
            TxtTimePeakDraw.Enabled = False
            PbPeak.Enabled = False
            LblPeakDraw.Enabled = False
            LblPeakDraw2.Enabled = False
            LblTroughDraw.Visible = False
            LblTroughDraw2.Visible = False
            LblNextDose.Visible = False
            LblNextDose2.Visible = False
            LblFirstDose.Visible = True
            LblFirstDose2.Visible = True
            LblRandom.Visible = True
            LblRandom2.Visible = True
        ElseIf My.Forms.FrmCalculator.NoteType = 1 Then
            TxtDatePeakDraw.Enabled = True
            TxtTimePeakDraw.Enabled = True
            PbPeak.Enabled = True
            LblPeakDraw.Enabled = True
            LblPeakDraw2.Enabled = True
            LblTroughDraw.Visible = True
            LblTroughDraw2.Visible = True
            LblFirstDose.Visible = True
            LblFirstDose2.Visible = True
            LblRandom.Visible = False
            LblRandom2.Visible = False
            LblNextDose.Visible = False
            LblNextDose2.Visible = False
        ElseIf My.Forms.FrmCalculator.NoteType = 3 Then
            TxtDatePeakDraw.Enabled = True
            TxtTimePeakDraw.Enabled = True
            PbPeak.Enabled = True
            LblPeakDraw.Enabled = True
            LblPeakDraw2.Enabled = True
            LblTroughDraw.Visible = True
            LblTroughDraw2.Visible = True
            LblFirstDose.Visible = False
            LblFirstDose2.Visible = False
            LblRandom.Visible = False
            LblRandom2.Visible = False
            LblNextDose.Visible = True
            LblNextDose2.Visible = True
        End If

    End Sub

    Private Sub FrmNoteData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Opened = 1
        Themerator()
    End Sub

    Private Sub Themerator()

        Me.ForeColor = My.Forms.FrmCalculator.TextColor
        Me.BackColor = My.Forms.FrmCalculator.BGround
        Me.GroupBox1.BackColor = My.Forms.FrmCalculator.Main
        Me.BtnHide.BackColor = My.Forms.FrmCalculator.Buttons


    End Sub

    Private Sub PbAdmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PbAdmit.Click
        Dim DDR As DialogResult = FrmDatePicker.ShowDialog()
        Dim PickedDate As Date
        Dim DateMonth As String
        Dim DateDay As String
        Dim DateString As String

        If DDR = Windows.Forms.DialogResult.OK Then

            PickedDate = My.Forms.FrmDatePicker.MC1.SelectionStart

            If PickedDate.Month < 10 Then
                DateMonth = "0" + PickedDate.Month.ToString
            Else
                DateMonth = PickedDate.Month.ToString
            End If

            If PickedDate.Day < 10 Then
                DateDay = "0" + PickedDate.Day.ToString
            Else
                DateDay = PickedDate.Day.ToString
            End If

            DateString = DateMonth + DateDay + PickedDate.Year.ToString
            TxtAdmitDate.Text = DateString

        End If

    End Sub

    Private Sub PbFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PbFirst.Click
        Dim DDR As DialogResult = FrmDatePicker.ShowDialog()
        Dim PickedDate As Date
        Dim DateMonth As String
        Dim DateDay As String
        Dim DateString As String

        If DDR = Windows.Forms.DialogResult.OK Then

            PickedDate = My.Forms.FrmDatePicker.MC1.SelectionStart

            If PickedDate.Month < 10 Then
                DateMonth = "0" + PickedDate.Month.ToString
            Else
                DateMonth = PickedDate.Month.ToString
            End If

            If PickedDate.Day < 10 Then
                DateDay = "0" + PickedDate.Day.ToString
            Else
                DateDay = PickedDate.Day.ToString
            End If

            DateString = DateMonth + DateDay + PickedDate.Year.ToString
            TxtFirstDoseDate.Text = DateString

        End If

    End Sub

    Private Sub PbPeak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PbPeak.Click
        Dim DDR As DialogResult = FrmDatePicker.ShowDialog()
        Dim PickedDate As Date
        Dim DateMonth As String
        Dim DateDay As String
        Dim DateString As String

        If DDR = Windows.Forms.DialogResult.OK Then

            PickedDate = My.Forms.FrmDatePicker.MC1.SelectionStart

            If PickedDate.Month < 10 Then
                DateMonth = "0" + PickedDate.Month.ToString
            Else
                DateMonth = PickedDate.Month.ToString
            End If

            If PickedDate.Day < 10 Then
                DateDay = "0" + PickedDate.Day.ToString
            Else
                DateDay = PickedDate.Day.ToString
            End If

            DateString = DateMonth + DateDay + PickedDate.Year.ToString
            TxtDatePeakDraw.Text = DateString

        End If

    End Sub

    Private Sub PbTrough_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PbTrough.Click
        Dim DDR As DialogResult = FrmDatePicker.ShowDialog()
        Dim PickedDate As Date
        Dim DateMonth As String
        Dim DateDay As String
        Dim DateString As String

        If DDR = Windows.Forms.DialogResult.OK Then

            PickedDate = My.Forms.FrmDatePicker.MC1.SelectionStart

            If PickedDate.Month < 10 Then
                DateMonth = "0" + PickedDate.Month.ToString
            Else
                DateMonth = PickedDate.Month.ToString
            End If

            If PickedDate.Day < 10 Then
                DateDay = "0" + PickedDate.Day.ToString
            Else
                DateDay = PickedDate.Day.ToString
            End If

            DateString = DateMonth + DateDay + PickedDate.Year.ToString
            TxtDateTroughDraw.Text = DateString

        End If

    End Sub

End Class