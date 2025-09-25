using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Hexagon.ALI.Analysis.Common.Enums
{
    public class LoadCaseEnums
    {
        public enum StressType
        {
            [Description("EXP")]
            EXP = 1,
            [Description("SUS")]
            SUS = 2,
            [Description("OCC")]
            OCC = 3,
            [Description("OPE")]
            OPE = 4,
            [Description("HGR")]
            HGR = 5,
            [Description("FAT")]
            FAT = 6,
            [Description("HYD")]
            HYD = 7,
            [Description("K1P")]
            K1P = 8,
            [Description("K1SR")]
            K1SR = 9,
            [Description("K2L")]
            K2L = 10,
            [Description("CRP")]
            CRP = 11,
            [Description("K2P")]
            K2P = 12,
            [Description("K2SA")]
            K2SA = 13,
            [Description("K2SR")]
            K2SR = 14,
            [Description("LMST")]
            LMST = 15,
            [Description("MDMT")]
            MDMT = 16,
        }

        public enum OutputStatus
        {
            Keep = 0,
            Suppress = 1,
        }
        public enum OutputType
        {
            DFS = 0,
            DF = 1,
            DS = 2,
            FS = 3,
            D = 4,
            F = 5,
            S = 6,
        }
        public enum CombinationMethod
        {
            Algebraic = 0,
            Scalar = 1,
            SRSS = 2,
            Abs = 3,
            Max = 4,
            Min = 5,
            SignMax = 6,
            SignMin = 7,
        }

        public enum HangerStiffness
        {
            Rigid = 0,
            Ignore = 1,
            AsDesigned = 2,
        }

        public enum LimitStateLoadType
        {
            None = 0,
            Empty = 1,
            WaterFilled = 2,
            TestHydro = 3,
            Operation = 4,
            Environment = 5,
        }
    }
}
