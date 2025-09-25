namespace Analysis2.SIO.Library.Enums
{
    public class AssetTypes : SIOEnum
    {
        #region VALUES
        public static readonly AssetTypes Plant = new AssetTypes("{bf065545-fa7e-45d3-b06f-05e4286a637b}", "Plant", "", 1);
        public static readonly AssetTypes Ship = new AssetTypes("{dc03a7c0-65c7-4b3e-b7dd-189cabf56323}", "Ship", "", 2);
        public static readonly AssetTypes OffShorePlatform = new AssetTypes("{d5de4d61-7015-4a08-b31f-a371c8e05b24}", "OffShorePlatform", "", 3);
        public static readonly AssetTypes MaterialHandling = new AssetTypes("{ecbe1d4f-d282-4e4a-9b06-c50c13e27af1}", "MaterialHandling", "", 4);
        #endregion
        public AssetTypes(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator AssetTypes(string text)
        {
            return FindByText<AssetTypes>(text);
        }
    }
}