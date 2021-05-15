using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    private Image TheHealthBar;
    private float CurrentHealth;
    public float PlayerMaxHealth = 100.0f;
    public MainPlayerController Player;
    //private float waitTime = 4f;
    public bool Regenerating;
    public IEnumerator coroutine;
    public int regenDelay;
    // Start is called before the first frame update
    void Start()
    {
        TheHealthBar = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        CurrentHealth = Player.Health;
        TheHealthBar.fillAmount = CurrentHealth/ PlayerMaxHealth;
        if(CurrentHealth < PlayerMaxHealth && !Regenerating)
        {    
            coroutine = RegainHealth();
            StartCoroutine(coroutine);
        }
    }

    private IEnumerator RegainHealth()
    {
        Regenerating = true;
        yield return new WaitForSeconds(regenDelay);
        while (CurrentHealth < PlayerMaxHealth)
        {
           AddHealth();
           yield return new WaitForSeconds(1);
        }
            Regenerating = false;
    }

    public void AddHealth()
    {
        Player.Health += 1.5f;
    }
}
