namespace Analysis2.SIO.Library.Enums
{
    public class CleaningResponsibility : SIOEnum
    {
        #region VALUES
        public static readonly CleaningResponsibility Undefined = new CleaningResponsibility("{0F5E6BD3-466F-4C6A-BB4F-AA342F9D4B55}", "Undefined", "", 1);
        public static readonly CleaningResponsibility None = new CleaningResponsibility("{E137CB2E-5CFE-4C57-8A5E-793C5BCF5913}", "None", "", 5);
        public static readonly CleaningResponsibility Contractor = new CleaningResponsibility("{65E7484A-AD78-412D-A5A2-17768AAAAF2B}", "Contractor", "", 10);
        public static readonly CleaningResponsibility Owner = new CleaningResponsibility("{4C9DA384-EC06-40A9-A43A-C20DF63B7F6B}", "Owner", "", 15);
        public static readonly CleaningResponsibility EquipmentVendor = new CleaningResponsibility("{DFAD9EE3-187B-49B5-A722-6AF29CB7334F}", "Equipment Vendor", "", 20);
        public static readonly CleaningResponsibility Piping = new CleaningResponsibility("{C52803F1-EFBC-4A67-9D1D-B63B3435FB64}", "Piping", "", 25);
        public static readonly CleaningResponsibility Instruments = new CleaningResponsibility("{831E5B5D-36C4-479D-B303-65BC2D2F0CF5}", "Instruments", "", 30);
        public static readonly CleaningResponsibility Others = new CleaningResponsibility("{BD88CCFE-A1AC-494F-B048-741D7814F9AC}", "Others", "", 35);
        #endregion
        public CleaningResponsibility(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator CleaningResponsibility(string text)
        {
            return FindByText<CleaningResponsibility>(text);
        }
    }
}