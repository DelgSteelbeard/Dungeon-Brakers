using Godot;
using System;

public partial class first_level : Node2D
{
	public TileMap levelBackground;
    public Node2D tileDataHolder;
    public PackedScene tileDataScene;

    public override void _Ready()
    {
        GenerateTiles();
    }

	public override void _Process(double delta)
	{
	}
    private void GenerateTiles()
    {
        for (int x = 0; x < levelBackground.GetUsedRect().Size.x; x++)
        {
            for (int y = 0; y < levelBackground.GetUsedRect().Size.y; y++)
            {
                TileMap tileMap = (TileMap)GetNode("level_background");
                TileData tileData = (TileData)tileDataScene.Instance();

                int tileId = tileMap.GetCell(x, y);

                // Przykladowa logika przypisania roznych wlasciwosci
                switch (tileId)
                {
                    case 1:
                        tileData.SetTileInfo(TileData.TerrainType.Grass, TileData.ObjectType.Crate, TileData.WallDirection.Left | TileData.WallDirection.Top);
                        break;

                    case 2:
                        tileData.SetTileInfo(TileData.TerrainType.Stone, TileData.ObjectType.Door, TileData.WallDirection.Bottom | TileData.WallDirection.Right);
                        break;

                    default:
                        tileData.SetTileInfo(TileData.TerrainType.Dirt, TileData.ObjectType.None, TileData.WallDirection.None);
                        break;
                }

                tileData.Position = new Vector2(x * 32, y * 32);

                tileDataHolder.AddChild(tileData);
            }
        }
    }
}
