using Hexagon.ALI.Analysis.Common.Classes.SIO;

namespace Hexagon.ALI.Analysis.Common.Interfaces
{
    public interface IBranchEndPort
    {
        PipeRun PipeRun { get; set; }
        PipeRun RunEnd1 { get; set; }
        string RunEnd1Id { get; set; }
        PipeRun RunEnd2 { get; set; }
        string RunEnd2Id { get; set; }
    }
}