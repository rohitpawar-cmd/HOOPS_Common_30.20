using System.Diagnostics.CodeAnalysis;

namespace Hexagon.ALI.Analysis.Common.Enums
{
    [ExcludeFromCodeCoverage]
    public class AnalysisHgrMultiLoadCaseOption : SIOEnum
    {
        #region VALUES                
        public static readonly AnalysisHgrMultiLoadCaseOption OperatingCase1 = new AnalysisHgrMultiLoadCaseOption("a7d45ec0-8fce-49f7-b64c-cc0842a74761", "OperatingCase1", "Designs the hanger for the selected operating load case.", 1);
        public static readonly AnalysisHgrMultiLoadCaseOption OperatingCase2 = new AnalysisHgrMultiLoadCaseOption("1cd6c99c-ecdf-49a4-a9ce-eea253f29b66", "OperatingCase2", "Designs the hanger for the selected operating load case.", 2);
        public static readonly AnalysisHgrMultiLoadCaseOption OperatingCase3 = new AnalysisHgrMultiLoadCaseOption("b54e48b3-20af-4fe1-b5f9-909501004fad", "OperatingCase3", "Designs the hanger for the selected operating load case.", 3);
        public static readonly AnalysisHgrMultiLoadCaseOption OperatingCase4 = new AnalysisHgrMultiLoadCaseOption("394ad351-63ba-45fb-815a-917d8de81f3a", "OperatingCase4", "Designs the hanger for the selected operating load case.", 4);
        public static readonly AnalysisHgrMultiLoadCaseOption OperatingCase5 = new AnalysisHgrMultiLoadCaseOption("1902c6b5-b5f4-44a3-afe9-30a15fd9758a", "OperatingCase5", "Designs the hanger for the selected operating load case.", 5);
        public static readonly AnalysisHgrMultiLoadCaseOption OperatingCase6 = new AnalysisHgrMultiLoadCaseOption("d253b870-cd71-453e-b09e-d0fb5964962d", "OperatingCase6", "Designs the hanger for the selected operating load case.", 6);
        public static readonly AnalysisHgrMultiLoadCaseOption OperatingCase7 = new AnalysisHgrMultiLoadCaseOption("3624a067-f833-43cf-92e9-43a5c6699c45", "OperatingCase7", "Designs the hanger for the selected operating load case.", 7);
        public static readonly AnalysisHgrMultiLoadCaseOption OperatingCase8 = new AnalysisHgrMultiLoadCaseOption("7c1b8a80-ea03-4c33-833c-8d8ea5764052", "OperatingCase8", "Designs the hanger for the selected operating load case.", 8);
        public static readonly AnalysisHgrMultiLoadCaseOption OperatingCase9 = new AnalysisHgrMultiLoadCaseOption("ea58c7b4-016f-4213-8ef2-26284688ef8b", "OperatingCase9", "Designs the hanger for the selected operating load case.", 9);
        public static readonly AnalysisHgrMultiLoadCaseOption MaximumLoad = new AnalysisHgrMultiLoadCaseOption("c608bcc8-574f-47c2-8668-89e8a64f0b12", "MaximumLoad", "Designs the hanger for the maximum load from the operating load cases", 10);
        public static readonly AnalysisHgrMultiLoadCaseOption MaximumTravel = new AnalysisHgrMultiLoadCaseOption("d4f9e4a2-de75-4cf4-9b9e-e29d28ccad80", "MaximumTravel", "Designs the hanger for the maximum travel from the operating load cases", 11);
        public static readonly AnalysisHgrMultiLoadCaseOption AvgLoadAndTravel = new AnalysisHgrMultiLoadCaseOption("921848d3-0911-40a0-b400-552aaea49180", "AveLoadandTravel", "Designs the hanger for the average load and average travel from the operating load cases", 12);
        public static readonly AnalysisHgrMultiLoadCaseOption MaxLoadAndTravel = new AnalysisHgrMultiLoadCaseOption("5a1f3ccd-17be-481e-a697-1a87fc92126b", "MaxLoadandTravel", "Designs the hanger for the maximum load and maximum travel from the operating load cases", 13);
        public static readonly AnalysisHgrMultiLoadCaseOption None = new AnalysisHgrMultiLoadCaseOption("6c71e047-5533-4bc1-adc7-1b585687c6e2", "None", "None", 14);

        #endregion

        public AnalysisHgrMultiLoadCaseOption(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
            dict.TryAdd(uid, text);
        }
    }
}