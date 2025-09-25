namespace Analysis2.SIO.Library.Enums
{
    public class ReportingType : SIOEnum
    {
        #region VALUES
        public static readonly ReportingType Undefined = new ReportingType("{B330C39A-6E4A-4D75-BB85-254CC24B1D06}", "Undefined", "", 1);
        public static readonly ReportingType NoMto = new ReportingType("{02FC600B-C2E6-4B7F-8B5C-F55F4C1850B1}", "No-MTO", "", 2);
        public static readonly ReportingType AsBuilt = new ReportingType("{881FC2A3-64AB-4618-9660-592E7BA5C216}", "As-built", "", 3);
        public static readonly ReportingType IncludedInMaterialControlSystem = new ReportingType("{00B57310-FEA8-495E-8037-A1BC13B07B21}", "Included in Material Control System", "", 5);
        public static readonly ReportingType ExcludedFromMaterialControlSystem = new ReportingType("{2373756D-96E5-4FCD-8693-6C5140FAD1DC}", "Excluded from Material Control System", "", 10);
        #endregion
        public ReportingType(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator ReportingType(string text)
        {
            return FindByText<ReportingType>(text);
        }
    }
}