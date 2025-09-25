namespace Analysis2.SIO.Library.Enums
{
    public class ScheduleThicknessPractice : SIOEnum
    {
        #region VALUES
        public static readonly ScheduleThicknessPractice Undefined = new ScheduleThicknessPractice("{0BF02485-79C8-4CC2-93F0-55AB64A370C4}", "Undefined", "", 1);
        public static readonly ScheduleThicknessPractice NotRequired = new ScheduleThicknessPractice("{9C0D3A5E-C8DC-4FB2-8499-E7F3D3AC76D8}", "Not Required", "", 2);
        public static readonly ScheduleThicknessPractice UniversalWallThicknessValues = new ScheduleThicknessPractice("{DDB6C7C9-1853-437F-9D1E-4C43BE8E0DB3}", "Universal Wall Thickness Values", "", 3);
        public static readonly ScheduleThicknessPractice UnitedStatesOfAmericaStandards = new ScheduleThicknessPractice("{D1641037-FAA3-48BA-BABD-F5BBCF36AE5B}", "United States of America, Standards", "", 5);
        public static readonly ScheduleThicknessPractice MatchPipeStock = new ScheduleThicknessPractice("{DAC92C1B-0B6C-45BD-8FA4-FB36B8EE6E58}", "Match Pipe Stock", "", 10);
        public static readonly ScheduleThicknessPractice CalculateWallThickness = new ScheduleThicknessPractice("{57B5007C-BFF7-4354-9D5C-647595E7D511}", "Calculate Wall Thickness", "", 15);
        public static readonly ScheduleThicknessPractice GermanyStandardsDin = new ScheduleThicknessPractice("{433C50F5-C9A0-4DAE-BF3A-5316E97D83E1}", "Germany Standards (DIN)", "", 18);
        public static readonly ScheduleThicknessPractice FinlandStandardsSfs = new ScheduleThicknessPractice("{2B7DFBD0-C6F2-4703-BC6A-8A9FFEB31718}", "Finland Standards (SFS)", "", 20);
        public static readonly ScheduleThicknessPractice CenEuStandards = new ScheduleThicknessPractice("{9B23193D-5662-4E7B-AB09-7A01E2C98680}", "CEN/EU Standards", "", 30);
        public static readonly ScheduleThicknessPractice UnitedKingdomStandardsBsi = new ScheduleThicknessPractice("{B642DE5A-41C9-49C5-9DC1-F826A156573C}", "United Kingdom Standards (BSI)", "", 33);
        public static readonly ScheduleThicknessPractice OtherEuropeMiddleEastAndAfricaStandards = new ScheduleThicknessPractice("{45D29185-61AC-4571-A7EB-78DAC840A225}", "Other Europe, Middle East, and Africa Standards", "", 35);
        public static readonly ScheduleThicknessPractice JapanStandardsJisc = new ScheduleThicknessPractice("{700ABA74-0DA1-47EE-8E93-07F5FA1F3A5B}", "Japan Standards (JISC)", "", 40);
        public static readonly ScheduleThicknessPractice ChinaStandardsSacs = new ScheduleThicknessPractice("{B02D01C4-3D30-4F96-BC46-87A85DCF9BE6}", "China Standards (SACS)", "", 45);
        public static readonly ScheduleThicknessPractice KoreaStandardsKats = new ScheduleThicknessPractice("{25A613C4-241A-4E48-A37A-0C0513FF1A41}", "Korea Standards (KATS)", "", 50);
        public static readonly ScheduleThicknessPractice OtherAsiaPacificStandards = new ScheduleThicknessPractice("{1BDC54B9-6298-46F0-807C-3281C7BE36D8}", "Other Asia-Pacific Standards", "", 55);
        public static readonly ScheduleThicknessPractice AustraliaStandardsAs = new ScheduleThicknessPractice("{8418B35A-1188-4223-BFB4-37AF77533CE2}", "Australia Standards (AS)", "", 60);
        public static readonly ScheduleThicknessPractice NorsokStandards = new ScheduleThicknessPractice("{28A13E4B-FA78-44A3-A968-0C7C581EA499}", "NORSOK Standards", "", 65);
        public static readonly ScheduleThicknessPractice KksStandards = new ScheduleThicknessPractice("{4A99463D-052F-4FC6-B450-4E1B5B092355}", "KKS Standards", "", 70);
        public static readonly ScheduleThicknessPractice CompanyStandards = new ScheduleThicknessPractice("{34518BD2-3034-44C2-9ADE-34800D0DFAC5}", "Company Standards", "", 75);
        public static readonly ScheduleThicknessPractice FranceStandardsAfnor = new ScheduleThicknessPractice("{D73F7494-D0CA-4829-B951-5907CB65F447}", "France Standards (AFNOR)", "", 95);
        public static readonly ScheduleThicknessPractice OtherAmericasStandards = new ScheduleThicknessPractice("{E243601F-7760-4E75-BA00-4EE7E060C11F}", "Other Americas Standards", "", 150);
        public static readonly ScheduleThicknessPractice ArgentinaStandardsIram = new ScheduleThicknessPractice("{2FD2C930-289E-4C5D-A887-16D1EDDB70EE}", "Argentina Standards (IRAM)", "", 200);
        public static readonly ScheduleThicknessPractice AustriaStandardsOn = new ScheduleThicknessPractice("{CE873623-D6A7-4DD5-BABE-F30AD430F86D}", "Austria Standards (ON)", "", 210);
        public static readonly ScheduleThicknessPractice BahrainStandardsBsmd = new ScheduleThicknessPractice("{7701E0A4-A4CE-4880-96BD-557E9D857DB3}", "Bahrain Standards (BSMD)", "", 220);
        public static readonly ScheduleThicknessPractice BarbadosStandardsBnsi = new ScheduleThicknessPractice("{3EB48BB6-C1EC-4D2C-9C8D-D8F466A2B227}", "Barbados Standards (BNSI)", "", 230);
        public static readonly ScheduleThicknessPractice BelarusStandardsBelst = new ScheduleThicknessPractice("{38F3AE1D-021E-4A5C-8CC2-0B47215E8905}", "Belarus Standards (BELST)", "", 240);
        public static readonly ScheduleThicknessPractice BelgiumStandardsIbn = new ScheduleThicknessPractice("{A52C827A-A219-4122-A71E-3C817CB14063}", "Belgium Standards (IBN)", "", 250);
        public static readonly ScheduleThicknessPractice BoliviaStandardsIbnorca = new ScheduleThicknessPractice("{26D536FE-A158-47F9-9CDE-6CA7E91EFC25}", "Bolivia Standards (IBNORCA)", "", 260);
        public static readonly ScheduleThicknessPractice BrazilStandardsAbnt = new ScheduleThicknessPractice("{D505E0B2-6B5F-4FE2-9DCC-F7883B8A80FF}", "Brazil Standards (ABNT)", "", 270);
        public static readonly ScheduleThicknessPractice CanadaStandardsScc = new ScheduleThicknessPractice("{AFE939DF-F09B-494C-B6A1-1ED48F973CD3}", "Canada, Standards (SCC = Standards Council of Canada, CSA = Canadian Standards Association)", "", 280);
        public static readonly ScheduleThicknessPractice ChileStandardsInn = new ScheduleThicknessPractice("{DEE5DE66-EDF8-4085-B1D7-4FCFFFF39A93}", "Chile Standards (INN)", "", 290);
        public static readonly ScheduleThicknessPractice ColombiaStandardsIcontec = new ScheduleThicknessPractice("{7A91E9E8-9573-455B-80F3-AD6E741F1B5B}", "Colombia Standards (ICONTEC)", "", 300);
        public static readonly ScheduleThicknessPractice CostaRicaStandardsInteco = new ScheduleThicknessPractice("{98C91DDD-9324-4F8E-8222-EA6EA41120D0}", "Costa Rica Standards (INTECO)", "", 310);
        public static readonly ScheduleThicknessPractice CzechRepublicStandardsCsni = new ScheduleThicknessPractice("{9B8074A9-FE96-44F6-9113-7146C64926E2}", "Czech Republic Standards (CSNI)", "", 320);
        public static readonly ScheduleThicknessPractice DenmarkStandardsDs = new ScheduleThicknessPractice("{61273A4D-B111-4B9B-9C6C-FC26705E2B88}", "Denmark Standards (DS)", "", 330);
        public static readonly ScheduleThicknessPractice GreeceStandardsElot = new ScheduleThicknessPractice("{A22D626A-CD28-4945-9129-B178904EF45E}", "Greece Standards (ELOT)", "", 340);
        public static readonly ScheduleThicknessPractice HongKongStandardsItchksar = new ScheduleThicknessPractice("{20E42620-F7C6-45EA-93CE-7AF98245CBDD}", "Hong Kong Standards (ITCHKSAR)", "", 350);
        public static readonly ScheduleThicknessPractice IcelandStandardsIst = new ScheduleThicknessPractice("{867427CC-464C-47E5-8D23-7A941E7191DE}", "Iceland Standards (IST)", "", 360);
        public static readonly ScheduleThicknessPractice IndiaStandardsBis = new ScheduleThicknessPractice("{3EF0611A-7277-442D-9BBC-B1354BC2741A}", "India Standards (BIS)", "", 370);
        public static readonly ScheduleThicknessPractice IndonesiaStandardsBsn = new ScheduleThicknessPractice("{2717C4C8-C85F-4960-B366-19FC724C5F9D}", "Indonesia Standards (BSN)", "", 380);
        public static readonly ScheduleThicknessPractice IrelandStandardsNsai = new ScheduleThicknessPractice("{37C5D987-6F5D-4325-AA8C-275F3A0F939E}", "Ireland Standards (NSAI)", "", 390);
        public static readonly ScheduleThicknessPractice IsraelStandardsSii = new ScheduleThicknessPractice("{57F8C07D-3894-4338-8168-5472B37258E2}", "Israel Standards (SII)", "", 400);
        public static readonly ScheduleThicknessPractice ItalyStandardsUni = new ScheduleThicknessPractice("{73035D34-FC69-4E0F-A480-85143CC61269}", "Italy Standards (UNI)", "", 410);
        public static readonly ScheduleThicknessPractice JordanStandardsJism = new ScheduleThicknessPractice("{8116E606-163B-49D7-B1FB-44B7CA4A1EB5}", "Jordan Standards (JISM)", "", 420);
        public static readonly ScheduleThicknessPractice KuwaitStandardsKowsmd = new ScheduleThicknessPractice("{785A7A8B-2B23-4060-9B75-9493C43FE809}", "Kuwait Standards (KOWSMD)", "", 430);
        public static readonly ScheduleThicknessPractice LebanonStandardsLibnor = new ScheduleThicknessPractice("{433049E7-AF50-488B-B458-492F59A51347}", "Lebanon Standards (LIBNOR)", "", 440);
        public static readonly ScheduleThicknessPractice LuxembourgStandardsSee = new ScheduleThicknessPractice("{988F2612-F274-4CFA-ADAC-4F5B6A42E198}", "Luxembourg Standards (SEE)", "", 450);
        public static readonly ScheduleThicknessPractice MalaysiaStandardsDsm = new ScheduleThicknessPractice("{1F506410-1C48-4A15-9D6B-D4001342FA32}", "Malaysia Standards (DSM)", "", 460);
        public static readonly ScheduleThicknessPractice MaltaStandardsMsa = new ScheduleThicknessPractice("{EE611648-5C35-4D0C-B64B-2BAC0F243A49}", "Malta Standards (MSA)", "", 470);
        public static readonly ScheduleThicknessPractice MexicoStandardsDgn = new ScheduleThicknessPractice("{1CBB9D77-DD98-41EC-86D8-F8BEFDAAC7A9}", "Mexico Standards (DGN)", "", 480);
        public static readonly ScheduleThicknessPractice NetherlandsStandardsNen = new ScheduleThicknessPractice("{EEC71A67-8194-40FD-ADB7-29DF417C3758}", "Netherlands Standards (NEN)", "", 490);
        public static readonly ScheduleThicknessPractice NewZealandStandardsSnz = new ScheduleThicknessPractice("{A9870551-F9D0-4E55-B7C9-6CBB4077FE9D}", "New Zealand Standards (SNZ)", "", 500);
        public static readonly ScheduleThicknessPractice NorwayStandardsNsf = new ScheduleThicknessPractice("{FA1BE877-3569-4060-AD82-687A4AE63F76}", "Norway Standards (NSF)", "", 510);
        public static readonly ScheduleThicknessPractice OmanStandardsDgsm = new ScheduleThicknessPractice("{A1579021-1216-48F1-B663-B52176FF6D60}", "Oman Standards (DGSM)", "", 520);
        public static readonly ScheduleThicknessPractice PanamaStandardsCopanit = new ScheduleThicknessPractice("{8C74E10D-7696-4FB6-89D4-4A61BDBCFA38}", "Panama Standards (COPANIT)", "", 530);
        public static readonly ScheduleThicknessPractice ParaguayStandardsIntn = new ScheduleThicknessPractice("{CB657CF8-2BCC-428B-AB91-B983E57F128A}", "Paraguay Standards (INTN)", "", 540);
        public static readonly ScheduleThicknessPractice PeruStandardsIndecopi = new ScheduleThicknessPractice("{3CD7736F-0256-4C40-8632-FE33D37A881A}", "Peru Standards (INDECOPI)", "", 550);
        public static readonly ScheduleThicknessPractice PhilippinesStandardsBps = new ScheduleThicknessPractice("{DC6A05A6-F06C-48B4-8626-3EFD303E8E5B}", "Philippines Standards (BPS)", "", 560);
        public static readonly ScheduleThicknessPractice PolandStandardsPkn = new ScheduleThicknessPractice("{21928FBF-48C3-400B-8A1F-E61C10648777}", "Poland Standards (PKN)", "", 570);
        public static readonly ScheduleThicknessPractice PortugalStandardsIpq = new ScheduleThicknessPractice("{766DE805-E3AE-42B7-BE15-E16F8EE2A75B}", "Portugal Standards (IPQ)", "", 580);
        public static readonly ScheduleThicknessPractice RomaniaStandardsAsro = new ScheduleThicknessPractice("{DCE239CB-D04F-4193-A8D7-96D20D0D1253}", "Romania Standards (ASRO)", "", 590);
        public static readonly ScheduleThicknessPractice RussianFederationStandardsGostR = new ScheduleThicknessPractice("{5A38E447-DAE1-4B02-A6A6-E24B293F7C50}", "Russian Federation Standards (GOST R)", "", 600);
        public static readonly ScheduleThicknessPractice SaudiArabiaStandardsSaso = new ScheduleThicknessPractice("{7F0FDD9A-4DBA-4E1E-9260-2A0C8256146B}", "Saudi Arabia Standards (SASO)", "", 610);
        public static readonly ScheduleThicknessPractice SingaporeStandardsSpringSg = new ScheduleThicknessPractice("{1E95421E-1286-43DA-A668-8A18A37F30BB}", "Singapore Standards (SPRING SG)", "", 620);
        public static readonly ScheduleThicknessPractice SouthAfricaStandardsSabs = new ScheduleThicknessPractice("{CDCE66C6-926C-46BC-8079-27B70F247492}", "South Africa Standards (SABS)", "", 630);
        public static readonly ScheduleThicknessPractice SpainStandardsAenor = new ScheduleThicknessPractice("{EBB7BE19-044C-4EFD-8D79-B9447A1BC5CE}", "Spain Standards (AENOR)", "", 640);
        public static readonly ScheduleThicknessPractice SwedenStandardsSis = new ScheduleThicknessPractice("{08102808-F02E-445C-8572-C6E97E59BF09}", "Sweden Standards (SIS)", "", 650);
        public static readonly ScheduleThicknessPractice SwitzerlandStandardsSnv = new ScheduleThicknessPractice("{C20E23A7-1898-43C5-A9DA-8568875C4F2B}", "Switzerland Standards (SNV)", "", 660);
        public static readonly ScheduleThicknessPractice ThailandStandardsTisi = new ScheduleThicknessPractice("{F3A19C2A-8BEF-4685-BB54-298D849DD811}", "Thailand Standards (TISI)", "", 670);
        public static readonly ScheduleThicknessPractice TurkeyStandardsTse = new ScheduleThicknessPractice("{4BA84168-CCC1-479F-B2B9-6F5E0072FE8C}", "Turkey Standards (TSE)", "", 680);
        public static readonly ScheduleThicknessPractice UkraineStandardsDstu = new ScheduleThicknessPractice("{512C6CDB-B21B-4DEF-8425-802B6DE70B6D}", "Ukraine Standards (DSTU)", "", 690);
        public static readonly ScheduleThicknessPractice UnitedArabEmiratesStandardsSsuae = new ScheduleThicknessPractice("{1E2D3AB8-6E0F-40EE-B12C-92694133ADB5}", "United Arab Emirates Standards (SSUAE)", "", 700);
        public static readonly ScheduleThicknessPractice UruguayStandardsUnit = new ScheduleThicknessPractice("{61B3574B-8684-4520-831D-13467CCC0AB1}", "Uruguay Standards (UNIT)", "", 710);
        public static readonly ScheduleThicknessPractice VenezuelaStandardsFondonorma = new ScheduleThicknessPractice("{F9B5F5DB-278E-4C1B-A57F-9F03984E9863}", "Venezuela Standards (FONDONORMA)", "", 720);
        public static readonly ScheduleThicknessPractice VietNamStandardsTcvn = new ScheduleThicknessPractice("{E551B7F3-3B1A-4B2B-B7F4-0E98B6C1FB01}", "Viet Nam Standards (TCVN)", "", 730);
        public static readonly ScheduleThicknessPractice UseCalculatedWallThickness = new ScheduleThicknessPractice("{5F26E7FF-D0D0-4B38-96E1-8682122B05E3}", "Use Calculated Wall Thickness", "", 4);
        #endregion
        public ScheduleThicknessPractice(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator ScheduleThicknessPractice(string text)
        {
            return FindByText<ScheduleThicknessPractice>(text);
        }
    }
}