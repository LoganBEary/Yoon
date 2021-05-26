using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class SetQuestUI : MonoBehaviour
{
    public GeneralQuest quest1;
    public GeneralQuest quest2;

    public TextMeshProUGUI Quest1Title;
    public TextMeshProUGUI Quest1Desc;
    public TextMeshProUGUI Quest2Title;
    public TextMeshProUGUI Quest2Desc;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        Quest1Title.text = quest1.title;
        Quest1Desc.text = quest1.description;
        Quest2Title.text = quest2.title;
        Quest2Desc.text = quest2.description;
    }
}
