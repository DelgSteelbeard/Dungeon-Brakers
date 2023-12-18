using Godot;
using System;

namespace GridManagement
{
    public partial class SideTypeList 
    {
        public List<SideType> SideTypes { get; set; }

        public SideTypeList() 
        {
            SideTypes = new List<SideType> 
            {
                new SideType("None"),
                new SideType("Wall"),
                new SideType("Door"),
                new SideType("LockedDoor"),
                new SideType("SecretDoor")
            };
        }
    }
}