using Hexagon.ALI.Analysis.Common.Classes.Analysis;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.LineElements;
using Hexagon.ALI.Analysis.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Xml.Linq;

namespace Hexagon.ALI.Analysis.Common.Helpers
{
    public class BendNode : IBendNode
    {
        public BendNode(string angle, AnalysisNode node, AnalysisBend bend) 
        {
            Angle = angle;
            AnalysisNode = node;
            AnalysisBend = bend;
        }
        public BendNode() { }

        public AnalysisBend AnalysisBend { get; set; }
        public string AnalysisBendID { get; set; }
        public AnalysisNode AnalysisNode { get; set; }
        public string AnalysisNodeID { get; set; }
        [NotMapped]
        public string Angle { get; set; }
        public double? AngleSiValue { get; protected set; }
    }
}
