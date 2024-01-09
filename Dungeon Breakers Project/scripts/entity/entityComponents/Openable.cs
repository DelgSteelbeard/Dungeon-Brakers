using Godot;
using System;
using game;

public partial class Openable : Node2D, IOpen
{
	public string name;
	public void Open()
	{
		GD.Print(name);
		GD.Print("Open something");
	}
}
