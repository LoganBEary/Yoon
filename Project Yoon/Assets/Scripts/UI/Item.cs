using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Base class for any type of item that can show up in the inventory menu
public class Item : ScriptableObject
{
    // Name of the item. This will be displayed in the inventory menu
    public string itemName;

    // Icon of the item. This will be displayed in the inventory menu
    public Sprite icon;

    // Index of the item in the inventory
    public int index;

    // This function will basically describe what happens when an item is clicked on in the menu
    public virtual void use()
    {
    }
}
