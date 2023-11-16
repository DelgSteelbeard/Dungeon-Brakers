using Godot;

public partial class PlayerAttributes
{
    //I'm use a singletron pattern, becouse we will use this class in many diffrent clases and we need use one object of this
    //I do it becouse Player already inherits from another function
    private static PlayerAttributes instance;  //here we store our instance
    public int health { get; set; }
    public int strength { get; set; }
    public int stamina { get; set; }
    public int mana { get; set; }
    public int speed { get; set; }
    public int fitness { get; set; }
    public string playerClass { get; set; }

    private PlayerAttributes() //constructor must be static to prevent invoke new operator
    {
        health = 100;
        strength = 100;
        stamina = 100;
        mana = 100;
        speed = 100;
        fitness = 100;
    }

    public int GetAttributeValueByName(string attributeName)
{
    switch (attributeName.ToLower())
    {
        case "health":
            return health;
        case "strength":
            return strength;
        case "stamina":
            return stamina;
        case "mana":
            return mana;
        case "speed":
            return speed;
        case "fitness":
            return fitness;
        default:
            GD.Print("Invalid attribute name");
            return 0;
    }
}

    public void UpdateAttribute(string attributeName, int value)
    {
        switch (attributeName)
        {
            case "health":
                health += value;
                break;
            case "strength":
                strength += value;
                break;
            case "stamina":
                stamina += value;
                break;
            case "mana":
                mana += value;
                break;
            case "speed":
                speed += value;
                break;
            case "fitness":
                fitness += value;
                break;
            default:
                GD.PrintErr("Nieznany atrybut: " + attributeName);
                break;
        }
    }

    public static PlayerAttributes Instance //with help of this method we will get our instance of this class wherever we wont
    {
        get
        {
            if (instance == null)
            {
                instance = new PlayerAttributes();
            }
            return instance;
        }
    }

}