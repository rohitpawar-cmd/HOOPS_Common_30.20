using Hexagon.ALI.Analysis.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis
{
    public interface IAnalysisElementOffset
    {
        [UoM("LengthUoM")]
        string X { get; set; }
        double? XSiValue { get;}
        [UoM("LengthUoM")]
        string Y { get; set; }
        double? YSiValue { get;}
        [UoM("LengthUoM")]
        string Z { get; set; }
        double? ZSiValue { get; }       
    }
}
