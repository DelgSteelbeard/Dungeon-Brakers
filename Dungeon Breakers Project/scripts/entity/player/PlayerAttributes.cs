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

    private PlayerAttributes() //constructor must be static to prevent invoke new operator
    {
        health = 100;
        strength = 100;
        stamina = 100;
        mana = 100;
        speed = 100;
        fitness = 100;
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