using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyQuest : MonoBehaviour
{
    public string questName;

    public void onDeath()
    {
        GameManager.gameManager.notifyEvent(questName);
        return;
    }
}
