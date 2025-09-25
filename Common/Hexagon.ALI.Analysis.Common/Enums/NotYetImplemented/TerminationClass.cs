namespace Analysis2.SIO.Library.Enums
{
    public class TerminationClass : SIOEnum
    {
        #region VALUES
        public static readonly TerminationClass Bolted = new TerminationClass("{C352C841-E37F-4BAD-9AD0-449B374EF1C4}", "Bolted", "", 5);
        public static readonly TerminationClass Male = new TerminationClass("{D236C355-DE86-4BDB-90CF-676CB5ADAC3A}", "Male", "", 10);
        public static readonly TerminationClass Female = new TerminationClass("{22964219-C561-4448-8865-C5E3E4FF82BD}", "Female", "", 15);
        public static readonly TerminationClass Mechanical = new TerminationClass("{0887D6EE-6275-4FAA-984C-5651D0D71ED0}", "Mechanical", "", 20);
        public static readonly TerminationClass Undefined = new TerminationClass("{D2142EF5-A654-4C75-B5C2-EA25E478BC76}", "Undefined", "", 1);
        #endregion
        public TerminationClass(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator TerminationClass(string text)
        {
            return FindByText<TerminationClass>(text);
        }
    }
}