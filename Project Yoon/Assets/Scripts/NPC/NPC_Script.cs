using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NPC_Script : MonoBehaviour
{
    // Reference to the child of the NPC gameobject that displays text
    float distance;
    public GameObject displayTextCanvas;
    public Text dialogueText;
    public GameObject prompt;
    public GameObject player;
    public float distance_;
    public string[] dialogueLines;
    private float is_interact = 0;

    // This function will be called whenever the player presses the "E" key
    public void OnPlayerInteract(InputAction.CallbackContext context)
    {
        // Call the displayText coroutine to display the text for 5 seconds

        // Not really sure how to explain this. basically if the button call was not already executed
        if (!context.performed)
        {
            // Check if the player has not already interacted and is in range
            if ((is_interact == 0) && (distance_ <= 1.5))
            {
                // Start the display text coroutine
                StartCoroutine(displayText());
            }
        }
    }


    // Coroutine to display the text for 5 seconds
    private IEnumerator displayText()
    {
        // Set interact to 1 so the player can't interact again while the NPC is talking
        is_interact = 1;

        // Set displayTextCanvas to active
        displayTextCanvas.SetActive(true);

        for (int i = 0; i < dialogueLines.Length; i++)
        {
            dialogueText.text = dialogueLines[i];
            dialogueText.enabled = true;
            yield return new WaitForSeconds(3f);
            dialogueText.text = "";
        }

        // Set displayTextCanvas to inactive
        displayTextCanvas.SetActive(false);

        // Set interact to 0 so the player can interact again if they want
        is_interact = 0;
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
                prompt.SetActive(false);
            }
            else // enable the prompt
            {
                prompt.SetActive(true);
            }
        }
        else
        {
            prompt.SetActive(false);
        }
    }

}
