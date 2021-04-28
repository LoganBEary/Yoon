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
            Time.timeScale = 1;
            pauseMenuUI.SetActive(false);
            paused = false;
        }
        else
        {
            resume();
        }
    }

    public void resume()
    {
        Time.timeScale = 0;
        pauseMenuUI.SetActive(true);
        paused = true;
    }
}
