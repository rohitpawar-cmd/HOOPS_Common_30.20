using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Allowables;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.Allowables
{
    [DefUID("AnalysisMaterialAllowablePD8010")]
    public class AnalysisMaterialAllowablePD8010 : AnalysisMaterial, IAnalysisMaterialAllowablePD8010
    {
        public AnalysisMaterial Material { get; set; }

        public string AnalysisMaterialId { get; set; }
        public double? WeldJointFactor { get; set; }
        public double? RestrainedFactor { get; set; }

        [NotMapped]
        public string MinimumYieldStress { get; set; }
        public double? MinimumYieldStressSiValue { get; private set; }
        public double? DesignFactor { get; set; }
        public double? DesignFactorTable2 { get; set; }
    }
}
