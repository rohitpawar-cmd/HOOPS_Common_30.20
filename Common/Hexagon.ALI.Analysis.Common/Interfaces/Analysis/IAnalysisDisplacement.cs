using Hexagon.ALI.Analysis.Common.Classes.Analysis.NodalAuxiliaries.Inputs.NozzleFlex;
using Hexagon.ALI.Analysis.Common.Helpers;
using System.Collections.Generic;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis
{
    public interface IAnalysisDisplacement
    {
        [UoM("LengthUoM")]
        [PPMProperty("DX", "IAnalysisDisplacement")]
        string DX { get; set; }
        double? DXSiValue { get; }

        [UoM("LengthUoM")]
        [PPMProperty("DY", "IAnalysisDisplacement")]
        string DY { get; set; }
        double? DYSiValue { get; }

        [UoM("LengthUoM")]
        [PPMProperty("DZ", "IAnalysisDisplacement")]
        string DZ { get; set; }
        double? DZSiValue { get; }

        [UoM("AngleUoM")]
        [PPMProperty("RX", "IAnalysisDisplacement")]
        string RX { get; set; }
        double? RXSiValue { get; }

        [UoM("AngleUoM")]
        [PPMProperty("RY", "IAnalysisDisplacement")]
        string RY { get; set; }
        double? RYSiValue { get; }

        [UoM("AngleUoM")]
        [PPMProperty("RZ", "IAnalysisDisplacement")]
        string RZ { get; set; }
        double? RZSiValue { get; }
    }
}
