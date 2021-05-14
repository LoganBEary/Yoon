using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;
using UnityEngine.UI;

public class NPC_Merchant : MonoBehaviour
{
    public GameObject player;
    public float distance_;
    public PauseManager pauseManager;
    public float is_interact = 0;

    public void OnPlayerInteract()
    {
        if (!pauseManager.inShop && distance_ <= 1.5)
        {
            is_interact = 1;
        }
    }

    private void FixedUpdate()
    {
        // Calculate the distance from the player to the NPC
        distance_ = Vector3.Distance(player.transform.position, transform.position);

        // If the player is close enough
        if (distance_ <= 1.5)
        {
            // If the player has interacted, disable the prompt
            if (is_interact == 1)
            {
                pauseManager.OpenShop();
                is_interact = 0;
            }
        }
    }
}
