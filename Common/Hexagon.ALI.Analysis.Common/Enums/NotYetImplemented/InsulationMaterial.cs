namespace Analysis2.SIO.Library.Enums
{
    public class InsulationMaterial : SIOEnum
    {
        #region VALUES
        public static readonly InsulationMaterial Undefined = new InsulationMaterial("{0BC515A0-972B-400A-8B07-91E30E88C0D8}", "Undefined", "", 1);
        public static readonly InsulationMaterial Ap = new InsulationMaterial("{8DA4B4F9-4389-41AD-B787-CE7C7C1E2C30}", "AP", "", 21);
        public static readonly InsulationMaterial ArmacellArmaflex = new InsulationMaterial("{3067AFA3-F1F9-41A0-AD6C-F5E8CC9757D6}", "Armacell Armaflex", "", 41);
        public static readonly InsulationMaterial ArmacellTubolitSelfSealPolyethylene = new InsulationMaterial("{B8A4EA3C-2637-4EC0-B1D9-9BD4DA195599}", "Armacell Tubolit self-seal polyethylene", "", 42);
        public static readonly InsulationMaterial As = new InsulationMaterial("{12EB29A7-B69C-11D6-BDB9-00104BCC2B69}", "AS", "", 6);
        public static readonly InsulationMaterial Brick = new InsulationMaterial("{12EB29AD-B69C-11D6-BDB9-00104BCC2B69}", "Brick", "", 7);
        public static readonly InsulationMaterial Cf = new InsulationMaterial("{D40920C0-6441-42BC-BF79-58D3E92731D7}", "CF", "", 50);
        public static readonly InsulationMaterial Cg = new InsulationMaterial("{B3C9FE2D-6BE7-4C86-9D74-0B27D2EA08E8}", "CG", "", 27);
        public static readonly InsulationMaterial Cork = new InsulationMaterial("{12EB29C5-B69C-11D6-BDB9-00104BCC2B69}", "Cork", "", 11);
        public static readonly InsulationMaterial Cs = new InsulationMaterial("{12EB298F-B69C-11D6-BDB9-00104BCC2B69}", "CS", "", 2);
        public static readonly InsulationMaterial Cw = new InsulationMaterial("{12EB29B3-B69C-11D6-BDB9-00104BCC2B69}", "CW", "", 8);
        public static readonly InsulationMaterial Da = new InsulationMaterial("{EC2537E0-06FE-435C-805E-B3F0D748B286}", "DA", "", 24);
        public static readonly InsulationMaterial Db = new InsulationMaterial("{CABF4742-3D29-40A9-9A83-9F074CF55F96}", "DB", "", 25);
        public static readonly InsulationMaterial DowStyrofoaExtrudedPolystyrene = new InsulationMaterial("{252A220E-0317-4D6D-A765-327784E57157}", "Dow Styrofoa extruded polystyrene", "", 14);
        public static readonly InsulationMaterial DowTrymer2000XpRigidPolyisocyanurate = new InsulationMaterial("{C64D69A0-103F-429C-BA23-D6B9F43460A5}", "Dow Trymer  2000 XP rigid polyisocyanurate", "", 13);
        public static readonly InsulationMaterial Ds = new InsulationMaterial("{4DFB0514-F349-48B2-AFAD-C21655E90377}", "DS", "", 60);
        public static readonly InsulationMaterial Ep = new InsulationMaterial("{901EF8B6-92F5-48B1-ACC4-91636AA28074}", "EP", "", 35);
        public static readonly InsulationMaterial Fbg = new InsulationMaterial("{12EB29A1-B69C-11D6-BDB9-00104BCC2B69}", "FBG", "", 5);
        public static readonly InsulationMaterial Fe = new InsulationMaterial("{6D7C724E-D35D-4E4C-8D44-E8D509B1506B}", "FE", "", 30);
        public static readonly InsulationMaterial Fg = new InsulationMaterial("{12EB2995-B69C-11D6-BDB9-00104BCC2B69}", "FG", "", 3);
        public static readonly InsulationMaterial Gim = new InsulationMaterial("{22516A76-7066-4278-B945-AD17FF212EEE}", "GIM", "", 55);
        public static readonly InsulationMaterial Gw = new InsulationMaterial("{12EB29B9-B69C-11D6-BDB9-00104BCC2B69}", "GW", "", 9);
        public static readonly InsulationMaterial IndustrialInsulationGroupthermo12GoldCalciumSilicate = new InsulationMaterial("{86FA8AE4-A765-4919-9AB6-C2DA96F00DAE}", "Industrial Insulation GroupThermo-12 Gold calcium silicate", "", 12);
        public static readonly InsulationMaterial JohnsManvilleMicroFlex = new InsulationMaterial("{DC4052C5-53E3-49E3-8E6B-59F679A90AF3}", "Johns Manville Micro-Flex", "", 36);
        public static readonly InsulationMaterial JohnsManvilleMicroLok = new InsulationMaterial("{DEC14308-AD11-4BAD-9062-BF04FD5C4D8F}", "Johns Manville Micro-Lok", "", 37);
        public static readonly InsulationMaterial JohnsManvillePermacoteLinacoustic = new InsulationMaterial("{AECB8DB5-643C-431A-A8DD-611E1FD67C1E}", "Johns Manville Permacote Linacoustic", "", 38);
        public static readonly InsulationMaterial JohnsManvillePrecipitatorSpinGlas = new InsulationMaterial("{1A814C8E-C185-435B-B9ED-FA02B215636B}", "Johns Manville Precipitator Spin Glas", "", 39);
        public static readonly InsulationMaterial Mf = new InsulationMaterial("{6665FC15-5B24-46B8-B0BF-0DAF17590677}", "MF", "", 40);
        public static readonly InsulationMaterial Mg = new InsulationMaterial("{0A4ED4C6-1E50-447D-A4FD-1D4DC0892DBD}", "MG", "", 65);
        public static readonly InsulationMaterial Mw = new InsulationMaterial("{1677F859-DAA9-4AFD-A6BC-E8B885AEC384}", "MW", "", 20);
        public static readonly InsulationMaterial OwensCorningAsj25 = new InsulationMaterial("{8BF86BF8-CA96-436D-8355-EFF7937A050F}", "Owens Corning ASJ 25", "", 31);
        public static readonly InsulationMaterial OwensCorningAsjSslIi = new InsulationMaterial("{F929208F-439F-4BFB-AD2A-7B76B03527F0}", "Owens Corning ASJ/SSL-II", "", 29);
        public static readonly InsulationMaterial OwensCorningHeavyDensity = new InsulationMaterial("{261CDFE6-115E-41B1-86E1-F609050D36D8}", "Owens Corning Heavy Density", "", 16);
        public static readonly InsulationMaterial OwensCorningPipeshield = new InsulationMaterial("{2FFF4462-C2B0-4C53-8B13-CC5F2FD73361}", "Owens Corning Pipeshield", "", 33);
        public static readonly InsulationMaterial OwensCorningSsl = new InsulationMaterial("{5DD4F188-66D0-412E-8D66-11C08ED47BB8}", "Owens Corning SSL", "", 17);
        public static readonly InsulationMaterial OwensCorningSslIi = new InsulationMaterial("{A9182A33-C232-49BC-BAD5-3584E0E99A75}", "Owens Corning SSL-II", "", 28);
        public static readonly InsulationMaterial OwensCorningVaporwick = new InsulationMaterial("{405D518A-035F-4874-882D-74F4A67DEBF0}", "Owens Corning Vaporwick", "", 32);
        public static readonly InsulationMaterial OwensCorningVitroFibras = new InsulationMaterial("{BA1260B6-A555-43D3-B015-42D21C95E35D}", "Owens Corning Vitro Fibras", "", 34);
        public static readonly InsulationMaterial Peth = new InsulationMaterial("{D89776E4-60DC-4A8D-BE07-84C263C6F2BE}", "PETH", "", 85);
        public static readonly InsulationMaterial Pf = new InsulationMaterial("{F55582DC-3761-4D9D-8038-5543D2EA78E5}", "PF", "", 70);
        public static readonly InsulationMaterial Phf = new InsulationMaterial("{53204B5F-02B7-48D1-98CC-382B5A2A37DF}", "PHF", "", 75);
        public static readonly InsulationMaterial Pi = new InsulationMaterial("{36D19F63-11F6-401F-82A2-64C2A643B2B1}", "PI", "", 19);
        public static readonly InsulationMaterial PittsburghCorningCorporationFoamglas = new InsulationMaterial("{689A968F-A0AA-4DA3-AB95-8D46DB512E5C}", "Pittsburgh Corning Corporation FOAMGLAS", "", 15);
        public static readonly InsulationMaterial Po = new InsulationMaterial("{51EDA67A-C097-4BFC-B532-4A249C41B08B}", "PO", "", 45);
        public static readonly InsulationMaterial Ppb = new InsulationMaterial("{3C28CCC8-0B4F-4EF6-90D1-DE7C9A217F04}", "PPB", "", 90);
        public static readonly InsulationMaterial Pr = new InsulationMaterial("{529C1C3F-0610-41CC-B05F-8F67EFBDAC45}", "PR", "", 22);
        public static readonly InsulationMaterial Pu = new InsulationMaterial("{2022AE44-7143-4B6B-89ED-30CB0D53BC12}", "PU", "", 18);
        public static readonly InsulationMaterial Pvcn = new InsulationMaterial("{BC481BDD-A060-415E-B319-8FE5E4E58E58}", "PVCN", "", 80);
        public static readonly InsulationMaterial Rb = new InsulationMaterial("{12EB29BF-B69C-11D6-BDB9-00104BCC2B69}", "RB", "", 10);
        public static readonly InsulationMaterial St = new InsulationMaterial("{70A13A54-C75A-4B70-896E-C5579D97E4EE}", "ST", "", 23);
        public static readonly InsulationMaterial Ur = new InsulationMaterial("{12EB299B-B69C-11D6-BDB9-00104BCC2B69}", "UR", "", 4);
        #endregion
        public InsulationMaterial(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator InsulationMaterial(string text)
        {
            return FindByText<InsulationMaterial>(text);
        }
    }
}