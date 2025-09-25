using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Outputs
{
    public interface IAnalysisGlobalForceMoments
    {
        [UoM("ForceUoM")]
        [PPMProperty(nameof(Axial), nameof(IAnalysisGlobalForceMoments))]
        string Axial
        {
            get;
            set;
        }

        double? AxialSiValue
        {
            get;
        }

        [UoM("ForceUoM")]
        [PPMProperty(nameof(Shear), nameof(IAnalysisGlobalForceMoments))]
        string Shear
        {
            get;
            set;
        }

        double? ShearSiValue
        {
            get;
        }

        [UoM("MomentOutputUoM", "MomentInputUoM")]
        [PPMProperty(nameof(Bending), nameof(IAnalysisGlobalForceMoments))]
        string Bending
        {
            get;
            set;
        }

        double? BendingSiValue
        {
            get;
        }

        [UoM("MomentOutputUoM", "MomentInputUoM")]
        [PPMProperty(nameof(Torsion), nameof(IAnalysisGlobalForceMoments))]
        string Torsion
        {
            get;
            set;
        }

        double? TorsionSiValue
        {
            get;
        }
    }
}
