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
        int[] bottom01 = {1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1};

        for(int i = 0; i < 65; i++)
        {
            gridInstance.grid[4, 0, i] = bottom01[i];
        }

        
    }
}