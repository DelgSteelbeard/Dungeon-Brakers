using Godot;
using System;
using System.Collections.Generic;

public class BaseValues
{
    //the class whitch contains a base value for each player class in dictionary
    public Dictionary<string, int> wizardBaseValues = new Dictionary<string, int>();
    public Dictionary<string, int> paladinBaseValues = new Dictionary<string, int>();

    public BaseValues()
    {
        wizardBaseValues.Add("health", 80);
        wizardBaseValues.Add("strength", 80);
        wizardBaseValues.Add("stamina", 90);
        wizardBaseValues.Add("mana", 135);
        wizardBaseValues.Add("speed", 6);
        wizardBaseValues.Add("fitness", 110);

        paladinBaseValues.Add("health", 120);
        paladinBaseValues.Add("strength", 130);
        paladinBaseValues.Add("stamina", 110);
        paladinBaseValues.Add("mana", 40);
        paladinBaseValues.Add("speed", 6);
        paladinBaseValues.Add("fitness", 60);
    }
}