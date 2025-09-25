namespace Analysis2.SIO.Library.Enums
{
    public class FabricationType : SIOEnum
    {
        #region VALUES
        public static readonly FabricationType Undefined = new FabricationType("{4DB6B1F2-DEEB-4DC3-99B3-07507860B6B7}", "Undefined", "", 1);
        public static readonly FabricationType Sf = new FabricationType("{7B5AEE76-2844-4863-AD08-F25EF2EC9F67}", "SF", "", 15);
        public static readonly FabricationType ShopFabricatedThermalFusion = new FabricationType("{62CB7C9D-46C9-4CC4-96DC-B7BA0D32F69F}", "Shop fabricated, thermal fusion", "", 16);
        public static readonly FabricationType ShopFabricatedElectrofusion = new FabricationType("{5D49CBB4-6207-4134-8D8E-2241C1D47A35}", "Shop fabricated, electrofusion", "", 17);
        public static readonly FabricationType ShopFabricatedLaminated = new FabricationType("{C193695D-0596-4DA2-9FEC-E1CECB7D463F}", "Shop fabricated, laminated", "", 18);
        public static readonly FabricationType ShopFabricatedBrazed = new FabricationType("{2C648D2E-9A80-4464-AA3F-80608F995E93}", "Shop fabricated, brazed", "", 19);
        public static readonly FabricationType ShopFabricatedAdhesiveBonded = new FabricationType("{21DB00DC-E593-4FF0-AB57-CA6136CCD04E}", "Shop fabricated, adhesive bonded", "", 41);
        public static readonly FabricationType ShopFabricatedSolventCemented = new FabricationType("{076F92E9-D1CB-4104-B1C6-8FA73006240A}", "Shop fabricated, solvent cemented", "", 44);
        public static readonly FabricationType ShopFabricatedButtFusion = new FabricationType("{c1233edf-b011-4c19-abfb-58513b9d7f84}", "Shop fabricated, butt fusion", "", 50);
        public static readonly FabricationType ShopFabricatedSaddleFusion = new FabricationType("{020968b9-565d-4386-b0f8-6720cd624b8c}", "Shop fabricated, saddle fusion", "", 55);
        public static readonly FabricationType ShopFabricatedSocketFusion = new FabricationType("{c3fa48fa-d6b5-4807-891d-f748b56803b2}", "Shop fabricated, socket fusion", "", 60);
        public static readonly FabricationType ShopFabricatedFittingToBeTapedBeforeSurfaceTreatment = new FabricationType("{D8D73125-21DE-42F8-A51C-F7CA1024B8AE}", "Shop fabricated, fitting to be taped before surface treatment", "", 38);
        public static readonly FabricationType ShopFabricatedJoinedPipeEndToBeTapedBeforeSurfaceTreatment = new FabricationType("{3CD70126-1908-42EA-9F4C-069CA46889C0}", "Shop fabricated, joined pipe end to be taped before surface treatment", "", 39);
        public static readonly FabricationType ShopFabricatedOpenPipeEndToBeTapedBeforeSurfaceTreatment = new FabricationType("{4E9A31BB-7EF1-4514-9B54-F0BFDE6C060B}", "Shop fabricated, open pipe end to be taped before surface treatment", "", 40);
        public static readonly FabricationType Cf = new FabricationType("{9256009E-0FF1-4CD8-BF3D-16F601D048F9}", "CF", "", 7);
        public static readonly FabricationType Of = new FabricationType("{54420203-1B26-481A-A73A-349CEF252564}", "OF", "", 20);
        public static readonly FabricationType ContractorFabricatedMatchMarked = new FabricationType("{89BBBF46-6FEA-4979-BB04-6161A9522427}", "Contractor fabricated, match marked", "", 21);
        public static readonly FabricationType OwnerFabricatedMatchMarked = new FabricationType("{2CD1854E-8338-45E3-8BB5-7DDADA8072BA}", "Owner fabricated, match marked", "", 22);
        public static readonly FabricationType ContractorFabricatedThermalFusion = new FabricationType("{6351CEF3-F443-47A3-99A6-8348A882FB96}", "Contractor fabricated, thermal fusion", "", 23);
        public static readonly FabricationType OwnerFabricatedThermalFusion = new FabricationType("{29196A04-E8A5-4450-B974-94BA8C60932C}", "Owner fabricated, thermal fusion", "", 24);
        public static readonly FabricationType ContractorFabricatedElectrofusion = new FabricationType("{793DD97B-D1AC-49F3-8583-9E3CFCDB6337}", "Contractor fabricated, electrofusion", "", 25);
        public static readonly FabricationType OwnerFabricatedElectrofusion = new FabricationType("{592F77AC-4DD0-4E29-A85E-969DC3C37A4C}", "Owner fabricated, electrofusion", "", 26);
        public static readonly FabricationType ContractorFabricatedLaminated = new FabricationType("{706FC346-F4C6-42D7-AEEB-5922490F709E}", "Contractor fabricated, laminated", "", 27);
        public static readonly FabricationType OwnerFabricatedLaminated = new FabricationType("{DEC92CC4-050A-4BAC-9CF0-7942A7194391}", "Owner fabricated, laminated", "", 28);
        public static readonly FabricationType ContractorFabricatedBrazed = new FabricationType("{81761B01-16F6-4700-A8BA-7E2BF6861824}", "Contractor fabricated, brazed", "", 29);
        public static readonly FabricationType OwnerFabricatedBrazed = new FabricationType("{67551E86-6A37-42FD-8800-47A8AFEFC7D0}", "Owner fabricated, brazed", "", 31);
        public static readonly FabricationType ContractorFabricatedAdhesiveBonded = new FabricationType("{4CBF96FA-4DA2-4C0A-8C47-C8E17F4E11DB}", "Contractor fabricated, adhesive bonded", "", 42);
        public static readonly FabricationType OwnerFabricatedAdhesiveBonded = new FabricationType("{EF5DB1AE-1564-4E45-AEC0-E5FD0F67269F}", "Owner fabricated, adhesive bonded", "", 43);
        public static readonly FabricationType ContractorFabricatedSolventCemented = new FabricationType("{9BACB376-9FD6-45D8-B6B3-29E3380EE3FA}", "Contractor fabricated, solvent cemented", "", 45);
        public static readonly FabricationType OwnerFabricatedSolventCemented = new FabricationType("{37F74FF4-B33F-499B-9401-B234A8D5965C}", "Owner fabricated, solvent cemented", "", 46);
        public static readonly FabricationType ContractorFabricatedButtFusion = new FabricationType("{32deea9a-27ab-48c1-a34f-77bac56a5a4d}", "Contractor fabricated, butt fusion", "", 65);
        public static readonly FabricationType OwnerFabricatedButtFusion = new FabricationType("{0849c1a4-8374-4d11-94f2-241bd855c9fa}", "Owner fabricated, butt fusion", "", 70);
        public static readonly FabricationType ContractorFabricatedSaddleFusion = new FabricationType("{cb8d89c1-4827-44b5-84e1-ec956f743e88}", "Contractor fabricated, saddle fusion", "", 75);
        public static readonly FabricationType OwnerFabricatedSaddleFusion = new FabricationType("{af2fdf6d-a66a-48cd-bdfb-53bfe8c589f3}", "Owner fabricated, saddle fusion", "", 80);
        public static readonly FabricationType ContractorFabricatedSocketFusion = new FabricationType("{e889e7be-472b-4a1c-83c9-ba48552429bd}", "Contractor fabricated, socket fusion", "", 85);
        public static readonly FabricationType OwnerFabricatedSocketFusion = new FabricationType("{9d2a4fa0-b6f3-4ccd-a6fb-e09b1e6ef483}", "Owner fabricated, socket fusion", "", 90);
        public static readonly FabricationType Sffw = new FabricationType("{80FC0701-05FE-43A8-9068-2B9B5CA7ABB3}", "SFFW", "", 30);
        #endregion
        public FabricationType(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator FabricationType(string text)
        {
            return FindByText<FabricationType>(text);
        }
    }
}