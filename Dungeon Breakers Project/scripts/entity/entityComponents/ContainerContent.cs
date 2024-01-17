using Godot;
using System;
using System.Collections.Generic;

public partial class ContainerContent : Node2D
{
	[Export]
	public int size = 4;
	ItemIdList itemIdList;
	Random random = new Random();
	public Dictionary<int, Node> slots = new Dictionary<int, Node>();

	public override void _Ready()
	{
		itemIdList = new ItemIdList();
		fillInContainerContent();
		foreach (var kvp in slots)
		{
			GD.Print("Key: ", kvp.Key, " Value: ", kvp.Value);
		}
	}

	public void fillInContainerContent()
	{
		for (int i = 1; i <= size; i++)
		{
			int randomInt = random.Next(0, 2);
			if (randomInt != 0)
			{
				string path = itemIdList.items[randomInt];
				var scene = GD.Load<PackedScene>(path);
				var item = scene.Instantiate();
				slots.Add(i, item);
			}
			else if (randomInt == 0)
			{
				slots.Add(i, null);
			}
		}
	}
}
