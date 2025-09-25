namespace Analysis2.SIO.Library.Enums
{
    public class ConstructionRequirement : SIOEnum
    {
        #region VALUES
        public static readonly ConstructionRequirement Undefined = new ConstructionRequirement("{B72FE633-954A-40BA-AB15-CA7A63796594}", "Undefined", "", 1);
        public static readonly ConstructionRequirement New = new ConstructionRequirement("{5a276129-6b2b-490b-930f-32dd0d8c2769}", "New", "", 2);
        public static readonly ConstructionRequirement Existing = new ConstructionRequirement("{7bdc5539-1461-4631-9389-9abaaf394ffc}", "Existing", "", 3);
        public static readonly ConstructionRequirement Future = new ConstructionRequirement("{7433e2d5-a919-4a88-8596-458d5bbc546a}", "Future", "", 8);
        #endregion
        public ConstructionRequirement(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator ConstructionRequirement(string text)
        {
            return FindByText<ConstructionRequirement>(text);
        }
    }
}