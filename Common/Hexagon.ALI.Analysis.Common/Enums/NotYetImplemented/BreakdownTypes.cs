namespace Analysis2.SIO.Library.Enums
{
    public class BreakdownTypes : SIOEnum
    {
        #region VALUES
        public static readonly BreakdownTypes PBSParent = new BreakdownTypes("{11dca325-ccdd-4659-88bc-4f9e0574b5b4}", "PBSParent", "", 1);
        public static readonly BreakdownTypes WBSParent = new BreakdownTypes("{050826e1-9469-4809-bf2b-7253fb29826c}", "WBSParent", "", 13);
        public static readonly BreakdownTypes AssemblyParent = new BreakdownTypes("{6c5cf7df-9725-49cc-a5d2-e29702fc7b11}", "AssemblyParent", "", 17);
        #endregion
        public BreakdownTypes(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator BreakdownTypes(string text)
        {
            return FindByText<BreakdownTypes>(text);
        }
    }
}