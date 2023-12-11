using Godot;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace TileManagement
{
	public class TileInfo
	{
		public enum SideType
		{
			Nothing,
			Wall,
			Door,
			SecretDoor
		}

		public enum FloorType
		{
			Nothing,
			WoodenPlanks,
			DirtPile,
			SumCircle,
			RunningBricks,
			Concrete,
			Cobble,
			Slime
		}

		public enum ItemType
		{
			Nothing,
			Bookshelf,
			Table,
			TableWithBook,
			TableWithNotes,
			Stone,
			Bones,
			BrokenWoodenChair,
			BrokenWoodenTable,
			BrokenWoodenDoor,
			Armchair
		}

		public int TileId { get; set; }  // Unique identifier for each tile
		public SideType Top { get; set; }
		public SideType Bottom { get; set; }
		public SideType Left { get; set; }
		public SideType Right { get; set; }
		public FloorType Floor { get; set; }
		public ItemType Item { get; set; }
		public bool IsWalkable { get; set; }


        public static string DictionaryToJson(Dictionary<Vector2, TileInfo> dictionary)
        {
            // Convert the dictionary to a list of KeyValuePair for serialization
            List<KeyValuePair<Vector2, TileInfo>> list = new List<KeyValuePair<Vector2, TileInfo>>(dictionary);

            // Use System.Text.Json to serialize the list to JSON
            string json = JsonSerializer.Serialize(list, new JsonSerializerOptions { WriteIndented = true });

            return json;
        }

        public static Dictionary<Vector2, TileInfo> DictionaryFromJson(string json)
        {
            // Deserialize the JSON string to a list of KeyValuePair
            List<KeyValuePair<Vector2, TileInfo>> list = JsonSerializer.Deserialize<List<KeyValuePair<Vector2, TileInfo>>>(json);

            // Convert the list back to a dictionary
            Dictionary<Vector2, TileInfo> dictionary = new Dictionary<Vector2, TileInfo>(list);

            return dictionary;
        }
    }
}