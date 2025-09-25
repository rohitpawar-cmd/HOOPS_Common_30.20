using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.SIO
{
    [DefUID("Support")]
    public class Support : SIOEntity, ILocation, IOrientation, IHgrSupportDirection, ISupport, IRtePipePart
    {
        public Support()
        {

        }

        #region PROPERTIES

        [NotMapped]
        public string LocationX
        {
            get;
            set;
        }

        public double? LocationXSiValue
        {
            get;
            private set;
        }
        [NotMapped]
        public string LocationY
        {
            get;
            set;
        }

        public double? LocationYSiValue
        {
            get;
            private set;
        }
        [NotMapped]
        public string LocationZ
        {
            get;
            set;
        }

        public double? LocationZSiValue
        {
            get;
            private set;
        }

        public double RadialOrientX
        {
            get;
            set;
        }

        public double RadialOrientY
        {
            get;
            set;
        }

        public double RadialOrientZ
        {
            get;
            set;
        }

        public double OrientationX
        {
            get;
            set;
        }

        public double OrientationY
        {
            get;
            set;
        }

        public double OrientationZ
        {
            get;
            set;
        }

        public double UVectorX
        {
            get;
            set;
        }

        public double UVectorY
        {
            get;
            set;
        }

        public double UVectorZ
        {
            get;
            set;
        }

        public string HgrSupportDirection
        {
            get;
            set;
        }

        public string StressSystemNo
        {
            get;
            set;
        }

        public string IsoSheetNo
        {
            get;
            set;
        }

        public string IsogenKey
        {
            get;
            set;
        }
        [RelDef()] public AnalysisSupport AnalysisSupport { get; set; }
        public string AnalysisSupportId { get; set; }
        public SupportedObject SupportedObject { get; set; }
        [RelDef()] public Pipeline Pipeline { get; set; }
        public string PipelineId { get; set; }
        #endregion PROPERTIES
    }
}