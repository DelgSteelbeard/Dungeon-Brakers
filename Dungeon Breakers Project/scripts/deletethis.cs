using Godot;
using System;
using System.Collections.Generic;
using game;
//class like a grid class for testing
public partial class deletethis : Node2D
{
	Chest chest;
	Barrel barrel;
	IOpen interafcee;
	StaticEntityList staticEntityList;
	public override void _Ready()
	{
		//tests for the openable interface
		chest = GetNode<Chest>("chest1");
		barrel = GetNode<Barrel>("barrel");
        interafcee = chest.open;
		interafcee.Open();
		interafcee = barrel.open;
		interafcee.Open();

		//tests for the static entity list
		int[,,] grid = new int[65, 65, 7];
		staticEntityList = StaticEntityList.Instance;
		List<SingleEntity> entities = staticEntityList.Entities;
		for(int i = 0; i < entities.Count; i++)
		{
			int x = entities[i].x;
			int y = entities[i].y;
			grid[x, y, 6] = i;
		}
		//test for getting the parameter from the grid
		string name = entities[grid[1, 2, 6]].name;
		GD.Print(name);
	}
}
