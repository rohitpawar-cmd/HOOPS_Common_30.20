namespace Analysis2.SIO.Library.Enums
{
    public class DocumentSupportClasses : SIOEnum
    {
        #region VALUES
        public static readonly DocumentSupportClasses File = new DocumentSupportClasses("{46e37404-80f5-465b-b4cc-9f8582677900}", "File", "", 1);
        public static readonly DocumentSupportClasses DrawingView = new DocumentSupportClasses("{e787c371-dfe0-44b7-8f4c-2af455333c24}", "DrawingView", "", 2);
        public static readonly DocumentSupportClasses Folder = new DocumentSupportClasses("{2ee8ac09-6c11-442a-abf2-497b099c9f92}", "Folder", "", 8);
        public static readonly DocumentSupportClasses GraphicalRepresentation = new DocumentSupportClasses("{2041e10c-e45d-476c-a416-b6d979983f5f}", "GraphicalRepresentation", "", 11);
        public static readonly DocumentSupportClasses DocumentRevision = new DocumentSupportClasses("{b792b10e-2226-40e1-aa06-95bd580aea7c}", "DocumentRevision", "", 12);
        public static readonly DocumentSupportClasses DocumentVersion = new DocumentSupportClasses("{936b1984-e8e0-4367-ad77-130cb20e2c68}", "DocumentVersion", "", 13);
        #endregion
        public DocumentSupportClasses(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator DocumentSupportClasses(string text)
        {
            return FindByText<DocumentSupportClasses>(text);
        }
    }
}