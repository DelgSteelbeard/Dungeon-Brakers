using Godot;
using System;

public partial class DisplayValue : Control
{
	PlayerAttributes playerAttributes;
	private BaseValues baseValues;
	private Label healthValue;
	private Label strengthValue;
	private Label staminaValue;
	private Label manaValue;
	private Label speedValue;
	private Label fitnessValue;

	public override void _Ready()
	{
		playerAttributes = PlayerAttributes.Instance;
		healthValue = GetNode<Label>("healthValue");
		strengthValue = GetNode<Label>("strengthValue");
		staminaValue = GetNode<Label>("staminaValue");
		manaValue = GetNode<Label>("manaValue");
		speedValue = GetNode<Label>("speedValue");
		fitnessValue = GetNode<Label>("fitnessValue");
		baseValues = new BaseValues();
	}

	public void drawValues()
	{
		healthValue.Text = playerAttributes.health.ToString();
		strengthValue.Text = playerAttributes.strength.ToString();
		staminaValue.Text = playerAttributes.stamina.ToString();
		manaValue.Text = playerAttributes.mana.ToString();
		speedValue.Text = playerAttributes.speed.ToString();
		fitnessValue.Text = playerAttributes.fitness.ToString();

		baseValueColor("health", playerAttributes.playerClass, healthValue);
		baseValueColor("strength", playerAttributes.playerClass, strengthValue);
		baseValueColor("stamina", playerAttributes.playerClass, staminaValue);
		baseValueColor("mana", playerAttributes.playerClass, manaValue);
		baseValueColor("speed", playerAttributes.playerClass, speedValue);
		baseValueColor("fitness", playerAttributes.playerClass, fitnessValue);
	}

	/// <summary>
    /// Set the label color to yellow when the value is equal base value
    /// </summary>
    /// <param name="attribute">Attribute name</param>
    /// <param name="playerClass">Player class (e.g., "paladin" or "wizard")</param>
    /// <param name="label">Label to modify</param>
	private void baseValueColor(string attribute, string playerClass, Label label)
	{
		if (playerAttributes.playerClass == "paladin")	
		{
			if (playerAttributes.getAttributeValueByName(attribute) == baseValues.paladinBaseValues[attribute])
			{
				label.Modulate = new Color(1, 1, 0);
			}
			if (playerAttributes.getAttributeValueByName(attribute) != baseValues.paladinBaseValues[attribute])
			{
				label.Modulate = new Color(1, 1, 1);
			}
		}
		if (playerAttributes.playerClass == "wizard")
		{
			if (playerAttributes.getAttributeValueByName(attribute) == baseValues.wizardBaseValues[attribute])
			{
				label.Modulate = new Color(1, 1, 0);
			}
			if (playerAttributes.getAttributeValueByName(attribute) != baseValues.wizardBaseValues[attribute])
			{
				label.Modulate = new Color(1, 1, 1);
			}
		}

	}
}
