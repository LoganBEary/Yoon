using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHolder : MonoBehaviour
{
    // Keeps track of the current selected weapon's ID, which is also its index
    // under the weaponHolder gameobject
    int selectedWeapon;

    public GameObject selectedWeaponObject;

    // Number of weapons available in the game
    public int numWeapons;

    // Start is called before the first frame update
    void Start()
    {
        // Get the selected weapon ID from the gamemanager. This is needed in order to save the selected weapon across scenes
        foreach (Transform child in transform)
        {
            Debug.Log(child.gameObject.name);
        }
        selectedWeapon = GameManager.gameManager.selectedWeaponID;
        selectedWeaponObject = transform.GetChild(selectedWeapon).gameObject; // Update the selected weapon GameObject
        selectWeapon(selectedWeapon); // Make this function call to 'equip' the weapon by setting the correct gameobject active in the scene
    }

    // This function will swap the weapon that the player is holding. It is called 
    // by the inventory script whenever the player equips a new weapon. It basically disables the currently
    // equipped weapon and enables a new weapon at the specified index
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
                selectedWeaponObject = weapon.gameObject;
            }
            i++; // update the index
        }
        selectedWeapon = weaponIndex; // Update the selected weapon ID/index
        GameObject.Find("Character").GetComponent<MainPlayerController>().updateWeapon(); // Update the player's weapon reference
    }

    // This function is called right before a scene change
    public void OnSceneChange()
    {
        // Save the currently selected weapon ID/index
        GameManager.gameManager.selectedWeaponID = selectedWeapon;
    }
}
