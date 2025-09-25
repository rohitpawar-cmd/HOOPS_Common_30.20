namespace Analysis2.SIO.Library.Enums
{
    public class InsulationPurpose : SIOEnum
    {
        #region VALUES
        public static readonly InsulationPurpose Undefined = new InsulationPurpose("{99E83C93-EAEE-4308-AF03-49B959E87A22}", "Undefined", "", 1);
        public static readonly InsulationPurpose None = new InsulationPurpose("{4930FD6E-D907-403C-BA9D-2B0C02DDE25B}", "None", "", 2);
        public static readonly InsulationPurpose R11 = new InsulationPurpose("{CB37D1FF-9D6B-11D6-BDA5-00104BCC2B69}", "R11", "", 30);
        public static readonly InsulationPurpose R15 = new InsulationPurpose("{CB37D205-9D6B-11D6-BDA5-00104BCC2B69}", "R15", "", 32);
        public static readonly InsulationPurpose R18 = new InsulationPurpose("{CB37D20B-9D6B-11D6-BDA5-00104BCC2B69}", "R18", "", 34);
        public static readonly InsulationPurpose Preins = new InsulationPurpose("{FA989414-43BC-45A2-AE3B-89426E0E5820}", "PREINS", "", 45);
        public static readonly InsulationPurpose Preinseht = new InsulationPurpose("{96FEAC90-EA18-427A-9829-E2A755FA7AA1}", "PREINSEHT", "", 50);
        public static readonly InsulationPurpose H = new InsulationPurpose("{CB37D23B-9D6B-11D6-BDA5-00104BCC2B69}", "H", "", 4);
        public static readonly InsulationPurpose Hs = new InsulationPurpose("{CB37D241-9D6B-11D6-BDA5-00104BCC2B69}", "HS", "", 5);
        public static readonly InsulationPurpose Hf = new InsulationPurpose("{CB37D247-9D6B-11D6-BDA5-00104BCC2B69}", "HF", "", 11);
        public static readonly InsulationPurpose C = new InsulationPurpose("{CB37D24D-9D6B-11D6-BDA5-00104BCC2B69}", "C", "", 15);
        public static readonly InsulationPurpose Cv = new InsulationPurpose("{CB37D253-9D6B-11D6-BDA5-00104BCC2B69}", "CV", "", 16);
        public static readonly InsulationPurpose Cs = new InsulationPurpose("{CB37D259-9D6B-11D6-BDA5-00104BCC2B69}", "CS", "", 17);
        public static readonly InsulationPurpose Cf = new InsulationPurpose("{CB37D25F-9D6B-11D6-BDA5-00104BCC2B69}", "CF", "", 20);
        public static readonly InsulationPurpose VacuumInsulatedPipe = new InsulationPurpose("{cb1f7402-fa45-448c-b58b-9f4ad25734e9}", "Vacuum insulated pipe", "", 6);
        public static readonly InsulationPurpose Ch = new InsulationPurpose("{CB37D26B-9D6B-11D6-BDA5-00104BCC2B69}", "CH", "", 18);
        public static readonly InsulationPurpose Fp = new InsulationPurpose("{CB37D271-9D6B-11D6-BDA5-00104BCC2B69}", "FP", "", 35);
        public static readonly InsulationPurpose Fip = new InsulationPurpose("{1FA794CA-2B91-468C-9764-4FDB6A4B68E2}", "FIP", "", 55);
        public static readonly InsulationPurpose Fiphc = new InsulationPurpose("{811A2776-C730-4DFD-8E9D-C94133B083B1}", "FIPHC", "", 60);
        public static readonly InsulationPurpose Fipsa = new InsulationPurpose("{3F4FDE23-96F7-4007-9193-0442A25ED54F}", "FIPSA", "", 65);
        public static readonly InsulationPurpose Fiphcsa = new InsulationPurpose("{C97190C1-BBD1-4F97-A1D7-060619C33EB7}", "FIPHCSA", "", 70);
        public static readonly InsulationPurpose Fipcc = new InsulationPurpose("{A50856A5-F4D6-436A-A493-5924B6AC5607}", "FIPCC", "", 75);
        public static readonly InsulationPurpose Fipfp = new InsulationPurpose("{A19B88E4-741E-462A-86B2-8D774F65488B}", "FIPFP", "", 80);
        public static readonly InsulationPurpose Fipec = new InsulationPurpose("{C9B7C8B2-5B29-406C-A522-FE203084D00A}", "FIPEC", "", 85);
        public static readonly InsulationPurpose Ecp = new InsulationPurpose("{058BE889-129C-47A6-98F7-4E3A0D5927F3}", "ECP", "", 90);
        public static readonly InsulationPurpose Icip = new InsulationPurpose("{B233B2FF-A72C-4FCA-88FB-7146288289DB}", "ICIP", "", 95);
        public static readonly InsulationPurpose As = new InsulationPurpose("{CB37D265-9D6B-11D6-BDA5-00104BCC2B69}", "AS", "", 14);
        public static readonly InsulationPurpose P = new InsulationPurpose("{CB37D27D-9D6B-11D6-BDA5-00104BCC2B69}", "P", "", 3);
        public static readonly InsulationPurpose Pc = new InsulationPurpose("{C584D92E-5D68-423D-84E8-13205F2C6E27}", "PC", "", 36);
        public static readonly InsulationPurpose S = new InsulationPurpose("{CB37D289-9D6B-11D6-BDA5-00104BCC2B69}", "S", "", 21);
        public static readonly InsulationPurpose Sv = new InsulationPurpose("{CB37D28F-9D6B-11D6-BDA5-00104BCC2B69}", "SV", "", 22);
        public static readonly InsulationPurpose Saby10 = new InsulationPurpose("{6710CE05-C5FC-4718-941C-A82FADF780B0}", "SABY10", "", 100);
        public static readonly InsulationPurpose Saby20 = new InsulationPurpose("{E6AF56D8-790C-4E49-876D-0F51B8A42ED7}", "SABY20", "", 105);
        public static readonly InsulationPurpose Saby30 = new InsulationPurpose("{B9EC787A-2139-4ECF-8C47-EF78D1F6545F}", "SABY30", "", 110);
        public static readonly InsulationPurpose Sahc = new InsulationPurpose("{19B8F430-FAC9-46AF-AE44-51E1B084BD27}", "SAHC", "", 115);
        public static readonly InsulationPurpose Saperp = new InsulationPurpose("{9CBFAE20-6004-43B3-8D0E-CF32511CF819}", "SAPERP", "", 120);
        public static readonly InsulationPurpose Sacc = new InsulationPurpose("{FF692F92-A765-465D-B985-D462D48474F9}", "SACC", "", 125);
        public static readonly InsulationPurpose Safrp = new InsulationPurpose("{492B9C68-C5EC-4B78-8BC9-B6949E7BA456}", "SAFRP", "", 130);
        public static readonly InsulationPurpose Saec = new InsulationPurpose("{EB5A1563-2D43-4D00-A379-DADBCBDC1297}", "SAEC", "", 135);
        public static readonly InsulationPurpose Varies = new InsulationPurpose("{CB37D295-9D6B-11D6-BDA5-00104BCC2B69}", "Varies", "", 40);
        #endregion
        public InsulationPurpose(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator InsulationPurpose(string text)
        {
            return FindByText<InsulationPurpose>(text);
        }
    }
}