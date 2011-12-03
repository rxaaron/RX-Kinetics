Imports System.IO
Public Class FrmCalculator
    Dim KineticCalc As New PharmCalc
    Public Drug As Integer
    Public Gender As Integer
    Dim CrClMethod As Integer
    Public ABW As Double
    Public PtHeight As Double
    Public Age As Double
    Public SCr As Double
    Dim CV As Double
    Dim UseWeight As Double
    Public IBW As Double
    Public BSA As Double
    Public CrCl As Double
    Public CrClStd As Double
    Public EstK As Double
    Public EstT05 As Double
    Public EstVd As Double
    Dim DoseWeight As Double
    Dim PeakDes As Double
    Dim TroughDes As Double
    Dim DesPeak As Double
    Dim DesTrough As Double
    Public Infusion As Double
    Public DrawPeak As Double
    Public DrawTrough As Double
    Dim KToUse As Double
    Dim VdToUse As Double
    Public DoseToUse As Double
    Public IntervalToUse As Double
    Dim DoseEst As Integer
    Dim IntervalEst As Double
    Public PredictPk As Double
    Public PredictTr As Double
    Public ExtIntDose As Double
    Public ExtIntInt As Double
    Public ActualPeak As Double
    Public ActualTrough As Double
    Dim ActualInfTime As Double
    Dim ActualPkTime As Double
    Dim ActualTrTime As Double
    Public ActualK As Double
    Public ActualVd As Double
    Public ActualT05 As Double
    Dim NewDose As Double
    Dim NewInterval As Double
    Public UseDose As Double
    Public UseInterval As Double
    Public PredictPk2 As Double
    Public PredictTr2 As Double
    Public ActualDose As Double
    Public ActualInterval As Double
    Public NoteType As Integer
    Public RTBoxText As String
    Public GenderString As String
    Public PKline1 As String
    Public PKline2 As String
    Public PKline3 As String
    Public PKline4 As String
    Public PKline5 As String
    Public PKline6 As String
    Public PKline7 As String
    Public PKline8 As String
    Public PKline9 As String
    Public PKline10 As String
    Public NeedsRegenerated As Integer
    Public NeedsHelp As Boolean
    Public AOT As Boolean
    Public SIT As Boolean
    Public SNI As Boolean
    Public VInf As Double
    Public VPDraw As Double
    Public VTDraw As Double
    Public VCV As Double
    Public VP1 As Double
    Public VP2 As Double
    Public VT1 As Double
    Public VT2 As Double
    Public TInf As Double
    Public TPDraw As Double
    Public TTDraw As Double
    Public TCV As Double
    Public TP1 As Double
    Public TP2 As Double
    Public TT1 As Double
    Public TT2 As Double
    Public GInf As Double
    Public GPDraw As Double
    Public GTDraw As Double
    Public GCV As Double
    Public GP1 As Double
    Public GP2 As Double
    Public GT1 As Double
    Public GT2 As Double
    Public BGround As Color
    Public Main As Color
    Public TextColor As Color
    Public Answers As Color
    Public Buttons As Color
    Public ExtInt As Double
    Public Q241 As Double
    Public Q242 As Double
    Public Q361 As Double
    Public Q362 As Double
    Public Q481 As Double
    Public Q482 As Double


    Private Sub FrmCalculator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        SetSettings()
        My.Forms.FrmUserAgreement.Visible = False
        Me.RadButCCG.Checked = True
        Me.RadButMale.Checked = True
        ClearAll()

    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Visible = True
        Me.WindowState = FormWindowState.Normal
        Me.ShowInTaskbar = SIT
        NotifyIcon1.Visible = SNI
    End Sub

    Private Sub Hider()
        Me.Visible = False
        Me.ShowInTaskbar = False
        Me.NotifyIcon1.Visible = True
    End Sub


    Private Sub GenderAssign()


        If Me.RadButMale.Checked = True Then
            Gender = 1
            GenderString = "Male"
        ElseIf Me.RadButFemale.Checked = True Then
            Gender = 2
            GenderString = "Female"
        Else
            'MsgBox("Plesae Select a Gender", , "Gender Needed")
            Gender = 0
        End If
    End Sub

    Private Sub GetCrClMethod()

        If Me.RadButCCG.Checked = True Then
            CrClMethod = 1
        ElseIf Me.RadButJelliffe.Checked = True Then
            CrClMethod = 2
        Else
            'MsgBox("Please Select a CrCl Method", , "Method Needed")
            CrClMethod = 0
        End If
    End Sub

    Private Sub GetValues()
        ABW = Val(Me.TxtABW.Text)
        Age = Val(Me.TxtAge.Text)
        PtHeight = Val(TxtHeight.Text)
        SCr = Val(Me.TxtSCr.Text)
        CV = Val(Me.TxtCV.Text)
        PeakDes = Val(Me.TxtPeakDes.Text)
        TroughDes = Val(Me.TxtTroughDes.Text)
        Infusion = Val(Me.TxtInfusion.Text)
        DrawPeak = Val(Me.TxtDrawPeak.Text)
        DrawTrough = Val(Me.TxtDrawTrough.Text)
        KToUse = Val(Me.LblKtoUse.Text)
        VdToUse = Val(Me.LblVdtoUse.Text)
        DoseToUse = Val(Me.TxtDoseUse.Text)
        IntervalToUse = Val(Me.TxtIntervalUse.Text)
        ActualPeak = Val(Me.TxtActualPeak.Text)
        ActualTrough = Val(Me.TxtActualTrough.Text)
        ActualInfTime = Val(Me.TxtActualInfTime.Text)
        ActualPkTime = Val(Me.TxtActualPkTime.Text)
        ActualTrTime = Val(Me.TxtActualTrTime.Text)
        UseDose = Val(Me.TxtUseDose.Text)
        UseInterval = Val(Me.TxtUseInterval.Text)
        ActualDose = Val(Me.TxtActualDose.Text)
        ActualInterval = Val(Me.TxtActualInterval.Text)
        DesPeak = Val(Me.TxtDesPeak.Text)
        DesTrough = Val(Me.TxtDesTrough.Text)

    End Sub

    Private Sub DrugAssign()
        If Me.CboXDrug.Text = "Vancomycin" Then
            Drug = 1
        ElseIf Me.CboXDrug.Text = "Gentamicin" Then
            Drug = 2
        ElseIf Me.CboXDrug.Text = "Tobramycin" Then
            Drug = 3
        Else
            Drug = 0
        End If

    End Sub

    Private Sub SetCV()
        If Drug = 1 Then
            TxtCV.Text = VCV.ToString
            TxtInfusion.Text = VInf.ToString
            TxtDrawPeak.Text = VPDraw.ToString
            TxtDrawTrough.Text = VTDraw.ToString
        ElseIf Drug = 2 Then
            TxtCV.Text = GCV.ToString
            TxtInfusion.Text = GInf.ToString
            TxtDrawPeak.Text = GPDraw.ToString
            TxtDrawTrough.Text = GTDraw.ToString
        ElseIf Drug = 3 Then
            TxtCV.Text = TCV.ToString
            TxtInfusion.Text = TInf.ToString
            TxtDrawPeak.Text = TPDraw.ToString
            TxtDrawTrough.Text = TTDraw.ToString
        End If
    End Sub

    Private Sub SetUseWeight()
        If ABW > (1.2 * IBW) Then
            UseWeight = (IBW + (0.2 * (ABW - IBW)))
        ElseIf ABW > IBW And ABW < (1.2 * IBW) Then
            UseWeight = IBW
        ElseIf ABW < IBW Then
            UseWeight = ABW
        End If
    End Sub

    Private Sub SetDoseWeight()
        If ABW > (1.2 * IBW) Then
            DoseWeight = (IBW + (0.4 * (ABW - IBW)))
        ElseIf ABW < IBW Then
            DoseWeight = ABW
        Else
            DoseWeight = IBW
        End If
    End Sub

    Private Sub Printdocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim titlefont As New Font("microsoft san serif", 14)
        Dim myfont As New Font("microsoft san serif", 12)
        Dim legalfont As New Font("microsoft san serif", 8)
        Dim Title As String
        Dim Sigline As String
        Dim linetag As String
        Title = "Pharmacokinetics Consult Note"
        Sigline = "_____________________________ / _________________________________"
        linetag = "This note was generated by Night Watch Kinetics Calculator on " & System.DateTime.Now
        e.Graphics.DrawString(Title, New Font(titlefont, FontStyle.Bold), Brushes.Black, 40, 40)
        e.Graphics.DrawString(PKline1, New Font(myfont, FontStyle.Regular), Brushes.Black, 40, 70)
        e.Graphics.DrawString(PKline2, New Font(myfont, FontStyle.Regular), Brushes.Black, 40, 90)
        e.Graphics.DrawString(PKline3, New Font(myfont, FontStyle.Regular), Brushes.Black, 40, 120)
        e.Graphics.DrawString(PKline4, New Font(myfont, FontStyle.Regular), Brushes.Black, 40, 140)
        e.Graphics.DrawString(PKline5, New Font(myfont, FontStyle.Regular), Brushes.Black, 40, 170)
        e.Graphics.DrawString(PKline6, New Font(myfont, FontStyle.Regular), Brushes.Black, 40, 200)
        e.Graphics.DrawString(PKline7, New Font(myfont, FontStyle.Regular), Brushes.Black, 40, 220)
        e.Graphics.DrawString(PKline8, New Font(myfont, FontStyle.Regular), Brushes.Black, 40, 240)
        e.Graphics.DrawString(PKline9, New Font(myfont, FontStyle.Regular), Brushes.Black, 40, 260)
        e.Graphics.DrawString(Sigline, New Font(myfont, FontStyle.Regular), Brushes.Black, 45, 300)
        e.Graphics.DrawImage(My.Resources.nightwatch, 25, 925, 100, 100)
        e.Graphics.DrawString(lineTag, New Font(legalfont, FontStyle.Regular), Brushes.Black, 140, 1010)


    End Sub

    Private Sub Printdocument2_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument2.PrintPage
        Dim titlefont As New Font("microsoft san serif", 14)
        Dim myfont As New Font("microsoft san serif", 12)
        Dim legalfont As New Font("microsoft san serif", 8)
        Dim Title As String
        Dim Sigline As String
        Dim linetag As String
        Title = "Pharmacokinetics Consult Note"
        Sigline = "______________________________ / _________________________________"
        linetag = "This note was generated by Night Watch Kinetics Calculator on " & System.DateTime.Now
        e.Graphics.DrawString(Title, New Font(titlefont, FontStyle.Bold), Brushes.Black, 40, 40)
        e.Graphics.DrawString(PKline1, New Font(myfont, FontStyle.Regular), Brushes.Black, 40, 70)
        e.Graphics.DrawString(PKline2, New Font(myfont, FontStyle.Regular), Brushes.Black, 40, 90)
        e.Graphics.DrawString(PKline3, New Font(myfont, FontStyle.Regular), Brushes.Black, 40, 120)
        e.Graphics.DrawString(PKline4, New Font(myfont, FontStyle.Regular), Brushes.Black, 40, 140)
        e.Graphics.DrawString(PKline5, New Font(myfont, FontStyle.Regular), Brushes.Black, 40, 170)
        e.Graphics.DrawString(PKline6, New Font(myfont, FontStyle.Regular), Brushes.Black, 40, 200)
        e.Graphics.DrawString(PKline7, New Font(myfont, FontStyle.Regular), Brushes.Black, 40, 220)
        e.Graphics.DrawString(PKline8, New Font(myfont, FontStyle.Regular), Brushes.Black, 40, 240)
        e.Graphics.DrawString(PKline9, New Font(myfont, FontStyle.Regular), Brushes.Black, 40, 260)
        e.Graphics.DrawString(Sigline, New Font(myfont, FontStyle.Regular), Brushes.Black, 45, 300)
        e.Graphics.DrawImage(My.Resources.nightwatch, 25, 925, 100, 100)
        e.Graphics.DrawString(linetag, New Font(legalfont, FontStyle.Regular), Brushes.Black, 140, 1010)


    End Sub

    Private Sub Printdocument3_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument3.PrintPage
        Dim titlefont As New Font("microsoft san serif", 14)
        Dim myfont As New Font("microsoft san serif", 12)
        Dim legalfont As New Font("microsoft san serif", 8)
        Dim Title As String
        Dim Sigline As String
        Dim linetag As String
        Title = "Pharmacokinetics Consult Note"
        Sigline = "______________________________ / _________________________________"
        linetag = "This note was generated by Night Watch Kinetics Calculator on " & System.DateTime.Now
        e.Graphics.DrawString(Title, New Font(titlefont, FontStyle.Bold), Brushes.Black, 40, 40)
        e.Graphics.DrawString(PKline1, New Font(myfont, FontStyle.Regular), Brushes.Black, 40, 70)
        e.Graphics.DrawString(PKline2, New Font(myfont, FontStyle.Regular), Brushes.Black, 40, 90)
        e.Graphics.DrawString(PKline3, New Font(myfont, FontStyle.Regular), Brushes.Black, 40, 110)
        e.Graphics.DrawString(PKline4, New Font(myfont, FontStyle.Regular), Brushes.Black, 40, 140)
        e.Graphics.DrawString(PKline5, New Font(myfont, FontStyle.Regular), Brushes.Black, 40, 160)
        e.Graphics.DrawString(PKline6, New Font(myfont, FontStyle.Regular), Brushes.Black, 40, 190)
        e.Graphics.DrawString(PKline7, New Font(myfont, FontStyle.Regular), Brushes.Black, 40, 220)
        e.Graphics.DrawString(PKline8, New Font(myfont, FontStyle.Regular), Brushes.Black, 40, 240)
        e.Graphics.DrawString(PKline9, New Font(myfont, FontStyle.Regular), Brushes.Black, 40, 260)
        e.Graphics.DrawString(PKline10, New Font(myfont, FontStyle.Regular), Brushes.Black, 40, 280)
        e.Graphics.DrawString(Sigline, New Font(myfont, FontStyle.Regular), Brushes.Black, 45, 310)
        e.Graphics.DrawImage(My.Resources.nightwatch, 25, 925, 100, 100)
        e.Graphics.DrawString(linetag, New Font(legalfont, FontStyle.Regular), Brushes.Black, 140, 1010)


    End Sub

    Private Sub CalculateDemo()

        GenderAssign()
        GetCrClMethod()
        GetValues()

        If ABW = 0 Or PtHeight = 0 Or Age = 0 Or SCr = 0 Or CV = 0 Or Gender = 0 Or CrClMethod = 0 Then
            GoTo EndUpdateSub
        End If

        If Gender = 1 Then
            IBW = KineticCalc.IBWMale(PtHeight)
        ElseIf Gender = 2 Then
            IBW = KineticCalc.IBWFemale(PtHeight)
        End If

        SetUseWeight()
        SetDoseWeight()

        BSA = KineticCalc.BSACalc(ABW, PtHeight)

        If Gender = 1 And CrClMethod = 1 Then
            CrCl = KineticCalc.CCGMale(Age, UseWeight, SCr)
        ElseIf Gender = 2 And CrClMethod = 1 Then
            CrCl = KineticCalc.CCGFemale(Age, UseWeight, SCr)
        ElseIf Gender = 1 And CrClMethod = 2 Then
            CrCl = KineticCalc.JelliffeMale(Age, SCr, BSA)
        ElseIf Gender = 2 And CrClMethod = 2 Then
            CrCl = KineticCalc.JelliffeFemale(Age, SCr, BSA)
        End If

        CrClStd = KineticCalc.CrClStd(CrCl, BSA)
        If Drug = 0 Then
            GoTo NoDrug
        End If
        If Drug = 1 Then
            EstK = KineticCalc.VancKEst(CrCl)
        ElseIf Drug = 2 Then
            EstK = KineticCalc.GentKEst(CrCl)
        ElseIf Drug = 3 Then
            EstK = KineticCalc.TobraKEst(CrClStd)
        End If

        EstT05 = KineticCalc.TOneHalf(EstK)

        EstVd = KineticCalc.VdCalc(CV, DoseWeight)

        ExtIntDose = KineticCalc.AgExtIntDose(DoseWeight)
        ExtIntInt = KineticCalc.AgExtIntInterval(CrClStd)

        If Drug = 2 Or Drug = 3 Then
            GrpBoxExtInt.Visible = True
            LblExtIntDose.Text = KineticCalc.RoundToSignificance(ExtIntDose, 20)
            LblExtIntInt.Text = ExtIntInt
        ElseIf Drug = 1 Then
            GrpBoxExtInt.Visible = False
        End If

        If CrCl < Q481 Then
            GrpBoxExtInt.Visible = False
        End If

        LblEstK.Text = Format(EstK, "0.000")
        LblEstT05.Text = Format(EstT05, "0")
        LblEstVd.Text = Format(EstVd, "0")
        LblKtoUse.Text = Format(EstK, "0.000")
        LblVdtoUse.Text = Format(EstVd, "0")
NoDrug:
        LblIBW.Text = Format(IBW, "0.0")
        LblBSA.Text = Format(BSA, "0.00")
        LblCrCl.Text = Format(CrCl, "0")
        LblCrClStd.Text = Format(CrClStd, "0")


EndUpdateSub:
    End Sub

    Private Sub InitDoseCalc()
        GetValues()

        If PeakDes = 0 Or TroughDes = 0 Or Infusion = 0 Or DrawPeak = 0 Or DrawTrough = 0 Or KToUse = 0 Or VdToUse = 0 Then
            GoTo EndInitDoseSub
        End If

        IntervalEst = KineticCalc.CalculateInterval(TroughDes, PeakDes, KToUse, DrawPeak)
        DoseEst = KineticCalc.CalculateDose(PeakDes, VdToUse, KToUse, IntervalEst, Infusion, DrawPeak)


        LblIntervalEst.Text = IntervalEst
        LblDoseEst.Text = DoseEst


EndInitDoseSub:
    End Sub

    Private Sub PredictInit()
        GetValues()

        If DoseToUse = 0 Or IntervalToUse = 0 Then
            GoTo EndPredictInit
        End If

        PredictPk = KineticCalc.PredictPeak(DoseToUse, Infusion, KToUse, DrawPeak, VdToUse, IntervalToUse)
        PredictTr = KineticCalc.PredictTrough(PredictPk, KToUse, IntervalToUse, Infusion, DrawPeak)

        LblPredictPk.Text = Format(PredictPk, "0.0")
        LblPredictTr.Text = Format(PredictTr, "0.0")

EndPredictInit:
    End Sub

    Private Sub CalcDoseAdj()
        GetValues()

        If ActualPeak = 0 Or ActualTrough = 0 Or ActualInterval = 0 Or ActualPkTime = 0 Or ActualTrTime = 0 Or ActualDose = 0 Or ActualInfTime = 0 Then
            GoTo EndCalcDoseAdj
        End If

        ActualK = KineticCalc.ActualK(ActualPeak, ActualTrough, ActualInterval, ActualPkTime, ActualTrTime)
        ActualVd = KineticCalc.ActualVolumeofDistribution(ActualDose, ActualInfTime, ActualK, ActualPkTime, ActualPeak, ActualInterval)
        ActualT05 = KineticCalc.TOneHalf(ActualK)

        LblActualK.Text = Format(ActualK, "0.000")
        LblActualVd.Text = Format(ActualVd, "0.0")
        LblActualT05.Text = Format(ActualT05, "0.0")

EndCalcDoseAdj:
    End Sub

    Private Sub CalcNewDose()
        GetValues()

        If DesTrough = 0 Or DesPeak = 0 Or ActualK = 0 Or DrawPeak = 0 Or ActualVd = 0 Or Infusion = 0 Then
            GoTo EndCalcNewDose
        End If

        NewInterval = KineticCalc.CalculateInterval(DesTrough, DesPeak, ActualK, DrawPeak)
        NewDose = KineticCalc.CalculateDose(DesPeak, ActualVd, ActualK, NewInterval, Infusion, DrawPeak)

        LblNewDose.Text = Format(NewDose, "0")
        LblNewInterval.Text = Format(NewInterval, "0")

EndCalcNewDose:
    End Sub

    Private Sub PredictAdj()
        GetValues()

        If UseDose = 0 Or Infusion = 0 Or ActualK = 0 Or DrawPeak = 0 Or ActualVd = 0 Or UseInterval = 0 Then
            GoTo EndPredictAdj
        End If

        PredictPk2 = KineticCalc.PredictPeak(UseDose, Infusion, ActualK, DrawPeak, ActualVd, UseInterval)
        PredictTr2 = KineticCalc.PredictTrough(PredictPk2, ActualK, UseInterval, Infusion, DrawPeak)

        LblPredictPk2.Text = Format(PredictPk2, "0.0")
        LblPredictTr2.Text = Format(PredictTr2, "0.0")

EndPredictAdj:
    End Sub

    Private Sub ClearAll()
        CboXDrug.Text = " "
        Drug = Nothing
        TxtABW.Text = " "
        TxtHeight.Text = " "
        TxtAge.Text = " "
        TxtSCr.Text = " "
        TxtCV.Text = " "
        LblIBW.Text = " "
        LblBSA.Text = " "
        LblCrCl.Text = " "
        LblCrClStd.Text = " "
        LblEstK.Text = " "
        LblEstT05.Text = " "
        TxtPeakDes.Text = " "
        TxtTroughDes.Text = " "
        TxtInfusion.Text = " "
        TxtDrawPeak.Text = " "
        TxtDrawTrough.Text = " "
        LblKtoUse.Text = " "
        LblVdtoUse.Text = " "
        TxtDoseUse.Text = " "
        TxtIntervalUse.Text = " "
        LblDoseEst.Text = " "
        LblIntervalEst.Text = " "
        LblPredictPk.Text = " "
        LblPredictTr.Text = " "
        LblExtIntDose.Text = " "
        LblExtIntInt.Text = " "
        TxtActualDose.Text = " "
        TxtActualInterval.Text = " "
        TxtActualPeak.Text = " "
        TxtActualTrough.Text = " "
        TxtActualInfTime.Text = " "
        TxtActualPkTime.Text = " "
        TxtActualTrTime.Text = " "
        TxtUseDose.Text = " "
        TxtUseInterval.Text = " "
        LblActualK.Text = " "
        LblActualVd.Text = " "
        LblActualT05.Text = " "
        LblNewDose.Text = " "
        LblNewInterval.Text = " "
        LblPredictPk2.Text = " "
        LblPredictTr2.Text = " "
        LblEstVd.Text = " "
        My.Forms.FrmNoteData.TxtInitials.Text = " "
        My.Forms.FrmNoteData.TxtAdmitDate.Text = " "
        My.Forms.FrmNoteData.TxtDiagnosis.Text = " "
        My.Forms.FrmNoteData.TxtFirstDoseDate.Text = " "
        My.Forms.FrmNoteData.TxtFirstDoseTime.Text = " "
        My.Forms.FrmNoteData.TxtDatePeakDraw.Text = " "
        My.Forms.FrmNoteData.TxtTimePeakDraw.Text = " "
        My.Forms.FrmNoteData.TxtDateTroughDraw.Text = " "
        My.Forms.FrmNoteData.TxtTimeTroughDraw.Text = " "
        My.Forms.FrmNoteData.TxtBUN.Text = " "
        My.Forms.FrmNoteData.TxtWBCs.Text = " "
        My.Forms.FrmNoteData.TxtTmax.Text = " "
        My.Forms.FrmNoteData.HasBeenGenerated = 0
        NeedsRegenerated = 0
        Me.RadButInitial.Checked = False
        Me.RadButExtInt.Checked = False
        Me.RadButFollow.Checked = False
        RichTextBox1.Text = " "
        NeedsHelp = False
        GrpBoxExtInt.Visible = False

    End Sub

    Private Sub DoItAll()

        CalculateDemo()
        InitDoseCalc()
        PredictInit()
        CalcDoseAdj()
        CalcNewDose()
        PredictAdj()
        If My.Forms.FrmNoteData.HasBeenGenerated = 1 Then
            RichTextBox1.Text = "Note must be regenerated to reflect changes made to data."
            NeedsRegenerated = 1
        End If

    End Sub

    Private Sub CboXDrug_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrugAssign()
        SetCV()
        DoItAll()

    End Sub

    Private Sub BtnUnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUnGo.Click
        ClearAll()
    End Sub

    Private Sub TxtABW_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtABW.Leave
        DoItAll()
    End Sub

    Private Sub TxtHeight_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtHeight.Leave
        DoItAll()
    End Sub

    Private Sub TxtAge_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtAge.Leave
        DoItAll()
    End Sub

    Private Sub TxtSCr_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSCr.Leave
        DoItAll()
    End Sub

    Private Sub TxtCV_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DoItAll()
    End Sub

    Private Sub BtnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGo.Click
        DoItAll()
    End Sub

    Private Sub TxtPeakDes_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPeakDes.Leave
        DoItAll()
        If Not PeakDes = 0 Then
            If Drug = 1 Then
                If PeakDes < VP1 Or PeakDes > VP2 Then
                    MsgBox("The entered Peak is outside of traditional Vancomycin ranges", MsgBoxStyle.Critical, "Peak Out of Normal Range")
                End If
            ElseIf Drug = 2 Then
                If PeakDes < GP1 Or PeakDes > GP2 Then
                    MsgBox("The entered Peak is outside of traditional Gentamicin ranges", MsgBoxStyle.Critical, "Peak Out of Normal Range")
                End If
            ElseIf Drug = 3 Then
                If PeakDes < TP1 Or PeakDes > TP2 Then
                    MsgBox("The entered Peak is outside of traditional Tobramycin ranges", MsgBoxStyle.Critical, "Peak Out of Normal Range")
                End If
            End If
        End If
    End Sub

    Private Sub TxtTroughDes_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtTroughDes.Leave
        DoItAll()
        If Not TroughDes = 0 Then
            If Drug = 1 Then
                If TroughDes < VT1 Or TroughDes > VT2 Then
                    MsgBox("The entered Trough is outside of traditional Vancomycin ranges", MsgBoxStyle.Critical, "Trough Out of Normal Range")
                End If
            ElseIf Drug = 2 Then
                If TroughDes < GT1 Or TroughDes > GT2 Then
                    MsgBox("The entered Trough is outside of traditional Gentamicin ranges", MsgBoxStyle.Critical, "Trough Out of Normal Range")
                End If
            ElseIf Drug = 3 Then
                If TroughDes < TT1 Or TroughDes > TT2 Then
                    MsgBox("The entered Trough is outside of traditional Tobramycin ranges", MsgBoxStyle.Critical, "Trough Out of Normal Range")
                End If
            End If
        End If
    End Sub

    Private Sub TxtKtoUse_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DoItAll()
    End Sub

    Private Sub TxtVdtoUse_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DoItAll()
    End Sub

    Private Sub TxtInfusion_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtInfusion.Leave
        DoItAll()
    End Sub

    Private Sub TxtDrawPeak_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDrawPeak.Leave
        DoItAll()
    End Sub

    Private Sub TxtDrawTrough_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDrawTrough.Leave
        DoItAll()
    End Sub

    Private Sub TxtDoseUse_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDoseUse.Leave
        DoItAll()
    End Sub

    Private Sub TxtIntervalUse_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtIntervalUse.Leave
        DoItAll()
    End Sub

    Private Sub TxtActualDose_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtActualDose.Leave
        DoItAll()
    End Sub

    Private Sub TxtActualPeak_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtActualPeak.Leave
        DoItAll()
    End Sub

    Private Sub TxtActualTrough_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtActualTrough.Leave
        DoItAll()
    End Sub

    Private Sub TxtActualInterval_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtActualInterval.Leave
        DoItAll()
    End Sub

    Private Sub TxtActualInfTime_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtActualInfTime.Leave
        DoItAll()
    End Sub

    Private Sub TxtActualPkTime_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtActualPkTime.Leave
        DoItAll()
    End Sub

    Private Sub TxtActualTrTime_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtActualTrTime.Leave
        DoItAll()
    End Sub

    Private Sub TxtUseDose_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtUseDose.Leave
        DoItAll()
    End Sub

    Private Sub TxtUseInterval_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtUseInterval.Leave
        DoItAll()
    End Sub

    Private Sub BtnViewNote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewNote.Click
        If NoteType = 1 Or NoteType = 2 Or NoteType = 3 Then
            RichTextBox1.Text = " "
            My.Forms.FrmNoteData.Visible = True
        Else
            MsgBox("The type of note must be selected before the note can be generated.", MsgBoxStyle.Information, "Please Select a Type of Note")
        End If
    End Sub

    Private Sub BtnPrintNote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintNote.Click
        Dim PdR As DialogResult
        If NeedsRegenerated = 1 Then
            MsgBox("Note must be regenerated to reflect changes made to data.", MsgBoxStyle.Exclamation, "Please Regenerate Note")
            GoTo EndPrintSub
        End If
        If My.Forms.FrmNoteData.HasBeenGenerated = 1 Then
            PdR = PrintDialog1.ShowDialog

            If PdR = Windows.Forms.DialogResult.OK Then

                If NoteType = 1 Then
                    PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
                    PrintDocument1.Print()
                ElseIf NoteType = 2 Then
                    PrintDocument2.PrinterSettings = PrintDialog1.PrinterSettings
                    PrintDocument2.Print()
                ElseIf NoteType = 3 Then
                    PrintDocument3.PrinterSettings = PrintDialog1.PrinterSettings
                    PrintDocument3.Print()
                End If

            End If
        Else
            MsgBox("A note must be generated before it can be printed.", MsgBoxStyle.Information, "Please Generate Note")
        End If
EndPrintSub:
    End Sub

    Private Sub SetNoteType()

        If RadButInitial.Checked = True Then
            NoteType = 1
        ElseIf RadButExtInt.Checked = True Then
            NoteType = 2
        ElseIf RadButFollow.Checked = True Then
            NoteType = 3
        Else
            NoteType = 0
        End If

    End Sub

    Private Sub RTBoxDir()

        If NoteType = 1 Then
            RTBoxText = "The following fields must contain data for the note to generate properly:  Drug and Gender must be selected; Height, ABW, Age, SCr, Dose to Use (initial dose tab), and Interval to Use (initial dose tab) must have data."
        ElseIf NoteType = 2 Then
            RTBoxText = "The following fields must contain data for the note to generate properly:  Drug must be either Tobramycin or Gentamicin; Gender must be selected; Height, ABW, Age, and SCr must have data."
        ElseIf NoteType = 3 Then
            RTBoxText = "The following fields must contain data for the note to generate properly:  Drug and Gender must be selected; Height, ABW, Age, SCr, Dose to Use (dose adjustment tab), Interval to Use (dose adjustment tab), Actual Peak, Actual Trough, Actual Dose, and Actual Interval must have data."
        ElseIf NoteType = 0 Then
            RTBoxText = " "
        End If

        RichTextBox1.Text = RTBoxText

    End Sub

    Private Sub RadButInitial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButInitial.Click
        SetNoteType()
        RTBoxDir()
    End Sub

    Private Sub RadButExtInt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButExtInt.Click
        SetNoteType()
        RTBoxDir()
    End Sub

    Private Sub RadButFollow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButFollow.Click
        SetNoteType()
        RTBoxDir()
    End Sub

    Private Sub CopyAllText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyAllText.Click
        RichTextBox1.SelectAll()
        RichTextBox1.Copy()
    End Sub

    'Private Sub LblHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If NeedsHelp = False Then
    '        Me.Cursor = Cursors.Help
    '        LblHelp.ForeColor = Color.Red
    '        NeedsHelp = True
    '        ToolTipEntry.Active = False
    '        ToolTipHelp.Active = True
    '        ToolTipHelp.SetToolTip(CboXDrug, "Drug selection is accomplished through a drop down box containing the drug" & Chr(13) _
    '        & "names.  When a drug is selected, the traditional Volume Constant (CV) for" & Chr(13) _
    '        & "that drug is automatically entered in the CV field.")
    '        ToolTipHelp.SetToolTip(GrpBoxCrCl, "Both Cockroft-Gault and Jelliffe methods of estimating creatinine clearance" & Chr(13) _
    '        & "are available for use in the calculator.  Cockroft-Gault is selected by default." & Chr(13) _
    '        & "Jelliffe is recommended in patients less than 60 in. tall.")
    '        ToolTipHelp.SetToolTip(RadButCCG, "Both Cockroft-Gault and Jelliffe methods of estimating creatinine clearance" & Chr(13) _
    '        & "are available for use in the calculator.  Cockroft-Gault is selected by default." & Chr(13) _
    '        & "Jelliffe is recommended in patients less than 60 in. tall.")
    '        ToolTipHelp.SetToolTip(RadButJelliffe, "Both Cockroft-Gault and Jelliffe methods of estimating creatinine clearance" & Chr(13) _
    '        & "are available for use in the calculator.  Cockroft-Gault is selected by default." & Chr(13) _
    '        & "Jelliffe is recommended in patients less than 60 in. tall.")
    '        ToolTipHelp.SetToolTip(GroupBox1, "Gender selection determines the methods the calculator uses.")
    '        ToolTipHelp.SetToolTip(RadButMale, "Gender selection determines the methods the calculator uses.")
    '        ToolTipHelp.SetToolTip(RadButFemale, "Gender selection determines the methods the calculator uses.")
    '        ToolTipHelp.SetToolTip(TxtABW, "Actual body weight is entered in kg.  The calculator automatically calculates" & Chr(13) _
    '        & "Ideal Body Weight (IBW) and determines the need for use of Adjusted Body" & Chr(13) _
    '        & "Weight and Dosing Weights for each drug and CrCl method.")
    '        ToolTipHelp.SetToolTip(TxtHeight, "Height is entered in inches.")
    '        ToolTipHelp.SetToolTip(TxtAge, "Age is entered in years.")
    '        ToolTipHelp.SetToolTip(TxtSCr, "Serum Creatinine is entered in mg/dL.  This field accepts decimal points.")
    '        ToolTipHelp.SetToolTip(TxtCV, "Volume Constant is in entered in L/kg.  The CV is automatically entered when the" & Chr(13) _
    '        & "drug is chosen.  In situations where a patient’s Volume of Distribution is affected by" & Chr(13) _
    '        & "co-existing conditions, the CV can be increased or decreased to take these conditions" & Chr(13) _
    '        & "into account.")
    '        ToolTipHelp.SetToolTip(TxtPeakDes, "Enter the desired peak value for that specific drug.  A warning window will appear if" & Chr(13) _
    '        & "the entered values are outside of traditional ranges for that drug; however, the entered" & Chr(13) _
    '        & "value will not be changed.  This is to allow for situations that occur outside of" & Chr(13) _
    '        & "traditional ranges.")
    '        ToolTipHelp.SetToolTip(TxtTroughDes, "Enter the desired trough value for that specific drug.  A warning window" & Chr(13) _
    '        & "will appear if the entered values are outside of traditional ranges for that drug; however," & Chr(13) _
    '        & "the entered value will not be changed.  This is to allow for situations that occur outside" & Chr(13) _
    '        & "of traditional ranges.")
    '        ToolTipHelp.SetToolTip(TxtInfusion, "Infusion time is the actual time of infusion entered in hours.  A standard" & Chr(13) _
    '        & "time of infusion is automatically entered for the chosen drug, but can be" & Chr(13) _
    '        & "changed for individual cases.")
    '        'ToolTipHelp.SetToolTip()
    '        'ToolTipHelp.SetToolTip()
    '        'ToolTipHelp.SetToolTip()
    '        'ToolTipHelp.SetToolTip()
    '        'ToolTipHelp.SetToolTip()
    '        'ToolTipHelp.SetToolTip()
    '        'ToolTipHelp.SetToolTip()
    '        'ToolTipHelp.SetToolTip()
    '        'ToolTipHelp.SetToolTip()
    '        'ToolTipHelp.SetToolTip()
    '        'ToolTipHelp.SetToolTip()
    '        'ToolTipHelp.SetToolTip()
    '        'ToolTipHelp.SetToolTip()
    '        'ToolTipHelp.SetToolTip()
    '        'ToolTipHelp.SetToolTip()
    '        'ToolTipHelp.SetToolTip()
    '        'ToolTipHelp.SetToolTip()
    '        'ToolTipHelp.SetToolTip()
    '        'ToolTipHelp.SetToolTip()
    '        'ToolTipHelp.SetToolTip()
    '        'ToolTipHelp.SetToolTip()
    '        'ToolTipHelp.SetToolTip()
    '        'ToolTipHelp.SetToolTip()
    '        'ToolTipHelp.SetToolTip()
    '        'ToolTipHelp.SetToolTip()
    '        'ToolTipHelp.SetToolTip()
    '        'ToolTipHelp.SetToolTip()
    '        'ToolTipHelp.SetToolTip()

    '    ElseIf NeedsHelp = True Then
    '        Me.Cursor = Cursors.Default
    '        LblHelp.ForeColor = Color.White
    '        NeedsHelp = False
    '        ToolTipHelp.Active = False
    '        ToolTipEntry.Active = True
    '    End If
    'End Sub

    Private Sub BtnOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOptions.Click
        My.Forms.FrmOptions.ShowDialog()
    End Sub

    Private Sub TxtDesPeak_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDesPeak.Leave
        DoItAll()
        If Not DesPeak = 0 Then
            If Drug = 1 Then
                If DesPeak < VP1 Or DesPeak > VP2 Then
                    MsgBox("The entered Peak is outside of traditional Vancomycin ranges", MsgBoxStyle.Critical, "Peak Out of Normal Range")
                End If
            ElseIf Drug = 2 Then
                If DesPeak < GP1 Or DesPeak > GP2 Then
                    MsgBox("The entered Peak is outside of traditional Gentamicin ranges", MsgBoxStyle.Critical, "Peak Out of Normal Range")
                End If
            ElseIf Drug = 3 Then
                If DesPeak < TP1 Or DesPeak > TP2 Then
                    MsgBox("The entered Peak is outside of traditional Tobramycin ranges", MsgBoxStyle.Critical, "Peak Out of Normal Range")
                End If
            End If
        End If
    End Sub

    Private Sub TxtDesTrough_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDesTrough.Leave
        DoItAll()
        If Not DesTrough = 0 Then
            If Drug = 1 Then
                If DesTrough < VT1 Or DesTrough > VT2 Then
                    MsgBox("The entered Trough is outside of traditional Vancomycin ranges", MsgBoxStyle.Critical, "Trough Out of Normal Range")
                End If
            ElseIf Drug = 2 Then
                If DesTrough < GT1 Or DesTrough > GT2 Then
                    MsgBox("The entered Trough is outside of traditional Gentamicin ranges", MsgBoxStyle.Critical, "Trough Out of Normal Range")
                End If
            ElseIf Drug = 3 Then
                If DesTrough < TT1 Or DesTrough > TT2 Then
                    MsgBox("The entered Trough is outside of traditional Tobramycin ranges", MsgBoxStyle.Critical, "Trough Out of Normal Range")
                End If
            End If
        End If
    End Sub

    Public Sub SetSettings()
        AOT = My.Settings.AlwaysOT
        SIT = My.Settings.ShowInTB
        SNI = My.Settings.ShowInNA
        VInf = My.Settings.VancInfuse
        VPDraw = My.Settings.VancPeakTime
        VTDraw = My.Settings.VancTroughTime
        VCV = My.Settings.VancCV
        VP1 = My.Settings.VancP1
        VP2 = My.Settings.VancP2
        VT1 = My.Settings.VancT1
        VT2 = My.Settings.VancT2
        TInf = My.Settings.TobInfuse
        TPDraw = My.Settings.TobPeakTime
        TTDraw = My.Settings.TobTroughTime
        TCV = My.Settings.TobCV
        TP1 = My.Settings.TobP1
        TP2 = My.Settings.TobP2
        TT1 = My.Settings.TobT1
        TT2 = My.Settings.TobT2
        GInf = My.Settings.GentInfuse
        GPDraw = My.Settings.GentPeakTime
        GTDraw = My.Settings.GentTroughTime
        GCV = My.Settings.GentCV
        GP1 = My.Settings.GentP1
        GP2 = My.Settings.GentP2
        GT1 = My.Settings.GentT1
        GT2 = My.Settings.GentT2
        ExtInt = My.Settings.ExtIntDose
        Q241 = My.Settings.Q241
        Q242 = My.Settings.Q242
        Q361 = My.Settings.Q361
        Q362 = My.Settings.Q362
        Q481 = My.Settings.Q481
        Q482 = My.Settings.Q482
        BGround = My.Settings.BGround
        Main = My.Settings.Main
        TextColor = My.Settings.Text
        Answers = My.Settings.Answers
        Buttons = My.Settings.Buttons
        Me.ShowInTaskbar = SIT
        Me.NotifyIcon1.Visible = SNI
        Me.TopMost = AOT
        Themerator()
    End Sub

    Private Sub Themerator()
        Me.ForeColor = TextColor
        Me.RichTextBox1.ForeColor = TextColor
        Me.BackColor = BGround
        Me.TabPageAdjust.BackColor = Main
        Me.TabPageDemo.BackColor = Main
        Me.TabPageInit.BackColor = Main
        Me.TabPageNote.BackColor = Main
        Me.BtnGo.BackColor = Buttons
        Me.BtnOptions.BackColor = Buttons
        Me.BtnPrintNote.BackColor = Buttons
        Me.BtnUnGo.BackColor = Buttons
        Me.BtnViewNote.BackColor = Buttons
        Me.RichTextBox1.BackColor = Buttons
        Me.LblBSA.ForeColor = Answers
        Me.LblCrCl.ForeColor = Answers
        Me.LblCrClStd.ForeColor = Answers
        Me.LblEstK.ForeColor = Answers
        Me.LblEstT05.ForeColor = Answers
        Me.LblEstVd.ForeColor = Answers
        Me.LblKtoUse.ForeColor = Answers
        Me.LblVdtoUse.ForeColor = Answers
        Me.LblActualK.ForeColor = Answers
        Me.LblActualVd.ForeColor = Answers
        Me.LblActualT05.ForeColor = Answers
        Me.LblIBW.ForeColor = Answers

    End Sub

    Private Sub FrmCalculator_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If My.Forms.FrmNoteData.Opened = 1 Then
            My.Forms.FrmNoteData.Close()
        End If
        My.Forms.FrmUserAgreement.Close()
    End Sub

    Private Sub FrmCalculator_SizeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.SizeChanged
        If Me.WindowState = FormWindowState.Minimized Then
            Hider()
        End If
    End Sub

End Class