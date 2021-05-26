using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startFirstQuest : MonoBehaviour
{
    public GameObject quest1;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            quest1.GetComponent<QuestGiver>().OpenQuestUI();
            GetComponent<Collider>().enabled = false;
        }
    }
}
