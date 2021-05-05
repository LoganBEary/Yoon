using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    // List of all the items in the player's inventory
    public List<Item> list = new List<Item>();

    // Reference to the player gameobject
    public GameObject player;
    // Reference to the inventory penal that is the parent of all the inventory slots
    public GameObject inventoryPanel;

    // Static inventory instance so any other script can reference the inventory instance
    public static Inventory inventoryInstance;

    /* This code will be used to maintain inventory singleton throughout scene changes. For now it is not
     * needed since the only working scene that uses inventory is the POC

    private void Awake()
    {
        if (pauseManagerInstance == null)
        {
            DontDestroyOnLoad(gameObject);
            pauseManagerInstance = this;
        }
        else if (pauseManagerInstance != this)
        {
            Destroy(gameObject);
        }
    }
    */

    private void Start()
    {
        // set instance to this inventory
        inventoryInstance = this;
        // Update the inventory slots
        updatePanelSlots();
    }

    // This function goes through the inventory and updates each slot to display the correct item
    void updatePanelSlots()
    {
        // Used for assigning indices to the items
        int i = 0;

        // Iterate through each of the inventory slots
        foreach (Transform child in inventoryPanel.transform)
        {
            // Get a reference to the inventory slot controller
            InventorySlotController slot = child.GetComponent<InventorySlotController>();

            // Make sure we are in the bounds of the items list
            if (i < list.Count)
            {
                // Assign the inventory slot's item to the item that is located at index 'i' in the list
                slot.item = list[i];

                // If the item is not null
                if (slot.item)
                {
                    // Assign the items index
                    slot.item.index = i;
                }

            }
            else
            {
                // These are inventory slots that won't have an item. They are initialized with null
                slot.item = null;
            }

            // Update the inventory slot to display the correct item
            slot.updateInfo();

            // Increment counter
            i++;
        }
    }

    // This function adds an item to the inventory
    public void add(Item item)
    {
        // 6 is the max number of items in the inventory. Can be expanded in the future if needed
        if (list.Count < 6)
        {
            // Add the item to the list
            list.Add(item);
        }
        // Update each of the inventory slots to display correct item
        updatePanelSlots();
    }

    // This function removes an item from the inventory
    public void remove(Item item)
    {
        // Remove the item from the list
        list.Remove(item);

        // Update each inventory slot to display correct item
        updatePanelSlots();
    }

    // This function swaps 'item' so that it is in the front of the list (equipped)
    public void swap(Item item)
    {
        // If the item given is not null
        if (item)
        {
            // Save the item' index into the inventory list
            int ind = item.index;
            
            // If index is not 0 (item is not already equipped)
            if (ind != 0)
            {
                // Create a temporary Item holding the currently equipped item
                Item temp = list[0];

                // Set list[0] to the given item (equipping the given item)
                list[0] = item;

                // Fill the index of the given item with the previously equipped item
                list[ind] = temp;

                // Update the given item's index to 0
                list[0].index = 0;

                if (list[ind])
                {
                    // If the equipped item was not null, then reassign its index to the given items old index
                    list[ind].index = ind;
                }
            }
            // Update each inventory slot to display the correct information
            updatePanelSlots();
        }

    }

}