using Hexagon.ALI.Analysis.Common.Classes.Analysis;
using Hexagon.ALI.Analysis.Common.Helpers;
using System.Runtime.Serialization;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.LineElements
{
    public interface IAnalysisReducer
    {
        [UoM("AngleUoM")]
        [PPMProperty("Alpha", "IAnalysisReducer")]
        string Alpha
        {
            get;
            set;
        }

        double? AlphaSiValue
        {
            get;
        }

        [UoM("LengthUoM")]
        [PPMProperty("R1", "IAnalysisReducer")]
        string R1
        {
            get;
            set;
        }

        double? R1SiValue
        {
            get;
        }

        [UoM("LengthUoM")]
        [PPMProperty("R2", "IAnalysisReducer")]
        string R2
        {
            get;
            set;
        }

        double? R2SiValue
        {
            get;
        }

        [UoM("LengthUoM")]
        [PPMProperty("L1", "IAnalysisReducer")]
        string L1
        {
            get;
            set;
        }

        double? L1SiValue
        {
            get;
        }

        [UoM("LengthUoM")]
        [PPMProperty("L2", "IAnalysisReducer")]
        string L2
        {
            get;
            set;
        }

        double? L2SiValue
        {
            get;
        }

        [RelDef("OwnsAnalysisPipePropertyEnd2", true, false)]
        AnalysisPipeProperty AnalysisPipePropertyEnd2 { get; set; }        

        [IgnoreDataMember] double? Diameter2SiValue { get; }
        [IgnoreDataMember] double? Thickness2SiValue { get; }
    }
}