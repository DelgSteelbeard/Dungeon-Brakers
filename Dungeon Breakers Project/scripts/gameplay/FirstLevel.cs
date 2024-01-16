using Godot;
using System;
using System.Collections.Generic;

namespace game
{
	public partial class FirstLevel : Node2D
	{
		Chest chest;
		Barrel barrel;
		IOpen iOpen;
		public StaticEntityList staticEntityList;
		PlayerAttributes playerAttributes = PlayerAttributes.Instance;
		public Grid gridClass = Grid.Instance;
		GridFristLayer gridFristLayer;
		public Control inventoryScene;
		public int x = 69;
		private bool isInventoryVisible = false;
		//MovementController player;
		public override void _Ready()
		{
			SetProcessInput(true);
			//tests for the openable interface
			chest = GetNode<Chest>("chest1");
			barrel = GetNode<Barrel>("barrel");
			iOpen = chest.open;
			iOpen.Open();
			iOpen = barrel.open;
			iOpen.Open();

			//tests for the static entity list
			int[,,] mygrid = new int[64, 64, 7];
			staticEntityList = StaticEntityList.Instance;
			List<SingleEntity> entities = staticEntityList.Entities;
			for (int i = 0; i < entities.Count; i++)
			{
				int x = entities[i].x;
				int y = entities[i].y;
				mygrid[x, y, 6] = i + 1;
				GD.Print($"Entity Name: {entities[i].name}, ID: {entities[i].entityID}, X: {entities[i].x}, Y: {entities[i].y} Interactable: {entities[i].interactable} i = {i} collision: {entities[i].collision}");
			}
			gridClass.grid = mygrid;
			gridFristLayer = new GridFristLayer();
			//test for getting the parameter from the grid
			string name = entities[mygrid[11, 4, 6]].name;
			GD.Print("4,0,1:" + mygrid[4, 0, 1]);

			inventoryScene = (Control)GetNode("player/uiContainer");
			//inventoryVisible();

			// var scene = GD.Load<PackedScene>("res://scenes/entity/player.tscn");

			// var playerInstance = scene.Instantiate();
			// AddChild(playerInstance);

			// player = playerInstance as MovementController;


		}

		public override void _Input(InputEvent @event)
		{
			HandleInputAction("playerE", Interact);
		}

		private void HandleInputAction(string action, Action actionFunction)
		{
			if (Input.IsActionPressed(action))
			{
				actionFunction?.Invoke();
			}
		}

		private void Interact()
		{
			if (isInventoryVisible)
			{
				hideInventory();
			}
			else
			{
				if (gridClass.grid[playerAttributes.playerX, playerAttributes.playerY, 6] != 0)
				{
					int entityNumber = gridClass.grid[playerAttributes.playerX, playerAttributes.playerY, 6];
					if (staticEntityList.Entities[entityNumber].interactable)
					{
						inventoryScene.Visible = true;
						isInventoryVisible = true;
					}
				}
			}

		}

		private void hideInventory()
		{
			inventoryScene.Visible = false;
			isInventoryVisible = false;
		}

		// public void inventoryVisible()
		// {
		// 	GD.Print("inventoryVisible");
		// 	inventoryScene.Visible = true;
		// }
	}

}