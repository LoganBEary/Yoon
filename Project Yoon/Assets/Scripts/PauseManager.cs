using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public GameObject settingsMenuUI;
    public bool paused;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
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
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0;
            pauseMenuUI.SetActive(true);
            paused = true;
        }
    }

    public void resume()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Time.timeScale = 1;
        pauseMenuUI.SetActive(false);
        paused = false;
    }

    public void gotoSettingsButton()
    {
        pauseMenuUI.SetActive(false);
        settingsMenuUI.SetActive(true);
    }

    public void settingsBackButton()
    {
        settingsMenuUI.SetActive(false);
        pauseMenuUI.SetActive(true);
        
    }

    public void loadMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
