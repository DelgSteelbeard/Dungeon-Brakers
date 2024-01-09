using Godot;
using System;
using System.Collections.Generic;

namespace game
{
    public partial class StaticObjectList 
    {
        public List<StaticObject> StaticObjects { get; set; }

        public StaticObjectList() 
        {
            StaticObjects = new List<StaticObject> 
            {
                new StaticObject(1, "None", true),
                new StaticObject(2, "Stones", true),
                new StaticObject(3, "BigStones", false),
                new StaticObject(4, "Bones", true),
                new StaticObject(5, "BigBones", false),
                new StaticObject(6, "BrokenTable", false),
                new StaticObject(7, "SumCircle", true),
                new StaticObject(8, "DirtPile", false),
                new StaticObject(9, "Chair", false),
                new StaticObject(10, "BrokenChair", false),
                new StaticObject(11, "BrokenDoor", false),
                new StaticObject(12, "Bookshelf", false),
                new StaticObject(13, "Table", false),
                new StaticObject(14, "TableWithBook", false),
                new StaticObject(15, "TableWithNotes", false),
                new StaticObject(16, "TableWithMap", false),
                new StaticObject(17, "TableWithLetter", false),
                new StaticObject(18, "TableWithFood", false),
                new StaticObject(19, "TableWithBow", false),
                new StaticObject(20, "TableWithArrows", false),
                new StaticObject(21, "TableWithCards", false),
                new StaticObject(22, "TableWithChess", false),
                new StaticObject(23, "Armchair", false),
                new StaticObject(24, "Pillar", false),
                new StaticObject(25, "BrokenPillar", false),
                new StaticObject(26, "Bench", false),
                new StaticObject(27, "Altar", false),
                new StaticObject(28, "Skeleton", true),
                new StaticObject(29, "GemPile", true),
                new StaticObject(30, "GoldPile", true),
                new StaticObject(31, "AshPile", true),
                new StaticObject(32, "OpenedChest", false),
                new StaticObject(33, "StoneStatue", false),
                new StaticObject(34, "Spiderweb", true),
                new StaticObject(35, "Cocoon", false),
                new StaticObject(36, "BrokenPottery", false),
                new StaticObject(37, "BrokenBridge", false),
                new StaticObject(38, "BloodStain", true),
                new StaticObject(39, "BloodTrail", true),
                new StaticObject(40, "CaveHole", false),
                new StaticObject(41, "DeadSpider", true),
                new StaticObject(42, "Bed", false),
                new StaticObject(43, "BrokenBed", false),
                new StaticObject(44, "GiantBarrel", false),
                new StaticObject(45, "WineStain", true),
                new StaticObject(46, "LogPile", false),
                new StaticObject(47, "Sandbags", false),
                new StaticObject(48, "Stove", false),
                new StaticObject(49, "SpitRoast", false),
                new StaticObject(50, "Arrows", true),
                new StaticObject(51, "Target", false),
                new StaticObject(52, "BowlWithArrows", false),
                new StaticObject(53, "WeaponShelf", false),
                new StaticObject(54, "Sofa", false),
                new StaticObject(55, "Workbench", false),
                new StaticObject(56, "GridingWheel", false),
                new StaticObject(57, "SlackTub", false),
                new StaticObject(58, "Anvil", false),
                new StaticObject(59, "Forge", false),
                new StaticObject(60, "MinecartWithCoal", false),
                new StaticObject(61, "CoalBags", false),
                new StaticObject(62, "IronBars", false),
                new StaticObject(63, "ChestWithIronBars", false),
                new StaticObject(64, "Grate", true),
                new StaticObject(65, "AtlasGlobe", false),
                new StaticObject(66, "BoarRug", true),
                new StaticObject(67, "Wardrobe", false),
                new StaticObject(68, "Fireplace", false),
                new StaticObject(69, "Stairs", true),
                new StaticObject(70, "Wall", false)
            };
        }
    }
}
