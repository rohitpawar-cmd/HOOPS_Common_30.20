namespace Analysis2.SIO.Library.Enums
{
    public class DistributionPortStatus : SIOEnum
    {
        #region VALUES
        public static readonly DistributionPortStatus Baseport = new DistributionPortStatus("{e8d14018-b5ae-458a-afb4-d1fc82d8f4db}", "BasePort", "", 2);
        public static readonly DistributionPortStatus Addedport = new DistributionPortStatus("{16412240-f602-4d92-a0e8-8860a05dfa0c}", "AddedPort", "", 3);
        #endregion
        public DistributionPortStatus(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator DistributionPortStatus(string text)
        {
            return FindByText<DistributionPortStatus>(text);
        }
    }
}