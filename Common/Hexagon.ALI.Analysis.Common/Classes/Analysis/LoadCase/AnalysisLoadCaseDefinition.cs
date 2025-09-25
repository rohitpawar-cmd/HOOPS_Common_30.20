using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.LoadCase
{
    public class AnalysisLoadCaseDefinition : AnalysisBaseObject
    {
        public List<AnalysisLoadCaseComponent> LoadCaseComponents = new List<AnalysisLoadCaseComponent>();
    }
}
