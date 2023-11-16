using Godot;
using System;
using System.Collections.Generic;

public partial class AdjustmentValues : GridContainer
{
	PlayerAttributes playerAttributes;
	DisplayValue displayValue;
	BaseValues baseValues;
	private int freePoints { get; set; } = 20;



	public override void _Ready()
	{
		playerAttributes = PlayerAttributes.Instance;
		displayValue = GetNode<DisplayValue>("/root/characterCreator/displayValue");
		baseValues = new BaseValues();
	}


	private void adjustValue(bool plus, string attribute)
	{
		if (plus)
		{
			if (freePoints > 0)
			{
				playerAttributes.UpdateAttribute(attribute, 1);
				freePoints--;
				displayValue.drawValues();
			}
		}
		else if (!plus)
		{
			if (playerAttributes.playerClass == "paladin")
			{
				if (freePoints < 20 && playerAttributes.GetAttributeValueByName(attribute) > baseValues.paladinBaseValues[attribute])
				{
					playerAttributes.UpdateAttribute(attribute, -1);
					freePoints++;
					displayValue.drawValues();
				}
			}
			else if (playerAttributes.playerClass == "wizard")
			{
				if (freePoints < 20 && playerAttributes.GetAttributeValueByName(attribute) > baseValues.wizardBaseValues[attribute])
				{
					playerAttributes.UpdateAttribute(attribute, -1);
					freePoints++;
					displayValue.drawValues();
				}
			}

		}

	}



	public void _on_health_plus_pressed()
	{
		adjustValue(true, "health");
	}
	public void _on_health_minus_pressed()
	{
		adjustValue(false, "health");
	}
	public void _on_strength_plus_pressed()
	{
		adjustValue(true, "strength");
	}
	public void _on_stamina_plus_pressed()
	{
		adjustValue(true, "stamina");
	}
	public void _on_mana_plus_pressed()
	{
		adjustValue(true, "mana");
	}
	public void _on_speed_plus_pressed()
	{
		adjustValue(true, "speed");
	}
	public void _on_fitness_plus_pressed()
	{
		adjustValue(true, "fitness");
	}
	



}