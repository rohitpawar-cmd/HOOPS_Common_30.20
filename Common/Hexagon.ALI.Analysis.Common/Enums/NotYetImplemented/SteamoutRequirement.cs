namespace Analysis2.SIO.Library.Enums
{
    public class SteamoutRequirement : SIOEnum
    {
        #region VALUES
        public static readonly SteamoutRequirement Undefined = new SteamoutRequirement("{783989D4-9F3D-11D6-BDA7-00104BCC2B69}", "Undefined", "", 1);
        public static readonly SteamoutRequirement NotRequired = new SteamoutRequirement("{783989D4-9F3D-11D6-BDA7-00104BCC2B69}", "Not Required", "", 5);
        public static readonly SteamoutRequirement Required = new SteamoutRequirement("{783989D4-9F3D-11D6-BDA7-00104BCC2B69}", "Required", "", 10);
        #endregion
        public SteamoutRequirement(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator SteamoutRequirement(string text)
        {
            return FindByText<SteamoutRequirement>(text);
        }
    }
}