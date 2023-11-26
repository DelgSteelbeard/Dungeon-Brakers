using Godot;

public partial class MovementController
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
        CheckAction("playerEsc", "esc", ref isPlayerEscPressed);
        CheckAction("playerLeft", "left", ref isPlayerLeftPressed);
        CheckAction("playerRight", "right", ref isPlayerRightPressed);
        CheckAction("playerUp", "up", ref isPlayerUpPressed);
        CheckAction("playerDown", "down", ref isPlayerDownPressed);
        CheckAction("playerMouseClick", "mouseClick", ref isPlayerMouseClickPressed);
        CheckAction("playerE", "e", ref isPlayerEPressed);
        CheckAction("playerI", "i", ref isPlayerIPressed);
        CheckAction("playerM", "m", ref isPlayerMPressed);
        CheckAction("playerTab", "tab", ref isPlayerTabPressed);
    }

	/// <summary>
    /// This method assures as that  if (Input.IsActionPressed) execute only once 
    /// </summary>
    /// <param name="actionName">Name of the button</param>
    /// <param name="message">in this place should be a method (or something) whitch supports a specific input</param>
    /// <param name="isPressed">bool whitch check wether button is pressed</param>
    private void CheckAction(string actionName, string message, ref bool isPressed)
    {
        if (Input.IsActionPressed(actionName))
        {
            isPressed = false;
        }
        else
        {
            if (Input.IsActionJustReleased(actionName) && !isPressed)
            {
                GD.Print(message); //in this place should be a method whitch supports a specific input
                isPressed = true;
            }
        }
    }
}