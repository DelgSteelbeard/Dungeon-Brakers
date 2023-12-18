using Godot;
using System;

namespace GridManagement
{
    public partial class StaticObject 
    {
        public string Type { get; set; }
        public bool CanPassThrough { get; set; }

        public StaticObject(string type, bool canPassThrough) 
        {
            this.Type = type;
            this.CanPassThrough = canPassThrough;
        }
    }
}
