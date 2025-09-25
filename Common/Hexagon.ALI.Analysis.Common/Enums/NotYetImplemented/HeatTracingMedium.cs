namespace Analysis2.SIO.Library.Enums
{
    public class HeatTracingMedium : SIOEnum
    {
        #region VALUES
        public static readonly HeatTracingMedium Undefined = new HeatTracingMedium("{41932999-69DE-409C-949B-88DC10404721}", "Undefined", "", 1);
        public static readonly HeatTracingMedium None = new HeatTracingMedium("{9C07EA65-57AD-420B-9267-7D9F0412F43F}", "None", "", 2);
        public static readonly HeatTracingMedium Sh = new HeatTracingMedium("{A36C898E-75E9-452F-90B6-7D23B271D782}", "SH", "", 20);
        public static readonly HeatTracingMedium Sm = new HeatTracingMedium("{5BC44A1C-0F43-4971-9F69-5B5AD58541D1}", "SM", "", 22);
        public static readonly HeatTracingMedium Sl = new HeatTracingMedium("{5195D902-ECB9-4674-8B3D-864015714C42}", "SL", "", 21);
        public static readonly HeatTracingMedium Sn = new HeatTracingMedium("{B8CE6BCD-C9E8-47C4-AF1C-2402BCEC6772}", "SN", "", 23);
        public static readonly HeatTracingMedium Ss = new HeatTracingMedium("{384E4DD4-878B-401A-B674-D888FB9E697A}", "SS", "", 24);
        public static readonly HeatTracingMedium Therminol75 = new HeatTracingMedium("{4634CC50-D78E-45D5-8F73-AACE6C98557F}", "Therminol® 75", "", 60);
        public static readonly HeatTracingMedium TherminolVp1 = new HeatTracingMedium("{209A4567-76D2-4C19-8B42-C471F8556F08}", "Therminol® VP-1", "", 65);
        public static readonly HeatTracingMedium Dowtherm = new HeatTracingMedium("{009C99E9-213D-4E9A-9271-823DBCFD51B2}", "Dowtherm®", "", 25);
        public static readonly HeatTracingMedium XcelthermXt = new HeatTracingMedium("{D233E30D-225B-4FB5-B578-6968C31500E7}", "XcelTherm® XT", "", 70);
        public static readonly HeatTracingMedium XcelthermLv2 = new HeatTracingMedium("{6F35ABD7-D4F9-48A4-A538-2470C810105C}", "XcelTherm® LV2", "", 75);
        public static readonly HeatTracingMedium Xceltherm500 = new HeatTracingMedium("{44363D65-43EF-4C59-9479-75BE233246AE}", "XcelTherm® 500", "", 80);
        public static readonly HeatTracingMedium XcelthermMk1 = new HeatTracingMedium("{D84C59B2-823D-4168-9AB7-F577430464F8}", "XcelTherm® MK1", "", 85);
        public static readonly HeatTracingMedium ParathermNf = new HeatTracingMedium("{DBC0BC8C-2ACD-433B-8B55-DBD73E96F4FA}", "Paratherm® NF", "", 90);
        public static readonly HeatTracingMedium ParathermHe = new HeatTracingMedium("{350BC0CB-46C3-4140-B8D4-C2C49BDE0A43}", "Paratherm® HE", "", 95);
        public static readonly HeatTracingMedium ParathermOr = new HeatTracingMedium("{C96AB3BC-6F5E-4071-977E-B6B2AE26FA34}", "Paratherm® OR", "", 100);
        public static readonly HeatTracingMedium Calflo = new HeatTracingMedium("{303A5AD5-B92C-4E10-9341-9341E3050415}", "Calflo®", "", 105);
        public static readonly HeatTracingMedium Multitherm = new HeatTracingMedium("{085E1525-B753-4E75-BC7C-9CEB43798ABB}", "Multitherm®", "", 110);
        public static readonly HeatTracingMedium MineralOil = new HeatTracingMedium("{D7B5B371-6C77-44BB-B877-58002601E9AB}", "Mineral oil", "", 115);
        public static readonly HeatTracingMedium HydrogenatedWhiteOil = new HeatTracingMedium("{252EF228-752E-4826-A096-ACDDCF62D404}", "Hydrogenated white oil", "", 120);
        public static readonly HeatTracingMedium ParaffinicNapthenicWhiteOil = new HeatTracingMedium("{B8DD28AA-323B-4539-917D-244132E7F3E3}", "Paraffinic/Napthenic white oil", "", 125);
        public static readonly HeatTracingMedium Polyalphaolefin = new HeatTracingMedium("{27A33DB1-40F2-4122-85B1-68C025DE939B}", "Polyalphaolefin", "", 130);
        public static readonly HeatTracingMedium Dowcal = new HeatTracingMedium("{69858DFC-D5F1-4C7F-8C4D-951CEF1C92FE}", "Dowcal®", "", 135);
        public static readonly HeatTracingMedium Dowfrost = new HeatTracingMedium("{B612CBDF-A4D8-4B95-A890-53FF82D5B7AF}", "Dowfrost®", "", 140);
        public static readonly HeatTracingMedium Syltherm = new HeatTracingMedium("{ECE84E43-CED3-486A-B035-5DAD1F3692E2}", "Syltherm®", "", 145);
        public static readonly HeatTracingMedium Ethylene = new HeatTracingMedium("{17330A80-0B56-4028-8ABA-31DE6B62BF57}", "Ethylene", "", 150);
        public static readonly HeatTracingMedium Propylene = new HeatTracingMedium("{22F6C906-0897-4A2F-8AC0-5F33B410A6E4}", "Propylene", "", 155);
        public static readonly HeatTracingMedium Dynalene = new HeatTracingMedium("{D0C20654-C8E2-42DF-885B-4BB57AFA2F20}", "Dynalene®", "", 160);
        public static readonly HeatTracingMedium Galden = new HeatTracingMedium("{5FAFCE57-D752-4992-AD18-F231742CB106}", "Galden®", "", 165);
        public static readonly HeatTracingMedium Coolanol = new HeatTracingMedium("{8DED8C8A-9D71-4B01-AC2F-5A09625FC6E4}", "Coolanol®", "", 170);
        public static readonly HeatTracingMedium MarlothermSh = new HeatTracingMedium("{D7BA5DB4-5093-4927-802D-3D406C362F0B}", "Marlotherm® SH", "", 175);
        public static readonly HeatTracingMedium Dwtherm = new HeatTracingMedium("{2168C83F-81EE-4420-9B11-1A7695405F25}", "DWTherm", "", 180);
        public static readonly HeatTracingMedium ArgonneNanofluid = new HeatTracingMedium("{AE325321-058B-43D3-853C-A887162F675D}", "Argonne nanofluid", "", 185);
        public static readonly HeatTracingMedium ModifiedTerphenyl = new HeatTracingMedium("{34D8F642-22C2-4679-939D-D978DA6A769D}", "Modified terphenyl", "", 190);
        public static readonly HeatTracingMedium Dibenzyltoluene = new HeatTracingMedium("{7D753920-DA26-4524-812F-BE5C91A166B9}", "Dibenzyltoluene", "", 195);
        public static readonly HeatTracingMedium DiphenylBiphenylOxide = new HeatTracingMedium("{7AAAE420-0F9C-4200-AEE1-BA6716E08926}", "Diphenyl/biphenyl oxide", "", 200);
        public static readonly HeatTracingMedium Diphenylethane = new HeatTracingMedium("{621B8F99-9622-48F4-84AE-7E6D906723E7}", "Diphenylethane", "", 205);
        public static readonly HeatTracingMedium ImpedanceEndFed = new HeatTracingMedium("{EF9E57F7-3655-4CE1-BEE8-277E285DCE32}", "Impedance, end fed", "", 16);
        public static readonly HeatTracingMedium ImpedanceMidFed = new HeatTracingMedium("{9F8EBAE6-DF1C-45DC-8573-215ACD59C457}", "Impedance, mid fed", "", 365);
        public static readonly HeatTracingMedium MagneticInduction = new HeatTracingMedium("{038C12BF-BA3A-491C-B714-E03FBB9A8DD0}", "Magnetic induction", "", 17);
        public static readonly HeatTracingMedium SkinEffect = new HeatTracingMedium("{08D6E7E5-3E0E-4717-B096-C1F2591CF737}", "Skin effect", "", 18);
        public static readonly HeatTracingMedium SeriesHeatingCable = new HeatTracingMedium("{DA7E4351-ACF2-433A-BFBD-E6D01B98AD3A}", "Series heating cable", "", 380);
        public static readonly HeatTracingMedium ParallelSelfRegulatingHeatingCable = new HeatTracingMedium("{9AED1F22-57DE-4D26-95F7-D85EF182C435}", "Parallel self-regulating heating cable", "", 370);
        public static readonly HeatTracingMedium ParallelPowerLimitingHeatingCable = new HeatTracingMedium("{A00DEE5E-E526-480B-A50A-7CD9FEEC17E0}", "Parallel power-limiting heating cable", "", 375);
        public static readonly HeatTracingMedium Shj = new HeatTracingMedium("{7C84DFC4-6BB6-4194-9E4F-A27066579331}", "SHJ", "", 50);
        public static readonly HeatTracingMedium Smj = new HeatTracingMedium("{6052FD40-B7ED-4958-BB5E-C4A831448108}", "SMJ", "", 52);
        public static readonly HeatTracingMedium Slj = new HeatTracingMedium("{D66E3238-CE50-4241-8FF2-EDB3CB4AA95C}", "SLJ", "", 51);
        public static readonly HeatTracingMedium Snj = new HeatTracingMedium("{F46C5C63-73EB-45D7-BD8C-92CCD4E51D01}", "SNJ", "", 53);
        public static readonly HeatTracingMedium Ssj = new HeatTracingMedium("{CD9A33AA-ACBC-4397-8567-6349D7CEE762}", "SSJ", "", 54);
        public static readonly HeatTracingMedium Therm75J = new HeatTracingMedium("{FC04360F-7CB2-436B-ADBE-DC01C0E9940B}", "THERM75J", "", 210);
        public static readonly HeatTracingMedium Thermvp1J = new HeatTracingMedium("{4B845A31-6E4D-44A5-B432-3BF4262F36B4}", "THERMVP1J", "", 215);
        public static readonly HeatTracingMedium Dowthermj = new HeatTracingMedium("{03A502A7-6159-4105-8FC4-C75D059005A1}", "DowthermJ", "", 220);
        public static readonly HeatTracingMedium Xthermxtj = new HeatTracingMedium("{F2E856DC-6768-429D-8ED4-C1AAEF32F59B}", "XTHERMXTJ", "", 225);
        public static readonly HeatTracingMedium Xthermlv2J = new HeatTracingMedium("{7D244B60-6309-4FF5-A347-6CE0506A720A}", "XTHERMLV2J", "", 230);
        public static readonly HeatTracingMedium Xtherm500J = new HeatTracingMedium("{5DA49D08-C844-49F6-91CB-729AA89AC917}", "XTHERM500J", "", 235);
        public static readonly HeatTracingMedium Xthermmk1J = new HeatTracingMedium("{404E6991-907D-4B9B-B801-9EDF1A1CF5FD}", "XTHERMMK1J", "", 240);
        public static readonly HeatTracingMedium Pthermnfj = new HeatTracingMedium("{6C7F34FD-339A-42C7-802A-5D8134171238}", "PTHERMNFJ", "", 245);
        public static readonly HeatTracingMedium Pthermhej = new HeatTracingMedium("{F55546A2-AFDF-413A-87B7-6CA8A4A76782}", "PTHERMHEJ", "", 250);
        public static readonly HeatTracingMedium Pthermorj = new HeatTracingMedium("{DDC8FEF8-63AD-4B6E-BAFB-C48E7F5F3984}", "PTHERMORJ", "", 255);
        public static readonly HeatTracingMedium Calj = new HeatTracingMedium("{91A06CC1-269B-4735-9B4B-0211A6AF07C4}", "CALJ", "", 260);
        public static readonly HeatTracingMedium Mthermj = new HeatTracingMedium("{8C39D66A-8EFD-40F3-A8AF-5D5FB1A5638B}", "MTHERMJ", "", 265);
        public static readonly HeatTracingMedium Minoilj = new HeatTracingMedium("{21B62414-F04C-4316-ABF0-F10260736E1C}", "MINOILJ", "", 270);
        public static readonly HeatTracingMedium Hwoilj = new HeatTracingMedium("{60F769B7-01AA-4F5B-A21F-223074D5B9BB}", "HWOILJ", "", 275);
        public static readonly HeatTracingMedium Pnwoilj = new HeatTracingMedium("{6471CB0E-7741-4251-8475-1DC577071099}", "PNWOILJ", "", 280);
        public static readonly HeatTracingMedium Paolefinj = new HeatTracingMedium("{DD916E31-F152-46A8-928D-3274899401BC}", "PAOLEFINJ", "", 285);
        public static readonly HeatTracingMedium Dowcalj = new HeatTracingMedium("{B6CDE8B3-7C0D-41EF-A0C7-D036CDB8F466}", "DowcalJ", "", 290);
        public static readonly HeatTracingMedium Dowfrostj = new HeatTracingMedium("{864B5A98-8B29-4119-997B-6547E8DE05B8}", "DowfrostJ", "", 295);
        public static readonly HeatTracingMedium Sylthermj = new HeatTracingMedium("{709D576B-E4A9-469A-B49D-EB43A07C1277}", "SylthermJ", "", 300);
        public static readonly HeatTracingMedium Ethylenej = new HeatTracingMedium("{35FC0299-6509-4180-8869-F3DBE6C56B04}", "EthyleneJ", "", 305);
        public static readonly HeatTracingMedium Propylenej = new HeatTracingMedium("{CEFACBA4-33A7-4B0B-A7A7-8370449CA885}", "PropyleneJ", "", 310);
        public static readonly HeatTracingMedium Dynalenej = new HeatTracingMedium("{645DB32A-50E0-4051-9314-B7909B69C713}", "DynaleneJ", "", 315);
        public static readonly HeatTracingMedium Galdenj = new HeatTracingMedium("{AEC75278-2EF8-490F-A093-6B47D2D5D4DF}", "GaldenJ", "", 320);
        public static readonly HeatTracingMedium Coolanolj = new HeatTracingMedium("{42EB64B6-0AA9-4A38-A701-F868EF2513F3}", "CoolanolJ", "", 325);
        public static readonly HeatTracingMedium Mathermshj = new HeatTracingMedium("{DEB2EDEB-B7A1-4E47-81BB-5AD0826D1F27}", "MATHERMSHJ", "", 330);
        public static readonly HeatTracingMedium Dwthermj = new HeatTracingMedium("{F754A4FC-31F7-429F-88B7-62ACD17946D9}", "DWThermJ", "", 335);
        public static readonly HeatTracingMedium Argnflj = new HeatTracingMedium("{2B19409E-8595-442F-9E92-37D992566140}", "ARGNFLJ", "", 340);
        public static readonly HeatTracingMedium Mterphej = new HeatTracingMedium("{4964E8DF-8396-4CBB-8F39-D766F30F2220}", "MTERPHEJ", "", 345);
        public static readonly HeatTracingMedium Dbentolj = new HeatTracingMedium("{075A2F6D-3E0F-45CB-9284-DE34DCF77F79}", "DBENTOLJ", "", 350);
        public static readonly HeatTracingMedium Dpheoxij = new HeatTracingMedium("{BB739534-EEA7-491A-8D86-6EF206628060}", "DPHEOXIJ", "", 355);
        public static readonly HeatTracingMedium Dphethej = new HeatTracingMedium("{0257DFB3-E81C-49EA-802E-5C22C4BD30F7}", "DPHETHEJ", "", 360);
        #endregion
        public HeatTracingMedium(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator HeatTracingMedium(string text)
        {
            return FindByText<HeatTracingMedium>(text);
        }
    }
}