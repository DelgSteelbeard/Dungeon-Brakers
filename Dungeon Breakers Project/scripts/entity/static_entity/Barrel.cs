using Godot;
using System;
using game;

public partial class Barrel : Node2D
{
	[Export]
	public Openable open;

	public override void _Ready()
	{
		open.name = "barrel open";
	}
}
