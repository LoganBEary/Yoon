using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Shop : MonoBehaviour
{
    public List<Item> weapons;
    public List<GameObject> weaponObjects;
    public List<int> weaponCosts;
    public MainPlayerController player;

    public TextMeshProUGUI yoodlesDisplayText;

    public GameObject notEnoughPrompt;
    public GameObject successPrompt;
    public PauseManager PauseM;

    public Toggle QuestToggle;
    public GameObject questCompletedMenuUI;

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

    IEnumerator displaysuccessPrompt()
    {
        successPrompt.SetActive(true);
        yield return new WaitForSecondsRealtime(2f);
        successPrompt.SetActive(false);
    }

    IEnumerator displaynotEnoughPrompt()
    {
        notEnoughPrompt.SetActive(true);
        yield return new WaitForSecondsRealtime(2f);
        notEnoughPrompt.SetActive(false);
    }

    public void onClickWeapon(int index)
    {
        Item itemtoadd = weapons[index];
        int itemCost = weaponCosts[index];
        if (enoughCoins(player.CoinCount, itemCost))
        {
            if(player.currentQuest == 1)
            {
                player.quest.isActive = false;
                player.quest.isComplete = true;
                QuestToggle.isOn = true;
                player.currentQuest = 2;
                ShopQuest(player.quest.yoodlesRewarded, player.quest.expRewarded);
            }
            Inventory.inventoryInstance.add(itemtoadd);
            weaponObjects[index].SetActive(false);
            player.CoinCount -= itemCost;
            player.SetCountText();
            StartCoroutine(displaysuccessPrompt());
            Debug.Log("Num coins after purchase is: " + player.CoinCount.ToString());
        }
        else
        {
            StartCoroutine(displaynotEnoughPrompt());
            Debug.Log("You don't have enough coins to purchase this item");
        }
    }

    public void ShopQuest(int yoodles, int exp){
        PauseM.addYoodles(yoodles);
        PauseM.addXP(exp);
        TextMeshProUGUI yoodlesText = questCompletedMenuUI.transform.GetChild(2).GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI xpText = questCompletedMenuUI.transform.GetChild(3).GetComponent<TextMeshProUGUI>();

        yoodlesText.text = "+ " + yoodles.ToString() + " Yoodles";
        xpText.text = "+ " + exp.ToString() + " XP";
        // Display the Completed Text UI
        questCompletedMenuUI.SetActive(true);
        return;
    }

}
