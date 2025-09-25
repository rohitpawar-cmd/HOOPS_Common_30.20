using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Enums;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.SIF;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.SIF
{
    public class AnalysisSpecialJoint : AnalysisBaseSif, IAnalysisSpecialJoint
    {
        public AnalysisSpecialJoint() { }
        public double? SocketFilletLengthSiValue { get; private set; }
        public double? MaximumCircumferentialWeldMismatchSiValue { get; private set; }
        public double? AverageCircumferentialWeldMismatchSiValue { get; private set; }


        #region NOT MAPPED
        [NotMapped]
        public string SocketFilletLength { get; set; }

        [NotMapped]
        public string MaximumCircumferentialWeldMismatch { get; set; }

        [NotMapped]
        public string AverageCircumferentialWeldMismatch { get; set; }
        #endregion
    }

    public enum RegularTees
    {
        [Description("1 - Reinforced")]
        Reinforced = 1,
        [Description("2 - Unreinforced")]
        Unreinforced = 2,
        [Description("3 - Welding")]
        Welding = 3,
        [Description("4 - Sweepolet")]
        Sweepolet = 4,
        [Description("5 - Weldolet")]
        Weldolet = 5,
        [Description("6 - Extruded")]
        Extruded = 6,
        [Description("7 - Butt Weld")]
        ButtWeld = 7,
        [Description("8 - Socket")]
        Socket = 8,
        [Description("9 - Socket/unfin")]
        SocketUnfinished = 9,
        [Description("10 - Tapered")]
        Tapered = 10,
        [Description("11 - Threaded")]
        Threaded = 11,
        [Description("12 -Double Welded")]
        DoubleWelded = 12,
        [Description("13 - Lap Joint")]
        LapJoint = 13,
        [Description("14 - Bonney Forge Sweepolet")]
        BFSweepolet = 14,
        [Description("15 - Bonney Forge Latrolet")]
        BFLatrolet = 15,
        [Description("16 - Bonney Forge Ins Weld")]
        BFInsWeld = 16,
        [Description("17 - Full Encirclement")]
        FullEncirclement = 17,
    }

    public enum TD12Tees
    {
        [Description("1 - Fab w/ Pad/Sad")]
        FabWithPad = 1,
        [Description("2 - Fabricated")]
        Fabricated,
        [Description("3 - Forged (BS 1640)")]
        Welding,
        [Description("4 - Sweepolet")]
        Sweepolet,
        [Description("5 - Weldolet")]
        Weldolet,
        [Description("6- Drawn/Extruded")]
        Extruded,
        [Description("7 - Butt Weld")]
        ButtWeld,
        [Description("Wall Thick Transition")]
        WallThick = 10,
        [Description("17 - Full Encirclement")]
        FullEncirclement = 17,
        [Description("18 - Long Weld Neck")]
        LongWeldNeck,
        [Description("19 - Weldoflange")]
        Weldoflange = 17,
    }

    public enum B31JTees
    {
        [Description("1 - Reinforced (2.2)")]
        Reinforced = 1,
        [Description("2 - Fabricated (2.3)")]
        Unreinforced,
        [Description("3 - Welding (2.1)")]
        Welding,
        [Description("4 - Sweepolet (2.5)")]
        Sweepolet,
        [Description("5 - Weldolet (2.6)")]
        Weldolet,
        [Description("6 - Extruded (2.4)")]
        Extruded,
        [Description("7 - Butt Weld (4.1.4)")]
        ButtWeld,
        [Description("8 - Socket (4.3)")]
        Socket,
        [Description("9 - Socket/unfin (4.3)")]
        SocketUn,
        [Description("10 - Tapered (4.4)")]
        Tapered,
        [Description("11 - Threaded (5.1)")]
        Threaded,
        [Description("12 - Double Welded (4.7)")]
        DblWelded,
        [Description("13 - Lap Joint (4.8)")]
        LapJoint,
    }
}
