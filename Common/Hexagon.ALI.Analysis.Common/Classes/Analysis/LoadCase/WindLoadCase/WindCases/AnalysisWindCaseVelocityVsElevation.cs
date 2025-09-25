using Hexagon.ALI.Analysis.Common.Classes.Analysis.VectorAuxiliaries;
using Hexagon.ALI.Analysis.Common.Enums.WindLoadEnums;
using System.Collections.Generic;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.LoadCase.WindLoadCase.WindCases
{
    public class AnalysisWindCaseVelocityVsElevation : AnalysisWindLoad
    {
        public AnalysisWindCaseVelocityVsElevation()
        {
            WindCode = WindCode.PvE;
        }
        List<WindVelocityVsElevation> WindVelocityVsElevations = new List<WindVelocityVsElevation>();
    }
}
