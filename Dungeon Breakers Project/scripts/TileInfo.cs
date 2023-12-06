using Godot;
using System;
using System.IO;

namespace TileManagement
{
	public class TileInfo
	{
		public enum SideType
		{
			Wall,
			Door,
			SecretDoor,
			Nothing
		}

		public enum FloorType
		{
			Wood,
			Stone,
			Bricks
		}

		public enum ItemType
		{
			Sword,
			Dagger,
			Bookshelf
		}

		public int TileId { get; set; }  // Unique identifier for each tile
		public SideType Top { get; set; }
		public SideType Bottom { get; set; }
		public SideType Left { get; set; }
		public SideType Right { get; set; }
		public FloorType Floor { get; set; }
		public ItemType Item { get; set; }
		public bool IsWalkable { get; set; }
	}
}