using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InventorySlotController : MonoBehaviour
{
    // Reference to the item that the inventory slot is displaying
    public Item item;

    private void Start()
    {
        // Update the inventory slot from the start
        updateInfo();
    }

    // This function updates the display information for the inventory slot
    public void updateInfo()
    {
        // Reference to the inventory slot's text child gameobject
        Text displayText = transform.Find("Text").GetComponent<Text>();

        // Reference to the inventory slot's image child gameobject
        Image displayImage = transform.Find("Icon").GetComponent<Image>();

        // If the inventory slot's item is not null
        if (item != null)
        {
            // Update the display text to show the item's name
            displayText.text = item.itemName;

            // update the display image to show the items icon
            displayImage.sprite = item.icon;

            // set the display image color to white so the icon is not invisible
            displayImage.color = Color.white;
        }
        else
        {
            // Set the display text to nothing
            displayText.text = "";

            // Set the display image to nothing
            displayImage.sprite = null;

            // Make the display image clear so it does not show up as a white rectangle
            displayImage.color = Color.clear;
        }
    }

    // This function defines what happens when an inventory slot is clicked on
    public void use()
    {
        // If the inventory slot was clicked on, then it will call the item's use() function if it's item is not none
        if (item)
        {
            item.use();
        }
    }
}