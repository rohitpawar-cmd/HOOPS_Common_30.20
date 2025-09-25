using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Classes.SIO;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis
{
    [DefUID("AnalysisNode")]
    public class AnalysisNode : AnalysisBaseObject, ILocation, IAnalysisNode
    {
        public AnalysisNode()
        {
        }
        [RelDef()] public PipingSystem PipingSystem { get; set; }
        public List<AnalysisNodeAuxiliary> OwnsAnalysisNodeAuxiliaries { get; set; } = new List<AnalysisNodeAuxiliary>();
        public int? Flags { get; set; }
        public bool IsLogical { get; set; } = false;
        public int InputNodeOrder { get; set; }
        public string NodeNumber { get; set; }
        [NotMapped]
        public string LocationX { get; set; }
        [NotMapped]
        public string LocationY { get; set; }
        [NotMapped]
        public string LocationZ { get; set; }
        public double? LocationXSiValue { get; private set; }
        public double? LocationYSiValue { get; private set; }
        public double? LocationZSiValue { get; private set; }
        [RelDef()]
        public List<AnalysisLineElement> AnalysisLineElementOwners { get; set; } = new List<AnalysisLineElement>();
        [RelDef()]
        [NotMapped]
        public List<dynamic> AnalysisTee { get; set; } = new List<dynamic>();
        public override string ToString()
        {
            var num = NodeNumber ?? "";
            return $"Node {num}";
        }

        public bool HasCoordinates() => LocationXSiValue != null || LocationYSiValue != null || LocationZSiValue != null;
    }
}