namespace Analysis2.SIO.Library.Enums
{
    public class DesignResponsibility : SIOEnum
    {
        #region VALUES
        public static readonly DesignResponsibility Undefined = new DesignResponsibility("{78398A45-9F3D-11D6-BDA7-00104BCC2B69}", "Undefined", "", 1);
        public static readonly DesignResponsibility None = new DesignResponsibility("{78398A4B-9F3D-11D6-BDA7-00104BCC2B69}", "None", "", 5);
        public static readonly DesignResponsibility Contractor = new DesignResponsibility("{78398A51-9F3D-11D6-BDA7-00104BCC2B69}", "Contractor", "", 10);
        public static readonly DesignResponsibility Owner = new DesignResponsibility("{78398A57-9F3D-11D6-BDA7-00104BCC2B69}", "Owner", "", 15);
        public static readonly DesignResponsibility EquipmentVendor = new DesignResponsibility("{78398A5D-9F3D-11D6-BDA7-00104BCC2B69}", "Equipment Vendor", "", 20);
        public static readonly DesignResponsibility Vendor = new DesignResponsibility("{78398A63-9F3D-11D6-BDA7-00104BCC2B69}", "Vendor", "", 25);
        public static readonly DesignResponsibility Piping = new DesignResponsibility("{78398A69-9F3D-11D6-BDA7-00104BCC2B69}", "Piping", "", 30);
        public static readonly DesignResponsibility Instruments = new DesignResponsibility("{78398A6F-9F3D-11D6-BDA7-00104BCC2B69}", "Instruments", "", 35);
        public static readonly DesignResponsibility Others = new DesignResponsibility("{78398A75-9F3D-11D6-BDA7-00104BCC2B69}", "Others", "", 40);
        #endregion
        public DesignResponsibility(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator DesignResponsibility(string text)
        {
            return FindByText<DesignResponsibility>(text);
        }
    }
}