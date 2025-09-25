using Hexagon.ALI.Analysis.Common.Classes.Abstract;
using Hexagon.ALI.Analysis.Common.Helpers;
using System.Collections.Generic;

namespace Hexagon.ALI.Analysis.Common.Interfaces
{
    public interface IItem
    {
        [RelDef("ItemHasOverrides", true)]
        List<PartOverride> PartOverrides { get; set; }
    }
    public abstract class Item : SupportedObject, IItem
    {
        public List<PartOverride> PartOverrides { get; set; } = new List<PartOverride>();
    }
}
