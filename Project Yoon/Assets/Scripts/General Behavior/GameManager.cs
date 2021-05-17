using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ObserverPattern;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;

    public float curHealth;

    public int selectedWeaponID;

    public int yoodles;
    public int playerLevel;

    public int experiencePoints;
    public List<Item> itemList = new List<Item>();
    public List<float> statsList = new List<float>(); // [MaxHealth, damage, defense, magic]

    public string previousScene;
    public string currentScene;

    Subject firstQuestSubject = new Subject();

    public Subject changeSceneSubject = new Subject();

    UI_Observer quest1_UIObserver;

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

    public void Start()
    {
        curHealth = GameManager.gameManager.curHealth;
        statsList = GameManager.gameManager.statsList;
        yoodles = GameManager.gameManager.yoodles;
        itemList = GameManager.gameManager.itemList;
        currentScene = GameManager.gameManager.currentScene;
        previousScene = GameManager.gameManager.previousScene;
        selectedWeaponID = GameManager.gameManager.selectedWeaponID;
    }

    public void updateInfo(float h, int y, List<Item> i, List<float> s, string curScene, string newScene)
    {
        curHealth = h;
        statsList = s;
        yoodles = y;
        itemList = i;
        previousScene = curScene;
        currentScene = newScene;
    }

    public void SaveState()
    {
        GameManager.gameManager.curHealth = curHealth;
        GameManager.gameManager.statsList = statsList;
        GameManager.gameManager.yoodles = yoodles;
        GameManager.gameManager.itemList = itemList;
        GameManager.gameManager.currentScene = currentScene;
        GameManager.gameManager.previousScene = previousScene;
    }

    public void notifyEvent(string m_event)
    {
        if (m_event == "Quest1")
        {
            firstQuestSubject.Notify();
            firstQuestSubject.RemoveObserver(quest1_UIObserver);
        }
    }

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
                player.damage = stat;
                break;
        }
    }
}
