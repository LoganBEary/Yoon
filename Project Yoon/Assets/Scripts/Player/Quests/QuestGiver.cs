using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[System.Serializable]
public class QuestGiver : MonoBehaviour
{
    public GeneralQuest quest;
    public MainPlayerController player;
    public GameObject questUI;
    public TextMeshProUGUI titleTxt;
    public TextMeshProUGUI descriptionTxt;
    public TextMeshProUGUI expText;
    public TextMeshProUGUI yoonTxt;
    public PauseManager pauseM;

    private GameObject crosshairs;


    private void Start()
    {
        crosshairs = GameObject.FindGameObjectWithTag("CrossHairs");
        OpenQuestUI();
    }
    // public int questNum;

    public void OpenQuestUI()
    {
        questUI.SetActive(true);
        titleTxt.text = quest.title;
        descriptionTxt.text = quest.description;
        expText.text = quest.expRewarded.ToString();
        yoonTxt.text = quest.yoodlesRewarded.ToString();
    }

    public void AcceptQuest()
    {
        questUI.SetActive(false);
        quest.isActive = true;
        player.quest = quest;
        // player.quest[questNum] = quest;
    }
}
