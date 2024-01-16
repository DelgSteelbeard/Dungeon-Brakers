using Godot;
using System;

public partial class uiContainer : Control
{
	Control slot1;
	public override void _Ready()
	{
		var slot1 = GetNode<Control>("slot1");
		var newScene = GD.Load<PackedScene>("res://scenes/items/weapons/blue_sword.tscn");
		var blueSword = newScene.Instantiate();
		slot1.AddChild(blueSword);
	}
}
