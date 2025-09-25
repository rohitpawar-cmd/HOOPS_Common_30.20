namespace Analysis2.SIO.Library.Enums
{
    public class RequisitionResponsibility : SIOEnum
    {
        #region VALUES
        public static readonly RequisitionResponsibility Undefined = new RequisitionResponsibility("{401661F1-A0C5-11D6-BDA9-00104BCC2B69}", "Undefined", "", 1);
        public static readonly RequisitionResponsibility None = new RequisitionResponsibility("{401661F7-A0C5-11D6-BDA9-00104BCC2B69}", "None", "", 5);
        public static readonly RequisitionResponsibility Contractor = new RequisitionResponsibility("{401661FD-A0C5-11D6-BDA9-00104BCC2B69}", "Contractor", "", 10);
        public static readonly RequisitionResponsibility Owner = new RequisitionResponsibility("{40166203-A0C5-11D6-BDA9-00104BCC2B69}", "Owner", "", 15);
        public static readonly RequisitionResponsibility Piping = new RequisitionResponsibility("{40166209-A0C5-11D6-BDA9-00104BCC2B69}", "Piping", "", 20);
        public static readonly RequisitionResponsibility Instruments = new RequisitionResponsibility("{4016620F-A0C5-11D6-BDA9-00104BCC2B69}", "Instruments", "", 25);
        public static readonly RequisitionResponsibility Others = new RequisitionResponsibility("{40166215-A0C5-11D6-BDA9-00104BCC2B69}", "Others", "", 30);
        public static readonly RequisitionResponsibility EquipmentVendor = new RequisitionResponsibility("{1E5B4640-BABF-4A38-8EE3-69287D091B18}", "Equipment Vendor", "", 35);
        public static readonly RequisitionResponsibility Vendor = new RequisitionResponsibility("{1BCCF121-22A8-46F0-9E46-9AC695F000B4}", "Vendor", "", 40);
        #endregion
        public RequisitionResponsibility(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator RequisitionResponsibility(string text)
        {
            return FindByText<RequisitionResponsibility>(text);
        }
    }
}