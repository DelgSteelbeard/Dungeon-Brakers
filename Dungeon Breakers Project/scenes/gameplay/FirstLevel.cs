using Godot;
using System;
using System.Collections.Generic;
using System.IO;
using TileManagement;

public class FirstLevel : Node2D
{
    private TileMap levelBackground;
    private Dictionary<Vector2, TileInfo> tileInfoDictionary;
    private int nextTileId = 1;

    public override void _Ready()
    {
        levelBackground = GetNode<TileMap>("level_background");

        // Check if the tile_info.json file exists before initializing the tile information
        string filePath = GetTileInfoFilePath();
        if (File.Exists(filePath))
        {
            // Initialize the tile information grid from the existing file
            InitializeGrid();
        }
        else
        {
            // Generate the level and save tile information to a JSON file
            GenerateFirstLevel();
            SaveTileInfoToFile("tile_info.json");
        }
    }

    private void InitializeGrid()
    {
        tileInfoDictionary = LoadTilesFromFile("tile_info.json");
    }

    private string GetTileInfoFilePath()
    {
        string globalFolderPath = ProjectSettings.GlobalizePath("res://");
        return Path.Combine(globalFolderPath, "tile_info.json");
    }

    private void GenerateFirstLevel()
    {
        // Row number 0
        SetSameMultipleTiles(new Vector2(0, 0), 64, CreateDefaultTilePattern());

        // Row number 1
        SetSameMultipleTiles(new Vector2(0, 1), 4, CreateDefaultTilePattern());
        SetTileInfo(new Vector2(4, 1), CreateUniqueTilePattern(TileInfo.SideType.Wall, TileInfo.SideType.Nothing, TileInfo.SideType.Wall, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Nothing, true));
        SetSameMultipleTiles(new Vector2(5, 1), 10, CreateUniqueTilePattern(TileInfo.SideType.Wall, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Nothing, true));
        SetTileInfo(new Vector2(15, 1), CreateUniqueTilePattern(TileInfo.SideType.Wall, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Wall, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Nothing, true));
        SetSameMultipleTiles(new Vector2(16, 1), 2, CreateDefaultTilePattern());
        SetTileInfo(new Vector2(18, 1), CreateUniqueTilePattern(TileInfo.SideType.Wall, TileInfo.SideType.Nothing, TileInfo.SideType.Wall, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Bookshelf, false));
        SetSameMultipleTiles(new Vector2(19, 1), 8, CreateUniqueTilePattern(TileInfo.SideType.Wall, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Bookshelf, false));
        SetTileInfo(new Vector2(27, 1), CreateUniqueTilePattern(TileInfo.SideType.Wall, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Nothing, true));
        SetTileInfo(new Vector2(28, 1), CreateUniqueTilePattern(TileInfo.SideType.Wall, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Table, false));
        SetTileInfo(new Vector2(29, 1), CreateUniqueTilePattern(TileInfo.SideType.Wall, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.TableWithBook, false));
        SetSameMultipleTiles(new Vector2(30, 1), 10, CreateUniqueTilePattern(TileInfo.SideType.Wall, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Nothing, true));
        SetSameMultipleTiles(new Vector2(40, 1), 2, CreateUniqueTilePattern(TileInfo.SideType.Wall, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Bookshelf, false));
        SetTileInfo(new Vector2(42, 1), CreateUniqueTilePattern(TileInfo.SideType.Wall, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Wall, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Bookshelf, false));
        SetSameMultipleTiles(new Vector2(43, 1), 21, CreateDefaultTilePattern());

        // Row number 2
        SetSameMultipleTiles(new Vector2(0, 2), 4, CreateDefaultTilePattern());
        SetTileInfo(new Vector2(4, 2), CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Wall, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Nothing, true));
        SetSameMultipleTiles(new Vector2(5, 2), 3, CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Stone, true));
        SetSameMultipleTiles(new Vector2(8, 2), 2, CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.FloorType.DirtPile, TileInfo.ItemType.Nothing, true));
        SetSameMultipleTiles(new Vector2(10, 2), 2, CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Nothing, true));
        SetSameMultipleTiles(new Vector2(12, 2), 2, CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Stone, false));
        SetTileInfo(new Vector2(14, 2), CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Bones, true));
        SetTileInfo(new Vector2(15, 2), CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Wall, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Nothing, true));
        SetSameMultipleTiles(new Vector2(16, 2), 2, CreateDefaultTilePattern());
        SetTileInfo(new Vector2(18, 2), CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Wall, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Bookshelf, false));
        SetSameMultipleTiles(new Vector2(19, 2), 7, CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Nothing, true));
        SetTileInfo(new Vector2(26, 2), CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Bookshelf, false));
        SetSameMultipleTiles(new Vector2(27, 2), 5, CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Nothing, true));
        SetSameMultipleTiles(new Vector2(32, 2), 6, CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Bookshelf, false));
        SetSameMultipleTiles(new Vector2(38, 2), 4, CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Nothing, true));
        SetTileInfo(new Vector2(42, 2), CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Wall, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Bookshelf, false));
        SetSameMultipleTiles(new Vector2(43, 2), 21, CreateDefaultTilePattern());

        // Row number 3
        SetSameMultipleTiles(new Vector2(0, 3), 4, CreateDefaultTilePattern());
        SetTileInfo(new Vector2(4, 3), CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Wall, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Nothing, true));
        SetTileInfo(new Vector2(5, 3), CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Stone, true));
        SetTileInfo(new Vector2(6, 3), CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Stone, false));
        SetTileInfo(new Vector2(7, 3), CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Stone, true));
        SetSameMultipleTiles(new Vector2(8, 3), 2, CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.FloorType.DirtPile, TileInfo.ItemType.Nothing, true));
        SetSameMultipleTiles(new Vector2(10, 3), 2, CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Nothing, true));
        SetSameMultipleTiles(new Vector2(12, 3), 2, CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Stone, false));
        SetTileInfo(new Vector2(14, 3), CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Bones, true));
        SetTileInfo(new Vector2(15, 3), CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Wall, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Bones, true));
        SetSameMultipleTiles(new Vector2(16, 3), 2, CreateDefaultTilePattern());
        SetTileInfo(new Vector2(18, 3), CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Wall, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Bookshelf, false));
        SetTileInfo(new Vector2(19, 3), CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Nothing, true));
        SetTileInfo(new Vector2(20, 3), CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.TableWithBook, false));
        SetSameMultipleTiles(new Vector2(21, 3), 2, CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Nothing, true));
        SetTileInfo(new Vector2(23, 3), CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.TableWithBook, false));
        SetSameMultipleTiles(new Vector2(24, 3), 2, CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Nothing, true));
        SetTileInfo(new Vector2(26, 3), CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Bookshelf, false));
        SetSameMultipleTiles(new Vector2(27, 3), 7, CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Nothing, true));
        SetSameMultipleTiles(new Vector2(34, 3), 2, CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Bookshelf, false));
        SetSameMultipleTiles(new Vector2(36, 3), 6, CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Nothing, true));
        SetTileInfo(new Vector2(42, 3), CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Wall, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Bookshelf, false));
        SetSameMultipleTiles(new Vector2(43, 3), 21, CreateDefaultTilePattern());

        // Row number 4
        SetSameMultipleTiles(new Vector2(0, 4), 4, CreateDefaultTilePattern());
        SetTileInfo(new Vector2(4, 4), CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Wall, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.BrokenWoodenTable, false));
        SetSameMultipleTiles(new Vector2(5, 4), 3, CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Stone, true));
        SetSameMultipleTiles(new Vector2(8, 4), 3, CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Nothing, true));
        SetTileInfo(new Vector2(11, 4), CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.BrokenWoodenChair, false));
        SetSameMultipleTiles(new Vector2(12, 4), 2, CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Nothing, true));
        SetTileInfo(new Vector2(14, 4), CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Bones, true));
        SetTileInfo(new Vector2(15, 4), CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Wall, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Bones, true));
        SetSameMultipleTiles(new Vector2(16, 4), 2, CreateDefaultTilePattern());
        SetTileInfo(new Vector2(18, 4), CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Wall, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Bookshelf, false));
        SetTileInfo(new Vector2(19, 4), CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Nothing, true));
        SetTileInfo(new Vector2(20, 4), CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.TableWithBook, false));
        SetSameMultipleTiles(new Vector2(21, 4), 2, CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Nothing, true));
        SetTileInfo(new Vector2(23, 4), CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.TableWithBook, false));
        SetSameMultipleTiles(new Vector2(24, 4), 10, CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Nothing, true));
        SetSameMultipleTiles(new Vector2(34, 4), 2, CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Bookshelf, false));
        SetSameMultipleTiles(new Vector2(36, 4), 6, CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Nothing, true));
        SetTileInfo(new Vector2(42, 4), CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Wall, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Nothing, true));
        SetSameMultipleTiles(new Vector2(43, 4), 3, CreateDefaultTilePattern());
        SetTileInfo(new Vector2(46, 4), CreateUniqueTilePattern(TileInfo.SideType.Wall, TileInfo.SideType.Nothing, TileInfo.SideType.Wall, TileInfo.SideType.Nothing, TileInfo.FloorType.Concrete, TileInfo.ItemType.Nothing, true));
        SetTileInfo(new Vector2(47, 4), CreateUniqueTilePattern(TileInfo.SideType.Wall, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Wall, TileInfo.FloorType.Concrete, TileInfo.ItemType.Nothing, true));
        SetTileInfo(new Vector2(48, 4), CreateUniqueTilePattern(TileInfo.SideType.Wall, TileInfo.SideType.Nothing, TileInfo.SideType.Wall, TileInfo.SideType.Nothing, TileInfo.FloorType.RunningBricks, TileInfo.ItemType.Nothing, true));
        SetSameMultipleTiles(new Vector2(49, 4), 3, CreateUniqueTilePattern(TileInfo.SideType.Wall, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.FloorType.RunningBricks, TileInfo.ItemType.Nothing, true));
        SetSameMultipleTiles(new Vector2(52, 4), 5, CreateUniqueTilePattern(TileInfo.SideType.Wall, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.FloorType.Slime, TileInfo.ItemType.Nothing, true));
        SetSameMultipleTiles(new Vector2(57, 4), 2, CreateUniqueTilePattern(TileInfo.SideType.Wall, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.FloorType.RunningBricks, TileInfo.ItemType.Nothing, true));
        SetTileInfo(new Vector2(59, 4), CreateUniqueTilePattern(TileInfo.SideType.Wall, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Wall, TileInfo.FloorType.RunningBricks, TileInfo.ItemType.Nothing, true));
        SetSameMultipleTiles(new Vector2(60, 4), 4, CreateDefaultTilePattern());

        // Row number 5
        SetSameMultipleTiles(new Vector2(0, 5), 4, CreateDefaultTilePattern());
        SetTileInfo(new Vector2(4, 5), CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Wall, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.BrokenWoodenTable, false));
        SetSameMultipleTiles(new Vector2(5, 5), 3, CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Nothing, true));
        SetSameMultipleTiles(new Vector2(8, 5), 2, CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.FloorType.SumCircle, TileInfo.ItemType.Nothing, true));
        SetSameMultipleTiles(new Vector2(10, 5), 5, CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Nothing, true));
        SetTileInfo(new Vector2(15, 5), CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Wall, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Nothing, true));
        SetTileInfo(new Vector2(16, 5), CreateUniqueTilePattern(TileInfo.SideType.Wall, TileInfo.SideType.Nothing, TileInfo.SideType.Wall, TileInfo.SideType.Nothing, TileInfo.FloorType.Concrete, TileInfo.ItemType.Nothing, true));
        SetTileInfo(new Vector2(17, 5), CreateUniqueTilePattern(TileInfo.SideType.Wall, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Wall, TileInfo.FloorType.Concrete, TileInfo.ItemType.Nothing, true));
        SetTileInfo(new Vector2(18, 5), CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Wall, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Bookshelf, false));
        SetSameMultipleTiles(new Vector2(19, 5), 9, CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Nothing, true));
        SetSameMultipleTiles(new Vector2(28, 5), 2, CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Bookshelf, false));
        SetSameMultipleTiles(new Vector2(30, 5), 4, CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Nothing, true));
        SetSameMultipleTiles(new Vector2(34, 5), 2, CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Bookshelf, false));
        SetSameMultipleTiles(new Vector2(36, 5), 6, CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Nothing, true));
        SetTileInfo(new Vector2(42, 5), CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Wall, TileInfo.FloorType.WoodenPlanks, TileInfo.ItemType.Bookshelf, false));
        SetSameMultipleTiles(new Vector2(43, 5), 3, CreateDefaultTilePattern());
        SetTileInfo(new Vector2(46, 5), CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Wall, TileInfo.SideType.Nothing, TileInfo.FloorType.Concrete, TileInfo.ItemType.Nothing, true));
        SetTileInfo(new Vector2(47, 5), CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Wall, TileInfo.FloorType.Concrete, TileInfo.ItemType.Nothing, true));
        SetTileInfo(new Vector2(48, 5), CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Wall, TileInfo.SideType.Nothing, TileInfo.FloorType.RunningBricks, TileInfo.ItemType.Nothing, true));
        SetSameMultipleTiles(new Vector2(49, 5), 3, CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.FloorType.RunningBricks, TileInfo.ItemType.Nothing, true));
        SetSameMultipleTiles(new Vector2(52, 5), 7, CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.FloorType.Slime, TileInfo.ItemType.Nothing, true));
        SetTileInfo(new Vector2(59, 5), CreateUniqueTilePattern(TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Nothing, TileInfo.SideType.Wall, TileInfo.FloorType.RunningBricks, TileInfo.ItemType.Nothing, true));
        SetSameMultipleTiles(new Vector2(60, 5), 4, CreateDefaultTilePattern());

        // Row number 6

        // Row number 7

        // Row number 8

        // Row number 9

    }

    private void SetSameMultipleTiles(Vector2 startTilePosition, int count, TileInfo tileInfo)
    {
        for (int i = 0; i < count; i++)
        {
            SetTileInfo(startTilePosition + new Vector2(i, 0), tileInfo);
        }
    }

    private TileInfo CreateUniqueTilePattern(TileInfo.SideType top, TileInfo.SideType bottom, TileInfo.SideType left, TileInfo.SideType right, TileInfo.FloorType floor, TileInfo.ItemType item, bool isWalkable)
    {
        return new TileInfo
        {
            Top = top,
            Bottom = bottom,
            Left = left,
            Right = right,
            Floor = floor,
            Item = item,
            IsWalkable = isWalkable
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

    private Dictionary<Vector2, TileInfo> LoadTilesFromFile(string filename)
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

    // Access a chosen tile by its X and Y position
    // int targetTileX = 3;
    // int targetTileY = 4;
    // AccessTileByPosition(targetTileX, targetTileY);

    private TileInfo CreateDefaultTilePattern()
    {
        return new TileInfo
        {
            Top = TileInfo.SideType.Nothing,
            Bottom = TileInfo.SideType.Nothing,
            Left = TileInfo.SideType.Nothing,
            Right = TileInfo.SideType.Nothing,
            Floor = TileInfo.FloorType.Nothing,
            Item = TileInfo.ItemType.Nothing,
            IsWalkable = false
        };
    }
    public override void _Process(double delta)
	{
	}
}