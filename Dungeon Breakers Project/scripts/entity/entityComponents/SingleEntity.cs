using Godot;
using System;

namespace x
{
    public partial class SingleEntity
    {
        public string name { get; set; }
        public int entityID { get; set; }
        public int x { get; set; }
        public int y { get; set; }

        public SingleEntity(string name, int entityID, int x, int y)
        {
            this.name = name;
            this.entityID = entityID;
            this.x = x;
            this.y = y;
        }
    }
}

