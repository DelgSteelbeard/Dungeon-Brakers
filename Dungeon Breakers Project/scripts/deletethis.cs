using Godot;
using System;

public partial class deletethis : Node2D
{
	Chest chest;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		GD.Print("xxx");
		chest = GetNode<Chest>("chest1");
        
        GD.Print(chest.name);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
