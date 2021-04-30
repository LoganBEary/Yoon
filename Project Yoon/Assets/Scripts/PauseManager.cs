using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public GameObject settingsMenuUI;
    public GameObject gameOverMenuUI;
    public bool paused;

    private float timeScale;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = timeScale;
    }

    public void OnPause()
    {
        togglePause();
    }

    private void togglePause()
    {
        Debug.Log("TOGGLEPAUSE");
        if (paused)
        {
            resume();
        }
        else
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            timeScale = 0;
            pauseMenuUI.SetActive(true);
            paused = true;
        }
    }

    public void resume()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        timeScale = 1;
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
        timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void gameOver()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        timeScale = 0;
        gameOverMenuUI.SetActive(true);
        paused = true;
    }

    public void reloadScene()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        timeScale = 1;
        gameOverMenuUI.SetActive(false);
        paused = false;

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
