using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuestObserver : MonoBehaviour
{
    public MainPlayerController playerController;
    public GameObject questCompletedMenuUI;
    public PauseManager PauseM;
    public GameObject QuestMenuUI;
    public GameObject Quest1;
    public GameObject Quest2;
    public GameObject Quest3;
    public GameObject Quest4;
    private int numOfDefeated;
    public GeneralQuest Q1;
    public GeneralQuest Q2;
    public GeneralQuest Q3;
    public GeneralQuest Q4;
    private bool set = false;

    // Start is called before the first frame update
    // Update is called once per frame
    public void Start()
    {

    }
    void Update()
    {
        // if firstQuest is done activate second quest
        if (playerController.currentQuest == 1)
        {
            Q1.isComplete = true;
            Quest1.SetActive(true);
            Quest1.GetComponent<TextMeshProUGUI>().text = Q1.title;
            Quest1.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = Q1.description;

        }
        if(playerController.currentQuest == 2)
        { 
            var obj = GameObject.FindGameObjectWithTag("OnStart");
            if(obj != null)
                obj.GetComponent<startFirstQuest>().enabled = false;
            Q1.isComplete = true;
            Quest1.GetComponent<TextMeshProUGUI>().text = Q1.title;
            Quest1.SetActive(true);
            Quest1.transform.GetChild(1).GetComponent<Toggle>().isOn = true;
            Quest1.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = Q1.description;
            Quest2.SetActive(true);
            Quest2.GetComponent<TextMeshProUGUI>().text = Q2.title;
            Quest2.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = Q2.description;
            if (playerController.numOfDefeated == 5 && !set)
            {
                numOfDefeated = 0;
                set = true;
                Quest2.transform.GetChild(1).GetComponent<Toggle>().isOn = true;
                PauseM.OnPause();
                QuestComplete(Q2.yoodlesRewarded, Q2.expRewarded);

            }
        }
        if(playerController.currentQuest == 3)
        {
            Q1.isComplete = true;
            Q2.isComplete = true;
            Q3.isActive = true;
            Quest1.SetActive(true);
            Quest1.transform.GetChild(1).GetComponent<Toggle>().isOn = true;
            Quest2.SetActive(true);
            Quest2.transform.GetChild(1).GetComponent<Toggle>().isOn = true;

        }
    }


    public void QuestComplete(int yoon, int exp)
    {
        PauseM.addYoodles(yoon);
        PauseM.addXP(exp);
        TextMeshProUGUI yoodlesText = questCompletedMenuUI.transform.GetChild(2).GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI xpText = questCompletedMenuUI.transform.GetChild(3).GetComponent<TextMeshProUGUI>();

        yoodlesText.text = "+ " + yoon.ToString() + " Yoodles";
        xpText.text = "+ " + exp.ToString() + " XP";
        // Display the Completed Text UI
        questCompletedMenuUI.SetActive(true);
        playerController.currentQuest++;
    }
}
