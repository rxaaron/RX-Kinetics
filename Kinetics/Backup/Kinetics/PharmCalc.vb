Public Class PharmCalc

    Public Function RoundToSignificance(ByVal number As Integer, _
        ByVal roundtonearest As Integer) As Integer
        'Round number up or down to the nearest multiple of significance
        Dim d As Double
        d = number / roundtonearest
        d = Math.Round(d, 0)
        RoundToSignificance = d * roundtonearest
    End Function

    Public Function TOneHalf(ByVal K As Double) As Double
        TOneHalf = 0.693 / K
    End Function

    Public Function GentKEst(ByVal CrCl As Double) As Double
        GentKEst = (0.00293 * CrCl) + 0.014
    End Function

    Public Function TobraKEst(ByVal CrClStd As Double) As Double
        TobraKEst = (0.00293 * CrClStd) + 0.014
    End Function

    Public Function VancKEst(ByVal CrCl As Double) As Double
        VancKEst = (0.00083 * CrCl) + 0.004
    End Function

    Public Function VdCalc(ByVal VolumeConstant As Double, ByVal PtWeightinKg As Double) As Double
        VdCalc = VolumeConstant * PtWeightinKg
    End Function

    Public Function CrClStd(ByVal CrCl As Double, ByVal BSA As Double) As Double
        CrClStd = CrCl * (1.73 / BSA)
    End Function

    Public Function BSACalc(ByVal ABW As Double, ByVal PtHeightinInches As Double) As Double
        BSACalc = System.Math.Sqrt((ABW * (2.54 * PtHeightinInches)) / 3600)
    End Function

    Public Function IBWMale(ByVal PtHeightinInches As Double) As Double
        IBWMale = 50 + (2.3 * (PtHeightinInches - 60))
    End Function

    Public Function IBWFemale(ByVal PtHeightinInches As Double) As Double
        IBWFemale = 45.5 + (2.3 * (PtHeightinInches - 60))
    End Function

    Public Function CCGMale(ByVal PtAge As Double, ByVal Weight As Double, ByVal SCr As Double) As Double
        CCGMale = (((140 - PtAge) * Weight) / (72 * SCr))
    End Function

    Public Function CCGFemale(ByVal PtAge As Double, ByVal Weight As Double, ByVal SCr As Double) As Double
        CCGFemale = (((140 - PtAge) * Weight) / (72 * SCr)) * 0.85
    End Function

    Public Function JelliffeMale(ByVal PtAge As Double, ByVal SCr As Double, ByVal BSA As Double) As Double
        JelliffeMale = (((98 - (0.8 * (PtAge - 20))) / SCr) * (BSA / 1.73))
    End Function

    Public Function JelliffeFemale(ByVal PtAge As Double, ByVal SCr As Double, ByVal BSA As Double) As Double
        JelliffeFemale = (((98 - (0.8 * (PtAge - 20))) / SCr) * (BSA / 1.73)) * 0.9
    End Function

    Public Function AgExtIntDose(ByVal DosingWeight As Double) As Integer
        AgExtIntDose = My.Forms.FrmCalculator.ExtInt * DosingWeight
    End Function

    Public Function AgExtIntInterval(ByVal CrClStd As Double) As Double
        Select Case CrClStd
            Case My.Forms.FrmCalculator.Q241 To My.Forms.FrmCalculator.Q242
                AgExtIntInterval = 24
            Case My.Forms.FrmCalculator.Q361 To My.Forms.FrmCalculator.Q362
                AgExtIntInterval = 36
            Case My.Forms.FrmCalculator.Q481 To My.Forms.FrmCalculator.Q482
                AgExtIntInterval = 48
        End Select
    End Function

    Public Function CalculateInterval(ByVal DesiredTrough As Double, ByVal DesiredPeak As Double, _
    ByVal EstimatedK As Double, ByVal TimetoPeak As Double) As Integer
        CalculateInterval = ((System.Math.Log(DesiredTrough / DesiredPeak)) / (0 - EstimatedK)) + TimetoPeak
    End Function

    Public Function CalculateDose(ByVal DesiredPeak As Double, ByVal VolumeOfDistribution As Double, _
    ByVal EstimatedK As Double, ByVal DoseInterval As Integer, ByVal TimeofInfusion As Double, _
    ByVal TimetoPeak As Double) As Double
        CalculateDose = ((DesiredPeak * VolumeOfDistribution * EstimatedK * (1 - System.Math.Exp((0 - EstimatedK) * _
        DoseInterval)) * TimeofInfusion) / ((1 - System.Math.Exp((0 - EstimatedK) * TimeofInfusion)) * _
        System.Math.Exp((0 - EstimatedK) * (TimetoPeak - TimeofInfusion))))
    End Function

    Public Function PredictPeak(ByVal DoseUsed As Double, ByVal TimeofInfusion As Double, ByVal EstimatedK As Double, _
    ByVal TimetoPeak As Double, ByVal VolumeOfDistribution As Double, ByVal IntervalUsed As Integer) As Double
        PredictPeak = ((DoseUsed / TimeofInfusion) * (1 - System.Math.Exp((0 - EstimatedK) * TimeofInfusion)) * _
        System.Math.Exp((0 - EstimatedK) * (TimetoPeak - TimeofInfusion))) / (VolumeOfDistribution * EstimatedK * _
        (1 - System.Math.Exp((0 - EstimatedK) * IntervalUsed)))
    End Function

    Public Function PredictTrough(ByVal PredictedPeak As Double, ByVal EstimatedK As Double, ByVal IntervalUsed As Double, _
    ByVal TimeofInfusion As Double, ByVal TimetoPeak As Double) As Double
        PredictTrough = (PredictedPeak * System.Math.Exp((0 - EstimatedK) * (IntervalUsed - TimetoPeak)))
    End Function

    Public Function ActualK(ByVal ActualPeak As Double, ByVal ActualTrough As Double, ByVal ActualInterval As Double, _
    ByVal TimetoPeak As Double, ByVal TimefromEndtoTrough As Double) As Double
        ActualK = (System.Math.Log(ActualPeak / ActualTrough)) / (ActualInterval - TimetoPeak - _
        TimefromEndtoTrough)
    End Function

    Public Function ActualVolumeofDistribution(ByVal ActualDose As Double, ByVal TimeofInfusion As Double, _
    ByVal ActualK As Double, ByVal TimetoPeak As Double, ByVal ActualPeak As Double, ByVal ActualInterval As Double) As Double
        ActualVolumeofDistribution = ((ActualDose / TimeofInfusion) * (1 - (System.Math.Exp((0 - ActualK) * TimeofInfusion))) _
        * (System.Math.Exp((0 - ActualK) * (TimetoPeak - TimeofInfusion)))) / (ActualPeak * ActualK * (1 - _
        (System.Math.Exp((0 - ActualK) * ActualInterval))))
    End Function


End Class
