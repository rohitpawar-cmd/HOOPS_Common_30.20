namespace Analysis2.SIO.Library.Enums
{
    public class FabricationResponsibility : SIOEnum
    {
        #region VALUES
        public static readonly FabricationResponsibility Undefined = new FabricationResponsibility("{80D292F9-582A-4C8A-A7EE-9A72FB8B137C}", "Undefined", "", 1);
        public static readonly FabricationResponsibility None = new FabricationResponsibility("{AB85FCAD-6F4D-4E14-90FF-19280E8A30F9}", "None", "", 5);
        public static readonly FabricationResponsibility Contractor = new FabricationResponsibility("{B6EEB720-00D9-4E8D-8BB2-5A6765D783E9}", "Contractor", "", 10);
        public static readonly FabricationResponsibility Owner = new FabricationResponsibility("{4D5C081B-0D9B-4BC9-B3E7-50043CDD0354}", "Owner", "", 15);
        public static readonly FabricationResponsibility EquipmentVendor = new FabricationResponsibility("{80D7A1F5-9FC1-47D4-A1E0-80D0BBE36677}", "Equipment Vendor", "", 45);
        public static readonly FabricationResponsibility Vendor = new FabricationResponsibility("{5DC7D09B-962C-4E00-97EA-1E9BFF7B0C27}", "Vendor", "", 50);
        public static readonly FabricationResponsibility Piping = new FabricationResponsibility("{D028EB0D-F3B1-4875-9027-5215F30DE9FF}", "Piping", "", 55);
        public static readonly FabricationResponsibility Instruments = new FabricationResponsibility("{A07ECA13-116C-4439-A87A-19A5EECC1DF3}", "Instruments", "", 60);
        public static readonly FabricationResponsibility Others = new FabricationResponsibility("{81F0B1CB-F41D-476F-A8AF-B1198FA6F75D}", "Others", "", 65);
        #endregion
        public FabricationResponsibility(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator FabricationResponsibility(string text)
        {
            return FindByText<FabricationResponsibility>(text);
        }
    }
}