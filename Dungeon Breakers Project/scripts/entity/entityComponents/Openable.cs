using Godot;
using System;
using x;

public partial class Openable : Node2D, IOpen
{
	public void Open(string name)
	{
		GD.Print(name);
	}
}
