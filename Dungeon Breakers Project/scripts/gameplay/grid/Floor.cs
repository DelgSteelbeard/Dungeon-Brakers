using Godot;
using System;

namespace game
{
    public partial class Floor
    {
        public string Name { get; set; }
        public int DamageGiven { get; set; }
        public int ID { get; set; }

        public Floor(int id, string name, int damageGiven) 
        {
            this.ID = id;
            this.Name = name;
            this.DamageGiven = damageGiven;
        }
    }
}
