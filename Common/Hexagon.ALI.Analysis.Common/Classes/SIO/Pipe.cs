using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.LineElements;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Hexagon.ALI.Analysis.Common.Classes.SIO
{
    [DefUID("Pipe")]
    public class Pipe : PipeRunItem, IRteBendData, ILocation, IOrientation
    {
        public Pipe()
        {

        }



        #region PROPERTIES
        [NotMapped]
        public string RteBendDataBendAngle
        {
            get;
            set;
        }

        public double? RteBendDataBendAngleSiValue
        {
            get;
            private set;
        }
        [NotMapped]
        public string RteBendDataBendRadius
        {
            get;
            set;
        }

        public double? RteBendDataBendRadiusSiValue
        {
            get;
            private set;
        }

        public string RteBendDataBRadMulti
        {
            get;
            set;
        }

        public string RteBendDataNoOfMiters
        {
            get;
            set;
        }
        [NotMapped]
        public string RteBendDataThroatRadius
        {
            get;
            set;
        }

        public double? RteBendDataThroatRadiusSiValue
        {
            get;
            private set;
        }

        public string componentId;
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
            get; set;
        }

        public double RadialOrientY
        {
            get; set;
        }

        public double RadialOrientZ
        {
            get; set;
        }

        public double OrientationX
        {
            get; set;
        }

        public double OrientationY
        {
            get; set;
        }

        public double OrientationZ
        {
            get; set;
        }

        public double UVectorX
        {
            get; set;
        }

        public double UVectorY
        {
            get; set;
        }

        public double UVectorZ
        {
            get; set;
        }
        #endregion PROPERTIES

        public override string ToString()
        {
            if (Name == "Pipe")
            {
                var nodes = AnalysisAbstractPipe.OfType<IAnalysisLineElement>().SelectMany(s => s.OwnsAnalysisNodes).OfType<IAnalysisNode>().Select(s => s.NodeNumber);
                var min = nodes.Select(s => int.TryParse(s, out int n) ? n : int.MaxValue).Min();
                var max = nodes.Select(s => int.TryParse(s, out int n) ? n : int.MinValue).Max();
                return (min != int.MaxValue && max != int.MinValue ? $"Pipe {min}-{max}" : !string.IsNullOrEmpty(Name) ? Name : "Pipe");
            }
            else if (!string.IsNullOrEmpty(Name))
            {
                return Name;
            }

            return "Pipe";
        }
    }
}