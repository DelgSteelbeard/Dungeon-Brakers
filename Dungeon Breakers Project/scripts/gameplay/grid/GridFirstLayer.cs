using Godot;
using System;
using System.Collections.Generic;
using game;

public partial class GridFristLayer
{
    Grid gridInstance = Grid.Instance;

    public GridFristLayer()
    {
        //0 - podłoga, 1 - ściana dół, 2 - ściana lewo, 3 - ściana góra, 4 - ściana prawo, 5 - obiekt na gridzie
        // Initialize the grid
        MakeRoomWalls(12, 9, 3, 0); //room 1
        gridInstance.grid[16, 6, 2] = 0; //exit from room 1
        MakeRoomWalls(2, 5, 15, 4); //hallway first part
        gridInstance.grid[15, 6, 4] = 0; //door to room 1
        gridInstance.grid[16, 10, 3] = 0; //way to second part of hallway
        gridInstance.grid[17, 10, 3] = 0;
        MakeRoomWalls(27, 2, 5, 9); //hallway second part
        gridInstance.grid[27, 9, 1] = 0; //door to room 2
        gridInstance.grid[16, 9, 1] = 0; //way to first part of hallway 
        gridInstance.grid[17, 9, 1] = 0;
        gridInstance.grid[12, 12, 3] = 0; //way to third part of hallway
        gridInstance.grid[13, 12, 3] = 0;
        gridInstance.grid[30, 12, 3] = 0; // door to room 20
        gridInstance.grid[31, 12, 3] = 0;
        MakeRoomWalls(2, 26, 11, 11); //hallway third part
        gridInstance.grid[12, 11, 1] = 0;//way to second part of hallway
        gridInstance.grid[13, 11, 1] = 0;
        gridInstance.grid[11, 27, 4] = 0; //way to fourth part of hallway
        gridInstance.grid[11, 26, 4] = 0;
        gridInstance.grid[11, 37, 4] = 0;
        gridInstance.grid[14, 37, 2] = 0; //way to fifth part of hallway
        gridInstance.grid[14, 36, 2] = 0;
        MakeRoomWalls(8, 2, 3, 25); //hallway fourth part
        gridInstance.grid[8, 25, 1] = 0; //door to room 18
        gridInstance.grid[12, 26, 2] = 0;
        gridInstance.grid[12, 27, 2] = 0;
        MakeRoomWalls(8, 12, 3, 13); //room 18
        gridInstance.grid[8, 26, 3] = 0; //exit from room 18
        MakeRoomWalls(8, 10, 3, 27); //room 17
        gridInstance.grid[12, 37, 2] = 0; //exit from room 17
        MakeRoomWalls(12, 10, 25, 11); //room 20 
        gridInstance.grid[30, 11, 1] = 0; //door up
        gridInstance.grid[31, 11, 1] = 0;
        gridInstance.grid[31, 22, 3] = 0; //door down
        gridInstance.grid[30, 22, 3] = 0;
        MakeRoomWalls(10, 12, 14, 16); //room 19 
        gridInstance.grid[25, 22, 2] = 0; //exit
        gridInstance.grid[25, 23, 2] = 0; //exit
        MakeRoomWalls(34, 2, 24, 21); //second horizontal hallway  
        gridInstance.grid[24, 23, 4] = 0; //door to room 19
        gridInstance.grid[24, 22, 4] = 0;
        gridInstance.grid[30, 21, 1] = 0; //1 up highway
        gridInstance.grid[31, 21, 1] = 0;
        gridInstance.grid[46, 21, 1] = 0; //2 up highway
        gridInstance.grid[47, 21, 1] = 0;
        gridInstance.grid[56, 21, 1] = 0; //door to room 5
        gridInstance.grid[37, 24, 3] = 0; //1 down
        gridInstance.grid[38, 24, 3] = 0;
        gridInstance.grid[51, 24, 3] = 0; //2 down
        gridInstance.grid[52, 24, 3] = 0;
        MakeRoomWalls(12, 18, 47, 3); // room 5
        gridInstance.grid[56, 22, 3] = 0; //exit 2
        gridInstance.grid[47, 6, 4] = 0; //exit 1
        MakeRoomWalls(6, 6, 38, 10); // room 4
        MakeRoomWalls(3, 1, 42, 5); // room 4
        MakeRoomWalls(1, 4, 43, 6); // hallway between room 4 and library
        gridInstance.grid[42, 6, 4] = 0; // next part hallway
        gridInstance.grid[46, 6, 2] = 0; // next part hallway
        gridInstance.grid[44, 7, 3] = 0; // next part hallway
        gridInstance.grid[44, 6, 1] = 0; // next part hallway
        gridInstance.grid[44, 10, 1] = 0; // next part hallway
        gridInstance.grid[44, 11, 3] = 0; // next part hallway
        MakeRoomWalls(11, 12, 25, 23); // room 21
        gridInstance.grid[37, 27, 2] = 0; // exit 1
        MakeRoomWalls(12, 10, 38, 23); // room 7
        gridInstance.grid[51, 31, 2] = 0; // exit 3
        gridInstance.grid[45, 34, 3] = 0; // exit 3
        gridInstance.grid[39, 34, 3] = 0; // next part of the room
        gridInstance.grid[30, 34, 3] = 0; // 
        gridInstance.grid[38, 34, 4] = 1; // next part collision of the room
        gridInstance.grid[39, 35, 3] = 1; // 
        gridInstance.grid[41, 34, 2] = 1; // 
        MakeRoomWalls(2, 12, 36, 23); // hallway between 21 ang 7
        gridInstance.grid[37, 23, 1] = 0; // 
        gridInstance.grid[38, 23, 1] = 0; // 
        gridInstance.grid[38, 36, 3] = 0; // 
        gridInstance.grid[37, 36, 3] = 0; // 
        gridInstance.grid[39, 35, 2] = 0; // 
        MakeRoomWalls(9, 3, 40, 33); // room 8
        gridInstance.grid[45, 33, 1] = 0; //exit 1 

        
    }

    public void MakeRoomWalls(int width, int height, int startX, int startY)
    {
        GD.Print("MakeRoomWalls");
        // Make the walls
        for (int i = 1; i < width + 1; i++)
        {
            gridInstance.grid[startX + i, startY, 1] = 1; //up
            gridInstance.grid[startX + i, startY + height + 1, 3] = 1; //down
        }
        for (int i = 1; i < height + 1; i++)
        {
            gridInstance.grid[startX, startY + i, 4] = 1; //left
            gridInstance.grid[startX + width + 1, startY + i, 2] = 1; //right 
        }
    }
}