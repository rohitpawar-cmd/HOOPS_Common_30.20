using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.LineElements;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis
{
    [DefUID("AnalysisPipeProperty")]
    public class AnalysisPipeProperty : AnalysisBaseObject, IAnalysisPipeProperty
    {
        public AnalysisPipeProperty()
        {
        }
        
        public string ScheduleThickness { get; set; }
        public bool? SeamWelded { get; set; }
        public double? WIFactor { get; set; }
        public double? OvalityAllowance { get; set; }
        public double? PositiveMillTolerance { get; set; }
        public double? NegativeMillTolerance { get; set; }
        public double? TVarAllowance { get; set; }

        public double? OutsideDiameterSiValue { get; private set; }
        public double? WallThicknessSiValue { get; private set; }
        public double? CorrosionSiValue { get; private set; }


        [RelDef()] public List<AnalysisPipe> AnalysisPipes { get; set; } = new List<AnalysisPipe>();

        #region NOT MAPPED
        
        public string NominalDiameter { get; set; }

        
        public string OutsideDiameter { get; set; }

        
        public string WallThickness { get; set; }
        
        public string Corrosion { get; set; }
        #endregion
    }
}
