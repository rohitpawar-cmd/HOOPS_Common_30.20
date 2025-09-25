namespace Hexagon.ALI.Analysis.Common.Models
{
    public class ExecutionMetadata
    {
        public bool PushGraphics = true;
        public ExecutionStatistics ExecutionStatistics { get; set; } = new ExecutionStatistics();

        public string OutputFilePath { get; set; } = string.Empty;
    }
}
