using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces;
using System.Collections.Generic;

namespace Hexagon.ALI.Analysis.Common.Classes.SIO
{
    [DefUID("Pipeline")]
    public class Pipeline : SIOEntity, IPipelineSystem, IPipeline, ISupportOwner
    {
        public Pipeline(string pline = "")
        {
            Pline = pline;
        }
        public Pipeline() { }
        [RelDef()] public PipingSystem PipingSystem { get; set; }

        public string Pline
        {
            get;
            private set;
        }
        public string Temperature;
        public string Pressure;

        public List<PipeRun> OwnsPipeRuns { get; set; } = new List<PipeRun>();
        public List<Support> OwnsSupports { get; set; } = new List<Support>();
        public List<OpCond> OperCond { get; set; } = new List<OpCond>();
        #region PROPERTIES

        public string PipelineSequenceNumber
        {
            get;
            set;
        }

        public string PipelineFluidSystem
        {
            get;
            set;
        }

        public string PipelineFluidCode
        {
            get;
            set;
        }

        #endregion PROPERTIES
    }

    public class OpCond
    {
        public string Id { get; set; }
        public string Name;
        public string Value;
    }

    public class Size
    {
        public string idx;
        public string Name;
        public string Value;
    }
}