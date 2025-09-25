namespace Analysis2.SIO.Library.Enums
{
    public class EndPractice : SIOEnum
    {
        #region VALUES
        public static readonly EndPractice Undefined = new EndPractice("{87166ECF-12B0-45B7-8312-08A6F40B7C75}", "Undefined", "", 1);
        public static readonly EndPractice UnitedStatesOfAmericaStandards = new EndPractice("{A5FE83C1-1571-41D7-ACAE-52BB847C8005}", "United States of America, Standards", "", 5);
        public static readonly EndPractice UnitedStatesOfAmericaManufacturers = new EndPractice("{E3750AD8-5629-4C4D-BB72-C4E7E540B872}", "United States of America, Manufacturers", "", 6);
        public static readonly EndPractice GermanyStandardsDin = new EndPractice("{1591AD5F-E809-4DA8-B3E2-CF10385FEEB3}", "Germany, Standards (DIN)", "", 18);
        public static readonly EndPractice FinlandStandardsSfs = new EndPractice("{78EF4A6B-D0C1-41FE-B208-75295E49FC8F}", "Finland, Standards (SFS)", "", 20);
        public static readonly EndPractice GermanyManufacturers = new EndPractice("{E0402E1C-E7EB-41DE-8C00-0B2EB0AFC492}", "Germany, Manufacturers", "", 25);
        public static readonly EndPractice CenEuStandards = new EndPractice("{7D9618A7-54F8-41C5-8217-A8185AE2D083}", "CEN/EU, Standards", "", 30);
        public static readonly EndPractice UnitedKingdomStandardsBsi = new EndPractice("{66FA9F50-E313-4AAF-8DF0-657B471B2BB2}", "United Kingdom, Standards (BSI)", "", 33);
        public static readonly EndPractice UnitedKingdomManufacturers = new EndPractice("{83B67299-A2A1-48A6-98AB-329CF8EEE998}", "United Kingdom, Manufacturers", "", 34);
        public static readonly EndPractice OtherEuropeMiddleEastAndAfricaStandards = new EndPractice("{B4C5643F-7EC9-4525-B202-24B1981088DA}", "Other Europe, Middle East, and Africa, Standards", "", 35);
        public static readonly EndPractice JapanStandardsJisc = new EndPractice("{73A1F341-1CB3-4760-A83F-D5DA5AD8F399}", "Japan, Standards (JISC)", "", 40);
        public static readonly EndPractice ChinaStandardsSacs = new EndPractice("{8D775AC9-7E38-425E-999E-61864C0FB3DA}", "China, Standards (SACS)", "", 45);
        public static readonly EndPractice RepublicOfKoreaStandardsKats = new EndPractice("{16460D10-26F4-42BE-8D17-57E3A19C0892}", "Republic of Korea, Standards (KATS)", "", 50);
        public static readonly EndPractice OtherAsiaPacificStandards = new EndPractice("{8FA48EC8-2ADD-4C5E-BDF0-5A7052810911}", "Other Asia-Pacific, Standards", "", 55);
        public static readonly EndPractice AustraliaStandardsAs = new EndPractice("{495D5B11-8B54-451A-924C-1C58688B3362}", "Australia, Standards (AS)", "", 60);
        public static readonly EndPractice NorsokStandards = new EndPractice("{7209053B-BE0D-4BC2-BC59-BF3E959A3085}", "NORSOK, Standards", "", 65);
        public static readonly EndPractice KksStandards = new EndPractice("{AF73B3FA-6E5B-4401-B69A-B07242E892AE}", "KKS, Standards", "", 70);
        public static readonly EndPractice CompanyStandards = new EndPractice("{16281EE1-E48E-4513-8E1E-952DAF49CD77}", "Company, Standards", "", 75);
        public static readonly EndPractice JapanManufacturers = new EndPractice("{3335A50E-0283-4A12-AF48-44EDDD14AC56}", "Japan Manufacturers", "", 80);
        public static readonly EndPractice FinlandManufacturers = new EndPractice("{77AABF2D-6BF4-49D7-87FA-CAE7C9FB6F1B}", "Finland Manufacturers", "", 85);
        public static readonly EndPractice ChinaManufacturers = new EndPractice("{3E20E040-AB0B-43CE-B23E-56FDEE2B9FB0}", "China Manufacturers", "", 90);
        public static readonly EndPractice FranceStandardsAfnor = new EndPractice("{7D976BA1-B262-4878-88FF-9FEEF75DF2D5}", "France, Standards (AFNOR)", "", 95);
        public static readonly EndPractice RepublicOfKoreaManufacturers = new EndPractice("{E5B3155F-E87F-43C1-906E-6AFF20730DB9}", "Republic of Korea, Manufacturers", "", 100);
        public static readonly EndPractice FranceManufacturers = new EndPractice("{74266175-A4F5-4A6F-8BB0-509332F60962}", "France Manufacturers", "", 105);
        public static readonly EndPractice OtherAsiaPacificManufacturers = new EndPractice("{5EACBB4D-E4C2-4EB1-A995-7D6ABE7682F7}", "Other Asia-Pacific Manufacturers", "", 110);
        public static readonly EndPractice OtherEuropeMiddleEastAndAfricaManufacturers = new EndPractice("{2A77D284-849C-4301-8797-E6D57575BE80}", "Other Europe, Middle East, and Africa Manufacturers", "", 115);
        public static readonly EndPractice AustraliaManufacturers = new EndPractice("{E063DE8B-BAB3-4F51-A00F-CF77BE6E17C2}", "Australia Manufacturers", "", 120);
        public static readonly EndPractice OffshoreIndustryManufacturers = new EndPractice("{6D6F5F44-A40F-43E3-99D5-1C269E586AEF}", "Offshore Industry Manufacturers", "", 130);
        public static readonly EndPractice PowerIndustryManufacturers = new EndPractice("{1E529832-61A1-4414-A00B-1BA762AC7BE4}", "Power Industry Manufacturers", "", 140);
        public static readonly EndPractice OtherAmericasStandards = new EndPractice("{507E1DE2-906C-4973-A51A-10F8AEEBB16A}", "Other Americas, Standards", "", 150);
        public static readonly EndPractice OtherAmericasManufacturers = new EndPractice("{E6990E09-CAA7-43D4-B937-10D22C13AB37}", "Other Americas Manufacturers", "", 155);
        public static readonly EndPractice ArgentinaStandardsIram = new EndPractice("{27A1BFD9-CD12-49E8-9346-CC4155C795FA}", "Argentina, Standards (IRAM)", "", 200);
        public static readonly EndPractice AustriaStandardsOn = new EndPractice("{CC5EFE5C-A0B0-4BA5-94A3-970F70B61191}", "Austria, Standards (ON)", "", 210);
        public static readonly EndPractice BahrainStandardsBsmd = new EndPractice("{ACAB7F72-63A6-40C4-A14F-351B17DC47BC}", "Bahrain, Standards (BSMD)", "", 220);
        public static readonly EndPractice BarbadosStandardsBnsi = new EndPractice("{18F575B5-D168-4B23-8426-F5E92747EB26}", "Barbados, Standards (BNSI)", "", 230);
        public static readonly EndPractice BelarusStandardsBelst = new EndPractice("{F74FCA4E-18E4-486F-8303-6727116AB9B6}", "Belarus, Standards (BELST)", "", 240);
        public static readonly EndPractice BelgiumStandardsIbn = new EndPractice("{01A3AD5D-0F29-4FBA-8102-5FB27AC0C40D}", "Belgium, Standards (IBN)", "", 250);
        public static readonly EndPractice BoliviaStandardsIbnorca = new EndPractice("{99DFC4B1-7F6B-458B-A2BD-736FFCF639DD}", "Bolivia, Standards (IBNORCA)", "", 260);
        public static readonly EndPractice BrazilStandardsAbnt = new EndPractice("{41E9C7B3-34EC-4437-AE97-9011FA36DEB3}", "Brazil, Standards (ABNT)", "", 270);
        public static readonly EndPractice CanadaStandardsScc = new EndPractice("{C2FE3F72-8EF4-4180-9DB4-423C3C1F3C26}", "Canada, Standards (SCC)", "", 280);
        public static readonly EndPractice ChileStandardsInn = new EndPractice("{9848BDDB-60E0-4BC6-A02C-6F0FDC8D88D6}", "Chile, Standards (INN)", "", 290);
        public static readonly EndPractice ColombiaStandardsIcontec = new EndPractice("{5F626039-A471-4A32-A0C2-CDC34AFED26F}", "Colombia, Standards (ICONTEC)", "", 300);
        public static readonly EndPractice CostaRicaStandardsInteco = new EndPractice("{086AB8C8-A40F-428F-99A9-D80F9B229D18}", "Costa Rica, Standards (INTECO)", "", 310);
        public static readonly EndPractice CzechRepublicStandardsCsni = new EndPractice("{C3345774-0985-4BFC-9D4D-44DF00324C26}", "Czech Republic, Standards (CSNI)", "", 320);
        public static readonly EndPractice DenmarkStandardsDs = new EndPractice("{59575316-3611-419A-ABE3-4E99F59181B8}", "Denmark, Standards (DS)", "", 330);
        public static readonly EndPractice GreeceStandardsElot = new EndPractice("{7D1FAC66-FD3C-4970-8FB1-898F40D0C609}", "Greece, Standards (ELOT)", "", 340);
        public static readonly EndPractice HongKongStandardsItchksar = new EndPractice("{3B714CB2-BC61-42E2-90BA-C1C7DC060FFF}", "Hong Kong, Standards (ITCHKSAR)", "", 350);
        public static readonly EndPractice IcelandStandardsIst = new EndPractice("{F44CD912-0612-4E6D-8C8A-99B30918C96F}", "Iceland, Standards (IST)", "", 360);
        public static readonly EndPractice IndiaStandardsBis = new EndPractice("{68A73B09-499D-495D-985B-94CAD833C0B5}", "India, Standards (BIS)", "", 370);
        public static readonly EndPractice IndonesiaStandardsBsn = new EndPractice("{0D57AE25-F2EB-4D94-B064-AF9BCFA98544}", "Indonesia, Standards (BSN)", "", 380);
        public static readonly EndPractice IrelandStandardsNsai = new EndPractice("{2A84D2A2-3519-47E9-987D-EBBEC5953A6A}", "Ireland, Standards (NSAI)", "", 390);
        public static readonly EndPractice IsraelStandardsSii = new EndPractice("{BAE4221C-E47E-4A6D-8134-2B59CC27F231}", "Israel, Standards (SII)", "", 400);
        public static readonly EndPractice ItalyStandardsUni = new EndPractice("{F2B1D41C-D8B3-447F-9AE4-159A4E8CAE3E}", "Italy, Standards (UNI)", "", 410);
        public static readonly EndPractice ItalyManufacturers = new EndPractice("{1ED64A35-C394-45AF-9CA8-22B98334312B}", "Italy, Manufacturers", "", 411);
        public static readonly EndPractice JordanStandardsJism = new EndPractice("{38B0EFA6-DE54-4C57-A68B-1440527087CD}", "Jordan, Standards (JISM)", "", 420);
        public static readonly EndPractice KuwaitStandardsKowsmd = new EndPractice("{B2D87B93-75AB-4E01-B531-3D0E2C8BA230}", "Kuwait, Standards (KOWSMD)", "", 430);
        public static readonly EndPractice LebanonStandardsLibnor = new EndPractice("{CB4130F4-7D3D-484B-B5D9-53679FFA89C2}", "Lebanon, Standards (LIBNOR)", "", 440);
        public static readonly EndPractice LuxembourgStandardsSee = new EndPractice("{C277B1DE-9C58-4F08-AAC5-7D20FB7AE70E}", "Luxembourg, Standards (SEE)", "", 450);
        public static readonly EndPractice MalaysiaStandardsDsm = new EndPractice("{3F3CD19B-C705-4C66-9D86-4BD69AE4F03F}", "Malaysia, Standards (DSM)", "", 460);
        public static readonly EndPractice MaltaStandardsMsa = new EndPractice("{47776058-5AE9-4217-9FB6-115C0BF5269D}", "Malta, Standards (MSA)", "", 470);
        public static readonly EndPractice MexicoStandardsDgn = new EndPractice("{DFDC953F-68CD-47FF-8FF7-5DA3294D5357}", "Mexico, Standards (DGN)", "", 480);
        public static readonly EndPractice NetherlandsStandardsNen = new EndPractice("{BC32FCF2-850D-47D3-84D5-B0BF023492AC}", "Netherlands, Standards (NEN)", "", 490);
        public static readonly EndPractice NewZealandStandardsSnz = new EndPractice("{1F16A011-4F47-406C-BBBF-E4D22C4DDC4C}", "New Zealand, Standards (SNZ)", "", 500);
        public static readonly EndPractice NorwayStandardsNsf = new EndPractice("{A417BB09-D65B-42C5-8B64-47960FD4CB08}", "Norway, Standards (NSF)", "", 510);
        public static readonly EndPractice NorwayManufacturers = new EndPractice("{7A8E55E9-325B-4926-83C0-CFCF161BDF5E}", "Norway, Manufacturers", "", 511);
        public static readonly EndPractice OmanStandardsDgsm = new EndPractice("{CAD74460-62B2-43C8-A78B-FBF7E24E4FB9}", "Oman, Standards (DGSM)", "", 520);
        public static readonly EndPractice PanamaStandardsCopanit = new EndPractice("{D2C00A81-A476-4645-880D-1AC27904773F}", "Panama, Standards (COPANIT)", "", 530);
        public static readonly EndPractice ParaguayStandardsIntn = new EndPractice("{7A5C9E2D-644F-420A-B605-A2DFBA681911}", "Paraguay, Standards (INTN)", "", 540);
        public static readonly EndPractice PeruStandardsIndecopi = new EndPractice("{B3F00616-F322-4591-A828-EBD61FF44D43}", "Peru, Standards (INDECOPI)", "", 550);
        public static readonly EndPractice PhilippinesStandardsBps = new EndPractice("{A649BB90-3A28-4236-BD3D-7C68022DF4EC}", "Philippines, Standards (BPS)", "", 560);
        public static readonly EndPractice PolandStandardsPkn = new EndPractice("{FBC48F34-B492-4B49-9A71-85A2DC13EE7F}", "Poland, Standards (PKN)", "", 570);
        public static readonly EndPractice PortugalStandardsIpq = new EndPractice("{63338045-0EF4-4BD7-BEAD-98B3B76D6158}", "Portugal, Standards (IPQ)", "", 580);
        public static readonly EndPractice RomaniaStandardsAsro = new EndPractice("{1FDA8D47-3656-41DA-AE33-BC1A7E417731}", "Romania, Standards (ASRO)", "", 590);
        public static readonly EndPractice RussianFederationStandardsGostR = new EndPractice("{B794D391-5C54-4335-9F11-1A0CCE812932}", "Russian Federation, Standards (GOST R)", "", 600);
        public static readonly EndPractice SaudiArabiaStandardsSaso = new EndPractice("{31D50690-203D-4315-AA4F-A8908C54FD31}", "Saudi Arabia, Standards (SASO)", "", 610);
        public static readonly EndPractice SingaporeStandardsSpringSg = new EndPractice("{B9E3BD54-5412-48C2-B28C-E085AE71EA84}", "Singapore, Standards (SPRING SG)", "", 620);
        public static readonly EndPractice SouthAfricaStandardsSabs = new EndPractice("{C4C7F03D-C32D-4C06-B18B-C9CEEB0B8541}", "South Africa, Standards (SABS)", "", 630);
        public static readonly EndPractice SpainStandardsAenor = new EndPractice("{4F055F43-0DC5-4036-9DEA-43A8DA745774}", "Spain, Standards (AENOR)", "", 640);
        public static readonly EndPractice SwedenStandardsSis = new EndPractice("{D3924CDE-15D4-4F34-8933-0244C940E1DA}", "Sweden, Standards (SIS)", "", 650);
        public static readonly EndPractice SwitzerlandStandardsSnv = new EndPractice("{770D043D-ADA1-4C6A-8909-899ECCEC3BCE}", "Switzerland, Standards (SNV)", "", 660);
        public static readonly EndPractice ThailandStandardsTisi = new EndPractice("{6C8C49F9-9774-4435-85C6-9D56B09743B5}", "Thailand, Standards (TISI)", "", 670);
        public static readonly EndPractice TurkeyStandardsTse = new EndPractice("{27FAF0DC-417B-40A8-BE42-D9B69BB8CDBB}", "Turkey, Standards (TSE)", "", 680);
        public static readonly EndPractice UkraineStandardsDstu = new EndPractice("{FD2BA477-AF4D-4514-820E-267699107892}", "Ukraine, Standards (DSTU)", "", 690);
        public static readonly EndPractice UnitedArabEmiratesStandardsSsuae = new EndPractice("{AA8B17A6-E0D5-4DC9-ABE5-1B6E60ABB498}", "United Arab Emirates, Standards (SSUAE)", "", 700);
        public static readonly EndPractice UruguayStandardsUnit = new EndPractice("{91BCF314-289B-400E-B1A4-57DF82EEDE72}", "Uruguay, Standards (UNIT)", "", 710);
        public static readonly EndPractice VenezuelaStandardsFondonorma = new EndPractice("{EBF2DCFE-34FA-4E72-9D29-72193106D066}", "Venezuela, Standards (FONDONORMA)", "", 720);
        public static readonly EndPractice VietNamStandardsTcvn = new EndPractice("{50759F83-F534-4D3E-B9D9-060A0758833A}", "Viet Nam, Standards (TCVN)", "", 730);
        public static readonly EndPractice CompanyPractice = new EndPractice("{F163DE37-1484-456F-A297-F43559A2A1E4}", "Company Practice", "", 125);
        public static readonly EndPractice IsoStandards = new EndPractice("{AC805172-FAEE-4B26-AFD8-1D6F40B5284C}", "ISO Standards", "", 135);
        public static readonly EndPractice IecInternationalElectricalCongressStandards = new EndPractice("{7F777BEA-53B5-44F0-B800-7529F6B18FA8}", "IEC (International Electrical Congress) Standards", "", 740);
        public static readonly EndPractice NonWettedInstruments = new EndPractice("{61EB1F11-5A8D-49A2-9F8D-9A670CC2BEE8}", "Non-Wetted Instruments", "", 46);
        #endregion
        public EndPractice(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator EndPractice(string text)
        {
            return FindByText<EndPractice>(text);
        }
    }
}