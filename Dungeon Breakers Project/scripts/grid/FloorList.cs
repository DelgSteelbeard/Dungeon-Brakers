using Godot;
using System;

namespace GridManagement
{
    public partial class FloorList 
    {
        public List<Floor> Floors { get; set; }

        public FloorList() 
        {
            Floors = new List<Floor> 
            {
                new Floor("WoodenPlanks", 0),
                new Floor("Herringbone", 0),
                new Floor("Concrete", 0),
                new Floor("Cobble", 0),
                new Floor("RunningBricks", 0),
                new Floor("Slime", 5),
                new Floor("RomanTiles", 0),
                new Floor("WoodInterlaced", 0),
                new Floor("DiamondPlate", 0),
                new Floor("Acid", 10),
                new Floor("Carpet", 0),
                new Floor("HighlitedArea", 0)
            };
        }
    }
}

