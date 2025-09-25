using System.Diagnostics.CodeAnalysis;

namespace Hexagon.ALI.Analysis.Common.Helpers.Objects
{
    //Base class for SIOEntity and SIORelation for use in the Object Processor class
    [ExcludeFromCodeCoverage]
    public class SIOObject
    {
        public string Id
        {
            get;
            set;
        }
    }
}
