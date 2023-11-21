using Godot;
using System;

public partial class ChooseClass : VBoxContainer
{
	PlayerAttributes playerAttributes;
	protected AdjustmentValues adjustmentValues;
	protected FreePointsDisplay freePointsDisplay;
	protected MarginContainer abilitiesName;
	protected DisplayValue displayValue;
	//UncoverAdjustmentSection uncoverAdjustmentSection;
	public override void _Ready()
	{
		playerAttributes = PlayerAttributes.Instance;
		displayValue = GetNode<DisplayValue>("/root/characterCreator/displayValue");
		adjustmentValues = GetNode<AdjustmentValues>("/root/characterCreator/adjustmentValues");
		freePointsDisplay = GetNode<FreePointsDisplay>("/root/characterCreator/freePoints");
		abilitiesName = GetNode<MarginContainer>("/root/characterCreator/abilitiesName");
		//uncoverAdjustmentSection = new UncoverAdjustmentSection();
		hideValues();
	}

	public void _on_paladin_pressed()
	{
		playerAttributes.playerClass = "paladin";
		playerAttributes.health = 120;
		playerAttributes.strength = 130;
		playerAttributes.stamina = 110;
		playerAttributes.mana = 40;
		playerAttributes.speed = 6;
		playerAttributes.fitness = 60;
		displayValue.drawValues();
		showValues();
	}
	public void _on_wizard_pressed()
	{
		playerAttributes.playerClass = "wizard";
		playerAttributes.health = 80;
		playerAttributes.strength = 80;
		playerAttributes.stamina = 90;
		playerAttributes.mana = 135;
		playerAttributes.speed = 6;
		playerAttributes.fitness = 110;
		displayValue.drawValues();
		showValues();
	}

	private void hideValues()
	{
		displayValue.Hide();
		adjustmentValues.Hide();
		freePointsDisplay.Hide();
		abilitiesName.Hide();
	}

	private void showValues()
	{
		displayValue.Show();
		adjustmentValues.Show();
		freePointsDisplay.Show();
		abilitiesName.Show();
	}
}
