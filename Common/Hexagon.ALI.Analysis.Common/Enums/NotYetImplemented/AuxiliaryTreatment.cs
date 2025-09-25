namespace Analysis2.SIO.Library.Enums
{
    public class AuxiliaryTreatment : SIOEnum
    {
        #region VALUES
        public static readonly AuxiliaryTreatment Undefined = new AuxiliaryTreatment("{CC5D4D3A-F1DD-48C9-BD30-D3FA818CE4B9}", "Undefined", "", 1);
        public static readonly AuxiliaryTreatment NotRequired = new AuxiliaryTreatment("{508ADA67-12F3-4DB5-B35E-2CBBCD1BE9CD}", "Not Required", "", 5);
        public static readonly AuxiliaryTreatment PostWeldHeatTreatmentPwhtRequired = new AuxiliaryTreatment("{7623F8A2-3046-4AE4-B176-6DF48D8CA36B}", "Post weld heat treatment (PWHT) required", "", 10);
        public static readonly AuxiliaryTreatment AnnealedBatch = new AuxiliaryTreatment("{066E9EFA-5A25-4196-BBE8-E3EC8E786FEB}", "Annealed - batch", "", 15);
        public static readonly AuxiliaryTreatment AnnealedContinuous = new AuxiliaryTreatment("{11C40ADD-F269-4C6A-A554-E637866521E8}", "Annealed - continuous", "", 20);
        public static readonly AuxiliaryTreatment SolutionAnnealed = new AuxiliaryTreatment("{C86A7687-0234-49D2-9CE4-0FE96FB4BC4A}", "Solution annealed", "", 25);
        public static readonly AuxiliaryTreatment Normalized = new AuxiliaryTreatment("{63C59D75-F77A-419F-BBC7-F2E3EA40EE50}", "Normalized", "", 30);
        public static readonly AuxiliaryTreatment Carburized = new AuxiliaryTreatment("{140B6E57-C202-4F7C-BDCB-3360ECD00FCC}", "Carburized", "", 35);
        public static readonly AuxiliaryTreatment CarburizedAndAnnealed = new AuxiliaryTreatment("{3D4AFB0D-3F92-4365-8627-AC6808488DD7}", "Carburized and annealed", "", 40);
        public static readonly AuxiliaryTreatment CarburizedAndNormalized = new AuxiliaryTreatment("{108FF2E9-7514-4EB6-85F5-F0622DDBD705}", "Carburized and normalized", "", 45);
        public static readonly AuxiliaryTreatment SolutionAnnealedAndQuenched = new AuxiliaryTreatment("{015B2399-DC93-4C81-8334-0C5E39F42224}", "Solution annealed and quenched", "", 50);
        public static readonly AuxiliaryTreatment NormalizedAndTemperd = new AuxiliaryTreatment("{C781FBC5-900E-4ADC-8DE7-333D06008DC0}", "Normalized and temperd", "", 55);
        public static readonly AuxiliaryTreatment QuenchedAndTempered = new AuxiliaryTreatment("{FAA9A060-DA1B-4FA0-B448-C3A59572A9EB}", "Quenched and tempered", "", 60);
        public static readonly AuxiliaryTreatment Tempered = new AuxiliaryTreatment("{5C36B5AD-C73E-4E0A-9465-FA813FDFC6CD}", "Tempered", "", 65);
        public static readonly AuxiliaryTreatment Annealed = new AuxiliaryTreatment("{aac17486-a823-4dde-a723-f80e5deca0d5}", "Annealed", "", 95);
        public static readonly AuxiliaryTreatment ColdWorkHardened = new AuxiliaryTreatment("{370602c6-9489-4fbe-8e86-8ea0bc8ec9ac}", "Cold work hardened", "", 85);
        public static readonly AuxiliaryTreatment IsothermallyAnnealed = new AuxiliaryTreatment("{eaf2d16e-b904-43c6-8374-d712cfa585f7}", "Isothermally annealed", "", 90);
        public static readonly AuxiliaryTreatment PrecipitationHardened = new AuxiliaryTreatment("{08acf02b-7704-4a3a-8ec5-2ea8356a7c75}", "Precipitation hardened", "", 80);
        public static readonly AuxiliaryTreatment RecrystalizedAnnealed = new AuxiliaryTreatment("{12da3479-0e6c-4038-ad3f-1b7553079b7e}", "Recrystalized annealed", "", 75);
        public static readonly AuxiliaryTreatment WarmWorked = new AuxiliaryTreatment("{f7da2e31-e91d-410f-90d4-6b86592fe5c5}", "Warm worked", "", 70);
        #endregion
        public AuxiliaryTreatment(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator AuxiliaryTreatment(string text)
        {
            return FindByText<AuxiliaryTreatment>(text);
        }
    }
}