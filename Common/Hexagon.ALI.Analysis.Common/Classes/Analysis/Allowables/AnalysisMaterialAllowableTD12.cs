using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Allowables;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.Allowables
{
    [DefUID("AnalysisMaterialAllowableTD12")]
    public class AnalysisMaterialAllowableTD12 : AnalysisMaterial, IAnalysisMaterialAllowableTD12
    {
        public AnalysisMaterial Material { get; set; }

        public string AnalysisMaterialId { get; set; }
        public double? SystemDesignFactor { get; set; }
        public double? MaterialShakedownFactor { get; set; }
    }
}
