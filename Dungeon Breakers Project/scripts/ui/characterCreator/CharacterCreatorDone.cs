using Godot;
using System;

public partial class CharacterCreatorDone : Button
{
	private void _on_pressed()
	{
		GetTree().ChangeSceneToFile("res://scenes/gameplay/first_level.tscn");
	}
}
