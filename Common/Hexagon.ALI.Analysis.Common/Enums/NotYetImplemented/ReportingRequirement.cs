namespace Analysis2.SIO.Library.Enums
{
    public class ReportingRequirement : SIOEnum
    {
        #region VALUES
        public static readonly ReportingRequirement Undefined = new ReportingRequirement("{BE95606B-5873-47AF-AB1E-4981E2D6B870}", "Undefined", "", 1);
        public static readonly ReportingRequirement NotToBeReported = new ReportingRequirement("{76F30337-6024-4876-BD7B-E1D2433FC10A}", "Not to be reported", "", 2);
        public static readonly ReportingRequirement ToBeReported = new ReportingRequirement("{BC93AE0E-A1D6-484B-A93A-2A6228C24ECE}", "To be reported", "", 5);
        #endregion
        public ReportingRequirement(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator ReportingRequirement(string text)
        {
            return FindByText<ReportingRequirement>(text);
        }
    }
}