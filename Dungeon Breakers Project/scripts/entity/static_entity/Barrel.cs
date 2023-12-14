using Godot;
using System;
using x;

public partial class Barrel : Node2D
{
	[Export]
	public Openable open;

	public override void _Ready()
	{
		open.name = "barrel open";
	}
}
