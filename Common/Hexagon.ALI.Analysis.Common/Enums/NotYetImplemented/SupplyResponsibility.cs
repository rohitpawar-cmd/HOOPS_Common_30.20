namespace Analysis2.SIO.Library.Enums
{
    public class SupplyResponsibility : SIOEnum
    {
        #region VALUES
        public static readonly SupplyResponsibility Undefined = new SupplyResponsibility("{783989EE-9F3D-11D6-BDA7-00104BCC2B69}", "Undefined", "", 1);
        public static readonly SupplyResponsibility Contractor = new SupplyResponsibility("{783989F4-9F3D-11D6-BDA7-00104BCC2B69}", "Contractor", "", 2);
        public static readonly SupplyResponsibility Owner = new SupplyResponsibility("{783989FA-9F3D-11D6-BDA7-00104BCC2B69}", "Owner", "", 3);
        public static readonly SupplyResponsibility EquipmentVendor = new SupplyResponsibility("{78398A00-9F3D-11D6-BDA7-00104BCC2B69}", "Equipment Vendor", "", 9);
        public static readonly SupplyResponsibility Vendor = new SupplyResponsibility("{78398A06-9F3D-11D6-BDA7-00104BCC2B69}", "Vendor", "", 10);
        public static readonly SupplyResponsibility Piping = new SupplyResponsibility("{78398A0C-9F3D-11D6-BDA7-00104BCC2B69}", "Piping", "", 15);
        public static readonly SupplyResponsibility Instruments = new SupplyResponsibility("{78398A12-9F3D-11D6-BDA7-00104BCC2B69}", "Instruments", "", 16);
        public static readonly SupplyResponsibility FabricationShop = new SupplyResponsibility("{78398A18-9F3D-11D6-BDA7-00104BCC2B69}", "Fabrication Shop", "", 20);
        public static readonly SupplyResponsibility Others = new SupplyResponsibility("{78398A1E-9F3D-11D6-BDA7-00104BCC2B69}", "Others", "", 25);
        #endregion
        public SupplyResponsibility(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator SupplyResponsibility(string text)
        {
            return FindByText<SupplyResponsibility>(text);
        }
    }
}