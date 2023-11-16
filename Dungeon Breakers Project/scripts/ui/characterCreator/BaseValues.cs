using Godot;
using System;
using System.Collections.Generic;

public class BaseValues
{
    public Dictionary<string, int> wizardBaseValues = new Dictionary<string, int>();
    public Dictionary<string, int> paladinBaseValues = new Dictionary<string, int>();

    public BaseValues()
    {
        wizardBaseValues.Add("health", 80);
        wizardBaseValues.Add("strength", 80);
        wizardBaseValues.Add("stamina", 90);
        wizardBaseValues.Add("mana", 135);
        wizardBaseValues.Add("speed", 1);
        wizardBaseValues.Add("fitness", 110);

        paladinBaseValues.Add("health", 120);
        paladinBaseValues.Add("strength", 130);
        paladinBaseValues.Add("stamina", 110);
        paladinBaseValues.Add("mana", 40);
        paladinBaseValues.Add("speed", 1);
        paladinBaseValues.Add("fitness", 60);
    }
}