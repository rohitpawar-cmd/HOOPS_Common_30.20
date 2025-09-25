namespace Analysis2.SIO.Library.Enums
{
    public class HeatTracingRequirement : SIOEnum
    {
        #region VALUES
        public static readonly HeatTracingRequirement NotHeatTraced = new HeatTracingRequirement("{82BB5B0B-584E-482D-9E1D-4E63489E5995}", "Not Heat Traced", "", 2);
        public static readonly HeatTracingRequirement HeatTraced = new HeatTracingRequirement("{A6587874-E80D-497A-9C81-7E556A8FA27D}", "Heat Traced", "", 3);
        #endregion
        public HeatTracingRequirement(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator HeatTracingRequirement(string text)
        {
            return FindByText<HeatTracingRequirement>(text);
        }
    }
}