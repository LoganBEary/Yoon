using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHolder : MonoBehaviour
{
    // Keeps track of the current selected weapon's ID, which is also its index
    // under the weaponHolder gameobject
    int selectedWeapon;


    // Number of weapons available in the game
    public int numWeapons;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // This function will swap the weapon that the player is holding. It is called 
    // by the inventory script whenever the player equips a new weapon
    public void selectWeapon(int weaponIndex)
    {
        // Make sure we are trying to access a valid index
        if (weaponIndex >= numWeapons)
        {
            return;
        }


        int i = 0;
        foreach (Transform weapon in transform) // Iterate through each of child gameobjects under the weaponHolder gameobject
        {
            if (i != weaponIndex) // If the current weapon is not selected/equipped
            {
                weapon.gameObject.SetActive(false); // disable the gameobject
            }
            else // If the current weapon is selected/equipped
            {
                weapon.gameObject.SetActive(true); // enable the gameobject
            }
            i++; // update the index
        }
    }
}
