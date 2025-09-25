namespace Analysis2.SIO.Library.Enums
{
    public class NotePurpose : SIOEnum
    {
        #region VALUES
        public static readonly NotePurpose General = new NotePurpose("{F781A733-FAFF-4ECE-A077-78B047863AA8}", "General", "", 1);
        public static readonly NotePurpose Design = new NotePurpose("{AFF6D3C1-1D80-481E-82C3-2618F085EAD9}", "Design", "", 2);
        public static readonly NotePurpose Fabrication = new NotePurpose("{6BD08572-EA5A-49FE-987A-31B4EECBE518}", "Fabrication", "", 3);
        public static readonly NotePurpose Installation = new NotePurpose("{86876994-D860-49B7-BE1F-2B1BB4CD1F6A}", "Installation", "", 4);
        public static readonly NotePurpose OperationAndMaintenance = new NotePurpose("{C122EF71-1281-4622-8AED-C5CD9A17F29F}", "Operation and Maintenance", "", 5);
        public static readonly NotePurpose Inspection = new NotePurpose("{277A37AB-8A3B-4FD9-ABC4-167C9622ED1B}", "Inspection", "", 6);
        public static readonly NotePurpose Remark = new NotePurpose("{C6AD25F1-AB65-4618-9BF4-11473F58FCC4}", "Remark", "", 7);
        public static readonly NotePurpose MaterialOfConstruction = new NotePurpose("{3E8FED2E-74B5-4BB4-95AE-AA978D8DD8A0}", "Material of Construction", "", 8);
        public static readonly NotePurpose DesignReview = new NotePurpose("{3209FDAA-C937-4B2F-AF29-66E8E32DF68F}", "Design Review", "", 9);
        public static readonly NotePurpose PipingSpecificationNote = new NotePurpose("{206E5F74-938E-40EE-B456-F87430A311C2}", "Piping Specification note", "", 10);
        public static readonly NotePurpose Justification = new NotePurpose("{9CB1F92B-CC48-4877-9531-F0C832C27A71}", "Justification", "", 11);
        public static readonly NotePurpose Procurement = new NotePurpose("{0DC824A4-D8A4-4747-967F-3AD8711DC38C}", "Procurement", "", 12);
        public static readonly NotePurpose StandardNote = new NotePurpose("{EFFE6A46-3F75-4AA9-B34F-61F36DA5F436}", "Standard note", "", 13);
        #endregion
        public NotePurpose(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator NotePurpose(string text)
        {
            return FindByText<NotePurpose>(text);
        }
    }
}