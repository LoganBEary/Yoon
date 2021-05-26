using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondQuestScript : MonoBehaviour
{
    public GameObject quest;
    public PauseManager pauseM;

    public MainPlayerController player;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("curr Quest:" + player.currentQuest);
            if(player.currentQuest == 2)
            {
                pauseM.GetComponent<PauseManager>().OnPause();
                quest.GetComponent<QuestGiver>().OpenQuestUI();
                GetComponent<Collider>().enabled = false;
            }
        }
    }
}
