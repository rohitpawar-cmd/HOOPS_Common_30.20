using Hexagon.ALI.Analysis.Common.Classes.Analysis.NodalAuxiliaries.Inputs;
using Hexagon.ALI.Analysis.Common.Helpers;
using System.Collections.Generic;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.NodalAuxiliaries
{
    public interface IAnalysisFlangeCheckNC
    {
        [UoM("LengthUoM")]
        [PPMProperty("BoltArea", "IAnalysisFlangeCheckNC")]
        string BoltArea { get; set; }
        double? BoltAreaSiValue { get; }

        [UoM("DiameterUoM")]
        [PPMProperty("BoltCircleDiameter", "IAnalysisFlangeCheckNC")]
        string BoltCircleDiameter { get; set; }
        double? BoltCircleDiameterSiValue { get; }

        [RelDef("FlangeCheckYieldStrength", true)]
        List<AnalysisFlangeCheckYieldStrength> FlangeCheckYieldStrength { get; set; }
    }
}
