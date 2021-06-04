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
    public GameObject QuestOffer1;
    public GameObject QuestOffer2;
    private bool set;
    //private GameObject GoblinKing;
    // Start is called before the first frame update
    // Update is called once per frame
    public void Start()
    {
        set = false;
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
        if (playerController.currentQuest == 2)
        {
            var obj = GameObject.FindGameObjectWithTag("OnStart");
            if (obj != null)
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
                //QuestComplete(Q2.yoodlesRewarded, Q2.expRewarded);

            }
        }
        if (playerController.currentQuest == 3)
        {
            Q1.isComplete = true;
            Q2.isComplete = true;
            Q3.isActive = true;
            Quest1.SetActive(true);
            Quest1.transform.GetChild(1).GetComponent<Toggle>().isOn = true;
            Quest1.GetComponent<TextMeshProUGUI>().text = Q1.title;
            Quest1.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = Q1.description;
            Quest2.SetActive(true);
            Quest2.GetComponent<TextMeshProUGUI>().text = Q2.title;
            Quest2.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = Q2.description;
            Quest2.transform.GetChild(1).GetComponent<Toggle>().isOn = true;
            Quest3.SetActive(true);
            Quest3.GetComponent<TextMeshProUGUI>().text = Q3.title;
            Quest3.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = Q3.description;

        }

        if (playerController.currentQuest == 4)
        {
            Quest1.SetActive(true);
            Quest1.transform.GetChild(1).GetComponent<Toggle>().isOn = true;
            Quest1.GetComponent<TextMeshProUGUI>().text = Q1.title;
            Quest1.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = Q1.description;
            Quest2.SetActive(true);
            Quest2.GetComponent<TextMeshProUGUI>().text = Q2.title;
            Quest2.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = Q2.description;
            Quest2.transform.GetChild(1).GetComponent<Toggle>().isOn = true;
            Quest3.SetActive(true);
            Quest3.GetComponent<TextMeshProUGUI>().text = Q3.title;
            Quest3.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = Q3.description;
            Quest3.transform.GetChild(1).GetComponent<Toggle>().isOn = true;
            Quest4.SetActive(true);
            Quest4.GetComponent<TextMeshProUGUI>().text = Q4.title;
            Quest4.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = Q4.description;
        }

        if(playerController.currentQuest >= 5)
        {
            Quest1.SetActive(true);
            Quest1.transform.GetChild(1).GetComponent<Toggle>().isOn = true;
            Quest1.GetComponent<TextMeshProUGUI>().text = Q1.title;
            Quest1.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = Q1.description;
            Quest2.SetActive(true);
            Quest2.GetComponent<TextMeshProUGUI>().text = Q2.title;
            Quest2.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = Q2.description;
            Quest2.transform.GetChild(1).GetComponent<Toggle>().isOn = true;
            Quest3.SetActive(true);
            Quest3.GetComponent<TextMeshProUGUI>().text = Q3.title;
            Quest3.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = Q3.description;
            Quest3.transform.GetChild(1).GetComponent<Toggle>().isOn = true;
            Quest4.SetActive(true);
            Quest4.GetComponent<TextMeshProUGUI>().text = Q4.title;
            Quest4.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = Q4.description;
            Quest4.transform.GetChild(1).GetComponent<Toggle>().isOn = true;
        }
    }


    public void QuestComplete(int yoon, int exp)
    {
        PauseM.OnPause();
        PauseM.addYoodles(yoon);
        PauseM.addXP(exp);
        TextMeshProUGUI yoodlesText = questCompletedMenuUI.transform.GetChild(2).GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI xpText = questCompletedMenuUI.transform.GetChild(3).GetComponent<TextMeshProUGUI>();

        yoodlesText.text = "+ " + yoon.ToString() + " Yoodles";
        xpText.text = "+ " + exp.ToString() + " XP";
        // Display the Completed Text UI
        questCompletedMenuUI.SetActive(true);
        playerController.currentQuest++;
        if (playerController.currentQuest == 3)
            Q3.isActive = true;
        if (playerController.currentQuest == 4)
            Q4.isActive = true;
    }

    public void OpenQuestUI(int Q)
    {
        if (Q == 3)
        {
            QuestOffer1.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = Q3.title;
            QuestOffer1.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = Q3.description;
            QuestOffer1.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = Q3.yoodlesRewarded.ToString();
            QuestOffer1.transform.GetChild(3).GetComponent<TextMeshProUGUI>().text = Q3.expRewarded.ToString();
            QuestOffer1.SetActive(true);
            Quest3.SetActive(true);
        }
        if (Q == 4)
        {
            QuestOffer2.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = Q4.title;
            QuestOffer2.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = Q4.description;
            QuestOffer2.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = Q4.yoodlesRewarded.ToString();
            QuestOffer2.transform.GetChild(3).GetComponent<TextMeshProUGUI>().text = Q4.expRewarded.ToString();
            QuestOffer2.SetActive(true);
            Quest4.SetActive(true);
        }


    }

    public void AcceptQuest(int Q)
    {
        if (Q == 3)
            QuestOffer1.SetActive(false);
        if (Q == 4)
            QuestOffer2.SetActive(false);
    }
}
