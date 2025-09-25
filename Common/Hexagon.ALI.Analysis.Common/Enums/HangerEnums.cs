using System.ComponentModel;

namespace Hexagon.ALI.Analysis.Common.Enums
{
    public enum HangerFreeCodeType
    {
        [Description("Y")] Y = 1,
        [Description("XY")] XY = 2,
        [Description("ZY")] ZY = 3,
        [Description("XYZ")] XYZ = 4,
        [Description("ALL")] ALL = 5,
        [Description("None")] None = 6,
    }

    public enum HangerMultiLoadCaseOption
    {
        [Description("Operating Case 1")] OperatingCase1 = 1,
        [Description("Operating Case 2")] OperatingCase2 = 2,
        [Description("Operating Case 3")] OperatingCase3 = 3,
        [Description("Operating Case 4")] OperatingCase4 = 4,
        [Description("Operating Case 5")] OperatingCase5 = 5,
        [Description("Operating Case 6")] OperatingCase6 = 6,
        [Description("Operating Case 7")] OperatingCase7 = 7,
        [Description("Operating Case 8")] OperatingCase8 = 8,
        [Description("Operating Case 9")] OperatingCase9 = 9,
        [Description("Maximum Load")] MaximumLoad = 10,
        [Description("Maximum Travel")] MaximumTravel = 11,
        [Description("Ave Load and Travel")] AvgLoadAndTravel = 12,
        [Description("Max Load and Travel")] MaxLoadAndTravel = 13,
        [Description("None")] None = 14,
    }

    public enum HangerTable
    {
        [Description("ANVIL")] Anvil = 1,
        [Description("Bergen (US) Pipe Supports Inc.")] BergenUS = 2,
        [Description("Power Piping")] PowerPiping = 3,
        [Description("NPS Industries")] NPSIndustries = 4,
        [Description("Lisega")] Lisega = 5,
        [Description("Fronek")] Fronek = 6,
        [Description("Piping Technology")] PipingTechnology = 7,
        [Description("Capitol")] Capitol = 8,
        [Description("Piping Services")] PipingServices = 9,
        [Description("Basic Engineers")] BasicEngineers = 10,
        [Description("Inoflex (Italy)")] InoflexItaly = 11,
        [Description("E.Myatt & Co. (Canada)")] MyattCanada = 12,
        [Description("Sinopec (China)")] SinopecChina = 13,
        [Description("Bhel (India)")] BhelIndia = 14,
        [Description("CASTIM (Italy)")] CASTIMItaly = 15,
        [Description("Carpenter & Paterson")] CarpenterPaterson = 16,
        [Description("Bergen(India) Pipe Priv Ltd")] BergenIndia = 17,
        [Description("Witzenmann (Germany)")] WitzenmannGermany = 18,
        [Description("SARATHI (India)")] SarathiIIndia = 19,
        [Description("Myricks (India)")] MyricksIndia = 20,
        [Description("China Power (China)")] ChinaPower = 21,
        [Description("Pipe Supports USA")] PipeSupportsUSA = 22,
        [Description("Quality Pipe Supports (UK)")] QualityPipeSupportsUK = 23,
        [Description("PiHASA (Spain)")] PiHASASpain = 24,
        [Description("Binder (UK)")] BinderUK = 25,
        [Description("Gradior (Czech Rep.)")] GradiorCzech = 26,
        [Description("NHK (Japan)")] NhkJapan = 27,
        [Description("PSSI GmbH")] PSSI = 28,
        [Description("Seonghwa (Korea)")] SeonghwaKorea = 29,
        [Description("Mitsubishi (Japan)")] MitsubishiJapan = 30,
        [Description("Yamashita (Japan)")] YamashitaJapan = 31,
        [Description("Sanwa Tekki (Japan)")] SanwaTekkiJapan = 32,
        [Description("Techno Instry (India)")] TechnoIndia = 33,
        [Description("Hesterberg (Germany)")] HesterbergGermany = 34,
        [Description("SprSupMfg (India)")] SprSupMfgIndia = 35,
        [Description("Senior (Brazil)")] SeniorBrazil = 36,
        [Description("Unison (Korea)")] UnisonKorea = 37,
        [Description("Wookwang (Korea)")] WookwangKorea = 38,
        [Description("Rilco")] Rilco = 39,
    }
}
