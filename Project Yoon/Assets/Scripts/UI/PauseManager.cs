using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    // Follows singleton pattern. Only 1 instance of the pause manager throughout the entire game
    // public static PauseManager pauseManagerInstance;
    private GameObject crosshairs;
    public GameObject pauseMenuUI;
    public GameObject settingsMenuUI;
    public GameObject gameOverMenuUI;
    public GameObject inventoryMenuUI;

    public bool paused;
    public bool inInventory;
    public bool inSettings;

    public bool crosshairOn;

    private float timeScale;
    
    /* This code will be used to maintain pauseManager singleton throughout scene changes. For now it is not
     * needed since the only working scene that uses pause manager is the POC

    private void Awake()
    {
        if (pauseManagerInstance == null)
        {
            DontDestroyOnLoad(gameObject);
            pauseManagerInstance = this;
        }
        else if (pauseManagerInstance != this)
        {
            Destroy(gameObject);
        }
    }
    */

    void Start()
    {
        crosshairs = GameObject.FindGameObjectWithTag("CrossHairs");
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        timeScale = 1;
        crosshairOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = timeScale;
    }

    // ==================================================== Helper Functions ======================================================
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

    private void hideCrosshairs()
    {
        if (crosshairOn)
        {
            crosshairs.SetActive(false);
        }
    }

    private void showCrosshairs()
    {
        if (crosshairOn)
        {
            crosshairs.SetActive(true);
        }
    }

    // ==================================================== Pause Menu Functions ======================================================

    public void OnPause()
    {
        togglePause();
    }

    private void togglePause()
    {
        Debug.Log("TOGGLEPAUSE");
        if (!inInventory && !inSettings)
        {
            if (paused)
            {
                resumeGame();
                //showCrosshairs();
            }
            else
            {
                showMouse();
                hideCrosshairs();
                timeScale = 0;
                pauseMenuUI.SetActive(true);
                paused = true;
            }
        }
    }

    public void resumeGame()
    {
        hideMouse();
        timeScale = 1;
        pauseMenuUI.SetActive(false);
        inventoryMenuUI.SetActive(false);
        paused = false;
        inInventory = false;
        showCrosshairs();
    }

    public void loadMainMenu()
    {
        timeScale = 1;
        SceneManager.LoadScene(0);
    }

    // ==================================================== Settings Menu Functions ======================================================
    public void gotoSettingsButton()
    {
        pauseMenuUI.SetActive(false);
        settingsMenuUI.SetActive(true);
        inSettings = true;
    }

    public void settingsBackButton()
    {
        settingsMenuUI.SetActive(false);
        pauseMenuUI.SetActive(true);
        inSettings = false;
        
    }

    public void toggleCrosshairButton(bool value)
    {
        //
        Debug.Log(value);
        if (value)
        {
            crosshairOn = true;
        }
        else
        {
            crosshairOn = false;
            crosshairs.SetActive(false);
        }
    }

    // ==================================================== Inventory Menu Functions ======================================================

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
                showCrosshairs();
                timeScale = 1;
                inventoryMenuUI.SetActive(false);
                inInventory = false;
            }
            else
            {
                showMouse();
                hideCrosshairs();
                timeScale = 0;
                inventoryMenuUI.SetActive(true);
                inInventory = true;
            }
        }
    }


    // ==================================================== Game Over Menu Functions ======================================================
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

    // ==================================================== Change Scene Functions ======================================================

    public void gotoScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
