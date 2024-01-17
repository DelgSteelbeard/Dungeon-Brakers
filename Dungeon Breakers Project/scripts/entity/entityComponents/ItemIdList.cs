using System.Collections.Generic;
public class ItemIdList
{
    public Dictionary<int, string> items = new Dictionary<int, string>();
    public ItemIdList()
    {
        items.Add(0, "nothing");
        items.Add(1, "res://scenes/items/weapons/brown_axe.tscn");
        items.Add(2, "res://scenes/items/weapons/blue_sword.tscn");
    }
}
