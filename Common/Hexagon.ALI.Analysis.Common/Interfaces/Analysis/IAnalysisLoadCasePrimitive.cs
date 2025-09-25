using Hexagon.ALI.Analysis.Common.Classes.Analysis.LoadCase;
using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis
{
    public interface IAnalysisLoadCasePrimitive
    {
        [RelDef("LoadCase", true)]
        AnalysisLoadCase LoadCase { get; set;  }
    }
}
