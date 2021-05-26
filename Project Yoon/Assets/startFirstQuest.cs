using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startFirstQuest : MonoBehaviour
{
    public GameObject quest;
    public PauseManager pauseM;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            pauseM.GetComponent<PauseManager>().OnPause();
            quest.GetComponent<QuestGiver>().OpenQuestUI();
            GetComponent<Collider>().enabled = false;
        }
    }
}
