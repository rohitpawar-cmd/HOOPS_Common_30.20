using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Allowables;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.Allowables
{
    [DefUID("AnalysisMaterialAllowableSwedishPowerCodeMethod1")]
    public class AnalysisMaterialAllowableSwedishPowerCodeMethod1 : AnalysisMaterial, IAnalysisMaterialAllowableSwedishPowerCodeMethod1
    {
        public AnalysisMaterial Material { get; set; }

        public string AnalysisMaterialId { get; set; }
        public double? CircumferentialJointFactor { get; set; }
        public double? StigmaMultiplier { get; set; }
        public double? BetaSeffCalculation { get; set; }
    }
}
