using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;

    public float health;
    public int yoodles;
    public List<Item> itemList = new List<Item>();

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
        health = GameManager.gameManager.health;
        yoodles = GameManager.gameManager.yoodles;
    }

    public void updateInfo(float h, int y, List<Item> i)
    {
        health = h;
        yoodles = y;
        itemList = i;
    }

    public void SaveState()
    {
        GameManager.gameManager.health = health;
        GameManager.gameManager.yoodles = yoodles;
        GameManager.gameManager.itemList = itemList;
    }
}
