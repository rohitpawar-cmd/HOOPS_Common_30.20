namespace Analysis2.SIO.Library.Enums
{
    public class FlexibleHoseTopologyType : SIOEnum
    {
        #region VALUES
        public static readonly FlexibleHoseTopologyType Radial = new FlexibleHoseTopologyType("{beb0a35b-9b53-44d3-b856-9b1962d1380e}", "Radial", "", 1);
        public static readonly FlexibleHoseTopologyType Offset = new FlexibleHoseTopologyType("{e8665b8c-d749-4e04-bd1a-f27e35679067}", "Offset", "", 2);
        public static readonly FlexibleHoseTopologyType TravellingLoop = new FlexibleHoseTopologyType("{8c473f93-3ee0-40fe-be96-f2d90d7786d4}", "Travelling loop", "", 3);
        #endregion
        public FlexibleHoseTopologyType(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator FlexibleHoseTopologyType(string text)
        {
            return FindByText<FlexibleHoseTopologyType>(text);
        }
    }
}