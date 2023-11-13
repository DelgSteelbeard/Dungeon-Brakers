using Godot;
using System;

public partial class MovementController : Node2D
{
    private bool isPlayerEscPressed = false;
    private bool isPlayerLeftPressed = false;
    private bool isPlayerRightPressed = false;
    private bool isPlayerUpPressed = false;
    private bool isPlayerDownPressed = false;
    private bool isPlayerMouseClickPressed = false;
    private bool isPlayerEPressed = false;
    private bool isPlayerIPressed = false;
    private bool isPlayerMPressed = false;
    private bool isPlayerTabPressed = false;

    public void GetInput()
    {
        //Adding actions
        CheckAction("playerEsc", HandlePlayerEsc, ref isPlayerEscPressed);
        CheckAction("playerLeft", HandlePlayerLeft, ref isPlayerLeftPressed);
        CheckAction("playerRight", HandlePlayerRight, ref isPlayerRightPressed);
        CheckAction("playerUp", HandlePlayerUp, ref isPlayerUpPressed);
        CheckAction("playerDown", HandlePlayerDown, ref isPlayerDownPressed);
        CheckAction("playerMouseClick", HandlePlayerMouseClick, ref isPlayerMouseClickPressed);
        CheckAction("playerE", HandlePlayerE, ref isPlayerEPressed);
        CheckAction("playerI", HandlePlayerI, ref isPlayerIPressed);
        CheckAction("playerM", HandlePlayerM, ref isPlayerMPressed);
        CheckAction("playerTab", HandlePlayerTab, ref isPlayerTabPressed);
    }

    /// <summary>
    /// This method assures as that  if (Input.IsActionPressed) execute only once 
    /// </summary>
    /// <param name="actionName">Name of the button</param>
    /// <param name="message">in this place should be a method (or something) whitch supports a specific input</param>
    /// <param name="isPressed">bool whitch check wether button is pressed</param>
    private void CheckAction(string actionName, Action actionFunction, ref bool isPressed)
    {
        if (Input.IsActionPressed(actionName))
        {
            isPressed = false;
        }
        else
        {
            if (Input.IsActionJustReleased(actionName) && !isPressed)
            {
                actionFunction?.Invoke(); //in this place should be a method whitch supports a specific input
                isPressed = true;
            }
        }
    }

    private void HandlePlayerEsc()
    {
        GD.Print("esc");
    }
    private void HandlePlayerLeft()
    {
        GD.Print("left");
    }
    private void HandlePlayerRight()
    {
        GD.Print("right");
    }
    private void HandlePlayerUp()
    {
        GD.Print("up");
    }
    private void HandlePlayerDown()
    {
        GD.Print("down");
    }
    private void HandlePlayerM()
    {
        //GetTree().ChangeSceneToFile("res://scenes/interface/characterCreator.tscn");
    }
    private void HandlePlayerTab()
    {
        GD.Print("tab");
    }
    private void HandlePlayerMouseClick()
    {
        GD.Print("mouseCLICK");
    }
    private void HandlePlayerE()
    {
        GD.Print("e");
    }
    private void HandlePlayerI()
    {
        GD.Print("i");
    }

}