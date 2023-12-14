using Godot;
using System;
using game;
public partial class MovementController : Node2D
{
    public float playerX { get; set; }
    Grid gridClass = Grid.Instance;
    StaticEntityList staticEntityList = StaticEntityList.Instance;

    public override void _Ready()
    {
        playerX = this.GlobalPosition.X;
        GD.Print(playerX);
    }
    public MovementController()
    {
        SetProcessInput(true);
    }

    public override void _Input(InputEvent @event)
    {
        HandleInputAction("playerTab", "tab");
        HandleInputAction("playerEsc", "esc");
        HandleInputAction("playerRight", goRight);
        HandleInputAction("playerLeft", goLeft);
        HandleInputAction("playerDown", goDown);
        HandleInputAction("playerUp", goUp);
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

    private void goRight()
    {
        //GlobalPosition = new Vector2(GlobalPosition.X + 100, GlobalPosition.Y);
        GD.Print("GlobalPosition");
        int xx = (int)(GlobalPosition.X + 50) / 100;
        int yy = (int)GlobalPosition.Y / 100;
         GD.Print("------------------------");
         GD.Print($"X: {xx}, Y: {yy}");
         GD.Print($"num: {gridClass.grid[xx, yy, 6]}");
         GD.Print($"colision: {staticEntityList.Entities[gridClass.grid[xx, yy, 6]].interactable}");
         GD.Print($"xcz: {gridClass.grid[11, 4, 6]}");

        if(gridClass.grid[xx, yy, 6] == 0 || (!staticEntityList.Entities[gridClass.grid[xx, yy, 6]].interactable))
        {
        GlobalPosition = new Vector2(GlobalPosition.X + 100, GlobalPosition.Y);
        }
    }

    private void goLeft()
    {
        GlobalPosition = new Vector2(GlobalPosition.X - 100, GlobalPosition.Y);
    }

    private void goDown()
    {
        GlobalPosition = new Vector2(GlobalPosition.X, GlobalPosition.Y + 100);
    }

    private void goUp()
    {
        GlobalPosition = new Vector2(GlobalPosition.X, GlobalPosition.Y - 100);
    }
}
