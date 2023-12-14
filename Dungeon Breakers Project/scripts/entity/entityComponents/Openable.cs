using Godot;
using System;
using x;

public partial class Openable : Node2D, IOpen
{
	public string name;
	public void Open()
	{
		GD.Print(name);
	}
}
