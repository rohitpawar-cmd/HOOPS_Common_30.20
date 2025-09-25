using Hexagon.ALI.Analysis.Common.Enums;
using Hexagon.ALI.Analysis.Common.Helpers;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.LineElements
{
    public interface IAnalysisBend
    {
        [UoM("LengthUoM")]
        [PPMProperty(nameof(Radius), nameof(IAnalysisBend))]
        string Radius
        {
            get;
            set;
        }
        [UoM("AngleUoM")]
        [PPMProperty(nameof(AngleB), nameof(IAnalysisBend))]
        string AngleB
        {
            get;
            set;
        }
        [UoM("LengthUoM")]
        [PPMProperty(nameof(SpaceBetweenCuts), nameof(IAnalysisBend))]
        string SpaceBetweenCuts
        {
            get;
            set;
        }
        [UoM("LengthUoM")]
        [PPMProperty(nameof(Tbend), nameof(IAnalysisBend))]
        string Tbend
        {
            get;
            set;
        }
        [PPMProperty("BendType", "IAnalysisBend")]
        BendType? BendType
        {
            get;
            set;
        }
        
        [PPMProperty(nameof(NumberOfMiterCuts), nameof(IAnalysisBend))]
        string NumberOfMiterCuts
        {
            get;
            set;
        }
        [PPMProperty(nameof(AxialModRatio), nameof(IAnalysisBend))]
        double? AxialModRatio //EpTp/(EbTb)
        {
            get;
            set;
        }
        double? TbendSiValue { get; }
        double? RadiusSiValue { get; }
        double? SpaceBetweenCutsSiValue { get; }
        double? AngleBSiValue { get; }
        [UoM("LengthUoM")]
        [PPMProperty("FittingThickness", "IAnalysisBend")]
        string FittingThickness
        {
            get;
            set;
        }

        double? FittingThicknessSiValue
        {
            get;
        }

        [PPMProperty(nameof(KFactorIn), "IAnalysisBend")]
        double KFactorIn
        {
            get;
            set;
        }
        [PPMProperty(nameof(KFactorOut), "IAnalysisBend")]
        double KFactorOut
        {
            get;
            set;
        }

        [UoM("LengthUoM")]
        [PPMProperty("OverlayThickness", "IAnalysisBend")]
        string OverlayThickness
        {
            get;
            set;
        }

        double? OverlayThicknessSiValue
        {
            get;
        }

        [PPMProperty("SeamWelded", "IAnalysisBend")]
        bool? SeamWelded
        {
            get;
            set;
        }

        [PPMProperty("WeldReductionFactor", "IAnalysisBend")]
        double? WeldReductionFactor
        {
            get;
            set;
        }

        [IgnoreDataMember] string BendNode1 { get; }
        [IgnoreDataMember] string BendNode2 { get; }
        [IgnoreDataMember] string BendNode3 { get; }
        [IgnoreDataMember] double? Angle1SiValue { get; }
        [IgnoreDataMember] double? Angle2SiValue { get; }
        [IgnoreDataMember] double? Angle3SiValue { get; }
    }

    public enum BendType
    {
        [Description("Single Flange")]
        SingleFlange = 1,
        [Description("Double Flange")]
        DoubleFlange = 2,
        [Description("CSM (Chopped Strand Mat)")]
        CSM = 3,
        [Description("CSM & Woven Roving")]
        CSM_AndWovenRoving = 4,
        [Description("CSM & Multi Filament")]
        CSM_AndMultiFilament = 5,
        [Description("Hand Lay")]
        HandLay = 6,
    }
}
