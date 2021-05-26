using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuestObserver : MonoBehaviour
{
    public MainPlayerController playerController;
    public GameObject QuestMenuUI;
    public PauseManager PauseM;
    public GameObject Quest2Display;
    public int numOfDefeated;
    private bool set;

    // Start is called before the first frame update
    private void Start()
    {
        set = false;
    }
    // Update is called once per frame
    void Update()
    {
        // if firstQuest is done activate second quest
        if(playerController.currentQuest == 2)
        {
            if(playerController.quest.isComplete && !PauseM.inShop)
            {
                Quest2Display.SetActive(true);
            }
        }
        if(playerController.numOfDefeated == 5)
        {
            if(!set)
            {
                PauseM.OnPause();
                playerController.quest.isActive = false;
                playerController.quest.isComplete = true;
                set = true;
                playerController.currentQuest = 3;
                QuestMenuUI.GetComponent<SetQuestReward>().SetReward();
                //Possibly set onclick to toggle pausescreen 
            }
        }
        /*if(playerController.currentQuest >= 2)
        {
            if(playerController.quest.isComplete)
            {

            }
   }*/
    }
}
