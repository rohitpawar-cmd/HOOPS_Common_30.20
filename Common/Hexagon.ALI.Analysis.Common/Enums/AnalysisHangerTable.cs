using System.Diagnostics.CodeAnalysis;

namespace Hexagon.ALI.Analysis.Common.Enums
{
    [ExcludeFromCodeCoverage]
    public class AnalysisHangerTable : SIOEnum
    {
        #region VALUES        
        public static readonly AnalysisHangerTable Anvil = new AnalysisHangerTable("d09fc1e0-8f2d-443a-9028-63e2f06a4ffd", "ANVIL", "ANVIL", 1);
        public static readonly AnalysisHangerTable BergenUS = new AnalysisHangerTable("908cb88f-3a15-4ed0-b754-0766889930d0", "Bergen (US) Pipe Supports Inc.", "Bergen (US) Pipe Supports Inc.", 2);
        public static readonly AnalysisHangerTable PowerPiping = new AnalysisHangerTable("e8338d70-b72e-4bce-9710-085b9d3e9d4c", "Power Piping", "Power Piping", 3);
        public static readonly AnalysisHangerTable NPSIndustries = new AnalysisHangerTable("6f27156f-a6ae-45f4-ab92-531123ba9765", "NPS Industries", "NPS Industries", 4);
        public static readonly AnalysisHangerTable Lisega = new AnalysisHangerTable("28a8d5ba-744c-481d-b0f7-080d187fd407", "Lisega", "Lisega", 5);
        public static readonly AnalysisHangerTable Fronek = new AnalysisHangerTable("e5e7ba10-e84e-4972-bd5e-a396c1b31913", "Fronek", "Fronek", 6);
        public static readonly AnalysisHangerTable PipingTechnology = new AnalysisHangerTable("fe943e99-f296-4cda-9baf-140d64a2f584", "Piping Technology", "Piping Technology", 7);
        public static readonly AnalysisHangerTable Capitol = new AnalysisHangerTable("0bd5cb6a-9984-40bb-ae7d-c3131d031e47", "Capitol", "Capitol", 8);
        public static readonly AnalysisHangerTable PipingServices = new AnalysisHangerTable("602601e9-2fa4-4067-a796-4c56644a8651", "Piping Services", "Piping Services", 9);
        public static readonly AnalysisHangerTable BasicEngineers = new AnalysisHangerTable("ddac5bf9-bf42-40f2-8575-d829eb0ebaaf", "Basic Engineers", "Basic Engineers", 10);
        public static readonly AnalysisHangerTable InoflexItaly = new AnalysisHangerTable("2e776fa5-b4ba-4190-b7fb-8ea2a7e5b247", "Inoflex (Italy)", "Inoflex (Italy)", 11);
        public static readonly AnalysisHangerTable MyattCanada = new AnalysisHangerTable("678b77df-75e5-44e5-9d50-a286b75e58b3", "E.Myatt & Co. (Canada)", "E.Myatt & Co. (Canada)", 12);
        public static readonly AnalysisHangerTable SinopecChina = new AnalysisHangerTable("4c655c82-8e82-4d18-86a1-802efc035991", "Sinopec (China)", "Sinopec (China)", 13);
        public static readonly AnalysisHangerTable BhelIndia = new AnalysisHangerTable("0bcb4e98-ba19-48cf-a76a-664ebfd158d2", "Bhel (India)", "Bhel (India)", 14);
        public static readonly AnalysisHangerTable CASTIMItaly = new AnalysisHangerTable("d7a19e27-6eca-4eeb-a858-e91ceb64e409", "CASTIM (Italy)", "CASTIM (Italy)", 15);
        public static readonly AnalysisHangerTable CarpenterPaterson = new AnalysisHangerTable("ef95e579-05ab-40ee-86da-f34cff36c211", "Carpenter & Paterson", "Carpenter & Paterson", 16);
        public static readonly AnalysisHangerTable BergenIndia = new AnalysisHangerTable("26fa9456-a1e0-46c1-a470-099c2076fa3f", "Bergen(India) Pipe Priv Ltd", "Bergen (India) Pipe Priv Ltd", 17);
        public static readonly AnalysisHangerTable WitzenmannGermany = new AnalysisHangerTable("92bcf30a-f803-4a3f-a21b-2bb1c8907494", "Witzenmann (Germany)", "Witzenmann (Germany)", 18);
        public static readonly AnalysisHangerTable SarathiIIndia = new AnalysisHangerTable("08007f32-0942-4b17-8ebd-c5d407bdec17", "SARATHI (India)", "SARATHI (India)", 19);
        public static readonly AnalysisHangerTable MyricksIndia = new AnalysisHangerTable("e02b94aa-78e7-48f3-ba30-7d79b11dc95b", "Myricks (India)", "Myricks (India)", 20);
        public static readonly AnalysisHangerTable ChinaPower = new AnalysisHangerTable("6e3e484d-29a8-418f-a2f3-fe565ba23c29", "China Power (China)", "China Power (China)", 21);
        public static readonly AnalysisHangerTable PipeSupportsUSA = new AnalysisHangerTable("b9f0f2dd-b07c-43d1-8f4b-d0367122db36", "Pipe Supports USA", "Pipe Supports USA", 22);
        public static readonly AnalysisHangerTable QualityPipeSupportsUK = new AnalysisHangerTable("66582ff2-e329-440a-a39b-09bd5cf8ba38", "Quality Pipe Supports (UK)", "Quality Pipe Supports (UK)", 23);
        public static readonly AnalysisHangerTable PiHASASpain = new AnalysisHangerTable("358f3380-6dd8-4a1c-ae3a-c05a12245412", "PiHASA (Spain)", "PiHASA (Spain)", 24);
        public static readonly AnalysisHangerTable BinderUK = new AnalysisHangerTable("e2694156-01ec-451b-913a-c13fcd5189e5", "Binder (UK)", "Binder (UK)", 25);
        public static readonly AnalysisHangerTable GradiorCzech = new AnalysisHangerTable("caa4f0bc-1789-4cea-8058-b6c4ffbbe0ab", "Gradior (Czech Rep.)", "Gradior (Czech Rep.)", 26);
        public static readonly AnalysisHangerTable NhkJapan = new AnalysisHangerTable("570f9b38-7d11-441b-9508-fa75b8a95f25", "NHK (Japan)", "NHK (Japan)", 27);
        public static readonly AnalysisHangerTable PSSI = new AnalysisHangerTable("74f398aa-94d6-4efc-a8b0-69bf1c6ddd8a", "PSSI GmbH", "PSSI GmbH", 28);
        public static readonly AnalysisHangerTable SeonghwaKorea = new AnalysisHangerTable("c9351b3a-7ebd-4b67-8d7a-914ee86f1a12", "Seonghwa (Korea)", "Seonghwa (Korea)", 29);
        public static readonly AnalysisHangerTable MitsubishiJapan = new AnalysisHangerTable("4aebb083-ba43-4424-bbbc-8d3b57a81100", "Mitsubishi (Japan)", "Mitsubishi (Japan)", 30);
        public static readonly AnalysisHangerTable YamashitaJapan = new AnalysisHangerTable("8b813e46-c864-44fa-9c90-a177854cd316", "Yamashita (Japan)", "Yamashita( Japan)", 31);
        public static readonly AnalysisHangerTable SanwaTekkiJapan = new AnalysisHangerTable("ad9851fc-e19d-4de6-ae4c-ddc5dc09ce69", "Sanwa Tekki (Japan)", "Sanwa Tekki (Japan)", 32);
        public static readonly AnalysisHangerTable TechnoIndia = new AnalysisHangerTable("6fa5bc69-2cca-4259-b740-da173e27fc42", "Techno Instry (India)", "Techno Instry (India)", 33);
        public static readonly AnalysisHangerTable HesterbergGermany = new AnalysisHangerTable("57eb71a5-320b-4b9d-b40e-90be92b2d24d", "Hesterberg (Germany)", "Hesterberg (Germany)", 34);
        public static readonly AnalysisHangerTable SprSupMfgIndia = new AnalysisHangerTable("02b01e0e-1911-42a3-961d-d0813bda7a65", "SprSupMfg (India)", "SprSupMfg (India)", 35);
        public static readonly AnalysisHangerTable SeniorBrazil = new AnalysisHangerTable("cd0127f9-ed7f-4772-a1f1-409317ea2f1d", "Senior (Brazil)", "Senior (Brazil)", 36);
        public static readonly AnalysisHangerTable UnisonKorea = new AnalysisHangerTable("2f37389c-2d07-4a25-a8d5-ba0bbf991e78", "Unison (Korea)", "Unison (Korea)", 37);
        public static readonly AnalysisHangerTable WookwangKorea = new AnalysisHangerTable("dcd924c1-729f-491f-974c-832462df7075", "Wookwang (Korea)", "Wookwang (Korea)", 38);
        public static readonly AnalysisHangerTable Rilco = new AnalysisHangerTable("dcd924c1-729f-491f-974c-832462df7075", "Rilco", "Rilco", 39);
        #endregion

        public AnalysisHangerTable(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
            dict.TryAdd(uid, text);
        }
    }
}