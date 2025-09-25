namespace Analysis2.SIO.Library.Enums
{
    public class TestingRequirements : SIOEnum
    {
        #region VALUES
        public static readonly TestingRequirements Undefined = new TestingRequirements("{671F2694-4523-4B60-9CBF-204516B81D3C}", "Undefined", "", 1);
        public static readonly TestingRequirements StaticTestingIsNotRequired = new TestingRequirements("{F03E4F56-9017-4C32-974B-E5D68C5AD5B3}", "Static testing is not required", "", 2);
        public static readonly TestingRequirements Piping = new TestingRequirements("{5A135041-1438-4029-B85F-ED6F8B7B5534}", "Piping", "", 10);
        public static readonly TestingRequirements WeldTestingIsRequired = new TestingRequirements("{C5E8740C-CD66-43AE-AB14-5A969B32EBA0}", "Weld testing is required", "", 15);
        public static readonly TestingRequirements HydrostaticTestingIsRequired = new TestingRequirements("{42F66290-8F9A-4A4D-9FE7-E6F92A2BD3CE}", "Hydrostatic testing is required", "", 3);
        public static readonly TestingRequirements PneumaticTestingIsRequired = new TestingRequirements("{6CEA5C74-0F8B-40E1-805A-03DC1FD7895D}", "Pneumatic testing is required", "", 4);
        public static readonly TestingRequirements ServiceTestingIsRequired = new TestingRequirements("{467E30BD-724B-41F7-BE2B-DE424DBE78D3}", "Service testing is required", "", 5);
        #endregion
        public TestingRequirements(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator TestingRequirements(string text)
        {
            return FindByText<TestingRequirements>(text);
        }
    }
}