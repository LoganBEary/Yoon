using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyQuest : MonoBehaviour
{
    public string questName;
    public TextMeshProUGUI questText;

    public void onDeath()
    {
        GameManager.gameManager.notifyEvent(questName);
        questText.enabled = false;
        return;
    }
}
