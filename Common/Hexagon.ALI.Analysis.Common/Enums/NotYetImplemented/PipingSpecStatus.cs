namespace Analysis2.SIO.Library.Enums
{
    public class PipingSpecStatus : SIOEnum
    {
        #region VALUES
        public static readonly PipingSpecStatus Undefined = new PipingSpecStatus("{4B826849-6374-4CC1-9571-D7D3B0D58214}", "Undefined", "", 1);
        public static readonly PipingSpecStatus Draft = new PipingSpecStatus("{3C6CCAE1-B45A-4E06-AE0E-26E5C359DABE}", "Draft", "", 5);
        public static readonly PipingSpecStatus IssuedForApproval = new PipingSpecStatus("{8C6FD928-7B50-456E-8FDB-0C904358F47E}", "Issued for approval", "", 10);
        public static readonly PipingSpecStatus IssuedForDesign = new PipingSpecStatus("{4A46B35E-501F-44C0-A556-12CB46B9365A}", "Issued for design", "", 15);
        public static readonly PipingSpecStatus IssuedForConstruction = new PipingSpecStatus("{6D39792E-F6FE-44E8-9608-E2DDDDC7F7E7}", "Issued for construction", "", 20);
        #endregion
        public PipingSpecStatus(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator PipingSpecStatus(string text)
        {
            return FindByText<PipingSpecStatus>(text);
        }
    }
}