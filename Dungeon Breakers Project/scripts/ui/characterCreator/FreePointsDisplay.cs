using Godot;
using System;

public partial class FreePointsDisplay : GridContainer
{
	private Label freePointsValue;
	AdjustmentValues adjustmentValues;
	public override void _Ready()
	{
		freePointsValue = GetNode<Label>("freePointsValue");
		adjustmentValues = GetNode<AdjustmentValues>("/root/characterCreator/adjustmentValues");
	}

	public void DrawFreePointsValue()
	{
		freePointsValue.Text = adjustmentValues.freePoints.ToString();
	}

}
