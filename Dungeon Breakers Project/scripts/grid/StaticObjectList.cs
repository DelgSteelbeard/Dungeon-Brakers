using Godot;
using System;

namespace GridManagement
{
    public partial class StaticObjectList 
    {
        public List<StaticObject> StaticObjects { get; set; }

        public StaticObjectList() 
        {
            StaticObjects = new List<StaticObject> 
            {
                new StaticObject("None", true),
                new StaticObject("Stones", true),
                new StaticObject("BigStones", false),
                new StaticObject("Bones", true),
                new StaticObject("BigBones", false),
                new StaticObject("BrokenTable", false),
                new StaticObject("SumCircle", true),
                new StaticObject("DirtPile", false),
                new StaticObject("Chair", false),
                new StaticObject("BrokenChair", false),
                new StaticObject("BrokenDoor", false),
                new StaticObject("Bookshelf", false),
                new StaticObject("Table", false),
                new StaticObject("TableWithBook", false),
                new StaticObject("TableWithNotes", false),
                new StaticObject("TableWithMap", false),
                new StaticObject("TableWithLetter", false),
                new StaticObject("TableWithFood", false),
                new StaticObject("TableWithBow", false),
                new StaticObject("TableWithArrows", false),
                new StaticObject("TableWithCards", false),
                new StaticObject("TableWithChess", false),
                new StaticObject("Armchair", false),
                new StaticObject("Pillar", false),
                new StaticObject("BrokenPillar", false),
                new StaticObject("Bench", false),
                new StaticObject("Altar", false),
                new StaticObject("Skeleton", true),
                new StaticObject("GemPile", true),
                new StaticObject("GoldPile", true),
                new StaticObject("AshPile", true),
                new StaticObject("OpenedChest", false),
                new StaticObject("StoneStatue", false),
                new StaticObject("Spiderweb", true),
                new StaticObject("Cocoon", false),
                new StaticObject("BrokenPottery", false),
                new StaticObject("BrokenBridge", false),
                new StaticObject("BloodStain", true),
                new StaticObject("BloodTrail", true),
                new StaticObject("CaveHole", false),
                new StaticObject("DeadSpider", true),
                new StaticObject("Bed", false),
                new StaticObject("BrokenBed", false),
                new StaticObject("GiantBarrel", false),
                new StaticObject("WineStain", true),
                new StaticObject("LogPile", false),
                new StaticObject("Sandbags", false),
                new StaticObject("Stove", false),
                new StaticObject("SpitRoast", false),
                new StaticObject("Arrows", true),
                new StaticObject("Target", false),
                new StaticObject("BowlWithArrows", false),
                new StaticObject("WeaponShelf", false),
                new StaticObject("Sofa", false),
                new StaticObject("Workbench", false),
                new StaticObject("GridingWheel", false),
                new StaticObject("SlackTub", false),
                new StaticObject("Anvil", false),
                new StaticObject("Forge", false),
                new StaticObject("MinecartWithCoal", false),
                new StaticObject("CoalBags", false),
                new StaticObject("IronBars", false),
                new StaticObject("ChestWithIronBars", false),
                new StaticObject("Grate", true),
                new StaticObject("AtlasGlobe", false),
                new StaticObject("BoarRug", true),
                new StaticObject("Wardrobe", false),
                new StaticObject("Fireplace", false),
                new StaticObject("Stairs", true)
            };
        }
    }
}
