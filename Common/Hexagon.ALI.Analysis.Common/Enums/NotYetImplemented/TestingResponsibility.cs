namespace Analysis2.SIO.Library.Enums
{
    public class TestingResponsibility : SIOEnum
    {
        #region VALUES
        public static readonly TestingResponsibility Undefined = new TestingResponsibility("{FB4F1B0E-62FD-4CA3-BFB8-47EE346EE6B9}", "Undefined", "", 1);
        public static readonly TestingResponsibility None = new TestingResponsibility("{91D75055-5F7C-44FE-9D72-22254584927E}", "None", "", 5);
        public static readonly TestingResponsibility Contractor = new TestingResponsibility("{7B80A6E1-7000-4501-AB94-86D41450F3CC}", "Contractor", "", 10);
        public static readonly TestingResponsibility Owner = new TestingResponsibility("{C2C27704-FF67-4500-B184-FC9A6433D02C}", "Owner", "", 15);
        public static readonly TestingResponsibility EquipmentVendor = new TestingResponsibility("{F34DC5BC-299B-43B6-A926-245FB3DE65C7}", "Equipment Vendor", "", 20);
        public static readonly TestingResponsibility Vendor = new TestingResponsibility("{E5EADADB-1D27-40A1-A310-CE684CB7DA07}", "Vendor", "", 25);
        public static readonly TestingResponsibility Piping = new TestingResponsibility("{176915CE-00CB-4316-B9F5-9B17B3CFAFA4}", "Piping", "", 30);
        public static readonly TestingResponsibility Instruments = new TestingResponsibility("{B8A96879-A69F-4ED0-9D48-FB43724E5C8C}", "Instruments", "", 35);
        public static readonly TestingResponsibility Others = new TestingResponsibility("{E3F154C9-15B9-45A9-85E7-73BEC572F8EE}", "Others", "", 40);
        #endregion
        public TestingResponsibility(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator TestingResponsibility(string text)
        {
            return FindByText<TestingResponsibility>(text);
        }
    }
}