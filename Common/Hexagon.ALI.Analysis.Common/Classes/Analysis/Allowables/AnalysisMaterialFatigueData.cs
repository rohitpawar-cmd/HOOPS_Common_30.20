using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Allowables;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.Allowables
{
    [DefUID("AnalysisMaterialFatigueDataSet")]
    public class AnalysisMaterialFatigueDataSet : AnalysisBaseObject, IAnalysisMaterialFatigueDataSet
    {
        public string AnalysisMaterialId { get; set; }
        public AnalysisMaterial Material { get; set; }
        public int? Vector { get; set; }
        public double Cycles { get; set; }

        [NotMapped]
        public string Stress { get; set; }
        public double? StressSiValue { get; private set; }
        [NotMapped]
        public string MaterialName => Material?.DisplayName;

    }
}
