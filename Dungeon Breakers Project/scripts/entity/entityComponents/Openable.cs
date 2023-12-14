using Godot;
using System;
using x;

public partial class Openable : Node2D, IOpen
{
	public void Open()
	{
		GD.Print("Open");
	}
}
