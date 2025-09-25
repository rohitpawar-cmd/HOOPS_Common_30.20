using Hexagon.ALI.Analysis.Common.Enums;
using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.SIF
{
    public interface IAnalysisSpecialJoint
    {
        [PPMProperty("SIFType", "IAnalysisSpecialJoint")]
        SIFType? SIFType { get; set; }

        [UoM("LengthUoM")]
        [PPMProperty("SocketFilletLength", "IAnalysisSpecialJoint")]
        string SocketFilletLength { get; set; }
        double? SocketFilletLengthSiValue { get; }

        [UoM("LengthUoM")]
        [PPMProperty("MaximumCircumferentialWeldMismatch", "IAnalysisSpecialJoint")]
        string MaximumCircumferentialWeldMismatch { get; set; }
        double? MaximumCircumferentialWeldMismatchSiValue { get; }

        [UoM("LengthUoM")]
        [PPMProperty("AverageCircumferentialWeldMismatch", "IAnalysisSpecialJoint")]
        string AverageCircumferentialWeldMismatch
        { get; set; }
        double? AverageCircumferentialWeldMismatchSiValue { get; }

        [PPMProperty("WeldStrFactWc", "IAnalysisSpecialJoint")]
        double? WeldStrFactWc { get; set; }
    }

    public enum SIFType
    {
    }
}
