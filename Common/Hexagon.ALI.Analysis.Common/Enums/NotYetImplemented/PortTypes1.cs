namespace Analysis2.SIO.Library.Enums
{
    public class PortTypes1 : SIOEnum
    {
        #region VALUES
        public static readonly PortTypes1 Vent = new PortTypes1("{7325e196-b419-4be0-a5f7-d0df28e56262}", "Vent", "", 27);
        public static readonly PortTypes1 Drain = new PortTypes1("{81e4271c-9ab8-4c7a-bf76-1a5b5932bb93}", "Drain", "", 28);
        public static readonly PortTypes1 Trap = new PortTypes1("{b72d28da-651c-4847-a914-2061a8e2176f}", "Trap", "", 29);
        #endregion
        public PortTypes1(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator PortTypes1(string text)
        {
            return FindByText<PortTypes1>(text);
        }
    }
}