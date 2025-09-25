namespace Analysis2.SIO.Library.Enums
{
    public class DocumentClasses : SIOEnum
    {
        #region VALUES
        public static readonly DocumentClasses GraphicalDocument = new DocumentClasses("{92f4bca3-a2b9-4678-b96e-1fab31cf78b9}", "GraphicalDocument", "", 1);
        public static readonly DocumentClasses NonGraphicalDocument = new DocumentClasses("{16b320d9-3b29-44d4-a975-e94a528cf695}", "NonGraphicalDocument", "", 131);
        #endregion
        public DocumentClasses(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator DocumentClasses(string text)
        {
            return FindByText<DocumentClasses>(text);
        }
    }
}