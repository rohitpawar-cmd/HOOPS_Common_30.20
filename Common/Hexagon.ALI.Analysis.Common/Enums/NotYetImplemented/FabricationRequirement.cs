namespace Analysis2.SIO.Library.Enums
{
    public class FabricationRequirement : SIOEnum
    {
        #region VALUES
        public static readonly FabricationRequirement Undefined = new FabricationRequirement("{DFFCD858-7D13-4485-BCB1-9601BCDCA09C}", "Undefined", "", 1);
        public static readonly FabricationRequirement ByPipeFabricator = new FabricationRequirement("{9CEB6C1C-38AB-47E7-B95B-FFF6C78F7935}", "By Pipe fabricator", "", 5);
        public static readonly FabricationRequirement ByPipeErector = new FabricationRequirement("{389AB2FD-3ADF-49EF-A5CC-7711383DE340}", "By Pipe erector", "", 10);
        public static readonly FabricationRequirement ByPipeErectorForLooseMaterial = new FabricationRequirement("{E65D51A7-40CD-45E8-A235-A5068E0B5A74}", "By Pipe erector for loose material", "", 15);
        #endregion
        public FabricationRequirement(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator FabricationRequirement(string text)
        {
            return FindByText<FabricationRequirement>(text);
        }
    }
}