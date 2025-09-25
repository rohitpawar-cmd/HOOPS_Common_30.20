using Hexagon.ALI.Analysis.Common.Classes.Analysis;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.LineElements;
using Hexagon.ALI.Analysis.Common.Helpers;
using System.Collections.Generic;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis
{
    public interface IAnalysisPipeProperty
    {
        List<AnalysisPipe> AnalysisPipes { get; set; }

        [PPMProperty("NominalDiameter", "IAnalysisPipeProperty")]
        string NominalDiameter { get; set; }

        [UoM("LengthUoM")]
        [PPMProperty("OutsideDiameter", "IAnalysisPipeProperty")]
        string OutsideDiameter { get; set; }

        [PPMProperty("ScheduleThickness", "IAnalysisPipeProperty")]
        string ScheduleThickness { get; set; }

        [UoM("ThicknessUoM")]
        [PPMProperty("WallThickness", "IAnalysisPipeProperty")]
        string WallThickness { get; set; }

        [PPMProperty("SeamWelded", "IAnalysisPipeProperty")]
        bool? SeamWelded { get; set; }

        [PPMProperty("WTFactor", "IAnalysisPipeProperty")]
        double? WIFactor { get; set; }

        [PPMProperty("OvalityAllowance", "IAnalysisPipeProperty")]
        double? OvalityAllowance { get; set; }

        [PPMProperty("PositiveMillTolerance", "IAnalysisPipeProperty")]
        double? PositiveMillTolerance { get; set; }

        [PPMProperty("NegativeMillTolerance", "IAnalysisPipeProperty")]
        double? NegativeMillTolerance { get; set; }

        [PPMProperty("TVarAllowance", "IAnalysisPipeProperty")]
        double? TVarAllowance { get; set; }

        [UoM("ThicknessUoM")]
        [PPMProperty("Corrosion", "IAnalysisPipeProperty")]
        string Corrosion { get; set; }
        double? OutsideDiameterSiValue { get; }
        double? WallThicknessSiValue { get; }
        double? CorrosionSiValue { get; }
    }
}
