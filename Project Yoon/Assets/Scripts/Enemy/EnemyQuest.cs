using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyQuest : MonoBehaviour
{
    public GeneralQuest Q3;
    public GameObject Quest4Offer;
    public MainPlayerController player;
    public PauseManager pauseM;
    public IEnumerator popUp;

    public void onDeath()
    {
        
            player.KingDefeated = true;
    
    }
}
