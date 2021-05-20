using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnergyBar : MonoBehaviour
{
    public Image energy;
    private float currentEnergy;
    public float maxEnergy = 100.0f;
    public MainPlayerController Player;
    //private float waitTime = 4f;
    public bool Regenerating;
    public IEnumerator coroutine;
    public int regenDelay;
    // Start is called before the first frame update
void Update()
    {
        currentEnergy = Player.Energy;
        energy.fillAmount = currentEnergy/ maxEnergy;
        if(currentEnergy < maxEnergy && !Regenerating)
        {
            coroutine = RegainEnergy();
            StartCoroutine(coroutine);
        }
    }

    private IEnumerator RegainEnergy()
    {
        Regenerating = true;
        yield return new WaitForSeconds(regenDelay);
        while (currentEnergy < maxEnergy)
        {
            AddEnergy();
            yield return new WaitForSeconds(0.09f);
        }
            Regenerating = false;
    }

    public void AddEnergy()
    {
        Player.Energy+= 0.5f;
    }
}
