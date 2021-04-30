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
    void Update()
    {
        CurrentHealth = Player.Health;
        TheHealthBar.fillAmount = CurrentHealth/100;
    }
}
