using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearGMonLoad : MonoBehaviour
{
    // ++++++++++++++++++++++++++++ Starting mainPlayerController variables ++++++++++++++++++++++++++++
    public float curHealth;
    public int yoodles;
    public bool playerIsInvincible;
    public int currentQ;

    // ++++++++++++++++++++++++++++ Starting PauseManager variables ++++++++++++++++++++++++++++
    public List<Item> itemList = new List<Item>();
    public string previousScene;
    public string currentScene;
    public int upgradePoints;
    public int playerLevel;
    public int experiencePoints;
    public List<float> statsList = new List<float>(); // [MaxHealth, baseDamage, defense, magic]

    // This is a list containing information about whether each of the stats are currently upgradeable
    // For example, [true, false, true, true] would indicate that the damage stat is maxed out
    public List<bool> statMaxedList = new List<bool>(); // [true, true, true, true]


    // ++++++++++++++++++++++++++++ Starting WeaponHolder variables ++++++++++++++++++++++++++++
    public int selectedWeaponID;
    public int currentAttackType;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Check for clear GM on load");
        Debug.Log(GameManager.gameManager.firstLoadTown);
        if (GameManager.gameManager.firstLoadTown)
        {
            // reset gm values
            GameManager.gameManager.curHealth = curHealth;
            GameManager.gameManager.statsList = statsList;
            GameManager.gameManager.yoodles = yoodles;
            GameManager.gameManager.itemList = itemList;
            GameManager.gameManager.currentScene = currentScene;
            GameManager.gameManager.previousScene = previousScene;
            GameManager.gameManager.upgradePoints = upgradePoints;
            GameManager.gameManager.playerIsInvincible = playerIsInvincible;
            GameManager.gameManager.statMaxedList = statMaxedList;
            GameManager.gameManager.currentQ = currentQ;
            GameManager.gameManager.currentAttackType = currentAttackType;

            GameManager.gameManager.firstLoadTown = false;

            GameManager.gameManager.SaveState();

            Inventory.inventoryInstance.list = GameManager.gameManager.itemList;
            Inventory.inventoryInstance.updatePanelSlots();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
