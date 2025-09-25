using Hexagon.ALI.Analysis.Common.Classes.Analysis.NodalAuxiliaries.Inputs;
using Hexagon.ALI.Analysis.Common.Helpers;
using System.Collections.Generic;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.NodalAuxiliaries
{
    public interface IAnalysisFlangeCheckPeq
    {
        [UoM("DiameterUoM")]
        [PPMProperty("GasketDiameter", "IAnalysisFlangeCheckKellogg")]
        string GasketDiameter { get; set; }
        double? GasketDiameterSiValue { get; }

        [RelDef("FlangeCheckPressureRating", true)]
        List<AnalysisFlangeCheckPressureRating> FlangeCheckPressureRating { get; set; }
    }
}
