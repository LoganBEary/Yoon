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
    public GameObject questText;
    public Image experienceBar;
    public TextMeshProUGUI playerLevelText;

    public GameObject cheatMenuUI;

    public bool paused;
    public bool inInventory;
    public bool inShop;
    public bool inSettings;
    public bool inCheatMenu;

    public bool crosshairOn;

    private float timeScale;
    public MainPlayerController player;

    public List<TextMeshProUGUI> statsList;
    public List<float> statVals;

    public List<Button> plusButtons;
    public List<bool> plusButtonActive;
    public int upgradePoints;

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

        if (GameManager.gameManager != null)
        {
            statVals = GameManager.gameManager.statsList;

            int count = statVals.Count;

            for (int i = 0; i < count; i++)
            {
                statsList[i].text = statVals[i].ToString();
            }
        }

        upgradePoints = GameManager.gameManager.upgradePoints;

        plusButtonActive = GameManager.gameManager.statMaxedList;
  
        if (upgradePoints > 0)
        {
            setPlusButton(true);
        }
        else
        {
            setPlusButton(false);
        }
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

    // This funtion will add yoodles. Probably would be best to implement with observer to make sure
    // all scripts involved with yoodles get notified easily. But this will have to do for now
    public void addYoodles(int yoodles)
    {
        player.addYoodles(yoodles);
    }

    public void addXP(int xp)
    {
        GameManager.gameManager.addXP(xp);
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
                paused = true;
                questText.SetActive(false);
                showMouse();
                hideCrosshairs();
                timeScale = 0;
                pauseMenuUI.SetActive(true);
            }
        }
    }

    public void resumeGame()
    {
        questText.SetActive(true);
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
                questText.SetActive(true);
                hideMouse();
                showCrosshairs();
                timeScale = 1;
                inventoryMenuUI.SetActive(false);
                inInventory = false;
            }
            else
            {
                inInventory = true;
                questText.SetActive(false);
                showMouse();
                hideCrosshairs();
                timeScale = 0;
                inventoryMenuUI.SetActive(true);
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

    public void setPlusButton(bool state)
    {
        print(state);
        for (int i = 0; i < plusButtons.Count; i++)
        {
            print(plusButtonActive[i]);
            if (plusButtonActive[i])
            {
                plusButtons[i].gameObject.SetActive(state);
            }
        }
    }

    public void levelUp()
    {
        upgradePoints += 1;

        setPlusButton(true);
    }

    public void plusButton(int index)
    {
        float val;
        float add;

        switch (index)
        {
            case 0: // Adding health
                add = 10;
                val = statVals[index] + add;
                updateStat(index, val);
                statVals[index] = val;
                break;
            case 1: // Adding damage
                add = 2;
                val = statVals[index] + add;
                updateStat(index, val);
                statVals[index] = val;

                if (val >= 20) // Max Damage
                {
                    plusButtons[index].gameObject.SetActive(false);
                    plusButtonActive[index] = false;
                }

                break;
            case 2: // Adding defense
                add = 2;
                val = statVals[index] + add;
                updateStat(index, val);
                statVals[index] = val;

                if (val >= 20) // Max Defense
                {
                    plusButtons[index].gameObject.SetActive(false);
                    plusButtonActive[index] = false;
                }

                break;
            default: // Adding magic
                add = 5;
                val = statVals[index] + add;
                updateStat(index, val);
                statVals[index] = val;
                break;
        }

        GameManager.gameManager.addStat(index, val, add);

        if (--upgradePoints < 1)
        {
            setPlusButton(false);
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

    public void OnSceneChange()
    {
        GameManager.gameManager.statsList = statVals;
        GameManager.gameManager.itemList = Inventory.inventoryInstance.list;
        GameManager.gameManager.previousScene = SceneManager.GetActiveScene().name;
        GameManager.gameManager.upgradePoints = upgradePoints;
        GameManager.gameManager.statMaxedList = plusButtonActive;
    }

    public void gotoScene(string newScene)
    {
        //string curScene = SceneManager.GetActiveScene().name;
        //GameManager.gameManager.updateInfo(player.Health, player.CoinCount, Inventory.inventoryInstance.list, statVals, curScene, scene);
        GameManager.gameManager.changeSceneSubject.Notify();
        GameManager.gameManager.currentScene = newScene;
        GameManager.gameManager.SaveState();
        SceneManager.LoadScene(newScene);
    }

    // ==================================================== Quest Menu Functions ======================================================

    public void CompletedQuest(int coins, int xp)
    {
        // Update coins display and xp display in inventory
        addYoodles(coins);

        TextMeshProUGUI yoodlesText = questCompletedMenuUI.transform.GetChild(2).GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI xpText = questCompletedMenuUI.transform.GetChild(3).GetComponent<TextMeshProUGUI>();

        yoodlesText.text = "+ " + coins.ToString() + " Yoodles";
        xpText.text = "+ " + xp.ToString() + " XP";


        // Display the Completed Text UI
        StartCoroutine(displayCompletedQuest());
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

    // ==================================================== Cheat Menu Functions ======================================================

    public void playerInvincibleToggle(bool value)
    {
        Transform t = transform.Find("CheatMenu/CheatMenuBG/AdditionalCheatBG/InvincibleToggle");
        t.gameObject.GetComponent<Toggle>().isOn = value;
        player.isInvincible = value;
    }
    
    public void OnOpenCheatMenu()
    {
        if (!inInventory && !inShop && !inSettings)
        {
            if (inCheatMenu)
            {
                questText.SetActive(false);
                timeScale = 1;
                hideMouse();
                showCrosshairs();
                cheatMenuUI.SetActive(false);
                inCheatMenu = false;
            }
            else
            {
                inCheatMenu = true;
                questText.SetActive(false);
                showMouse();
                hideCrosshairs();
                timeScale = 0;
                cheatMenuUI.SetActive(true);
            }
        }
        return;
    }
}
