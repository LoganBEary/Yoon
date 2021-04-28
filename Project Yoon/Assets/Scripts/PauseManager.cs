using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public bool paused;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnPause()
    {
        togglePause();
    }

    private void togglePause()
    {
        if (paused)
        {
            resume();
        }
        else
        {
            Time.timeScale = 0;
            pauseMenuUI.SetActive(true);
            paused = true;
        }
    }

    public void resume()
    {
        Time.timeScale = 1;
        pauseMenuUI.SetActive(false);
        paused = false;
    }
}
