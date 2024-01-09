using Godot;
using System;
using System.Collections.Generic;
using game;

public partial class Grid
{
    public int[,,] grid = new int[65, 65, 7];

    // Singleton instance
    private static Grid instance = null;

    // Private constructor to prevent instance creation
    private Grid() { }

    // Method to get the singleton instance
    public static Grid Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Grid();
            }
            return instance;
        }
    }
}