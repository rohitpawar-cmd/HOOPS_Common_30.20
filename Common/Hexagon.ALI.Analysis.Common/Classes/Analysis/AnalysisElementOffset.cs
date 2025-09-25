using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis
{
    public class AnalysisElementOffset : AnalysisBaseObject, IAnalysisElementOffset
    {
        [NotMapped]
        public string X { get; set; }
        public double? XSiValue { get; private set; }
        [NotMapped]
        public string Y { get; set; }
        public double? YSiValue { get; private set; }
        [NotMapped]
        public string Z { get; set; }
        public double? ZSiValue { get; private set; }

    }
}
