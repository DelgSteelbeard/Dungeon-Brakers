using Godot;
using System;
using System.Collections.Generic;

namespace game
{
    public partial class SideTypeList 
    {
        public List<SideType> SideTypes { get; set; }

        public SideTypeList() 
        {
            SideTypes = new List<SideType> 
            {
                new SideType(1, "None"),
                new SideType(2, "Wall"),
                new SideType(3, "Door"),
                new SideType(4, "LockedDoor"),
                new SideType(5, "SecretDoor")
            };
        }
    }
}