using Hexagon.ALI.Analysis.Common.Classes.Analysis.Allowables;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.VectorAuxiliaries;
using Hexagon.ALI.Analysis.Common.Enums;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract
{
    public class AnalysisMaterial : AnalysisBaseObject, IAnalysisMaterial
    {
        public PipingCode PipingCode { get; set; }

        public int MaterialNumber { get; set; }

        public string MaterialName { get; set; }

        public double? PoissonsRatio { get; set; }
        [NotMapped]
        public string PipeDensity
        {
            get; set;
        }
        public double? PipeDensitySiValue { get; private set; }
        [NotMapped]
        public string YieldStress { get; set; }

        public double? YieldStressSiValue { get; private set; }

        public List<AnalysisAllowable> OwnsAllowables { get; set; } = new List<AnalysisAllowable>();

        public List<AnalysisLineElement> AnalysisLineElements { get; set; } = new List<AnalysisLineElement>();

        public List<AnalysisMaterialAllowableDataSet> OwnsAnalysisMaterialAllowableDataSet { get; set; } = new List<AnalysisMaterialAllowableDataSet>();

        public List<AnalysisMaterialFatigueDataSet> OwnsAnalysisMaterialFatigueDataSet { get; set; } = new List<AnalysisMaterialFatigueDataSet>();

        [NotMapped]
        public string DisplayName => $"({MaterialNumber}){MaterialName}";
    }
}
