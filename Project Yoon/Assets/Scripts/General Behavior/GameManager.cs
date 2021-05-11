using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ObserverPattern;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;

    public float curHealth;
    public int yoodles;
    public List<Item> itemList = new List<Item>();
    public List<float> statsList = new List<float>(); // [MaxHealth, damage, defense, magic]

    public string previousScene;
    public string currentScene;

    Subject firstQuestSubject = new Subject();

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
        UI_Observer quest1_UIObserver = new UI_Observer(new UIQuestBehavior(200, 500));

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
        }
    }
}
