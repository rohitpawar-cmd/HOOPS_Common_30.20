using Hexagon.ALI.Analysis.Common.Classes.Analysis.LineElements;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Abstract
{
    public abstract class PartOverride : SIOEntity, IOverrideCommon, IStartEndLocation, IRtePipePathOverride, IPartOverride
    {
        public PartOverride()
        {

        }
        [NotMapped]
        public string StartLocX
        {
            get;
            set;
        }

        public double? StartLocXSiValue
        {
            get;
            protected set;
        }
        [NotMapped]
        public string StartLocY
        {
            get;
            set;
        }

        public double? StartLocYSiValue
        {
            get;
            protected set;
        }
        [NotMapped]
        public string StartLocZ
        {
            get;
            set;
        }

        public double? StartLocZSiValue
        {
            get;
            protected set;
        }
        [NotMapped]
        public string EndLocX
        {
            get;
            set;
        }

        public double? EndLocXSiValue
        {
            get;
            protected set;
        }
        [NotMapped]
        public string EndLocY
        {
            get;
            set;
        }

        public double? EndLocYSiValue
        {
            get;
            protected set;
        }
        [NotMapped]
        public string EndLocZ
        {
            get;
            set;
        }

        public double? EndLocZSiValue
        {
            get;
            protected set;
        }
        [NotMapped]
        public string PipePathOverrideNPD
        {
            get;
            set;
        }

        public double? PipePathOverrideNPDSiValue
        {
            get;
            protected set;
        }
        [NotMapped]
        public string PipePathOverrideOuterDiameter
        {
            get;
            set;
        }

        public double? PipePathOverrideOuterDiameterSiValue
        {
            get;
            protected set;
        }
        [RelDef()] public Item Item { get; set; }
        public string ItemId { get; set; }
        public List<AnalysisPipe> AnalysisBeams { get; set; } = new List<AnalysisPipe>();
    }
}