using System.Diagnostics.CodeAnalysis;

namespace Hexagon.ALI.Analysis.Common.Enums
{
    [ExcludeFromCodeCoverage]
    public class MaterialsGradePractice : SIOEnum
    {
        #region VALUES

        public static readonly MaterialsGradePractice Undefined = new MaterialsGradePractice("{a540bd22-842b-4ae6-89a3-341485243371}", "Undefined", "", 1);
        public static readonly MaterialsGradePractice UniversalGenericMaterials = new MaterialsGradePractice("{904af998-b1e1-4526-b03f-3e2f1a0a28b7}", "Universal, Generic Materials", "", 4);
        public static readonly MaterialsGradePractice UnitedStatesOfAmericaStandards = new MaterialsGradePractice("{a5401f4f-4438-4c6c-8993-bb142ee3bccd}", "United States of America, Standards", "", 5);
        public static readonly MaterialsGradePractice GermanyStandardsDin = new MaterialsGradePractice("{218b00fb-fd3b-469a-90ff-5e746287e9c3}", "Germany Standards (DIN)", "", 18);
        public static readonly MaterialsGradePractice FinlandStandardsSfs = new MaterialsGradePractice("{c9d38274-61b9-4ade-8c69-727dc66a8982}", "Finland Standards (SFS)", "", 20);
        public static readonly MaterialsGradePractice CenEuStandards = new MaterialsGradePractice("{9b26bd5a-a8bc-4733-a78a-993b3edbb72f}", "CEN/EU Standards", "", 30);
        public static readonly MaterialsGradePractice UnitedKingdomStandardsBsi = new MaterialsGradePractice("{758f8760-99ab-463b-a461-5f7267b8387e}", "United Kingdom Standards (BSI)", "", 33);
        public static readonly MaterialsGradePractice OtherEuropeMiddleEastAndAfricaStandards = new MaterialsGradePractice("{c739d8b4-edad-4a48-acb1-764c63a41e0f}", "Other Europe, Middle East, and Africa Standards", "", 35);
        public static readonly MaterialsGradePractice JapanStandardsJisc = new MaterialsGradePractice("{f2fd0255-9f64-4653-8356-658dacf02752}", "Japan Standards (JISC)", "", 40);
        public static readonly MaterialsGradePractice ChinaStandardsGbGuojiaBiaozhunSacs = new MaterialsGradePractice("{0a704106-1e8f-4f92-966b-ebbfdfcfd79d}", "China Standards (GB, Guojia Biaozhun; SACS)", "", 45);
        public static readonly MaterialsGradePractice RepublicOfKoreaStandardsKats = new MaterialsGradePractice("{f1c00648-d67b-4aa5-878b-f9f2665b635d}", "Republic of Korea, Standards (KATS)", "", 50);
        public static readonly MaterialsGradePractice OtherAsiaPacificStandards = new MaterialsGradePractice("{47f47a7a-92a9-472b-a3bd-11be512f7e0a}", "Other Asia-Pacific Standards", "", 55);
        public static readonly MaterialsGradePractice AustraliaStandardsAs = new MaterialsGradePractice("{619c8cd3-4050-4849-8453-fd18d355fb62}", "Australia Standards (AS)", "", 60);
        public static readonly MaterialsGradePractice NorsokStandards = new MaterialsGradePractice("{c1218e3e-9d6e-4288-8533-5e51c35d5afd}", "NORSOK Standards", "", 65);
        public static readonly MaterialsGradePractice KksStandards = new MaterialsGradePractice("{12998ef0-af28-4584-8f61-d2b295ab63e5}", "KKS Standards", "", 70);
        public static readonly MaterialsGradePractice CompanyStandards = new MaterialsGradePractice("{70e2edae-1a04-4177-8cb4-065abd34fbfc}", "Company Standards", "", 75);
        public static readonly MaterialsGradePractice FranceStandardsAfnor = new MaterialsGradePractice("{34faf22d-d81c-49f1-9f5c-f8e2206d848e}", "France Standards (AFNOR)", "", 95);
        public static readonly MaterialsGradePractice OtherAmericasStandards = new MaterialsGradePractice("{bafda68d-8c69-4f83-9c63-e32ccc79f55f}", "Other Americas Standards", "", 150);
        public static readonly MaterialsGradePractice ArgentinaStandardsIram = new MaterialsGradePractice("{9fa48500-3536-418c-85ee-a3a2103c4dfc}", "Argentina Standards (IRAM)", "", 200);
        public static readonly MaterialsGradePractice AustriaStandardsOn = new MaterialsGradePractice("{fe27bc66-3c9d-46b5-8b37-b65b008c67bb}", "Austria Standards (ON)", "", 210);
        public static readonly MaterialsGradePractice BahrainStandardsBsmd = new MaterialsGradePractice("{aeac0436-41f5-4520-9785-222f9b8b45d9}", "Bahrain Standards (BSMD)", "", 220);
        public static readonly MaterialsGradePractice BarbadosStandardsBnsi = new MaterialsGradePractice("{dbbef9be-cbd7-4144-9a2a-27862da4503f}", "Barbados Standards (BNSI)", "", 230);
        public static readonly MaterialsGradePractice BelarusStandardsBelst = new MaterialsGradePractice("{85f358d7-8f5d-4a86-868f-21493a48ce3b}", "Belarus Standards (BELST)", "", 240);
        public static readonly MaterialsGradePractice BelgiumStandardsIbn = new MaterialsGradePractice("{3e4d7872-508c-4710-895e-83a744e9f956}", "Belgium Standards (IBN)", "", 250);
        public static readonly MaterialsGradePractice BoliviaStandardsIbnorca = new MaterialsGradePractice("{8e3dbe0b-77d7-4b0e-a262-934bc9f84f94}", "Bolivia Standards (IBNORCA)", "", 260);
        public static readonly MaterialsGradePractice BrazilStandardsAbnt = new MaterialsGradePractice("{202576a1-a628-40ab-82b4-efc4712e55ff}", "Brazil Standards (ABNT)", "", 270);
        public static readonly MaterialsGradePractice CanadaStandardsScc = new MaterialsGradePractice("{ba1bd056-20d4-4810-b0a5-104310ba5b11}", "Canada Standards (SCC)", "", 280);
        public static readonly MaterialsGradePractice ChileStandardsInn = new MaterialsGradePractice("{afa2d312-87b3-4c94-8d86-f27ac1a5ad2c}", "Chile Standards (INN)", "", 290);
        public static readonly MaterialsGradePractice ColombiaStandardsIcontec = new MaterialsGradePractice("{b968e7e9-ce47-4f53-ad51-9b610b1fc6bf}", "Colombia Standards (ICONTEC)", "", 300);
        public static readonly MaterialsGradePractice CostaRicaStandardsInteco = new MaterialsGradePractice("{8f457352-a8ea-412e-8e73-fc87d34951f7}", "Costa Rica Standards (INTECO)", "", 310);
        public static readonly MaterialsGradePractice CzechRepublicStandardsCsni = new MaterialsGradePractice("{03d32b96-8842-4f45-9324-5e217450d36b}", "Czech Republic Standards (CSNI)", "", 320);
        public static readonly MaterialsGradePractice DenmarkStandardsDs = new MaterialsGradePractice("{96d67c86-0791-4cbc-bbd0-8b1f6c0c92a8}", "Denmark Standards (DS)", "", 330);
        public static readonly MaterialsGradePractice GreeceStandardsElot = new MaterialsGradePractice("{0e0f785d-e547-4bbb-8145-23eeadc0a9c2}", "Greece Standards (ELOT)", "", 340);
        public static readonly MaterialsGradePractice HongKongStandardsItchksar = new MaterialsGradePractice("{a4677ccb-20e1-44f6-9a49-856ef6548f78}", "Hong Kong Standards (ITCHKSAR)", "", 350);
        public static readonly MaterialsGradePractice IcelandStandardsIst = new MaterialsGradePractice("{36bc7ead-2b8d-4025-925a-ddc1e5b3da32}", "Iceland Standards (IST)", "", 360);
        public static readonly MaterialsGradePractice IndiaStandardsBis = new MaterialsGradePractice("{39d80bda-557f-451f-8049-fe76b26ea75e}", "India Standards (BIS)", "", 370);
        public static readonly MaterialsGradePractice IndonesiaStandardsBsn = new MaterialsGradePractice("{07c62037-5dee-45a6-aec7-46a1bd632961}", "Indonesia Standards (BSN)", "", 380);
        public static readonly MaterialsGradePractice IrelandStandardsNsai = new MaterialsGradePractice("{5cabf790-c414-4322-b80b-8a6cd5f8789e}", "Ireland Standards (NSAI)", "", 390);
        public static readonly MaterialsGradePractice IsraelStandardsSii = new MaterialsGradePractice("{b8a58e81-ee95-4737-a28c-0279a13b2b92}", "Israel Standards (SII)", "", 400);
        public static readonly MaterialsGradePractice ItalyStandardsUni = new MaterialsGradePractice("{2ec54a4e-f018-4d3a-8b05-38e13e6a3ed8}", "Italy Standards (UNI)", "", 410);
        public static readonly MaterialsGradePractice JordanStandardsJism = new MaterialsGradePractice("{69d13423-973c-4f7d-9576-711b0569d07a}", "Jordan Standards (JISM)", "", 420);
        public static readonly MaterialsGradePractice KuwaitStandardsKowsmd = new MaterialsGradePractice("{79bb53dd-1897-4dff-a619-cf1f099745fc}", "Kuwait Standards (KOWSMD)", "", 430);
        public static readonly MaterialsGradePractice LebanonStandardsLibnor = new MaterialsGradePractice("{ebdffec4-aba1-439d-97a9-cd776e8a7576}", "Lebanon Standards (LIBNOR)", "", 440);
        public static readonly MaterialsGradePractice LuxembourgStandardsSee = new MaterialsGradePractice("{eb6e6b1b-ef94-40e3-86bc-30354e872553}", "Luxembourg Standards (SEE)", "", 450);
        public static readonly MaterialsGradePractice MalaysiaStandardsDsm = new MaterialsGradePractice("{d79cf921-5867-4998-a66e-1013130d750c}", "Malaysia Standards (DSM)", "", 460);
        public static readonly MaterialsGradePractice MaltaStandardsMsa = new MaterialsGradePractice("{5e278a3d-a218-46f3-8085-7e3a1fe3ab2a}", "Malta Standards (MSA)", "", 470);
        public static readonly MaterialsGradePractice MexicoStandardsDgn = new MaterialsGradePractice("{cdf15d5c-9333-455a-9b96-01a4cf8bb871}", "Mexico Standards (DGN)", "", 480);
        public static readonly MaterialsGradePractice NetherlandsStandardsNen = new MaterialsGradePractice("{c940d202-4372-485f-abb2-6380de595a4a}", "Netherlands Standards (NEN)", "", 490);
        public static readonly MaterialsGradePractice NewZealandStandardsSnz = new MaterialsGradePractice("{2d3b9ac2-9267-46fe-8baa-24ed70ba79a4}", "New Zealand Standards (SNZ)", "", 500);
        public static readonly MaterialsGradePractice NorwayStandardsNsf = new MaterialsGradePractice("{48700b42-f4cc-489e-b13b-f464afebea1b}", "Norway Standards (NSF)", "", 510);
        public static readonly MaterialsGradePractice OmanStandardsDgsm = new MaterialsGradePractice("{dbd3fc2b-437d-42cb-aedc-d7281d0192f7}", "Oman Standards (DGSM)", "", 520);
        public static readonly MaterialsGradePractice PanamaStandardsCopanit = new MaterialsGradePractice("{d323eb11-c57c-40b6-a1c8-f0fb99c633b6}", "Panama Standards (COPANIT)", "", 530);
        public static readonly MaterialsGradePractice ParaguayStandardsIntn = new MaterialsGradePractice("{bc0e59ed-9040-4a2f-a630-0b19529566c0}", "Paraguay Standards (INTN)", "", 540);
        public static readonly MaterialsGradePractice PeruStandardsIndecopi = new MaterialsGradePractice("{b5fc768e-1244-425d-95b9-3411c1dde77c}", "Peru Standards (INDECOPI)", "", 550);
        public static readonly MaterialsGradePractice PhilippinesStandardsBps = new MaterialsGradePractice("{0d3fa301-102a-4ffb-855e-a0d961a5e8c0}", "Philippines Standards (BPS)", "", 560);
        public static readonly MaterialsGradePractice PolandStandardsPkn = new MaterialsGradePractice("{c8fd8831-5678-4021-b829-22584b8daeaf}", "Poland Standards (PKN)", "", 570);
        public static readonly MaterialsGradePractice PortugalStandardsIpq = new MaterialsGradePractice("{04e896db-662d-4db1-8d48-014fd45e9ec4}", "Portugal Standards (IPQ)", "", 580);
        public static readonly MaterialsGradePractice RomaniaStandardsAsro = new MaterialsGradePractice("{6b99d822-3d94-4187-975d-1d91cc602e62}", "Romania Standards (ASRO)", "", 590);
        public static readonly MaterialsGradePractice RussianFederationStandardsGostR = new MaterialsGradePractice("{5c156b97-d4bb-43ce-b4a3-b1407f60765f}", "Russian Federation Standards (GOST R)", "", 600);
        public static readonly MaterialsGradePractice SaudiArabiaStandardsSaso = new MaterialsGradePractice("{98a10d7f-15e6-4a15-ba7b-3c560eef07c1}", "Saudi Arabia Standards (SASO)", "", 610);
        public static readonly MaterialsGradePractice SingaporeStandardsSpringSg = new MaterialsGradePractice("{67f2044c-2f79-490b-8968-0c2a7c6d6226}", "Singapore Standards (SPRING SG)", "", 620);
        public static readonly MaterialsGradePractice SouthAfricaStandardsSabs = new MaterialsGradePractice("{2f66eb80-0ef1-4657-b4e7-42eca965bef2}", "South Africa Standards (SABS)", "", 630);
        public static readonly MaterialsGradePractice SpainStandardsAenor = new MaterialsGradePractice("{39a2dc68-2e53-4dc1-957a-1de47fa0f904}", "Spain Standards (AENOR)", "", 640);
        public static readonly MaterialsGradePractice SwedenStandardsSis = new MaterialsGradePractice("{6c8dcf74-c71a-4d67-a373-b4ac309fa41f}", "Sweden Standards (SIS)", "", 650);
        public static readonly MaterialsGradePractice SwitzerlandStandardsSnv = new MaterialsGradePractice("{14780f48-4a20-4c00-be39-0e7ba931f923}", "Switzerland Standards (SNV)", "", 660);
        public static readonly MaterialsGradePractice ThailandStandardsTisi = new MaterialsGradePractice("{e902424a-0bc0-45dd-b01a-113479d5879d}", "Thailand Standards (TISI)", "", 670);
        public static readonly MaterialsGradePractice TurkeyStandardsTse = new MaterialsGradePractice("{0d829d18-df13-4216-8801-9f54bc4c9f77}", "Turkey Standards (TSE)", "", 680);
        public static readonly MaterialsGradePractice UkraineStandardsDstu = new MaterialsGradePractice("{001abe41-e683-4f3b-945a-4f62c79e10d9}", "Ukraine Standards (DSTU)", "", 690);
        public static readonly MaterialsGradePractice UnitedArabEmiratesStandardsSsuae = new MaterialsGradePractice("{783413df-d9f8-49d5-9491-cbd5ae10fd14}", "United Arab Emirates Standards (SSUAE)", "", 700);
        public static readonly MaterialsGradePractice UruguayStandardsUnit = new MaterialsGradePractice("{37ec2c62-80ce-4664-9faf-9b1e16e854d4}", "Uruguay Standards (UNIT)", "", 710);
        public static readonly MaterialsGradePractice VenezuelaStandardsFondonorma = new MaterialsGradePractice("{f52c6063-b033-4aff-ae59-6c54a89ffdb6}", "Venezuela Standards (FONDONORMA)", "", 720);
        public static readonly MaterialsGradePractice VietNamStandardsTcvn = new MaterialsGradePractice("{4e60be3f-679f-4d70-bcfc-71f4b6250e74}", "Viet Nam Standards (TCVN)", "", 730);
        public static readonly MaterialsGradePractice IsoStandards = new MaterialsGradePractice("{803b36c3-6d01-4160-938e-7b8a4143042d}", "ISO Standards", "", 105031);

        #endregion VALUES

        public MaterialsGradePractice(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
            dict.TryAdd(uid, text);
        }

    }
}