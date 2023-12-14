using Godot;
using System;
using x;
public partial class MovementController : Node2D
{
    public MovementController()
    {
        SetProcessInput(true);
    }

    public override void _Input(InputEvent @event)
    {
        HandleInputAction("playerTab", "tab");
        HandleInputAction("playerEsc", "esc");
        HandleInputAction("playerRight", "right");
        HandleInputAction("playerLeft", "left");
        HandleInputAction("playerDown", "down");
        HandleInputAction("playerUp", "up");
        HandleInputAction("playerE", "e");
        HandleInputAction("playerI", "i");
        HandleInputAction("playerMouseClick", "mouseClick");
        HandleInputAction("playerM", ChangeScene);
    }

    private void HandleInputAction(string action, string message)
    {
        if (Input.IsActionPressed(action))
        {
            GD.Print(message);
        }
    }

    private void HandleInputAction(string action, Action actionFunction)
    {
        if (Input.IsActionPressed(action))
        {
            actionFunction?.Invoke();
        }
    }

    private void ChangeScene()
    {
        GetTree().ChangeSceneToFile("res://scenes/interface/characterCreator.tscn");
    }
}
