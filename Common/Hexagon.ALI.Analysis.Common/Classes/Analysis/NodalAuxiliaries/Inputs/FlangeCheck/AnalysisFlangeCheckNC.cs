using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.NodalAuxiliaries;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.NodalAuxiliaries.Inputs
{
    [DefUID("AnalysisFlangeCheckNC")]
    public class AnalysisFlangeCheckNC : AnalysisFlangeCheck, IAnalysisFlangeCheckNC
    {
        public AnalysisFlangeCheckNC()
        {
            EvaluationMethod = "NC-3658.3";
            FlangeVectors = FlangeCheckYieldStrength;
        }
        [NotMapped]
        public string BoltArea
        {
            get;
            set;
        }
        [NotMapped]
        public string BoltCircleDiameter
        {
            get;
            set;
        }

        public double? BoltAreaSiValue
        {
            get;
            private set;
        }

        public double? BoltCircleDiameterSiValue
        {
            get;
            private set;
        }

        public List<AnalysisFlangeCheckYieldStrength> FlangeCheckYieldStrength { get; set; } =
            new List<AnalysisFlangeCheckYieldStrength>();
    }
}
