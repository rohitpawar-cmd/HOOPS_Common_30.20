using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Classes.SIO;
using Hexagon.ALI.Analysis.Common.Enums;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.LoadCase
{
    [DefUID("AnalysisLoadCase")]
    public class AnalysisLoadCase : AnalysisBaseObject, IAnalysisLoadCase
    {
        public AnalysisLoadCase()
        {
        }
        [RelDef()] public PipingSystem PipingSystem { get; set; }
        public string PipingSystemId { get; set; }
        public List<AnalysisNodeAuxiliaryOutput> NodeAuxiliaries { get; set; } = new List<AnalysisNodeAuxiliaryOutput>();
        public bool IsCombonation
        {
            get
            {
                if(LoadCaseDefinition == null)
                    return false;
                return LoadCaseDefinition.LoadCaseComponents.Any(s => s.Primitive.PrimitiveType == PrimitiveType.LC);
            }
        }
        public bool BypassLoadCase //ExcludeLC
        {
            get;
            set;
        }
        public AnalysisLoadCaseDefinition LoadCaseDefinition { get; private set; } = new AnalysisLoadCaseDefinition();

        public LoadCaseEnums.StressType? StressType
        {
            get;
            set;
        }
        public AnalysisLoadCase AltSustained {  get; set; }

        public double? Cycles
        {
            get;
            set;
        }
        public LoadCaseEnums.OutputStatus? OutputStatus
        {
            get;
            set;
        }
        public LoadCaseEnums.OutputType? OutputType
        {
            get;
            set;
        }
        public LoadCaseEnums.CombinationMethod? CombinationMethod
        {
            get;
            set;
        }
        public bool? Snubbers
        {
            get;
            set;
        }
        public LoadCaseEnums.HangerStiffness? HangerStiffness
        {
            get;
            set;
        }
        public AnalysisPrimitive ElasticModulus //EC isnt in the classes
        {
            get;
            set;
        }
        public AnalysisPrimitive ElbowStiffeningPressure //P1 - P9 or PMax/Min
        {
            get;
            set;
        }
        public AnalysisPrimitive ElbowStiffeningElasticModulus //EC isnt in the classes
        {
            get;
            set;
        }
        public AnalysisPrimitive SusOccCaseSh
        {
            get;
            set;
        }
        public double? FrictionMultiplier
        {
            get;
            set;
        }

        public double? FluidDensityMultiplier
        {
            get;
            set;
        }

        public double? OccLoadFactor
        {
            get;
            set;
        }
        private int _loadCaseNumber;
        public int LoadCaseNumber
        {
            get { return _loadCaseNumber; }
            set
            {
                _loadCaseNumber = value;                
            }
        }
        public AnalysisPrimitive FlangeAnalysisTemperature
        {
            get;
            set;
        }
        public LoadCaseEnums.LimitStateLoadType? LimitStateLoadType
        {
            get;
            set;
        }

        public string LoadCaseName
        {
            get;
            set;
        }

        public bool HasOutputDisplacements()
        {
            return OutputStatus != LoadCaseEnums.OutputStatus.Suppress &&
                (OutputType == null || OutputType == LoadCaseEnums.OutputType.DFS|| OutputType == LoadCaseEnums.OutputType.D || OutputType == LoadCaseEnums.OutputType.DS || OutputType == LoadCaseEnums.OutputType.DF);
        }

        public bool HasOutputForces()
        {
            return OutputStatus != LoadCaseEnums.OutputStatus.Suppress &&
                (OutputType == null || OutputType == LoadCaseEnums.OutputType.DFS || OutputType == LoadCaseEnums.OutputType.F || OutputType == LoadCaseEnums.OutputType.FS || OutputType == LoadCaseEnums.OutputType.DF);
        }

        public bool HasOutputStresses()
        {
            return OutputStatus != LoadCaseEnums.OutputStatus.Suppress &&
                (OutputType == null || OutputType == LoadCaseEnums.OutputType.DFS|| OutputType == LoadCaseEnums.OutputType.S || OutputType == LoadCaseEnums.OutputType.DS || OutputType == LoadCaseEnums.OutputType.FS);
        }

        [NotMapped]
        public bool? CodeCheckFailed
        {
            get;
            set;
        }

        public override string ToString() => $"{GetType().Name}-L{LoadCaseNumber}";
    }
}