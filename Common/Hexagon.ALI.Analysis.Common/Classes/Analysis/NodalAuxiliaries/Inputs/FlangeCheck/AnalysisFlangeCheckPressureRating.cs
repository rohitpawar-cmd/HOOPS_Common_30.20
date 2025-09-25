using Hexagon.ALI.Analysis.Common.Classes.Abstract;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.NodalAuxiliaries;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.NodalAuxiliaries.Inputs
{
    [DefUID("AnalysisFlangeCheckPressureRating")]
    public class AnalysisFlangeCheckPressureRating : AnalysisFlangeCheckVector, IAnalysisFlangeCheckPressureRating
    {
        public AnalysisFlangeCheckPressureRating()
        {
        }
        [NotMapped]
        public string Temperature
        {
            get;
            set;
        }
        [NotMapped]
        public string PressureRating
        {
            get;
            set;
        }

        public double? TemperatureSiValue
        {
            get;
            private set;
        }

        public double? PressureRatingSiValue
        {
            get;
            private set;
        }
        [RelDef()] public AnalysisFlangeCheckPeq AnalysisFlangeCheckPeq { get; set; }
        public string AnalysisFlangeCheckPeqId { get; set; }


        [NotMapped]
        public new string EvaluationMethod => AnalysisFlangeCheckPeq?.EvaluationMethod ?? "";

    }
}
