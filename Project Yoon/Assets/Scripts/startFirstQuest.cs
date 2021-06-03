using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startFirstQuest : MonoBehaviour
{
    public GameObject quest;
    public PauseManager pauseM;
    private GameObject player;
    private bool set;

    private void Start()
    {
        set = false;
        player = GameObject.FindGameObjectWithTag("Player");
    }
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
            if (other.gameObject.CompareTag("Player") && !set)
            {
                    set = true;
                    pauseM.GetComponent<PauseManager>().OnPause();
                    quest.GetComponent<QuestGiver>().OpenQuestUI();
                    player.GetComponent<MainPlayerController>().currentQuest++;
                    GetComponent<Collider>().enabled = false;
            }
    }
}
