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
    public void OnPlayerInteract(InputValue val)
    {
        // Call the displayText coroutine to display the text for 5 seconds
        is_interact = val.Get<float>();
    }

    
    // Coroutine to display the text for 5 seconds
    private IEnumerator displayText()
    {
        // Set displayTextCanvas to active
        displayTextCanvas.SetActive(true);
        
        for(int i = 0; i < dialogueLines.Length; i++)
        {
            dialogueText.text = dialogueLines[i];
            dialogueText.enabled = true;
            yield return new WaitForSeconds(3f);
            dialogueText.text = "";
        }

        // Set displayTextCanvas to inactive
        displayTextCanvas.SetActive(false);
    }

    void FixedUpdate()
    {
        distance_ = Vector3.Distance(player.transform.position, transform.position);
        if(distance_ <= 1.5)
        {
            prompt.SetActive(true);
            if(is_interact == 1)
            {
                prompt.SetActive(false);
                StartCoroutine(displayText());
            }
        }
        else
        {
            prompt.SetActive(false);
            is_interact = 0;
        }
    }
}
