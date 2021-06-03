using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ObserverPattern;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;


    // ++++++++++++++++++++++++++++ Info saved for MainPlayerController script ++++++++++++++++++++++++++++
    public float curHealth;
    public int yoodles;
    public bool playerIsInvincible;
    public int currentQ;

    // ++++++++++++++++++++++++++++ Info saved for PauseManager script ++++++++++++++++++++++++++++
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


    // ++++++++++++++++++++++++++++ Info saved for WeaponHolder script ++++++++++++++++++++++++++++
    public int selectedWeaponID;
    public int currentAttackType;


    // ++++++++++++++++++++++++++++ Subjects and observers used for observer pattern ++++++++++++++++++++++++++++
    Subject firstQuestSubject = new Subject();

    public Subject changeSceneSubject = new Subject();

    UI_Observer quest1_UIObserver;

    // ============================================================================== Awake Funtion ==============================================================================
    private void Awake()
    {
        if (gameManager == null)
        {
            gameManager = this;
            DontDestroyOnLoad(gameManager);
        }
        else if (gameManager != this)
        {
            Destroy(gameObject);
        }

        // Observers for quest 1
        quest1_UIObserver = new UI_Observer(new UIQuestBehavior(200, 500));

        // Observer for scene changes
        SceneChange_Observer sc = new SceneChange_Observer();

        // Add observers to the first quest subject
        firstQuestSubject.AddObserver(quest1_UIObserver);

        // Add scene change observer to the scene change subject
        changeSceneSubject.AddObserver(sc);

    }

    // ============================================================================== Start Funtion ==============================================================================
    public void Start() // At the start of each scene load info from gamemanager singleton
    {
        curHealth = GameManager.gameManager.curHealth;
        statsList = GameManager.gameManager.statsList;
        yoodles = GameManager.gameManager.yoodles;
        itemList = GameManager.gameManager.itemList;
        currentScene = GameManager.gameManager.currentScene;
        previousScene = GameManager.gameManager.previousScene;
        selectedWeaponID = GameManager.gameManager.selectedWeaponID;
        upgradePoints = GameManager.gameManager.upgradePoints;
        playerIsInvincible = GameManager.gameManager.playerIsInvincible;
        statMaxedList = GameManager.gameManager.statMaxedList;
        currentQ = GameManager.gameManager.currentQ;
        currentAttackType = GameManager.gameManager.currentAttackType;
    }

    // ============================================================================== UpdateInfo Funtion ==============================================================================
    public void updateInfo(float h, int y, List<Item> i, List<float> s, string curScene, string newScene, int currQ)
    {
        curHealth = h;
        statsList = s;
        yoodles = y;
        itemList = i;
        previousScene = curScene;
        currentScene = newScene;
        currentQ = currQ;
    }

    // ============================================================================== SaveState Funtion ==============================================================================
    public void SaveState()
    {
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
    }

    // ============================================================================== Notify Funtion ==============================================================================
    public void notifyEvent(string m_event)
    {
        if (m_event == "Quest1")
        {
            firstQuestSubject.Notify();
            firstQuestSubject.RemoveObserver(quest1_UIObserver);
        }
    }


    // ============================================================================== AddXP Funtion ==============================================================================

    // Updates the xp stat of the player and notifies the pausemanager to update the xp bar. 
    // This is temporary and should probably be changed to use the observer pattern later on
    public void addXP(int xp)
    {
        PauseManager p = GameObject.Find("Pause Manager").GetComponent<PauseManager>();

        experiencePoints += xp;
        if (experiencePoints >= 500)
        {
            int numLevels = experiencePoints / 500;
            playerLevel += numLevels;
            experiencePoints = experiencePoints % 500;
            for (int i = 0; i < numLevels; i++)
            {
                p.levelUp();
            }
        }
        SaveState();

        p.updateXPbar();
    }

    // ============================================================================== UpdateStat Funtion ==============================================================================
    public void addStat(int index, float stat, float add)
    {
        statsList[index] = stat;

        MainPlayerController player = GameObject.Find("Character").GetComponent<MainPlayerController>();

        switch (index)
        {
            case 0:
                HealthBar hb = GameObject.Find("HealthGuage").GetComponent<HealthBar>();
                player.Health += add;
                hb.PlayerMaxHealth = stat;
                break;
            case 1:
                player.baseDamage = stat;
                player.damage = player.baseDamage + player.weaponDamage;
                break;
            case 2:
                player.defense = Mathf.Lerp(0, 40, stat / 20) / 100;
                break;
            case 3:
                player.coolDownTime = (100 - stat) / 100f;
                player.AttackEnergyCost = 15 - (stat / 10);
                break;
        }
    }


    // ============================================================================== UpdateQuestLine Funtion ==============================================================================
    public void updateQuestLine(int currQuest)
    {
        MainPlayerController player = GameObject.Find("Character").GetComponent<MainPlayerController>();
        player.currentQuest = currQuest;

    }
}
