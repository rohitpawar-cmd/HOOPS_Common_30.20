using Hexagon.ALI.Analysis.Common.Classes.Analysis.VectorAuxiliaries;
using Hexagon.ALI.Analysis.Common.Enums.WindLoadEnums;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.LoadCase.WindLoadCase.WindCases
{
    public class AnalysisWindCaseUBC_1997 : AnalysisWindLoad, IAnalysisWindCaseUBC
    {
        public AnalysisWindCaseUBC_1997()
        {
            WindCode = WindCode.UBC;
            CodeYear = "1997";
        }
        [NotMapped]
        public string DesignWindSpeed { get; set; }
        public double? DesignWindSpeedSiValue { get; private set; }
        public double? ImportanceFactor { get; set; }
        public ExposureConstant ExposureConstant { get; set; }
        public double? StructuralDampingCoeff_Beta { get; set; }

    }
}
