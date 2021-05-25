using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Shop : MonoBehaviour
{
    public List<Item> weapons;
    public List<GameObject> weaponObjects;
    public List<int> weaponCosts;
    public MainPlayerController player;
    public GameObject notEnoughPrompt;

    public TextMeshProUGUI yoodlesDisplayText;

    private void Update()
    {
        updateCoinsDisplay();
    }

    public void updateCoinsDisplay()
    {
        yoodlesDisplayText.text = "Yoodles: " + player.CoinCount;
    }

    public bool enoughCoins(int num_coins, int cost)
    {
        return num_coins >= cost;
    }

    public void onClickWeapon(int index)
    {
        Item itemtoadd = weapons[index];
        int itemCost = weaponCosts[index];
        if (enoughCoins(player.CoinCount, itemCost))
        {
            Inventory.inventoryInstance.add(itemtoadd);
            weaponObjects[index].SetActive(false);
            player.CoinCount -= itemCost;
            player.SetCountText();
            Debug.Log("Num coins after purchase is: " + player.CoinCount.ToString());
        }
        else
        {
            Debug.Log("You don't have enough coins to purchase this item");
        }
    }
}
