namespace Analysis2.SIO.Library.Enums
{
    public class ApprovalReason : SIOEnum
    {
        #region VALUES
        public static readonly ApprovalReason Working = new ApprovalReason("{1DF9BDFC-8FE1-4CFA-A9B5-B648522D0298}", "Working", "", 1);
        public static readonly ApprovalReason InReview = new ApprovalReason("{2565BD17-C04E-4796-8B44-EBC654EA177A}", "InReview", "", 2);
        public static readonly ApprovalReason Rejected = new ApprovalReason("{DF7D7BEB-7ECB-4113-8068-94038566D9C6}", "Rejected", "", 4);
        public static readonly ApprovalReason Approved = new ApprovalReason("{376F1661-E9B5-4B2E-9FD0-09346EE9E8A5}", "Approved", "", 8);
        #endregion
        public ApprovalReason(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator ApprovalReason(string text)
        {
            return FindByText<ApprovalReason>(text);
        }
    }
}