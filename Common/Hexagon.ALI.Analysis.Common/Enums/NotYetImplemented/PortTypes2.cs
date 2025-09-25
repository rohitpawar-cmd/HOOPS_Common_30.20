namespace Analysis2.SIO.Library.Enums
{
    public class PortTypes2 : SIOEnum
    {
        public PortTypes2(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator PortTypes2(string text)
        {
            return FindByText<PortTypes2>(text);
        }
    }
}