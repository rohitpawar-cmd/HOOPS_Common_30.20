namespace Analysis2.SIO.Library.Enums
{
    public class FlowDirection : SIOEnum
    {
        #region VALUES
        public static readonly FlowDirection Undefined = new FlowDirection("{9E6342D5-82E8-4D49-8077-59E43D9DBAC8}", "Undefined", "", 0);
        public static readonly FlowDirection Out = new FlowDirection("{bd2e4baf-a92b-4b47-bb55-243bf74878ac}", "Out", "", 1);
        public static readonly FlowDirection In = new FlowDirection("{fcf751f9-3d13-42cb-b201-fedffc94668a}", "In", "", 2);
        public static readonly FlowDirection BiDirectional = new FlowDirection("{6febc727-2332-4acf-84db-c3e24389ff32}", "Bi-directional", "", 3);
        public static readonly FlowDirection NoFlow = new FlowDirection("{14a7465b-efc9-4e33-9205-3522669eea8a}", "No Flow", "", 4);
        #endregion
        public FlowDirection(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator FlowDirection(string text)
        {
            return FindByText<FlowDirection>(text);
        }
    }
}