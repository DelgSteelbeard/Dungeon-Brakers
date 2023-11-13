using Godot;
using System;

public partial class Player : Node2D
{
    private MovementController movementController;
    private PlayerAttributes playerAttributes;

    //built-in function. execute when the node is loaded in godot
    public override void _Ready()
    {
        SetProcessInput(true);
        movementController = new MovementController();
        playerAttributes = PlayerAttributes.Instance; //here i'm invoke our instance of PlayerAttribute class
        
    }

    public override void _Input(InputEvent @event)
    {
        // Ta funkcja jest wywoływana, gdy występuje zdarzenie wejścia.
        if (@event.IsActionPressed("playerM"))
        {
            // Sprawdzamy, czy naciśnięty został przycisk akceptacji (domyślnie Enter lub Spacja).
            GD.Print("Przycisk akceptacji został naciśnięty!");
            
            // Tutaj następuje zmiana sceny na SecondScene.
            GetTree().ChangeSceneToFile("res://scenes/interface/characterCreator.tscn");
        }
    }

    //built-in function. execute 60 time for a second
    //delta is time between two frames
    public override void _PhysicsProcess(double delta)  
    {
        movementController.GetInput();
    }
}