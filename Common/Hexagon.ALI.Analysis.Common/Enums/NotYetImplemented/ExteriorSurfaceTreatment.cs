namespace Analysis2.SIO.Library.Enums
{
    public class ExteriorSurfaceTreatment : SIOEnum
    {
        #region VALUES
        public static readonly ExteriorSurfaceTreatment Undefined = new ExteriorSurfaceTreatment("{4AD992CA-8AA4-43F6-A661-7BD11BE1EF53}", "Undefined", "", 1);
        public static readonly ExteriorSurfaceTreatment NotRequired = new ExteriorSurfaceTreatment("{B7E68BCB-C7CA-4E0D-8364-75B15B1EBD67}", "Not Required", "", 2);
        public static readonly ExteriorSurfaceTreatment Pickled = new ExteriorSurfaceTreatment("{aa05625a-571d-470d-a5d9-e7f3fc24a0a2}", "Pickled", "", 20);
        public static readonly ExteriorSurfaceTreatment PickleWithAcid = new ExteriorSurfaceTreatment("{A52F346C-5E05-49D7-A90C-60FD35DF1384}", "Pickle with acid", "", 25);
        public static readonly ExteriorSurfaceTreatment PickleOilWithAcid = new ExteriorSurfaceTreatment("{EE7073EA-3950-4DD8-BB8E-7DA8E0CED568}", "Pickle/oil with acid", "", 30);
        public static readonly ExteriorSurfaceTreatment PickleWithNitricAcid2050Pct = new ExteriorSurfaceTreatment("{39C663DB-D88F-4208-892D-6D1D1DB385E9}", "Pickle with nitric acid (20-50%)", "", 35);
        public static readonly ExteriorSurfaceTreatment PickleWithNitricAcid2040PctSodiumDichromate26Pct = new ExteriorSurfaceTreatment("{3C013C4A-5BBA-4C1E-B130-0DE4DC580AE6}", "Pickle with nitric acid (20-40%) + sodium dichromate (2-6%)", "", 40);
        public static readonly ExteriorSurfaceTreatment PickleWithNitricAcid12PctCopperSulfate4Pct = new ExteriorSurfaceTreatment("{8F665EE4-4179-4825-8908-993ACCD8D17D}", "Pickle with nitric acid (12%) + copper sulfate (4%)", "", 45);
        public static readonly ExteriorSurfaceTreatment AcidDescaleWithOxalicAcid5Pct = new ExteriorSurfaceTreatment("{9D45D6D2-23DF-49DC-A762-E29F104B048C}", "Acid descale with oxalic acid (5%)", "", 50);
        public static readonly ExteriorSurfaceTreatment AcidDescaleWithSulfuricAcid811Pct = new ExteriorSurfaceTreatment("{871A10B9-E414-4DE3-8782-9934884F9AB7}", "Acid descale with sulfuric acid (8-11%)", "", 55);
        public static readonly ExteriorSurfaceTreatment AcidDescaleWithNitricAcid1525PctHydrogenFluoride8Pct = new ExteriorSurfaceTreatment("{EAD07E13-5736-41BE-9273-D93FFBD79AD8}", "Acid descale with nitric acid (15-25%) + hydrogen fluoride (8%)", "", 60);
        public static readonly ExteriorSurfaceTreatment PickleWithNitricAcid20PctHydrogenFluoride5PctAt125130Of = new ExteriorSurfaceTreatment("{3CDA2B49-2B96-46D2-8492-C45DB3DAAE5D}", "Pickle with nitric acid (20%) + hydrogen fluoride (5%) at 125-130oF", "", 61);
        public static readonly ExteriorSurfaceTreatment FlushWithRustInhibitor = new ExteriorSurfaceTreatment("{CF2EDF6A-382A-48B3-B66D-E63AF38CE5B5}", "Flush with rust inhibitor", "", 65);
        public static readonly ExteriorSurfaceTreatment FlushWithSodiumNitrite05PctDspMsp05Pct = new ExteriorSurfaceTreatment("{649B2F87-C06B-4D35-87A0-8134307F6512}", "Flush with sodium nitrite (0.5%) + DSP/MSP (0.5%)", "", 70);
        #endregion
        public ExteriorSurfaceTreatment(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator ExteriorSurfaceTreatment(string text)
        {
            return FindByText<ExteriorSurfaceTreatment>(text);
        }
    }
}