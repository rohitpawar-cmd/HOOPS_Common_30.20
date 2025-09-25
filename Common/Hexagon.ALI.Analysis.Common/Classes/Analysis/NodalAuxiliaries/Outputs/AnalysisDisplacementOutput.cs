using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.LoadCase;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.NodalAuxiliaries.Outputs
{
    [DefUID("AnalysisDisplacementOutput")]
    public class AnalysisDisplacementOutput : AnalysisNodeAuxiliaryOutput, IAnalysisDisplacement
    {
        public AnalysisDisplacementOutput(AnalysisNode node = null, AnalysisLoadCase loadCase = null) : base(node, loadCase)
        {
        }
        public AnalysisDisplacementOutput()
        {

        }
        public int? VectorNumber { get; set; }
        [NotMapped]
        public string DX { get; set; }

        public double? DXSiValue
        {
            get;
            private set;
        }
        [NotMapped]
        public string DY { get; set; }

        public double? DYSiValue
        {
            get;
            private set;
        }
        [NotMapped]
        public string DZ { get; set; }

        public double? DZSiValue
        {
            get;
            private set;
        }
        [NotMapped]
        public string RX { get; set; }

        public double? RXSiValue
        {
            get;
            private set;
        }
        [NotMapped]
        public string RY { get; set; }
        
        public double? RYSiValue
        {
            get;
            private set;
        }
        [NotMapped]
        public string RZ { get; set; }

        public double? RZSiValue
        {
            get;
            private set;
        }
    }
}