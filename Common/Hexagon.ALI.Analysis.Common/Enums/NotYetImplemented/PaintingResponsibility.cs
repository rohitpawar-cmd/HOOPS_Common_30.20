namespace Analysis2.SIO.Library.Enums
{
    public class PaintingResponsibility : SIOEnum
    {
        #region VALUES
        public static readonly PaintingResponsibility Undefined = new PaintingResponsibility("{702A8B72-C05F-4A00-9A33-DE916FA535C7}", "Undefined", "", 1);
        public static readonly PaintingResponsibility None = new PaintingResponsibility("{B3836F34-DEF4-4721-9BE5-EE2889AB72DA}", "None", "", 5);
        public static readonly PaintingResponsibility Contractor = new PaintingResponsibility("{2CAC540A-C1D3-46FB-A11E-738DFC8361C3}", "Contractor", "", 10);
        public static readonly PaintingResponsibility Owner = new PaintingResponsibility("{EC702292-0675-4ECE-A517-AD82F5487256}", "Owner", "", 15);
        public static readonly PaintingResponsibility EquipmentVendor = new PaintingResponsibility("{49618BCD-E99F-494A-9118-D9A5C87F7CE1}", "Equipment Vendor", "", 45);
        public static readonly PaintingResponsibility Vendor = new PaintingResponsibility("{65F267E9-7C9B-4A99-B4FE-DB37AFA60055}", "Vendor", "", 50);
        public static readonly PaintingResponsibility Piping = new PaintingResponsibility("{853384A5-3462-40F8-81F4-605B9E8AFCFA}", "Piping", "", 55);
        public static readonly PaintingResponsibility Instruments = new PaintingResponsibility("{5A6F738F-7D84-4481-BAD1-F081DF1B22BC}", "Instruments", "", 60);
        public static readonly PaintingResponsibility Others = new PaintingResponsibility("{FD3E8F1E-147C-4EBA-8991-6F0A78F45CC1}", "Others", "", 65);
        #endregion
        public PaintingResponsibility(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator PaintingResponsibility(string text)
        {
            return FindByText<PaintingResponsibility>(text);
        }
    }
}