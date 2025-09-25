using Hexagon.ALI.Analysis.Common.Classes.Analysis.VectorAuxiliaries;
using Hexagon.ALI.Analysis.Common.Enums.WindLoadEnums;
using System.Collections.Generic;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.LoadCase.WindLoadCase.WindCases
{
    public class AnalysisWindCasePressureVsElevation : AnalysisWindLoad
    {
        public AnalysisWindCasePressureVsElevation()
        {
            WindCode = WindCode.PvE;
        }

        List<WindPressureVsElevation> WindPressureVsElevations = new List<WindPressureVsElevation>();
    }    
}
