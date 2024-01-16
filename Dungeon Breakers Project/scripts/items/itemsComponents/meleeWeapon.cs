using Godot;
using System;

public partial class meleeWeapon : Node2D
{
	[Export]
	public int damage = 1;
	[Export]
	public int range = 1;
	[Export]
	public int cooldown = 1;
	public override void _Ready()
	{

	}
}
