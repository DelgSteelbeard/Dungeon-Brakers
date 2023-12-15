using Godot;
using System;
using game;
using System.Threading.Tasks;
public partial class MovementController : Node2D
{
    public float playerX { get; set; }
    Grid gridClass = Grid.Instance;
    StaticEntityList staticEntityList = StaticEntityList.Instance;
    private bool stop = false;

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

    private async void goRight()
    {
        //GlobalPosition = new Vector2(GlobalPosition.X + 100, GlobalPosition.Y);
        GD.Print("GlobalPosition");
        int playerX = (int)(GlobalPosition.X + 50) / 100;
        int playerY = (int)GlobalPosition.Y / 100;
        //GD.Print($"colision: {staticEntityList.Entities[gridClass.grid[playerX, playerY, 6]].interactable}");
        GD.Print($"xcz: {gridClass.grid[11, 4, 6]}");

        if ((gridClass.grid[playerX, playerY, 6] == 0 || (!staticEntityList.Entities[gridClass.grid[playerX, playerY, 6]].interactable)) && !stop)
        {
            GlobalPosition = new Vector2(GlobalPosition.X + 100, GlobalPosition.Y);
            stop = true;
            await wait();
            stop = false;
        }
    }

    

    private async void goLeft()
    {
        int playerX = (int)(GlobalPosition.X - 100) / 100;
        int playerY = (int)GlobalPosition.Y / 100;
        if ((gridClass.grid[playerX, playerY, 6] == 0 || (!staticEntityList.Entities[gridClass.grid[playerX, playerY, 6]].interactable)) && !stop)
        {
            GlobalPosition = new Vector2(GlobalPosition.X - 100, GlobalPosition.Y);
            stop = true;
            await wait();
            stop = false;
        }
    }

    private async void goDown()
    {
        int playerX = (int)GlobalPosition.X / 100;
        int playerY = (int)(GlobalPosition.Y + 50) / 100;
        if ((gridClass.grid[playerX, playerY, 6] == 0 || (!staticEntityList.Entities[gridClass.grid[playerX, playerY, 6]].interactable)) && !stop)
        {
            GlobalPosition = new Vector2(GlobalPosition.X, GlobalPosition.Y + 100);
            stop = true;
            await wait();
            stop = false;
        }
    }

    private async void goUp()
    {
        int playerX = (int)GlobalPosition.X / 100;
        int playerY = (int)(GlobalPosition.Y - 100) / 100;
        if ((gridClass.grid[playerX, playerY, 6] == 0 || (!staticEntityList.Entities[gridClass.grid[playerX, playerY, 6]].interactable)) && !stop)
        {
            GlobalPosition = new Vector2(GlobalPosition.X, GlobalPosition.Y - 100);
            stop = true;
            await wait();
            stop = false;
        }
    }

    public async Task wait()
    {
        // Your code here
        GD.Print("YourMethodName");
        await ToSignal(GetTree().CreateTimer(0.1f), "timeout");
        GD.Print("YourMethodNameeeee");
        // More of your code here
    }
}
