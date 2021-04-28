using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Script : MonoBehaviour
{
    // Reference to the child of the NPC gameobject that displays text
    public GameObject displayTextCanvas;

    // This function will be called whenever the player presses the "E" key
    public void OnPlayerInteract()
    {
        // Call the displayText coroutine to display the text for 5 seconds
        StartCoroutine(displayText());
    }

    // Coroutine to display the text for 5 seconds
    private IEnumerator displayText()
    {

        // Set displayTextCanvas to active
        displayTextCanvas.SetActive(true);
        yield return new WaitForSeconds(5f);

        // Set displayTextCanvas to inactive
        displayTextCanvas.SetActive(false);
        yield return new WaitForSeconds(5f);
    }
}
