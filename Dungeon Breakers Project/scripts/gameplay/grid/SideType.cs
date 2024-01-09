using Godot;
using System;

namespace game
{
    public partial class SideType 
    {
        public string Type { get; set; }
        public int ID { get; set; }

        public SideType(int id, string type) 
        {
            this.ID = id;
            this.Type = type;
        }
    }
}
