using Hexagon.ALI.Analysis.Common.Enums;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.LineElementAuxiliaries;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.LineElements
{
    [DefUID("AnalysisRigid")]
    public class AnalysisRigid : AnalysisPipe, IAnalysisRigid
    {        
        public RigidType? RigidType { get; set; }
        public double? RigidWeightSiValue { get; private set; }

        [NotMapped]
        public string RigidWeight { get; set; }
        
        public override string ToString()
        {
            return string.IsNullOrEmpty(Name) ? base.ToString().Replace("Element", "Rigid") : Name;
        }
    }
}
