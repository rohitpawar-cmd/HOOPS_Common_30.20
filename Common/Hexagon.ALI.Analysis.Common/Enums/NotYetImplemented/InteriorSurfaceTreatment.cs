namespace Analysis2.SIO.Library.Enums
{
    public class InteriorSurfaceTreatment : SIOEnum
    {
        #region VALUES
        public static readonly InteriorSurfaceTreatment Undefined = new InteriorSurfaceTreatment("{2F7479CC-949A-41EE-83D9-69FAFDCBA1F6}", "Undefined", "", 1);
        public static readonly InteriorSurfaceTreatment NotRequired = new InteriorSurfaceTreatment("{D31C4CD6-36B6-4A28-8581-063D33F1AC4F}", "Not Required", "", 2);
        public static readonly InteriorSurfaceTreatment Pickled = new InteriorSurfaceTreatment("0cb8cf25-0889-41cd-acd3-21398ea85eec", "Pickled", "", 20);
        public static readonly InteriorSurfaceTreatment PickleWithAcid = new InteriorSurfaceTreatment("{4ED13130-CCE9-465C-8E7C-5AC271ABB124}", "Pickle with acid", "", 25);
        public static readonly InteriorSurfaceTreatment PickleOilWithAcid = new InteriorSurfaceTreatment("{72CF5CA4-5C8A-4CAE-A373-86CF707B371E}", "Pickle/oil with acid", "", 30);
        public static readonly InteriorSurfaceTreatment PickleWithNitricAcid2050Pct = new InteriorSurfaceTreatment("{25D941D7-562C-4063-A0A2-8C990317000D}", "Pickle with nitric acid (20-50%)", "", 35);
        public static readonly InteriorSurfaceTreatment PickleWithNitricAcid2040PctSodiumDichromate26Pct = new InteriorSurfaceTreatment("{1E5DF97F-4E09-4A94-843F-9FEC876760C7}", "Pickle with nitric acid (20-40%) + sodium dichromate (2-6%)", "", 40);
        public static readonly InteriorSurfaceTreatment PickleWithNitricAcid12PctCopperSulfate4Pct = new InteriorSurfaceTreatment("{60E22425-259F-49AE-AC1F-E27AEC5C2B9B}", "Pickle with nitric acid (12%) + copper sulfate (4%)", "", 45);
        public static readonly InteriorSurfaceTreatment AcidDescaleWithOxalicAcid5Pct = new InteriorSurfaceTreatment("{F1864502-38F1-4793-9FB0-2D9F4D6C7555}", "Acid descale with oxalic acid (5%)", "", 50);
        public static readonly InteriorSurfaceTreatment AcidDescaleWithSulfuricAcid811Pct = new InteriorSurfaceTreatment("{23858D9F-6A25-455D-AAB2-4BD60C2801C2}", "Acid descale with sulfuric acid (8-11%)", "", 55);
        public static readonly InteriorSurfaceTreatment AcidDescaleWithNitricAcid1525PctHydrogenFluoride8Pct = new InteriorSurfaceTreatment("{2BFD26F3-52F6-4E4D-AA45-95C6C0FF5656}", "Acid descale with nitric acid (15-25%) + hydrogen fluoride (8%)", "", 60);
        public static readonly InteriorSurfaceTreatment PickleWithNitricAcid20PctHydrogenFluoride5PctAt125130Of = new InteriorSurfaceTreatment("{611C6B3B-F7E2-4DCC-8B65-C636DE67E098}", "Pickle with nitric acid (20%) + hydrogen fluoride (5%) at 125-130oF", "", 62);
        public static readonly InteriorSurfaceTreatment FlushWithRustInhibitor = new InteriorSurfaceTreatment("{5F97D2C5-9434-450E-85F8-ADBB215F6CD7}", "Flush with rust inhibitor", "", 65);
        public static readonly InteriorSurfaceTreatment FlushWithSodiumNitrite05PctDspMsp05Pct = new InteriorSurfaceTreatment("{4424D6AA-F05C-449C-A1F3-2581A916B454}", "Flush with sodium nitrite (0.5%) + DSP/MSP (0.5%)", "", 70);
        public static readonly InteriorSurfaceTreatment EnerceptWaterSolubleCorrosionInhibitorsNalco = new InteriorSurfaceTreatment("{16A8FE49-FC98-4689-94BC-45C0B859BF0E}", "Enercept®, water-soluble corrosion inhibitors (Nalco)", "", 71);
        public static readonly InteriorSurfaceTreatment EnerceptOilSolubleCorrosionInhibitorsNalco = new InteriorSurfaceTreatment("{FA50F0CD-696B-4F09-8D46-BAD458A77F2B}", "Enercept®, oil-soluble corrosion inhibitors (Nalco)", "", 72);
        public static readonly InteriorSurfaceTreatment EnerceptMultiFunctionalCorrosionInhibitorsNalco = new InteriorSurfaceTreatment("{A584546A-88DC-47BA-9CC5-D37A1EA02F37}", "Enercept®, multi-functional corrosion inhibitors (Nalco)", "", 73);
        public static readonly InteriorSurfaceTreatment EnerceptEnvironmentallyFriendlyCorrosionInhibitorsNalco = new InteriorSurfaceTreatment("{A0D4BAAB-4B0F-40F6-8FC2-317DE868F588}", "Enercept®, environmentally friendly corrosion inhibitors (Nalco)", "", 74);
        public static readonly InteriorSurfaceTreatment DryPowderApplicationVci1030OuncesWeightPerCubicFoot = new InteriorSurfaceTreatment("{139343B0-EBCB-4902-AF0F-D751385324B7}", "Dry powder application, VCI-1, 0.30 ounces (weight) per cubic foot", "", 75);
        public static readonly InteriorSurfaceTreatment WetPowderApplicationVci1025PctSolutionInWaterBasedUponWeight = new InteriorSurfaceTreatment("{2B9B3A76-274A-4833-8261-7F77475A1569}", "Wet powder application, VCI-1, 0.25% solution in water (based upon weight)", "", 76);
        public static readonly InteriorSurfaceTreatment ScaleInhibitor = new InteriorSurfaceTreatment("{9DCED7FC-D5D9-48AF-AFDA-7E8654AAAAB1}", "Scale inhibitor", "", 77);
        #endregion
        public InteriorSurfaceTreatment(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator InteriorSurfaceTreatment(string text)
        {
            return FindByText<InteriorSurfaceTreatment>(text);
        }
    }
}