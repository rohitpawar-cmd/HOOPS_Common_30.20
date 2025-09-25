using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Allowables
{
    public interface IAnalysisMaterialAllowableDNV
    {
        [PPMProperty(nameof(SupplementaryRequirement), nameof(IAnalysisMaterialAllowableDNV))]
        bool? SupplementaryRequirement { get; set; }

        [PPMProperty(nameof(MaterialLuderPlateau), nameof(IAnalysisMaterialAllowableDNV))]
        bool? MaterialLuderPlateau { get; set; }

        [PPMProperty(nameof(StrainHardeningFactor), nameof(IAnalysisMaterialAllowableDNV))]
        double? StrainHardeningFactor { get; set; }

        [PPMProperty(nameof(FabricationStringResisteanceFactor), nameof(IAnalysisMaterialAllowableDNV))]
        double? FabricationStringResisteanceFactor { get; set; }

        [PPMProperty(nameof(BurstFailureOperation), nameof(IAnalysisMaterialAllowableDNV))]
        string BurstFailureOperation { get; set; }

        [PPMProperty(nameof(BurstFailureTesing), nameof(IAnalysisMaterialAllowableDNV))]
        string BurstFailureTesing { get; set; }

        [PPMProperty(nameof(CollapseFailure), nameof(IAnalysisMaterialAllowableDNV))]
        string CollapseFailure { get; set; }

        [PPMProperty(nameof(PropagationBuckling), nameof(IAnalysisMaterialAllowableDNV))]
        string PropagationBuckling { get; set; }

        [PPMProperty(nameof(LoadControlCondition), nameof(IAnalysisMaterialAllowableDNV))]
        string LoadControlCondition { get; set; }

        [PPMProperty(nameof(DisplacementControlledCondition), nameof(IAnalysisMaterialAllowableDNV))]
        string DisplacementControlledCondition { get; set; }

        [PPMProperty(nameof(LoadEffectFactor), nameof(IAnalysisMaterialAllowableDNV))]
        double? LoadEffectFactor { get; set; }

        [PPMProperty(nameof(GirthWeldStrainResisteanceFactor), nameof(IAnalysisMaterialAllowableDNV))]
        double? GirthWeldStrainResisteanceFactor { get; set; }

        [UoM("ForceUoM")]
        [PPMProperty(nameof(ReactionForce), nameof(IAnalysisMaterialAllowableDNV))]
        string ReactionForce { get; set; }

        [PPMProperty(nameof(PressureYieldingUsageFactor), nameof(IAnalysisMaterialAllowableDNV))]
        double? PressureYieldingUsageFactor { get; set; }

        [PPMProperty(nameof(PressureBurstingUsageFactor), nameof(IAnalysisMaterialAllowableDNV))]
        double? PressureBurstingUsageFactor { get; set; }

        [PPMProperty(nameof(EquivalentStressCheckUsageFactor), nameof(IAnalysisMaterialAllowableDNV))]
        double? EquivalentStressCheckUsageFactor { get; set; }


        #region SI VALUES
        double? ReactionForceSiValue { get; }
        #endregion
    }
}
