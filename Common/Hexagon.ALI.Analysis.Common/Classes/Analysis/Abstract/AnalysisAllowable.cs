using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Allowables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract
{
    public abstract class AnalysisAllowable: AnalysisBaseObject, IAnalysisAllowable
    {
        public AnalysisMaterial Material { get; set; }
        public string AnalysisMaterialId { get; set; }
        [NotMapped]
        public string Sc { get; set; }
        public double? ScSiValue { get; private set; }
        [NotMapped]
        public string Sy { get; set; }
        public double? SySiValue { get; private set; }
        public double? Eff { get; set; }
        public double? Fac { get; set; }
        [NotMapped]
        public string Pvar { get; set; }
        public double? PvarSiValue { get; private set; }

    }

    public interface IAnalysisAllowable
    {
        [UoM("StressUoM")]
        [PPMProperty(nameof(Sc), nameof(IAnalysisAllowable))]
        string Sc { get; set; }
        double? ScSiValue { get; }

        [UoM("StressUoM")]
        [PPMProperty(nameof(Sy), nameof(IAnalysisAllowable))]
        string Sy { get; set; }
        double? SySiValue { get; }

        [UoM("PressureUoM")]
        [PPMProperty(nameof(Pvar), nameof(IAnalysisMaterialAllowableASME))]
        string Pvar { get; set; }

        double? PvarSiValue { get; }
    }
}
