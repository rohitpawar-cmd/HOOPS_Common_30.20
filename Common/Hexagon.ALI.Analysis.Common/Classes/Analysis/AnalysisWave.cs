using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis
{
    public class AnalysisWave : AnalysisBaseObject, IAnalysisWave
    {
        public double? DragCoefficient { get; set; }
        public double? AddedMassCoefficient { get; set; }
        public double? LiftCoefficient { get; set; }
        [NotMapped]
        public string MarineGrowthThickness { get; set; }
        public double? MarineGrowthThicknessSiValue { get; private set; }
        [NotMapped]
        public string MarineGrowthDensity { get; set; }
        public double? MarineGrowthDensitySiValue { get; private set; }
        public List<AnalysisLineElement> AnalysisLineElements { get; set; } = new List<AnalysisLineElement>();
    }
}
