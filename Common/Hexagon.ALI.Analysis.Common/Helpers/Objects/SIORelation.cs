using Hexagon.ALI.Analysis.Common.Classes;
using System.Diagnostics.CodeAnalysis;

namespace Hexagon.ALI.Analysis.Common.Helpers.Objects
{
    [ExcludeFromCodeCoverage]
    public partial class SIORelation : SIOObject
    {
        public SIORelation(SIOEntity end1, SIOEntity end2, RelDefAttribute relationDefinition)
        {
            End1 = end1;
            End2 = end2;
            End1ClassName = end1.GetType().Name;
            End2ClassName = end2.GetType().Name;
            RelationDefinition = relationDefinition;

            Id = $"{relationDefinition.relDef}_{end1.InternalID}_{end2.InternalID}";
        }
        public SIOEntity End1 { get; set; }
        public SIOEntity End2 { get; set; }
        public string End1ClassName { get; internal set; }
        public string End2ClassName { get; internal set; }
        public RelDefAttribute RelationDefinition { get; set; }
    }
}
