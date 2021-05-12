using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ObserverPattern;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;

    public float curHealth;

    public int yoodles;
    public int playerLevel;

    public int experiencePoints;
    public List<Item> itemList = new List<Item>();
    public List<float> statsList = new List<float>(); // [MaxHealth, damage, defense, magic]

    public string previousScene;
    public string currentScene;

    Subject firstQuestSubject = new Subject();
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

        // Add observers to the first quest subject
        firstQuestSubject.AddObserver(quest1_UIObserver);

    }

    public void Start()
    {
        curHealth = GameManager.gameManager.curHealth;
        statsList = GameManager.gameManager.statsList;
        yoodles = GameManager.gameManager.yoodles;
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
    public void xp(int xp)
    {
        experiencePoints += xp;
        Debug.Log(experiencePoints);
        if (experiencePoints >= 500)
        {
            playerLevel += 1;
            experiencePoints = experiencePoints % 500;
        }
        SaveState();

        PauseManager p = GameObject.Find("Pause Manager").GetComponent<PauseManager>();
        p.updateXPbar();
    }
}
