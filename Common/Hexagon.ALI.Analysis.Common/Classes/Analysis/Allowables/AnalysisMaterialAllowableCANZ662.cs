using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Allowables;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.Allowables
{
    [DefUID("AnalysisMaterialAllowableCANZ662")]
    public class AnalysisMaterialAllowableCANZ662 : AnalysisMaterial, IAnalysisMaterialAllowableCANZ662
    {
        public AnalysisMaterial Material { get; set; }

        public string AnalysisMaterialId { get; set; }
        public double? LocationFactor { get; set; }
        public double? TemperatureDeratingFactor { get; set; }
        public double? ConditionADesignFactor { get; set; }
        public double? ConditionBDesignFactor { get; set; }
        public double? LongitudinalWeldJointEfficiency { get; set; }
        public double? RestrainedFactor { get; set; }
        public double? MinimumYieldStrength { get; set; }
    }
}
