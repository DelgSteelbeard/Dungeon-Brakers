using Godot;
using System;

public partial class DisplayValue : Control
{
	PlayerAttributes playerAttributes;
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
	}

	public void drawValues()
	{
		healthValue.Text = playerAttributes.health.ToString();
		strengthValue.Text = playerAttributes.strength.ToString();
		staminaValue.Text = playerAttributes.stamina.ToString();
		manaValue.Text = playerAttributes.mana.ToString();
		speedValue.Text = playerAttributes.speed.ToString();
		fitnessValue.Text = playerAttributes.fitness.ToString();
	}
}
