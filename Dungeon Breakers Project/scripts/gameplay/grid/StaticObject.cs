using Godot;
using System;

namespace game
{
    public partial class StaticObject 
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public bool CanPassThrough { get; set; }

        public StaticObject(int id, string type, bool canPassThrough) 
        {
            this.ID = id;
            this.Type = type;
            this.CanPassThrough = canPassThrough;
        }
    }
}
