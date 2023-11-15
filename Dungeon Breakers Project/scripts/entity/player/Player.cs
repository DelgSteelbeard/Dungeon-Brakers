using Godot;
using System;

public partial class Player : Node2D
{
    private MovementController movementController;
    private PlayerAttributes playerAttributes;

    //built-in function. execute when the node is loaded in godot
    public override void _Ready()
    {
        movementController = new MovementController();
        playerAttributes = PlayerAttributes.Instance; //here i'm invoke our instance of PlayerAttribute class
        
    }
}