using Hexagon.ALI.Analysis.Common.Helpers;
using System.ComponentModel;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.SIF
{
    public interface IAnalysisCommonTee
    {
        [PPMProperty("CommonTeeWeldID", "IAnalysisCommonTee")]
        CommonTeeWeld? CommonTeeWeldID { get; set; }

        [UoM("LengthUoM")]
        [PPMProperty("FittingOutsideRadius", "IAnalysisCommonTee")]
        string FittingOutsideRadius { get; set; }
        double? FittingOutsideRadiusSiValue { get; }

        [UoM("LengthUoM")]
        [PPMProperty("FittingCrotchRadius", "IAnalysisCommonTee")]
        string FittingCrotchRadius { get; set; }
        double? FittingCrotchRadiusSiValue { get; }

        [UoM("LengthUoM")]
        [PPMProperty("FittingCrotchThickness", "IAnalysisCommonTee")]
        string FittingCrotchThickness { get; set; }
        double? FittingCrotchThicknessSiValue { get; }

        [UoM("LengthUoM")]
        [PPMProperty("EncirclementPadSaddleThickness", "IAnalysisCommonTee")]
        string EncirclementPadSaddleThickness { get; set; }
        double? EncirclementPadSaddleThicknessSiValue { get; }
    }

    public enum CommonTeeWeld
    {
        [Description("0 - As Welded")]
        AsWelded = 0,
        [Description("1 - Finished/Ground Flush")]
        Finished = 1,
    }
}
