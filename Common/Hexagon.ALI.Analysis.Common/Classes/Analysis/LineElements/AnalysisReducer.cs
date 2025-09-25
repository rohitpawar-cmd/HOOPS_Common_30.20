using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.LineElements;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.LineElements
{
    [DefUID("AnalysisReducer")]
    public class AnalysisReducer : AnalysisPipe, IAnalysisReducer
    {
        public AnalysisReducer()
        {
        }

        [NotMapped]
        public string Alpha { get; set; }
        
        [NotMapped]
        public string R1 { get; set; }
        
        [NotMapped]
        public string R2 { get; set; }
        
        [NotMapped]
        public string L1 { get; set; }
        
        [NotMapped]
        public string L2 { get; set; }

        public double? AlphaSiValue { get; private set; }
        public double? R1SiValue { get; private set; }
        public double? R2SiValue { get; private set; }
        public double? L1SiValue { get; private set; }
        public double? L2SiValue { get; private set; }

        public AnalysisPipeProperty AnalysisPipePropertyEnd2 { get; set; }
        public string AnalysisPipePropertyEnd2Id { get; set; }      

        #region Helper Properties
        [NotMapped] public double? Diameter2SiValue => AnalysisPipePropertyEnd2?.OutsideDiameterSiValue;
        [NotMapped] public double? Thickness2SiValue => AnalysisPipePropertyEnd2?.WallThicknessSiValue;
        #endregion

        public override string ToString()
        {
            return string.IsNullOrEmpty(Name) ? base.ToString().Replace("Element", "Reducer") : Name;
        }
    }
}