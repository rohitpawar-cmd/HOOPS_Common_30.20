using Hexagon.ALI.Analysis.Common.Classes;
using Hexagon.ALI.Analysis.Common.Classes.SIO;
using Hexagon.ALI.Analysis.Common.Helpers;
using System.Collections.Generic;

namespace Hexagon.ALI.Analysis.Common.Interfaces
{
    public interface ISupportedObject
    {
        [RelDef("SupportHasSupportedObject")]
        List<Support> SupportHasSupportedObject { get; set; }
    }
    public abstract class SupportedObject : SIOEntity, ISupportedObject
    {
        [RelDef()] public List<Support> SupportHasSupportedObject { get; set; }
    }
}
