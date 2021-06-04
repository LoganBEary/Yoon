using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour
{
    public GameObject GameOverUI;
    public PauseManager pause;
    
    public void GameOver()
    {
        pause.OnPause();
        GameOverUI.SetActive(true);
    }

}
