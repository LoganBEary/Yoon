using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public GameObject settingsMenuUI;
    public GameObject gameOverMenuUI;
    public GameObject inventoryMenuUI;

    public bool paused;
    public bool inInventory;

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

    private void showMouse()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    private void hideMouse()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void OnOpenInventory()
    {
        toggleInventory();
    }

    private void toggleInventory()
    {
        if (!paused)
        {
            if (inInventory)
            {
                hideMouse();
                timeScale = 1;
                inventoryMenuUI.SetActive(false);
                inInventory = false;
            }
            else
            {
                showMouse();
                timeScale = 0;
                inventoryMenuUI.SetActive(true);
                inInventory = true;
            }
        }
    }

    private void togglePause()
    {
        Debug.Log("TOGGLEPAUSE");
        if (!inInventory)
        {
            if (paused)
            {
                resume();
            }
            else
            {
                showMouse();
                timeScale = 0;
                pauseMenuUI.SetActive(true);
                paused = true;
            }
        }
    }

    public void resume()
    {
        hideMouse();
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
        showMouse();
        timeScale = 0;
        gameOverMenuUI.SetActive(true);
        paused = true;
    }

    public void reloadScene()
    {
        hideMouse();
        timeScale = 1;
        gameOverMenuUI.SetActive(false);
        paused = false;

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}