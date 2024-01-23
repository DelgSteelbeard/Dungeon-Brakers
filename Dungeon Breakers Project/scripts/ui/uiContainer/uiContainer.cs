using Godot;
using System;

public partial class uiContainer : Control
{
	// Control slot1;
	// Control slot2;
	// Control slot3;
	// Control slot4;
	ContainerContent containerContent;
	Control slot;
	public override void _Ready()
	{
		containerContent = new ContainerContent();
		fillInContainer();
		// slot1 = GetNode<Control>("slot1");
		// slot2 = GetNode<Control>("slot2");
		// slot3 = GetNode<Control>("slot3");
		// slot4 = GetNode<Control>("slot4");
		// var newScene = GD.Load<PackedScene>("res://scenes/items/weapons/blue_sword.tscn");
		// var blueSword = newScene.Instantiate();
		// slot1.AddChild(blueSword);
	}

	private void fillInContainer()
	{
		// for (int i = 1; i <= 4; i++)
		// {
		// 	if (containerContent.slots[i] != null)
		// 	{
		// 		GD.Print("slot" + i + " is not null");
		// 		slot = GetNode<Control>("slot" + i);
		// 		slot.AddChild(containerContent.slots[i]);
		// 	}
		// }
		for (int i = 1; i <= 4; i++)
		{
			slot = GetNode<Control>("slot" + i);
			var newScene = GD.Load<PackedScene>("res://scenes/items/weapons/blue_sword.tscn");
			var blueSword = newScene.Instantiate();
			slot.AddChild(blueSword);
		}
	}
}
