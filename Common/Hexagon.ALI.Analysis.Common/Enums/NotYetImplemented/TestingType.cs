namespace Analysis2.SIO.Library.Enums
{
    public class TestingType : SIOEnum
    {
        #region VALUES
        public static readonly TestingType Undefined = new TestingType("{EB34D57B-A5D5-40F9-B57E-409B6ECAB2A3}", "Undefined", "", 1);
        public static readonly TestingType NoTestRequired = new TestingType("{AE43F10F-33B4-46B0-A600-A12904F20589}", "No test required", "", 2);
        public static readonly TestingType Hst1 = new TestingType("{2DC5545C-BCE1-40C2-BB57-1970B13CBABE}", "HST1", "", 10);
        public static readonly TestingType Hst2 = new TestingType("{44BC5656-E5E3-41AE-BCE2-5D5507060C79}", "HST2", "", 15);
        public static readonly TestingType Hst3 = new TestingType("{304A48AC-B4DA-440A-A5DA-94F8A1F695AB}", "HST3", "", 20);
        public static readonly TestingType Hst4 = new TestingType("{45E41BD1-E34B-4A22-8221-9AC32B414C74}", "HST4", "", 25);
        public static readonly TestingType Hst5 = new TestingType("{51DCD01E-19BA-404C-961D-91056BEB2888}", "HST5", "", 30);
        public static readonly TestingType Hst6 = new TestingType("{53314A61-F757-4E8B-9B9A-FBC531C6AF75}", "HST6", "", 35);
        public static readonly TestingType Visual = new TestingType("{CC33073E-F0F2-4769-8759-BE1F3E11B5A2}", "Visual", "", 50);
        public static readonly TestingType Radiographic = new TestingType("{172F41A9-1A86-4D1F-9BE6-682A6BC25B8E}", "Radiographic", "", 55);
        public static readonly TestingType MagneticParticle = new TestingType("{3E671E1E-6605-4071-83AB-FAD6CE4C2010}", "Magnetic Particle", "", 60);
        public static readonly TestingType LiquidFluorescent = new TestingType("{E7E319DF-6911-407A-B5F3-E31440DAFC24}", "Liquid Fluorescent", "", 65);
        public static readonly TestingType LiquidDyePenetrant = new TestingType("{6D4F4FA4-F878-4909-B49E-9ACED35CD3F9}", "Liquid Dye Penetrant", "", 70);
        public static readonly TestingType Ultrasonic = new TestingType("{F25C3EB2-F085-4A1E-AFE5-441E498DC52E}", "Ultrasonic", "", 75);
        public static readonly TestingType Water = new TestingType("{E5AD082C-8090-4557-A154-7A12C737E63E}", "Water", "", 40);
        public static readonly TestingType Air = new TestingType("{CF55E3CA-E4BF-4FC7-8811-DFD380E2EF9B}", "Air", "", 45);
        public static readonly TestingType Nitrogen = new TestingType("{323A28DD-CEF5-4560-9D75-1F42C38537DB}", "Nitrogen", "", 46);
        public static readonly TestingType HighPressureSweetNaturalGas = new TestingType("{4BD23488-0DCF-4B61-ABD0-ED9DDC7D893B}", "High pressure sweet natural gas", "", 47);
        public static readonly TestingType Steam = new TestingType("{5A69B2FA-D99C-4DBA-B596-893BCB4F9FC4}", "Steam", "", 48);
        public static readonly TestingType OperatingFluid = new TestingType("{D9FE8376-77BC-47A9-8E3E-BE3503C03B8B}", "Operating fluid", "", 49);
        #endregion
        public TestingType(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator TestingType(string text)
        {
            return FindByText<TestingType>(text);
        }
    }
}