using Godot;
using System;
using System.Collections.Generic;

namespace game
{
    public partial class FloorList
    {
        public List<Floor> Floors { get; set; }

        public FloorList()
        {
            Floors = new List<Floor>
            {
                new Floor(1, "WoodenPlanks", 0),
                new Floor(2, "Herringbone", 0),
                new Floor(3, "Concrete", 0),
                new Floor(4, "Cobble", 0),
                new Floor(5, "RunningBricks", 0),
                new Floor(6, "Slime", 5),
                new Floor(7, "RomanTiles", 0),
                new Floor(8, "WoodInterlaced", 0),
                new Floor(9, "DiamondPlate", 0),
                new Floor(10, "Acid", 10),
                new Floor(11, "Carpet", 0),
                new Floor(12, "HighlitedArea", 0)
            };
        }
    }
}

