using Godot;
using System;

namespace game
{
    public partial class SingleEntity
    {
        public string name { get; set; }
        public int entityID { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public bool interactable { get; set; } = false;
        public bool collision { get; set; } = false;

        public SingleEntity(string name, int entityID, int x, int y, bool interactable, bool collision)
        {
            this.name = name;
            this.entityID = entityID;
            this.x = x;
            this.y = y;
            this.interactable = interactable;
            this.collision = collision;
        }
    }
}

