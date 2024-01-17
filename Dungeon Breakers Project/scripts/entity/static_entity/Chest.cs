using Godot;
using Microsoft.VisualBasic;
using System;
using game;

public partial class Chest : Node2D
{
	private StaticEntityList staticEntityList = StaticEntityList.Instance;
	private int entityID = 1;
	public string name = "chest";
	private int _x;
	private int _y;
	public bool intreactable = true;
	public bool collision = true;
	[Export]
	public Openable open;
	
	[Export]
	public int x
	{
		get => _x;
		set
		{
			_x = value;
			checkReady();
		}
	}
	[Export]
	public int y
	{
		get => _y;
		set
		{
			_y = value;
			checkReady();
		}
	}

	public override void _Ready()
	{
		open.name = "chest open";
	}

	private void checkReady()
	{
		if (_x != 0 && _y != 0)
		{
			SingleEntity chest = new SingleEntity(name, entityID, _x, _y, intreactable, collision);
			staticEntityList.Entities.Add(chest);
			//staticEntityList.ReadAllEntities();
			GlobalPosition = new Vector2((_x * 100) + 50, (_y * 100) + 50);
			GD.Print($"Chest:  is ready");
		}
	}
	
	// public void openChest()
	// {
	// 	open.name = "chest";
	// }
	
	
}


