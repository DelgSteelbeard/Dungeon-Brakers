using Godot;
using System;
using game;
using System.Threading.Tasks;
public partial class MovementController : Node2D
{
    Grid gridClass = Grid.Instance;
    StaticEntityList staticEntityList = StaticEntityList.Instance;
    private bool stop = false;
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
        HandleInputAction("playerE", Interact);
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

    private void Interact(){
        GD.Print("Interact");
    }

    private async void goRight()
    {
        //Coordinates of the grid cell to the right of the player
        int playerX = (int)(GlobalPosition.X + 50) / 100;
        int playerY = (int)GlobalPosition.Y / 100;
        if (CanMove(playerX, playerY, 2))
        {
            GlobalPosition = new Vector2(GlobalPosition.X + 100, GlobalPosition.Y);
            await wait();
        }
    }



    private async void goLeft()
    {
        int playerX = (int)(GlobalPosition.X - 100) / 100;
        int playerY = (int)GlobalPosition.Y / 100;
        if (CanMove(playerX, playerY, 4))
        {
            GlobalPosition = new Vector2(GlobalPosition.X - 100, GlobalPosition.Y);
            await wait();
        }
    }

    private async void goDown()
    {
        int playerX = (int)GlobalPosition.X / 100;
        int playerY = (int)(GlobalPosition.Y + 50) / 100;
        if (CanMove(playerX, playerY, 3))
        {
            GlobalPosition = new Vector2(GlobalPosition.X, GlobalPosition.Y + 100);
            await wait();
        }
    }

    private async void goUp()
    {
        int playerX = (int)GlobalPosition.X / 100;
        int playerY = (int)(GlobalPosition.Y - 100) / 100;
        if (CanMove(playerX, playerY, 1))
        {
            GlobalPosition = new Vector2(GlobalPosition.X, GlobalPosition.Y - 100);
            await wait();
        }
    }
    // This method checks if the player can move to the given coordinates.
    // It first checks if the grid cell at the player's target position is empty (grid value is 0).
    // If the grid cell is not empty, it checks if the entity at that position is not interactable.
    // It also checks if the 'stop' flag is not set.
    // If all these conditions are met, the player can move, so the method returns true.
    // Otherwise, it returns false.
    private bool CanMove(int X, int Y, int Z)
    {
        //return (gridClass.grid[X, Y, 6] == 0 || (!staticEntityList.Entities[gridClass.grid[X, Y, 6]].interactable)) && !stop;

        if (gridClass.grid[X, Y, 6] != 0)
        {
            return (!staticEntityList.Entities[gridClass.grid[X, Y, 6]].collision) && !stop;
        }
        else if ((gridClass.grid[X, Y, 6] == 0) && !stop)
        {
            if ((gridClass.grid[X, Y, Z] == 0) && !stop)
            {
                return true;
            }
            else if (gridClass.grid[X, Y, Z] != 0)
            {
                return false;
            }
            else return true;
        }
        else return false;

    }

    public async Task wait()
    {
        stop = true;
        await ToSignal(GetTree().CreateTimer(0.1f), "timeout"); // wait 0.1 seconds
        stop = false;
    }
}
