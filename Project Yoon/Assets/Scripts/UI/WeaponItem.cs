using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Allows for creating a weapon item in the assets folder. Basically for creating an object that isn't attached to a gameobject in the hierarchy
[CreateAssetMenu(fileName = "New Weapon", menuName = "Items/Weapon")]
public class WeaponItem : Item
{
    public override void use()
    {
        // If the item was clicked on, equip it by calling the inventory.swap function
        Inventory.inventoryInstance.swap(this);
    }
}
