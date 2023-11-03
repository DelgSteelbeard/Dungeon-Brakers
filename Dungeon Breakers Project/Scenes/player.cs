using Godot;

public partial class player : Node2D
{
    private MovementController movementController;

    //built-in function. execute when the node is loaded in godot
    public override void _Ready()
    {
        movementController = new MovementController();
    }

    //built-in function. execute 60 time for a second
    //delta is time between two frames
    public override void _PhysicsProcess(double delta)  
    {
        movementController.GetInput();
    }
}