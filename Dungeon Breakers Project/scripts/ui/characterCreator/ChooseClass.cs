using Godot;
using System;

public partial class ChooseClass : VBoxContainer
{
	PlayerAttributes playerAttributes;
	DisplayValue displayValue;
	public override void _Ready()
	{
		playerAttributes = PlayerAttributes.Instance;
		displayValue = GetNode<DisplayValue>("/root/characterCreator/displayValue");
	}

	public void _on_paladin_pressed()
	{
		playerAttributes.health = 120;
		playerAttributes.strength = 130;
		playerAttributes.stamina = 110;
		playerAttributes.mana = 40;
		playerAttributes.speed = 1;
		playerAttributes.fitness = 60;
		displayValue.drawValues();
	}
	public void _on_wizard_pressed()
	{
		playerAttributes.health = 80;
		playerAttributes.strength = 80;
		playerAttributes.stamina = 90;
		playerAttributes.mana = 135;
		playerAttributes.speed = 1;
		playerAttributes.fitness = 110;
		displayValue.drawValues();
	}
}
