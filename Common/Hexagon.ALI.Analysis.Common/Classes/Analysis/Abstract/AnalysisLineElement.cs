using Hexagon.ALI.Analysis.Common.Classes.Analysis.VectorAuxiliaries;
using Hexagon.ALI.Analysis.Common.Classes.SIO;
using Hexagon.ALI.Analysis.Common.Enums;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.LineElements;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract
{
    [DefUID("AnalysisLineElement")]
    public abstract class AnalysisLineElement : AnalysisBaseObject, IAnalysisLineElement
    {
        public AnalysisLineElement()
        {
        }
        [RelDef()] public PipingSystem PipingSystem { get; set; }
        public string PipingSystemId { get; set; }
        public string ParentID { get; set; }
        public string FromNodeID { get; set; }
        public AnalysisNode FromNode { get; set; }
        public string ToNodeID { get; set; }
        public AnalysisNode ToNode { get; set; }
        public int? Flags { get; set; }
        public AnalysisLineElementType ElementType { get; set; }
        [NotMapped]
        public string BaseDX { get; set; }
        [NotMapped]
        public string BaseDY { get; set; }
        [NotMapped]
        public string BaseDZ { get; set; }

        public int? InputElementOrderNumber { get; set; }
        public int? DynamicsElementOrderNumber { get; set; }
        public int? StaticsElementOrderNumber { get; set; }

        #region SI VALUES
        public double? BaseDXSiValue { get; protected set; }
        public double? BaseDYSiValue { get; protected set; }
        public double? BaseDZSiValue { get; protected set; }
        #endregion

        #region REL DEFS
        public List<AnalysisNode> OwnsAnalysisNodes { get; set; } = new List<AnalysisNode>();
        public AnalysisWave AnalysisWave { get; set; }
        public AnalysisWind AnalysisWind { get; set; }
        public AnalysisDensities AnalysisDensities { get; set; }
        public AnalysisModelOrganization AnalysisModelOrganization { get; set; }
        public AnalysisMaterial OwnsMaterial { get; set; }
        public AnalysisFlangeCheck AnalysisFlangeCheck { get; set; }
        public AnalysisElementOffset FromOffset { get; set; }
        public string FromOffsetID { get; set; }
        public AnalysisElementOffset ToOffset { get; set; }
        public string ToOffsetID { get; set; }
        public List<AnalysisProcessInfo> OwnsAnalysisProcessInfoDataSet { get; set; } = new List<AnalysisProcessInfo>();
        public List<AnalysisUniformLoadDataSet> OwnsAnalysisUniformLoadDataSet { get; set; } = new List<AnalysisUniformLoadDataSet>();
        public List<AnalysisSifLineElement> OwnsAnalysisSIFs { get; set; } = new List<AnalysisSifLineElement>();

        #endregion

        [NotMapped]
        public List<AnalysisLineElement> Children { get; set; } = new List<AnalysisLineElement>();

        #region Helper Properties
        [NotMapped] public double? LengthSiValue => Math.Sqrt(Math.Pow(BaseDXSiValue ?? 0, 2) + Math.Pow(BaseDYSiValue ?? 0, 2) + Math.Pow(BaseDZSiValue ?? 0, 2));
        #endregion

        public override string ToString()
        {
            return string.IsNullOrEmpty(Name) ? $"Element {FromNode.NodeNumber}-{ToNode.NodeNumber}" : Name;
        }

    }

}