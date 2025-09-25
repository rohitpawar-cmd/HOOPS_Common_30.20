namespace Hexagon.ALI.Analysis.Common.Models
{
    public class ExecutionStatistics
    {
        public OutputTranslationTime OutputTranslationTime = new OutputTranslationTime();
        public InputTranslationTime InputTranslationTime = new InputTranslationTime();
        public double PersistencyTime { get; set; } = 0;
        public double TotalTranslationTime { get; set; } = 0;
        public int NumberOfObjects { get; set; } = 0;
        public int NumberOfRelations { get; set; } = 0;
        public double TranslateToPipingSystemTime { get; set; } = 0;
    }

}
