using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalBoss : MonoBehaviour
{
    public GameObject quest;
    public PauseManager pauseM;

    public MainPlayerController player;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (player.currentQuest == 5)
            {
                pauseM.GetComponent<PauseManager>().OnPause();
                quest.GetComponent<QuestGiver>().OpenQuestUI();
                player.currentQuest++;
            }
        }
    }
}