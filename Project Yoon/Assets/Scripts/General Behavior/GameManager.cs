using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;

    public float curHealth;
    public int yoodles;
    public List<Item> itemList = new List<Item>();
    public List<float> statsList = new List<float>(); // [MaxHealth, damage, defense, magic]

    public string previousScene;
    public string currentScene;

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
}
