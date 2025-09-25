namespace Analysis2.SIO.Library.Enums
{
    public class CleaningRequirement : SIOEnum
    {
        #region VALUES
        public static readonly CleaningRequirement Undefined = new CleaningRequirement("{20F08AE3-B60A-11D6-BDB8-00104BCC2B69}", "Undefined", "", 1);
        public static readonly CleaningRequirement NotRequired = new CleaningRequirement("{20F08AE3-B60A-11D6-BDB8-00104BCC2B69}", "Not Required", "", 2);
        public static readonly CleaningRequirement CC1 = new CleaningRequirement("{20F08AE3-B60A-11D6-BDB8-00104BCC2B69}", "CC1", "", 10);
        public static readonly CleaningRequirement CC2 = new CleaningRequirement("{20F08AE3-B60A-11D6-BDB8-00104BCC2B69}", "CC2", "", 15);
        public static readonly CleaningRequirement CC3 = new CleaningRequirement("{20F08AE3-B60A-11D6-BDB8-00104BCC2B69}", "CC3", "", 20);
        public static readonly CleaningRequirement CC4 = new CleaningRequirement("{20F08AE3-B60A-11D6-BDB8-00104BCC2B69}", "CC4", "", 25);
        public static readonly CleaningRequirement CC5 = new CleaningRequirement("{20F08AE3-B60A-11D6-BDB8-00104BCC2B69}", "CC5", "", 30);
        public static readonly CleaningRequirement Varies = new CleaningRequirement("{20F08AE3-B60A-11D6-BDB8-00104BCC2B69}", "Varies", "", 35);
        #endregion
        public CleaningRequirement(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator CleaningRequirement(string text)
        {
            return FindByText<CleaningRequirement>(text);
        }
    }
}