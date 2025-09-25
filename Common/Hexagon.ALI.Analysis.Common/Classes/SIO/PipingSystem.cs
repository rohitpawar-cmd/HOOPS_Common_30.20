using Hexagon.ALI.Analysis.Common.Classes.Analysis;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.LoadCase;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.NodalAuxiliaries.Inputs;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.Primitives;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.SIF;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.VectorAuxiliaries;
using Hexagon.ALI.Analysis.Common.Enums;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Helpers.Units;
using Hexagon.ALI.Analysis.Common.Interfaces;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Hexagon.ALI.Analysis.Common.Classes.SIO
{
    public static class Globals
    {
        public static UnitStore userUnits { get; private set; } = new UnitStore();
    }

    [DefUID("PipingSystem")]
    public class PipingSystem : SIOEntity, IBreakdown, IPipingSystem, IPipelineOwner
    {
        public PipingSystem()
        {
            UserUnits = new UnitStore();
        }
        #region Public methods


        public AnalysisOperatingPrimitive GetOrAddPrimitive(PrimitiveType type, int number)
        {
            AnalysisOperatingPrimitive primitive = OwnsAnalysisOperatingPrimitive.FirstOrDefault(f => f.PrimitiveType == type && f.Number == number);

            if (primitive == null)
            {
                primitive = new AnalysisOperatingPrimitive() { PrimitiveType = type, Number = number, Name = $"{type}{number}" };
                OwnsAnalysisOperatingPrimitive.Add(primitive);
            }

            return primitive;
        }

        public void AddVectorAuxiliary(IAnalysisVectorAuxiliary auxiliary, PrimitiveType type, int? number)
        {
            if (!number.HasValue)
            {
                return;
            }

            AnalysisOperatingPrimitive primitive = GetOrAddPrimitive(type, number.Value);

            auxiliary.AnalysisPrimitive = primitive;

            switch (auxiliary)
            {
                case AnalysisProcessInfo processInfo:
                    if (!primitive.AnalysisOperatingPrimitiveToAnalysisProcessInfo.Contains(processInfo))
                    {
                        primitive.AnalysisOperatingPrimitiveToAnalysisProcessInfo.Add(processInfo);
                    }
                    break;
                case AnalysisDisplacement displacement:
                    if (!primitive.AnalysisOperatingPrimitiveToAnalysisDisplacement.Contains(displacement))
                    {
                        primitive.AnalysisOperatingPrimitiveToAnalysisDisplacement.Add(displacement);
                    }
                    break;
                case AnalysisAppliedPointForce analysisAppliedPointForce:
                    if (!primitive.AnalysisOperatingPrimitiveToAnalysisAppliedPointForce.Contains(analysisAppliedPointForce))
                    {
                        primitive.AnalysisOperatingPrimitiveToAnalysisAppliedPointForce.Add(analysisAppliedPointForce);
                    }
                    break;
                case AnalysisMaterialAllowableDataSet analysisMaterialAllowableDataSet:
                    if (!primitive.AnalysisOperatingPrimitiveToAnalysisMaterialAllowableDataSet.Contains(analysisMaterialAllowableDataSet))
                    {
                        primitive.AnalysisOperatingPrimitiveToAnalysisMaterialAllowableDataSet.Add(analysisMaterialAllowableDataSet);
                    }
                    break;
                case AnalysisUniformLoadDataSet analysisUniformLoadDataSet:
                    if (!primitive.AnalysisOperatingPrimitiveToAnalysisUniformLoadDataSet.Contains(analysisUniformLoadDataSet))
                    {

                        primitive.AnalysisOperatingPrimitiveToAnalysisUniformLoadDataSet.Add(analysisUniformLoadDataSet);
                    }
                    break;
                case AnalysisWindLoad analysisWindLoad:
                    if (!primitive.AnalysisOperatingPrimitiveToAnalysisWindLoad.Contains(analysisWindLoad))
                    {
                        primitive.AnalysisOperatingPrimitiveToAnalysisWindLoad.Add(analysisWindLoad);
                    }
                    break;
                case AnalysisWaveLoad analysisWaveLoad:
                    if (!primitive.AnalysisOperatingPrimitiveToAnalysisWaveLoad.Contains(analysisWaveLoad))
                    {
                        primitive.AnalysisOperatingPrimitiveToAnalysisWaveLoad.Add(analysisWaveLoad);
                    }
                    break;
            }
            
        }

        #endregion

        #region RELATIONS
        public List<AnalysisLoadCase> OwnsAnalysisLoadCase { get; set; } = new List<AnalysisLoadCase>();
        public List<AnalysisNode> OwnsAnalysisNode { get; set; } = new List<AnalysisNode>();
        public List<AnalysisLineElement> OwnsAnalysisLineElements { get; set; } = new List<AnalysisLineElement>();
        public List<AnalysisOperatingPrimitive> OwnsAnalysisOperatingPrimitive { get; set; } = new List<AnalysisOperatingPrimitive>();
        public List<AnalysisLoadCasePrimitive> OwnsAnalysisLoadCasePrimitive { get; set; } = new List<AnalysisLoadCasePrimitive>();
        public List<Pipeline> OwnsPipelines { get; set; } = new List<Pipeline>();

        #endregion RELATIONS

        #region PROPERTIES
        public UnitStore UserUnits { get; set; }

        [NotMapped]
        public List<AnalysisSifLineElement> SIFLineElements { get; } = new List<AnalysisSifLineElement>();
        
        public string BreakdownType
        {
            get;
            set;
        }

        public string BreakdownClass
        {
            get;
            set;
        }

        public string SpecificBreakdownType
        {
            get;
            set;
        }

        public string BreakdownTypeDescription
        {
            get;
            set;
        }
        #endregion PROPERTIES
    }
}