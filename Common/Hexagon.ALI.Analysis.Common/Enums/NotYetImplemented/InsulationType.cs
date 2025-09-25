namespace Analysis2.SIO.Library.Enums
{
    public class InsulationType : SIOEnum
    {
        #region VALUES
        public static readonly InsulationType Undefined = new InsulationType("{99E83C93-EAEE-4308-AF03-49B959E87A22}", "Undefined", "", 1);
        public static readonly InsulationType None = new InsulationType("{4930FD6E-D907-403C-BA9D-2B0C02DDE25B}", "None", "", 2);
        public static readonly InsulationType R11 = new InsulationType("{CB37D1FF-9D6B-11D6-BDA5-00104BCC2B69}", "R11", "", 30);
        public static readonly InsulationType R15 = new InsulationType("{CB37D205-9D6B-11D6-BDA5-00104BCC2B69}", "R15", "", 32);
        public static readonly InsulationType R18 = new InsulationType("{CB37D20B-9D6B-11D6-BDA5-00104BCC2B69}", "R18", "", 34);
        public static readonly InsulationType Preins = new InsulationType("{FA989414-43BC-45A2-AE3B-89426E0E5820}", "PREINS", "", 45);
        public static readonly InsulationType Preinseht = new InsulationType("{96FEAC90-EA18-427A-9829-E2A755FA7AA1}", "PREINSEHT", "", 50);
        public static readonly InsulationType H = new InsulationType("{CB37D23B-9D6B-11D6-BDA5-00104BCC2B69}", "H", "", 4);
        public static readonly InsulationType Hs = new InsulationType("{CB37D241-9D6B-11D6-BDA5-00104BCC2B69}", "HS", "", 5);
        public static readonly InsulationType Hf = new InsulationType("{CB37D247-9D6B-11D6-BDA5-00104BCC2B69}", "HF", "", 11);
        public static readonly InsulationType C = new InsulationType("{CB37D24D-9D6B-11D6-BDA5-00104BCC2B69}", "C", "", 15);
        public static readonly InsulationType Cv = new InsulationType("{CB37D253-9D6B-11D6-BDA5-00104BCC2B69}", "CV", "", 16);
        public static readonly InsulationType Cs = new InsulationType("{CB37D259-9D6B-11D6-BDA5-00104BCC2B69}", "CS", "", 17);
        public static readonly InsulationType Cf = new InsulationType("{CB37D25F-9D6B-11D6-BDA5-00104BCC2B69}", "CF", "", 20);
        public static readonly InsulationType VacuumInsulatedPipe = new InsulationType("{cb1f7402-fa45-448c-b58b-9f4ad25734e9}", "Vacuum insulated pipe", "", 6);
        public static readonly InsulationType Ch = new InsulationType("{CB37D26B-9D6B-11D6-BDA5-00104BCC2B69}", "CH", "", 18);
        public static readonly InsulationType Fp = new InsulationType("{CB37D271-9D6B-11D6-BDA5-00104BCC2B69}", "FP", "", 35);
        public static readonly InsulationType Fip = new InsulationType("{1FA794CA-2B91-468C-9764-4FDB6A4B68E2}", "FIP", "", 55);
        public static readonly InsulationType Fiphc = new InsulationType("{811A2776-C730-4DFD-8E9D-C94133B083B1}", "FIPHC", "", 60);
        public static readonly InsulationType Fipsa = new InsulationType("{3F4FDE23-96F7-4007-9193-0442A25ED54F}", "FIPSA", "", 65);
        public static readonly InsulationType Fiphcsa = new InsulationType("{C97190C1-BBD1-4F97-A1D7-060619C33EB7}", "FIPHCSA", "", 70);
        public static readonly InsulationType Fipcc = new InsulationType("{A50856A5-F4D6-436A-A493-5924B6AC5607}", "FIPCC", "", 75);
        public static readonly InsulationType Fipfp = new InsulationType("{A19B88E4-741E-462A-86B2-8D774F65488B}", "FIPFP", "", 80);
        public static readonly InsulationType Fipec = new InsulationType("{C9B7C8B2-5B29-406C-A522-FE203084D00A}", "FIPEC", "", 85);
        public static readonly InsulationType Ecp = new InsulationType("{058BE889-129C-47A6-98F7-4E3A0D5927F3}", "ECP", "", 90);
        public static readonly InsulationType Icip = new InsulationType("{B233B2FF-A72C-4FCA-88FB-7146288289DB}", "ICIP", "", 95);
        public static readonly InsulationType As = new InsulationType("{CB37D265-9D6B-11D6-BDA5-00104BCC2B69}", "AS", "", 14);
        public static readonly InsulationType P = new InsulationType("{CB37D27D-9D6B-11D6-BDA5-00104BCC2B69}", "P", "", 3);
        public static readonly InsulationType Pc = new InsulationType("{C584D92E-5D68-423D-84E8-13205F2C6E27}", "PC", "", 36);
        public static readonly InsulationType S = new InsulationType("{CB37D289-9D6B-11D6-BDA5-00104BCC2B69}", "S", "", 21);
        public static readonly InsulationType Sv = new InsulationType("{CB37D28F-9D6B-11D6-BDA5-00104BCC2B69}", "SV", "", 22);
        public static readonly InsulationType Saby10 = new InsulationType("{6710CE05-C5FC-4718-941C-A82FADF780B0}", "SABY10", "", 100);
        public static readonly InsulationType Saby20 = new InsulationType("{E6AF56D8-790C-4E49-876D-0F51B8A42ED7}", "SABY20", "", 105);
        public static readonly InsulationType Saby30 = new InsulationType("{B9EC787A-2139-4ECF-8C47-EF78D1F6545F}", "SABY30", "", 110);
        public static readonly InsulationType Sahc = new InsulationType("{19B8F430-FAC9-46AF-AE44-51E1B084BD27}", "SAHC", "", 115);
        public static readonly InsulationType Saperp = new InsulationType("{9CBFAE20-6004-43B3-8D0E-CF32511CF819}", "SAPERP", "", 120);
        public static readonly InsulationType Sacc = new InsulationType("{FF692F92-A765-465D-B985-D462D48474F9}", "SACC", "", 125);
        public static readonly InsulationType Safrp = new InsulationType("{492B9C68-C5EC-4B78-8BC9-B6949E7BA456}", "SAFRP", "", 130);
        public static readonly InsulationType Saec = new InsulationType("{EB5A1563-2D43-4D00-A379-DADBCBDC1297}", "SAEC", "", 135);
        public static readonly InsulationType Varies = new InsulationType("{CB37D295-9D6B-11D6-BDA5-00104BCC2B69}", "Varies", "", 40);
        #endregion
        public InsulationType(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator InsulationType(string text)
        {
            return FindByText<InsulationType>(text);
        }
    }
}