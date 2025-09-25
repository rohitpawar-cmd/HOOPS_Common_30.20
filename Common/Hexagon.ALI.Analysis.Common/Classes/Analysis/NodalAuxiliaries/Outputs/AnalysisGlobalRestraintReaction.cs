using Hexagon.ALI.Analysis.Common.Classes.Analysis.LoadCase;
using Hexagon.ALI.Analysis.Common.DTOs;
using Hexagon.ALI.Analysis.Common.Enums;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Helpers.Units;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.NodalAuxiliaries.Outputs
{
    [DefUID("AnalysisGlobalRestraintReaction")]
    public class AnalysisGlobalRestraintReaction : AnalysisForceMomentOutput, IAnalysisRestraintReaction
    {
        public AnalysisGlobalRestraintReaction(AnalysisNode node = null, AnalysisLoadCase loadCase = null) : base(node, loadCase)
        {
        }
        public AnalysisGlobalRestraintReaction()
        {
        }
        #region PRIVATE PROPERTIES
        #endregion

        #region PUBLIC PROPERTIES

        public RestraintType? RestraintType
        { 
            get; 
            set; 
        }

        public int? SummaryReportFlag
        {
            get;
            set;
        }
        public int? RigidOrFlexFlag
        {
            get;
            set;
        }
        public int? GapFlag
        {
            get;
            set;
        }
        [NotMapped]
        public string ResultantForce
        {
            get;
            set;
        }
        [NotMapped]
        public string ResultantMoment
        {
            get;
            set;
        }
        #endregion

        #region SIVALUES
        public double? ResultantForceSiValue
        {
            get;
            private set;
        }

        public double? ResultantMomentSiValue
        {
            get;
            private set;
        }
        #endregion

        public static AnalysisGlobalRestraintReaction CombineReactions(IEnumerable<AnalysisGlobalRestraintReaction> restraints, AnalysisLoadCase loadCase, AnalysisNode node, UnitStore unitStore)
        {
            if (restraints.Count() == 0)
                return null;

            if (restraints.Count() == 1)
                return restraints.First();

            var restraint = new AnalysisGlobalRestraintReaction()
            {
                AnalysisNode = node,
                AnalysisNodeId = node.Id,
                AnalysisLoadCase = loadCase,
                AnalysisLoadCaseId = loadCase.Id,
                FXSiValue = restraints.Sum(s => s.FXSiValue ?? 0.0),
                FYSiValue = restraints.Sum(s => s.FYSiValue ?? 0.0),
                FZSiValue = restraints.Sum(s => s.FZSiValue ?? 0.0),
                MXSiValue = restraints.Sum(s => s.MXSiValue ?? 0.0),
                MYSiValue = restraints.Sum(s => s.MYSiValue ?? 0.0),
                MZSiValue = restraints.Sum(s => s.MZSiValue ?? 0.0),
                ResultantForceSiValue = restraints.Sum(s => s.ResultantForceSiValue ?? 0.0),
                ResultantMomentSiValue = restraints.Sum(s => s.ResultantMomentSiValue ?? 0.0),
                RestraintType = null,
                RestraintTypeDisplay = string.Join("; ", restraints.OrderBy(o => o.RestraintType).Select(s => s.RestraintTypeDisplay).Where(w => !string.IsNullOrEmpty(w))),
            };

            return restraint;
        }
        private string _restraintTypeDisplay;
        [NotMapped]
        public string RestraintTypeDisplay
        {
            get
            {
                return _restraintTypeDisplay ?? $"{EnumHelper.GetEnumDescription(RestraintType)}";
            }
            set
            {
                _restraintTypeDisplay = value;

            }
        }
    }
}