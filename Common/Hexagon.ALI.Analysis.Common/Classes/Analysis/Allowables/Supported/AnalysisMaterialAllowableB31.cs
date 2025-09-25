using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Allowables;
using System.ComponentModel.DataAnnotations.Schema;
using Hexagon.ALI.Analysis.Common.Enums;
using System.ComponentModel;


namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.Allowables
{
    [DefUID("AnalysisMaterialAllowableB31")]
    public class AnalysisMaterialAllowableB31 : AnalysisAllowable, IAnalysisMaterialAllowableB31
    {
        public double? MinimumWallThicknessCalculation { get; set; }
        public DesignFactor? DesignFactor { get; set; }
        public double? HoopStressFactor { get; set; }
        public AllowableStressIndicator? AllowableStressIndicator { get; set; }
        [NotMapped]
        public string SpecifiedMinimumYieldStress { get; set; }
        public double? SpecifiedMinimumYieldStressSiValue { get; private set; }
        public double? CoefficientY { get; set; }
        public double? DesignFactorF { get; set; }
        public AllowableMaximumStressRange? AllowMaximumStressRangeFactor { get; set; }
        public bool? AppP { get; set; }
    }
}
