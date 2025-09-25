using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.LoadCase;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.Primitives;
using Hexagon.ALI.Analysis.Common.Classes.SIO;
using Hexagon.ALI.Analysis.Common.Helpers;
using System.Collections.Generic;

namespace Hexagon.ALI.Analysis.Common.Interfaces
{
    public interface IAnalysisLoadCase
    {
        PipingSystem PipingSystem { get; set; }
        string PipingSystemId { get; set; }

        [RelDef("AnalysisLoadCaseToNodeAuxiliary")]
        List<AnalysisNodeAuxiliaryOutput> NodeAuxiliaries { get; set; }

        [RelDef("AnalysisLoadCaseDefinition")]
        AnalysisLoadCaseDefinition LoadCaseDefinition { get; }

        [RelDef("AltSustained")]
        AnalysisLoadCase AltSustained { get; set; }

        [PPMProperty("LoadCaseNumber", "IAnalysisLoadCase")]
        int LoadCaseNumber { get; set; }

        [PPMProperty("LoadCaseName", "IAnalysisLoadCase")]
        string LoadCaseName { get; set; }
    }
}
