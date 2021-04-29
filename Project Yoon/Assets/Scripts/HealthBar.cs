using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    private Image TheHealthBar;
    private float CurrentHealth;
    private float MaxHealth;
    public MainPlayerController Player;
    // Start is called before the first frame update
    void Start()
    {
        TheHealthBar = GetComponent<Image>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        CurrentHealth = Player.Health;
        TheHealthBar.fillAmount = CurrentHealth/100;
        if(CurrentHealth <= 0)
            Application.Quit();
    }
}
