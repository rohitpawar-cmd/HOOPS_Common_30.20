namespace Analysis2.SIO.Library.Enums
{
    public class ApprovalStatus : SIOEnum
    {
        #region VALUES
        public static readonly ApprovalStatus Working = new ApprovalStatus("{F1988105-5461-4002-AB0E-A9B3398DC3BF}", "Working", "", 1);
        public static readonly ApprovalStatus InReview = new ApprovalStatus("{1E4EBEAE-33F5-41CD-B0CD-02F984644E54}", "InReview", "", 2);
        public static readonly ApprovalStatus Rejected = new ApprovalStatus("{5FD98017-8D66-45C8-94CF-4CA9851C8E8C}", "Rejected", "", 4);
        public static readonly ApprovalStatus Approved = new ApprovalStatus("{4F1D20EE-55B5-4908-BDA5-6971E9F7DC7C}", "Approved", "", 8);
        #endregion
        public ApprovalStatus(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator ApprovalStatus(string text)
        {
            return FindByText<ApprovalStatus>(text);
        }
    }
}