using Hexagon.ALI.Analysis.Common.Classes.Analysis;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.VectorAuxiliaries;
using Hexagon.ALI.Analysis.Common.Classes.SIO;
using Hexagon.ALI.Analysis.Common.Enums;
using Hexagon.ALI.Analysis.Common.Helpers;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.LineElements
{
    public interface IAnalysisLineElement
    {
        PipingSystem PipingSystem { get; set; }
        string PipingSystemId { get; set; }

        [PPMProperty(nameof(ParentID), nameof(IAnalysisLineElement))]
        string ParentID { get; set; }

        [PPMProperty(nameof(FromNodeID), nameof(IAnalysisLineElement))]
        string FromNodeID { get; set; }
        [PPMProperty(nameof(ToNodeID), nameof(IAnalysisLineElement))]
        string ToNodeID { get; set; }

        [PPMProperty(nameof(Flags), nameof(IAnalysisLineElement))]
        int? Flags { get; set; }

        [PPMProperty(nameof(InputElementOrderNumber), nameof(IAnalysisLineElement))]
        int? InputElementOrderNumber { get; set; }

        [PPMProperty(nameof(DynamicsElementOrderNumber), nameof(IAnalysisLineElement))]
        int? DynamicsElementOrderNumber { get; set; }

        [PPMProperty(nameof(StaticsElementOrderNumber), nameof(IAnalysisLineElement))]
        int? StaticsElementOrderNumber { get; set; }

        [PPMProperty(nameof(ElementType), nameof(IAnalysisLineElement))]
        AnalysisLineElementType ElementType { get; set; }

        [UoM("LengthUoM")]
        [PPMProperty(nameof(BaseDX), nameof(IAnalysisLineElement))]
        string BaseDX { get; set; }

        [UoM("LengthUoM")]
        [PPMProperty(nameof(BaseDY), nameof(IAnalysisLineElement))]
        string BaseDY { get; set; }

        [UoM("LengthUoM")]
        [PPMProperty(nameof(BaseDZ), nameof(IAnalysisLineElement))]
        string BaseDZ { get; set; }

        double? BaseDXSiValue { get; }
        double? BaseDYSiValue { get; }
        double? BaseDZSiValue { get; }

        [IgnoreDataMember] double? LengthSiValue { get; }


        #region REL DEFS        
        [RelDef("OwnsMaterial", true, false)]
        AnalysisMaterial OwnsMaterial { get; set; }

        [RelDef("AnalysisFlangeCheck", true, false)]
        AnalysisFlangeCheck AnalysisFlangeCheck { get; set; }

        [RelDef("AnalysisDensities", true, false)]
        AnalysisDensities AnalysisDensities { get; set; }

        [RelDef("AnalysisModelOrganization", true, false)]
        AnalysisModelOrganization AnalysisModelOrganization { get; set; }

        [RelDef("AnalysisWind", true, false)]
        AnalysisWind AnalysisWind { get; set; }

        [RelDef("AnalysisWave", true, false)]
        AnalysisWave AnalysisWave { get; set; }

        [RelDef("FromOffset")]
        AnalysisElementOffset FromOffset { get; set; }
        
        [RelDef("ToOffset")]
        AnalysisElementOffset ToOffset { get; set; }

        [RelDef("OwnsAnalysisNodes", true, false)]
        List<AnalysisNode> OwnsAnalysisNodes { get; set; }

        [RelDef("OwnsAnalysisProcessInfoDataSet", true, false)]
        List<AnalysisProcessInfo> OwnsAnalysisProcessInfoDataSet { get; set; }

        [RelDef("OwnsAnalysisUniformLoadDataSet", true, false)]
        List<AnalysisUniformLoadDataSet> OwnsAnalysisUniformLoadDataSet { get; set; }
        #endregion
    }
}