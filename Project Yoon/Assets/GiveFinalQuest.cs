using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveFinalQuest : MonoBehaviour
{
    public MainPlayerController player;
    public PauseManager Pause;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && player.currentQuest == 4)
        {
            Pause.OnPause();
            GetComponent<SetQuestReward>().SetReward();
        }
    }
}
