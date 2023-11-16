using Godot;
using System;

public partial class AdjustmentValues : GridContainer
{
	PlayerAttributes playerAttributes;
	DisplayValue displayValue;

	private Button healthPlus;
	public override void _Ready()
	{
		playerAttributes = PlayerAttributes.Instance;
		displayValue = GetNode<DisplayValue>("/root/characterCreator/displayValue");
		healthPlus = GetNode<Button>("healthPlus");
		
		healthPlus.Pressed += () => pressHandling(playerAttributes.health);
	}

	public void pressHandling(PlayerAttributes atribute)
	{
		atribute++;
	 	displayValue.drawValues();
	}




	// public void _on_health_plus_pressed(string txt)
	// {
	// 	GD.Print(txt);
	// }
	// public void _on_strength_plus_pressed()
	// {
	// 	playerAttributes.strength++;
	// 	displayValue.drawValues();
	// }
	

	
}