using Godot;
using System;
using System.Collections.Generic;
using System.IO;
using TileManagement;
public class FirstLevel : Node2D
{
    private TileMap levelBackground;
    private Dictionary<Vector2, TileInfo> tileInfoDictionary;
    private int nextTileId = 1; // Unique identifier for each tile

    public override void _Ready()
    {
        levelBackground = GetNode<TileMap>("level_background");

        // Check if the tile_info.json file exists before initializing the tile information
        string filePath = GetTileInfoFilePath();
        if (File.Exists(filePath))
        {
            // Initialize the tile information grid from the existing file
            InitializeTileInfoGrid();
        }
        else
        {
            // Generate the level and save tile information to a JSON file
            GenerateLevel();
            SaveTileInfoToFile("tile_info.json");
        }

        // Access a chosen tile by its X and Y position (replace with actual coordinates)
        // int targetTileX = 3;
        // int targetTileY = 4;
        // AccessTileByPosition(targetTileX, targetTileY);
    }

    private void InitializeTileInfoGrid()
    {
        tileInfoDictionary = LoadTileInfoFromFile("tile_info.json");
    }

    private string GetTileInfoFilePath()
    {
        // Get the path of the script and combine it with the filename
        string scriptPath = GlobalizePath("res://");
        return Path.Combine(scriptPath, "tile_info.json");
    }

    private void GenerateLevel()
    {
        // For example, set information for the first 8 top tiles
        SetTileInfoPattern(new Vector2(0, 0), 8, CreatePatternTileInfo());

        // Set information for the next 3 tiles with different information
        SetTileInfo(new Vector2(8, 0), CreateUniqueTileInfo(/*...*/, TileInfo.FloorInfo.Stone, TileInfo.ItemInfo.Sword));
        SetTileInfo(new Vector2(9, 0), CreateUniqueTileInfo(/*...*/, TileInfo.FloorInfo.Stone, TileInfo.ItemInfo.Sword));
        SetTileInfo(new Vector2(10, 0), CreateUniqueTileInfo(/*...*/, TileInfo.FloorInfo.Stone, TileInfo.ItemInfo.Sword));

        // Set information for the next 5 tiles with the same properties
        SetTileInfoPattern(new Vector2(11, 0), 5, CreatePatternTileInfo());
    }

    private void SetTileInfoPattern(Vector2 startTilePosition, int count, TileInfo tileInfo)
    {
        for (int i = 0; i < count; i++)
        {
            SetTileInfo(startTilePosition + new Vector2(i, 0), tileInfo);
        }
    }

    private TileInfo CreatePatternTileInfo()
    {
        return new TileInfo
        {
            Top = TileInfo.SideInfo.Wall,
            Bottom = TileInfo.SideInfo.Nothing,
            Left = TileInfo.SideInfo.Nothing,
            Right = TileInfo.SideInfo.Nothing,
            Floor = TileInfo.FloorInfo.Wood,
            Item = TileInfo.ItemInfo.Bookshelf
        };
    }

    private TileInfo CreateUniqueTileInfo(/* Add parameters as needed */)
    {
        return new TileInfo
        {
            Top = TileInfo.SideInfo.Door,
            Bottom = TileInfo.SideInfo.Nothing,
            Left = TileInfo.SideInfo.Wall,
            Right = TileInfo.SideInfo.Nothing,
            Floor = TileInfo.FloorInfo.Stone,
            Item = TileInfo.ItemInfo.Sword
        };
    }

    private void SaveTileInfoToFile(string filename)
    {
        // Convert the tile information dictionary to a serialized JSON string
        string json = TileInfo.DictionaryToJson(tileInfoDictionary);

        // Get the path of the script and combine it with the filename
        string filePath = GetTileInfoFilePath();

        // Write the JSON string to the file
        File.WriteAllText(filePath, json);
    }

    private Dictionary<Vector2, TileInfo> LoadTileInfoFromFile(string filename)
    {
        // Read the entire JSON file
        string json = File.ReadAllText(filename);

        // Convert the JSON string to a dictionary
        return TileInfo.DictionaryFromJson(json);
    }

    private void SetTileInfo(Vector2 tilePosition, TileInfo tileInfo)
    {
        // Assign a unique identifier to each tile
        tileInfo.TileId = nextTileId++;

        // Add the tile information to the dictionary
        tileInfoDictionary[tilePosition] = tileInfo;
    }

    private void AccessTileByPosition(int x, int y)
    {
        // Access the chosen tile by its X and Y position
        Vector2 targetPosition = new Vector2(x, y);
        if (tileInfoDictionary.ContainsKey(targetPosition))
        {
            TileInfo targetTileInfo = tileInfoDictionary[targetPosition];
            GD.Print($"Tile at position ({x}, {y}): Floor - {targetTileInfo.Floor}, Item - {targetTileInfo.Item}");
        }
        else
        {
            GD.Print($"No information available for tile at position ({x}, {y})");
        }
    }

		public override void _Process(double delta)
	{
	}
}