using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.LineElements;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.LineElements
{
    [DefUID("AnalysisSubBend")]
    public class AnalysisSubBend : AnalysisPipe, IAnalysisBendTangent
    {
        [NotMapped]
        public string Tangent1X { get; set; }
        [NotMapped]
        public string Tangent1Y { get; set; }
        [NotMapped]
        public string Tangent1Z { get; set; }
        [NotMapped]
        public string Tangent2X { get; set; }
        [NotMapped]
        public string Tangent2Y { get; set; }
        [NotMapped]
        public string Tangent2Z { get; set; }

        public double? Tangent1XSiValue { get; set; }
        public double? Tangent1YSiValue { get; set; }
        public double? Tangent1ZSiValue { get; set; }
        public double? Tangent2XSiValue { get; set; }
        public double? Tangent2YSiValue { get; set; }
        public double? Tangent2ZSiValue { get; set; }

        public override string ToString()
        {
            return string.IsNullOrEmpty(Name) ? base.ToString().Replace("Element", "Sub Bend") : Name;
        }
    }
}
