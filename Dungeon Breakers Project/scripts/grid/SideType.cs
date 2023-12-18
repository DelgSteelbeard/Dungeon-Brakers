using Godot;
using System;

namespace GridManagement
{
    public partial class SideType 
    {
        public string Type { get; set; }

        public SideType(string type) 
        {
            this.Type = type;
        }
    }
}
