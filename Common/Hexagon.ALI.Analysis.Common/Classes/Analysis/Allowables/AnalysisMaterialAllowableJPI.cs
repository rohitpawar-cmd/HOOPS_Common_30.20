using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Allowables;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.Allowables
{
    [DefUID("AnalysisMaterialAllowableJPI")]
    public class AnalysisMaterialAllowableJPI : AnalysisMaterial, IAnalysisMaterialAllowableJPI
    {
        public AnalysisMaterial Material { get; set; }

        public string AnalysisMaterialId { get; set; }
        public double? LongitudinaWeldJointEfficiency { get; set; }
        public string CompositionType { get; set; }
    }
}
