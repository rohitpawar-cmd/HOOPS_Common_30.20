using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.SIO
{
    public enum PRunConnectionType
    {
        NONE,
        END,
        INSIDE
    }

    [DefUID("PipeRun")]
    public class PipeRun : SIOEntity, IRtePipeRun, IProcessDataInfo, IPipeRun, IRun
    {
        public List<PipeRunItem> PipeRunItems { get; set; } = new List<PipeRunItem>();

        public string PipeRunDiscriptor
        {
            get;
            private set;
        }

        public PipeRun(string discriptor = "")
        {
            PipeRunDiscriptor = discriptor;
        }
        public PipeRun()
        {

        }
        public void AddBranchEndPort(BranchEndPort branchEndPort, PRunConnectionType pRunConnectionType)
        {
            if (branchEndPort != this.RunEnd1BranchPort && branchEndPort != this.RunEnd2BranchPort)
            {
                switch (pRunConnectionType)
                {
                    case PRunConnectionType.END:
                        if (this.RunEnd1BranchPort is null)
                        {
                            this.RunEnd1BranchPort = branchEndPort;
                        }
                        else if (this.RunEnd2BranchPort is null)
                        {
                            this.RunEnd2BranchPort = branchEndPort;
                        }
                        else
                        {
                            // TODO:
                            // raise exception???
                        }
                        break;

                    case PRunConnectionType.INSIDE:
                        if (!this.RunBranchPorts.Contains(branchEndPort))
                        {
                            this.RunBranchPorts.Add(branchEndPort);
                        }
                        break;

                    case PRunConnectionType.NONE:
                        // TODO: What it mean by NONE??
                        break;
                }
            }
        }

        #region PROPERTIES

        #region IRtePipeRun

        public string PipeRunFlowDirection
        {
            get; set;
        }
        [NotMapped]
        public string MinSlope
        {

            get;
            set;
        }
        [NotMapped]
        public string PipeRunNPD
        {
            get;
            set;
        }

        public string PipeRunScheduleOverride
        {
            get; set;
        }

        public string PipeRunSlopeDirection
        {
            get; set;
        }
        [NotMapped]
        public string PipeRunEstimatedLength
        {
            get;
            set;
        }

        public string PipeRunMaterialsClass
        {
            get; set;
        }

        public string PipeRunSpecStatus
        {
            get; set;
        }

        public string PipeRunSchedulePractice
        {
            get;
            set;
        }

        #endregion IRtePipeRun
        #region IProcessDataInfo
        [NotMapped]
        public string DesignMaxTemp
        {
            get;
            set;
        }
        [NotMapped]
        public string DesignMinTemp
        {
            get;
            set;
        }
        [NotMapped]
        public string DesignMaxPressure
        {
            get;
            set;
        }
        [NotMapped]
        public string DesignMinPressure
        {
            get;
            set;
        }
        [NotMapped]
        public string OperatingMaxTemp
        {
            get;
            set;
        }
        [NotMapped]
        public string OperatingMinTemp
        {
            get;
            set;
        }
        [NotMapped]
        public string OperatingMaxPressure
        {
            get;
            set;
        }
        [NotMapped]
        public string OperatingMinPressure
        {
            get;
            set;
        }
        [NotMapped]
        public string TestingMaxTemp
        {
            get;
            set;
        }
        [NotMapped]
        public string TestingMinTemp
        {
            get;
            set;
        }
        [NotMapped]
        public string TestingMaxPressure
        {
            get;
            set;
        }
        [NotMapped]
        public string TestingMinPressure
        {
            get;
            set;
        }

        #endregion IProcessDataInfo

        #region Si Values

        public double? MinSlopeSiValue
        {
            get;
            protected set;
        }

        public double? PipeRunNPDSiValue
        {
            get;
            protected set;
        }

        public double? PipeRunEstimatedLengthSiValue
        {
            get;
            protected set;
        }

        public double? DesignMaxTempSiValue
        {
            get;
            protected set;
        }

        public double? DesignMinTempSiValue
        {
            get; protected set;
        }

        public double? DesignMaxPressureSiValue
        {
            get; protected set;
        }

        public double? DesignMinPressureSiValue
        {
            get; protected set;
        }

        public double? OperatingMaxTempSiValue
        {
            get; protected set;
        }

        public double? OperatingMinTempSiValue
        {
            get; protected set;
        }

        public double? OperatingMaxPressureSiValue
        {
            get; protected set;
        }

        public double? OperatingMinPressureSiValue
        {
            get; protected set;
        }

        public double? TestingMaxTempSiValue
        {
            get; protected set;
        }

        public double? TestingMinTempSiValue
        {
            get; protected set;
        }

        public double? TestingMaxPressureSiValue
        {
            get; protected set;
        }

        public double? TestingMinPressureSiValue
        {
            get; protected set;
        }
        [RelDef()] public Pipeline Pipeline { get; set; }
        public List<BranchEndPort> RunBranchPorts { get; set; } = new List<BranchEndPort>();
        public BranchEndPort RunEnd1BranchPort { get; set; }
        public string RunEnd1BranchPortId { get; set; }
        public BranchEndPort RunEnd2BranchPort { get; set; }
        public string RunEnd2BranchPortId { get; set; }
        #endregion Si Values

        #endregion PROPERTIES

        #region UNMAPPED_PROPERTIES

        public string Thickness;
        public string coldElasticModulus;
        public string pipeDensity;
        public string insulationDensity;
        public string cladUnitWeight;

        #endregion UNMAPPED_PROPERTIES
    }
}