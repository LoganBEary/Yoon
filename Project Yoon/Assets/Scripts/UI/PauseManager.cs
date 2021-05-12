using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class PauseManager : MonoBehaviour
{
    private GameObject crosshairs;
    public GameObject pauseMenuUI;
    public GameObject settingsMenuUI;
    public GameObject gameOverMenuUI;
    public GameObject inventoryMenuUI;
    public GameObject questCompletedMenuUI;
    public GameObject shopMenuUI;

    public Image experienceBar;
    public TextMeshProUGUI playerLevelText;

    public bool paused;
    public bool inInventory;
    public bool inShop;
    public bool inSettings;

    public bool crosshairOn;

    private float timeScale;
    public MainPlayerController player;

    public List<TextMeshProUGUI> statsList;
    public List<float> statVals;

    private void Awake()
    {
        if (GameManager.gameManager != null)
        {
            statVals = GameManager.gameManager.statsList;

            int count = statVals.Count;

            for (int i = 0; i < count; i++)
            {
                statsList[i].text = statVals[i].ToString();
            }
        }
    }

    void Start()
    {
        crosshairs = GameObject.FindGameObjectWithTag("CrossHairs");
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.lockState = CursorLockMode.None;
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = false;
        timeScale = 1;
        crosshairOn = true;
        updateXPbar();
        // updateStat(2, 1200);
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
        if (!inInventory && !inShop && !inSettings)
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
        shopMenuUI.SetActive(false);
        paused = false;
        inInventory = false;
        inShop = false;
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
        // Debug.Log(value);
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

    // Updates the stat at the specified index with the new value
    // EX: health is at index 0 -> updateStat(0, 120)
    public void updateStat(int index, float value)
    {
        // Make sure we are accessing a valid stat/index
        if (index < statsList.Count)
        {
            // Update the text of that stat with the new value
            statsList[index].text = value.ToString();
        }
    }

    public void updateXPbar()
    {
        playerLevelText.text = GameManager.gameManager.playerLevel.ToString();
        float x = GameManager.gameManager.experiencePoints / 500f;
        experienceBar.fillAmount = x;
        return;
    }

    public void plusButton(int index)
    {
        float val = statVals[index] + 1;
        //updateStat(index, val);
        //statVals[index] = val;
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

    // ==================================================== Shop Menu Functions ======================================================
    public void OpenShop()
    {
        toggleShop();
    }

    private void toggleShop()
    {
        if (!paused)
        {
            if (inShop)
            {
                hideMouse();
                showCrosshairs();
                timeScale = 1;
                shopMenuUI.SetActive(false);
                inShop = false;
            }
            else
            {
                showMouse();
                hideCrosshairs();
                timeScale = 0;
                shopMenuUI.SetActive(true);
                inShop = true;
            }
        }
    }

    // ==================================================== Change Scene Functions ======================================================

    public void gotoScene(string scene)
    {
        string curScene = SceneManager.GetActiveScene().name;
        GameManager.gameManager.updateInfo(player.Health, player.CoinCount, Inventory.inventoryInstance.list, statVals, curScene, scene);
        GameManager.gameManager.SaveState();
        SceneManager.LoadScene(scene);
    }

    // ==================================================== Quest Menu Functions ======================================================

    public void CompletedQuest(int coins, int xp)
    {
        // Update coins display and xp display in inventory
        player.addYoodles(coins);

        TextMeshProUGUI yoodlesText = questCompletedMenuUI.transform.GetChild(2).GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI xpText = questCompletedMenuUI.transform.GetChild(3).GetComponent<TextMeshProUGUI>();

        Debug.Log(yoodlesText);
        Debug.Log(xpText);

        yoodlesText.text = "+ " + coins.ToString() + " Yoodles";
        xpText.text = "+ " + xp.ToString() + " XP";


        // Display the Completed Text UI
        StartCoroutine(displayCompletedQuest());
        GameManager.gameManager.xp(xp);
        return;
    }

    public IEnumerator displayCompletedQuest()
    {
        hideCrosshairs();
        questCompletedMenuUI.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        questCompletedMenuUI.SetActive(false);
        showCrosshairs();
    }
}
