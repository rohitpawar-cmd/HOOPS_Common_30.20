using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.LineElements
{
    public interface IAnalysisExpansionJoint
    {
        [UoM("TranslationalUoM")]
        [PPMProperty("AxialStiffness", "IAnalysisExpansionJoint")]
        string AxialStiffness
        {
            get;
            set;
        }

        double? AxialStiffnessSiValue
        {
            get;
        }

        [UoM("TranslationalUoM")]
        [PPMProperty("TransverseStiffness", "IAnalysisExpansionJoint")]
        string TransverseStiffness
        {
            get;
            set;
        }

        double? TransverseStiffnessSiValue
        {
            get;
        }

        [UoM("RotationalStiffnessUoM")]
        [PPMProperty("BendingStiffness", "IAnalysisExpansionJoint")]
        string BendingStiffness
        {
            get;
            set;
        }

        double? BendingStiffnessSiValue
        {
            get;
        }

        [UoM("RotationalStiffnessUoM")]
        [PPMProperty("TorsionalStiffness", "IAnalysisExpansionJoint")]
        string TorsionalStiffness
        {
            get;
            set;
        }

        double? TorsionalStiffnessSiValue
        {
            get;
        }

        [UoM("LengthUoM")]
        [PPMProperty(nameof(EffectiveId), nameof(IAnalysisExpansionJoint))]
        string EffectiveId
        {
            get;
            set;
        }

        double? EffectiveIdSiValue
        {
            get;
        }
    }
}
