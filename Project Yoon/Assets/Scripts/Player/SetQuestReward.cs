using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class SetQuestReward : MonoBehaviour
{

    public int exp;
    public int yoon;
    public PauseManager PauseM;
    public Toggle QuestToggle;
    public GameObject questCompletedMenuUI;
    public MainPlayerController player;
    

    public void SetReward(){
    // Start is called before the first frame update      PauseM.addXP(exp);
            PauseM.addYoodles(yoon);
            PauseM.addXP(exp);
            TextMeshProUGUI yoodlesText = questCompletedMenuUI.transform.GetChild(2).GetComponent<TextMeshProUGUI>();
            TextMeshProUGUI xpText = questCompletedMenuUI.transform.GetChild(3).GetComponent<TextMeshProUGUI>();

            yoodlesText.text = "+ " + yoon.ToString() + " Yoodles";
            xpText.text = "+ " + exp.ToString() + " XP";
            QuestToggle.isOn = true;
        // Display the Completed Text UI
            questCompletedMenuUI.SetActive(true);
            player.currentQuest++;
        
    }
}
