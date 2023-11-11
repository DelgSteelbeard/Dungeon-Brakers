using Godot;

public partial class Player : Node2D
{
    private MovementController movementController;
    private PlayerAttributes playerAttributes;

    //built-in function. execute when the node is loaded in godot
    public override void _Ready()
    {
        movementController = new MovementController();
        playerAttributes = playerAttributes.Instance; //here i'm invoke our instance of PlayerAttribute class
    }

    //built-in function. execute 60 time for a second
    //delta is time between two frames
    public override void _PhysicsProcess(double delta)  
    {
        movementController.GetInput();
    }
}