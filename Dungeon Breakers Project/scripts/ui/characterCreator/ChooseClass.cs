using Godot;
using System;

public partial class ChooseClass : VBoxContainer
{
	PlayerAttributes playerAttributes;
	protected AdjustmentValues adjustmentValues;
	protected FreePointsDisplay freePointsDisplay;
	protected MarginContainer abilitiesName;
	protected DisplayValue displayValue;
	protected Button characterCreatorDone;
	public override void _Ready()
	{
		playerAttributes = PlayerAttributes.Instance;
		displayValue = GetNode<DisplayValue>("/root/characterCreator/displayValue");
		adjustmentValues = GetNode<AdjustmentValues>("/root/characterCreator/adjustmentValues");
		freePointsDisplay = GetNode<FreePointsDisplay>("/root/characterCreator/freePoints");
		abilitiesName = GetNode<MarginContainer>("/root/characterCreator/abilitiesName");
		characterCreatorDone = GetNode<CharacterCreatorDone>("/root/characterCreator/done");
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
		adjustmentValues.freePoints = 20;
		freePointsDisplay.DrawFreePointsValue();
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
		adjustmentValues.freePoints = 20;
		freePointsDisplay.DrawFreePointsValue();
		displayValue.drawValues();
		showValues();
	}

	//Todo move this part of code to the diffrent class UncoverAdjustmentValues and find out why godot not allowing for this now
	private void hideValues()
	{
		displayValue.Hide();
		adjustmentValues.Hide();
		freePointsDisplay.Hide();
		abilitiesName.Hide();
		characterCreatorDone.Hide();
	}

	private void showValues()
	{
		displayValue.Show();
		adjustmentValues.Show();
		freePointsDisplay.Show();
		abilitiesName.Show();
		characterCreatorDone.Show();
	}
}
