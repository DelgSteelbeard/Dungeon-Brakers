using Godot;

public partial class PlayerAttributes
{
    public int health { get; set; }
    public int strength { get; set; }
    public int stamina { get; set; }
    public int mana { get; set; }
    public int speed { get; set; }
    public int fitness { get; set; }

    /// <summary>
    /// Constructor for the PlayerAttributes class, initializes player attributes.
    /// </summary>
    /// <param name="initialHealth">Initial value for health points.</param>
    /// <param name="initialStrength">Initial value for strength.</param>
    /// <param name="initialStamina">Initial value for stamina.</param>
    /// <param name="initialMana">Initial value for mana.</param>
    /// <param name="initialSpeed">Initial value for speed.</param>
    /// <param name="initialFitness">Initial value for fitness.</param>
    public PlayerAttributes(int initialHealth, int initialStrength, int initialStamina, int initialMana, int initialSpeed, int initialFitness)
    {
        health = initialHealth;
        strength = initialStrength;
        stamina = initialStamina;
        mana = initialMana;
        speed = initialSpeed;
        fitness = initialFitness;
    }

}