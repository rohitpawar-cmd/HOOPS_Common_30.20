namespace Analysis2.SIO.Library.Enums
{
    public class HngSupSupportDirection : SIOEnum
    {
        #region VALUES
        public static readonly HngSupSupportDirection Computed = new HngSupSupportDirection("{8d634168-aa52-4878-b4ca-ae198fb2d78f}", "Computed", "", 0);
        public static readonly HngSupSupportDirection PosX = new HngSupSupportDirection("{1d7b4687-b247-4692-bad2-c4ec7a487abf}", "+X", "", 1);
        public static readonly HngSupSupportDirection NegX = new HngSupSupportDirection("{817d2d37-30c2-40f2-a26d-85184e30bba0}", "-X", "", 2);
        public static readonly HngSupSupportDirection PosY = new HngSupSupportDirection("{7b03b563-0743-4958-b770-b639e6852abe}", "+Y", "", 3);
        public static readonly HngSupSupportDirection NegY = new HngSupSupportDirection("{dd94e006-9865-426d-aca4-895a841a722e}", "-Y", "", 4);
        public static readonly HngSupSupportDirection PosZ = new HngSupSupportDirection("{996377e5-9361-4b90-8d59-4abd0ef873e1}", "+Z", "", 5);
        public static readonly HngSupSupportDirection NegZ = new HngSupSupportDirection("{177d2a4d-c2a6-4df8-8981-cdc841964c1c}", "-Z", "", 6);
        #endregion
        public HngSupSupportDirection(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator HngSupSupportDirection(string text)
        {
            return FindByText<HngSupSupportDirection>(text);
        }
    }
}