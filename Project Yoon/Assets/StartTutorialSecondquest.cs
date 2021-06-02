using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTutorialSecondquest : MonoBehaviour
{
    public MainPlayerController player;
    public PauseManager pauseM;
    public GameObject quest;
    private bool alreadySent;
    // Start is called before the first frame update
    void Start()
    {
        alreadySent = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(player.numOfDefeated == 1 && !alreadySent)
        {
            pauseM.GetComponent<PauseManager>().OnPause();
            quest.GetComponent<QuestGiver>().OpenQuestUI();
            alreadySent = true;
        }
    }
}
