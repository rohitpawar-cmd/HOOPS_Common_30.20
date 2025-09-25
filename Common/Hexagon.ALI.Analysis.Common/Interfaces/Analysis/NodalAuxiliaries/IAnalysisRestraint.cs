using Hexagon.ALI.Analysis.Common.Enums;
using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.NodalAuxiliaries
{
    public interface IAnalysisRestraint
    {
        [PPMProperty("RestraintType", "IAnalysisRestraint")]
        RestraintType? RestraintType { get; set; }

        [UoM("TranslationalUoM")]
        [PPMProperty("Stiffness", "IAnalysisRestraint")]
        string Stiffness { get; set; }
        double? StiffnessSiValue { get; }

        [UoM("LengthUoM")]
        [PPMProperty("Gap", "IAnalysisRestraint")]
        string Gap { get; set; }
        double? GapSiValue { get; }

        [UoM("AngleUoM")]
        [PPMProperty("AngularGap", "IAnalysisRestraint")]
        string AngularGap { get; set; }
        double? AngularGapSiValue { get; }

        [PPMProperty("FrictionCoefficient", "IAnalysisRestraint")]
        double? FrictionCoefficient { get; set; }
        [PPMProperty("XDirectionCosine", "IAnalysisRestraint")]
        double? XDirectionCosine { get; set; }
        [PPMProperty("YDirectionCosine", "IAnalysisRestraint")]
        double? YDirectionCosine { get; set; }
        [PPMProperty("ZDirectionCosine", "IAnalysisRestraint")]
        double? ZDirectionCosine { get; set; }

        [UoM("LengthUoM")]
        [PPMProperty("RodLength", "IAnalysisRestraint")]
        string RodLength { get; set; }
        double? RodLengthSiValue { get; }

        [UoM("ForceUoM")]
        [PPMProperty("RodInitialLoadFi", "IAnalysisRestraint")]
        string RodInitialLoadFi { get; set; }
        double? RodInitialLoadFiSiValue { get; }

        [UoM("TranslationalUoM")]
        [PPMProperty("BiLinear2ndStiffnessK2", "IAnalysisRestraint")]
        string BiLinear2ndStiffnessK2 { get; set; }
        double? BiLinear2ndStiffnessK2SiValue { get; }

        [UoM("ForceUoM")]
        [PPMProperty("BiLinearYieldLoadFy", "IAnalysisRestraint")]
        string BiLinearYieldLoadFy { get; set; }
        double? BiLinearYieldLoadFySiValue { get; }

        [UoM("LengthUoM")]
        [PPMProperty("BottomOutSpringx", "IAnalysisRestraint")]
        string BottomOutSpringx { get; set; }
        double? BottomOutSpringxSiValue { get; }

        [UoM("ForceUoM")]
        [PPMProperty("BottomOutSpringF", "IAnalysisRestraint")]
        string BottomOutSpringF { get; set; }
        double? BottomOutSpringFSiValue { get; }

        [UoM("RotationalStiffnessUoM")]
        [PPMProperty("RotationalStiffness", "IAnalysisRestraint")]
        string RotationalStiffness { get; set; }
        double? RotationalStiffnessSiValue { get; }

        [UoM("RotationalStiffnessUoM")]
        [PPMProperty("BiRotational2ndStiffnessK2", "IAnalysisRestraint")]
        string BiRotational2ndStiffnessK2 { get; set; }
        double? BiRotational2ndStiffnessK2SiValue { get; }

        [UoM("MomentInputUoM")]
        [PPMProperty("BiRotationalYieldMoment", "IAnalysisRestraint")]
        string BiRotationalYieldMoment { get; set; }
        double? BiRotationalYieldMomentSiValue { get; }

        [UoM("TranslationalUoM")]
        [PPMProperty("BiRotational2ndStiffnessK2", "IAnalysisRestraint")]
        string BiLinearInitialStiffnessK1 { get; set; }
        double? BiLinearInitialStiffnessK1SiValue { get; }

        [UoM("RotationalStiffnessUoM")]
        [PPMProperty("BiRotationalInitialStiffnessK1", "IAnalysisRestraint")]
        string BiRotationalInitialStiffnessK1 { get; set; }
        double? BiRotationalInitialStiffnessK1SiValue { get; }
    }
}
