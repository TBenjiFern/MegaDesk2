﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk2
{

    public enum DesktopMaterial
    {
        Laminate,
        Oak,
        Rosewood,
        Veneer,
        Pine
    }

    public class Desk
    {

        public const short MIN_WIDTH = 24;
        public const short MAX_WIDTH = 96;
        public const short MIN_DEPTH = 12;
        public const short MAX_DEPTH = 48;
        public const short MIN_DRAWERS = 0;
        public const short MAX_DRAWERS = 7;

        public int Width { get; set; }

        public int Depth { get; set; }

        public int NumDrawers { get; set; }

        public DesktopMaterial  DesktopMaterial { get; set; }

    }
}
