using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using System.Collections.Generic;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis
{
    public interface IAnalysisModelOrganization
    {
        List<AnalysisLineElement> AnalysisLineElements { get; set; }
        string CAESARIILineNumber { get; set; }
    }
}