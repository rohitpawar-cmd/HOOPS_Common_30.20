using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis
{
    public class AnalysisDensities : AnalysisBaseObject, IAnalysisDensities
    {
        [NotMapped]
        public string RefractoryThickness { get; set; }
        public double? RefractoryThicknessSiValue { get; private set; }
        [NotMapped]
        public string RefractoryDensity { get; set; }
        public double? RefractoryDensitySiValue { get; private set; }
        [NotMapped]
        public string InsulationThickness { get; set; }
        public double? InsulationThicknessSiValue { get; private set; }
        [NotMapped]
        public string CladdingThickness { get; set; }
        public double? CladdingThicknessSiValue { get; private set; }
        [NotMapped]
        public string InsulationDensity { get; set; }
        public double? InsulationDensitySiValue { get; private set; }
        [NotMapped]
        public string CladdingDensity { get; set; }
        public double? CladdingDensitySiValue { get; private set; }
        [NotMapped]
        public string Insulation_CladdingUnitWeight { get; set; }
        public double? Insulation_CladdingUnitWeightSiValue { get; private set; }
        public List<AnalysisLineElement> AnalysisLineElements { get; set; } = new List<AnalysisLineElement>();
    }
}
