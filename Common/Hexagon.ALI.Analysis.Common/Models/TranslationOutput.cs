using Hexagon.ALI.Analysis.Common.Classes.SIO;

namespace Hexagon.ALI.Analysis.Common.Models
{
    public class TranslationOutput
    {
        public PipingSystem pipingSystem;
        public ExecutionMetadata ExecutionMetadata { get; set; } = new ExecutionMetadata();
    }
}
