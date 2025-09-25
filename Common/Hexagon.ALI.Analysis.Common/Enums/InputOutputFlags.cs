using System;

namespace Hexagon.ALI.Analysis.Common.Enums
{
    [Flags]
    public enum InputOutputFlags
    {
        Input = 1,
        Statics = 2,
        Dynamics = 4
    }
}
