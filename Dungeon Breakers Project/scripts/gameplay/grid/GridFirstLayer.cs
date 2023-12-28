using Godot;
using System;
using System.Collections.Generic;
using game;

public partial class GridFristLayer
{
    Grid gridInstance = Grid.Instance;

    public GridFristLayer()
    {
        // Initialize the grid
        MakeRoomWalls(12, 9, 3, 0); //room 1
        gridInstance.grid[16, 6, 2] = 0; //exit from room 1
    }

    public void MakeRoomWalls(int width, int height, int startX, int startY)
    {
        GD.Print("MakeRoomWalls");
        // Make the walls
        for (int i = 1; i < width + 1; i++)
        {
            gridInstance.grid[startX + i, startY, 1] = 1; //up
            gridInstance.grid[startX + i, startY + height + 1, 3] = 1; //down
            GD.Print($"field: {startX + i} {startY + height - 1} = {gridInstance.grid[startX + i, startY + height - 1, 3]}");
        }
        for (int i = 1; i < height + 1; i++)
        {
            gridInstance.grid[startX, startY + i, 4] = 1; //left
            gridInstance.grid[startX + width + 1, startY + i, 2] = 1; //right 
        }
    }
}