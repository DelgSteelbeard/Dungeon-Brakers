using Godot;
using System;
using x;
public partial class deletethis : Node2D
{
	Chest chest;
	Barrel barrel;
	IOpen interafcee;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		chest = GetNode<Chest>("chest1");
		barrel = GetNode<Barrel>("barrel");
        interafcee = chest.open;
		interafcee.Open();
		interafcee = barrel.open;
		interafcee.Open();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
