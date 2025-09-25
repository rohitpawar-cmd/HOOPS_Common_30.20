using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.NodalAuxiliaries;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.NodalAuxiliaries.Inputs
{
    [DefUID("AnalysisFlangeCheckPeq")]
    public class AnalysisFlangeCheckPeq : AnalysisFlangeCheck, IAnalysisFlangeCheckPeq
    {
        public AnalysisFlangeCheckPeq()
        {
            EvaluationMethod = "Peq";
            FlangeVectors = FlangeCheckPressureRating;
        }
        public string FlangeClass
        {
            get;
            set;
        }
        [NotMapped]
        public string GasketDiameter
        {
            get;
            set;
        }
        public double? GasketDiameterSiValue
        {
            get;
            private set;
        }

        public List<AnalysisFlangeCheckPressureRating> FlangeCheckPressureRating { get; set; } =
            new List<AnalysisFlangeCheckPressureRating>();
    }
}
