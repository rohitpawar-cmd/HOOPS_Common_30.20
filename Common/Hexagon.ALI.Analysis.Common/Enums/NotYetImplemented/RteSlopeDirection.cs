namespace Analysis2.SIO.Library.Enums
{
    public class RteSlopeDirection : SIOEnum
    {
        #region VALUES
        public static readonly RteSlopeDirection NotSloped = new RteSlopeDirection("{64474386-0e10-4ccb-a1c7-b3bc9058dff3}", "Not sloped", "", 0);
        public static readonly RteSlopeDirection Up = new RteSlopeDirection("{31100d51-7583-4f80-85c3-7de83aa842ed}", "Up", "", 1);
        public static readonly RteSlopeDirection Down = new RteSlopeDirection("{52c206c9-ee0e-42de-a449-431153157ddb}", "Down", "", 2);
        public static readonly RteSlopeDirection Multiple = new RteSlopeDirection("{f3347aa2-c6d9-45ad-9156-0e607a232606}", "Multiple", "", 3);
        #endregion
        public RteSlopeDirection(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator RteSlopeDirection(string text)
        {
            return FindByText<RteSlopeDirection>(text);
        }
    }
}