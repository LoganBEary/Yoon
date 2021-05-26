using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuestObserver : MonoBehaviour
{
    public MainPlayerController playerController;

    public PauseManager PauseM;
    public GameObject Quest2Display;
    public int numOfDefeated;

    public Toggle QuestToggle;
    public GameObject questCompletedMenuUI;
    // Start is called before the first frame update
    
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
                playerController.quest.isActive = false;
                playerController.quest.isComplete = true;
                QuestToggle.isOn = true;
                playerController.currentQuest = 3;
                QuestComplete(playerController.quest.yoodlesRewarded, playerController.quest.expRewarded);
        }
        /*if(playerController.currentQuest >= 2)
        {
            if(playerController.quest.isComplete)
            {

            }
   }*/
    }
    public void QuestComplete(int yoon, int exp)
    {
            PauseM.addXP(exp);
            PauseM.addYoodles(yoon);

            TextMeshProUGUI yoodlesText = questCompletedMenuUI.transform.GetChild(2).GetComponent<TextMeshProUGUI>();
            TextMeshProUGUI xpText = questCompletedMenuUI.transform.GetChild(3).GetComponent<TextMeshProUGUI>();

            yoodlesText.text = "+ " + yoon.ToString() + " Yoodles";
            xpText.text = "+ " + exp.ToString() + " XP";
        // Display the Completed Text UI
            questCompletedMenuUI.SetActive(true);
        return;
     }
}
