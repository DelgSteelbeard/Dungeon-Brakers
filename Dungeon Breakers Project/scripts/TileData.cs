using Godot;
using System;

public class TileData : Node2D
{
    public enum TerrainType
    {
        Grass,
        Dirt,
        Stone
    }

    public enum ObjectType
    {
        None,
        Crate,
        Player,
        Door
    }

    public enum WallDirection
    {
        None,
        Top,
        Bottom,
        Left,
        Right
    }

    private TerrainType terrain = TerrainType.Grass;
    private ObjectType objectType = ObjectType.None;
    private WallDirection wallDirection = WallDirection.None;

    public void SetTileInfo(TerrainType terrainType, ObjectType objType, WallDirection wallDir)
    {
        terrain = terrainType;
        objectType = objType;
        wallDirection = wallDir;
    }
}

