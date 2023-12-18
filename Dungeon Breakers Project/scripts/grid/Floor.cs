using Godot;
using System;

namespace GridManagement
{
    public partial class Floor
    {
        public string Name { get; set; }
        public int DamageGiven { get; set; }

        public Floor(string name, int damageGiven) 
        {
            this.Name = name;
            this.DamageGiven = damageGiven;
        }
    }
}
