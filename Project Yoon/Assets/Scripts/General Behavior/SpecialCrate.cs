using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpecialCrate : CrateBase
{

    public Transform battleAxeDisplayPrefab;

    private void Start()
    {
        hitsToBreak = Random.Range(5, 10);

        player = GameObject.Find("Character").transform;
    }

    private void FixedUpdate()
    {
        bool playerInRange = (Vector3.SqrMagnitude(player.position - transform.position) < 5);
        if (numHits > 0 && playerInRange && (timeSinceLastHit <= 5))
        {
            canvas.SetActive(true);

        }
        else
        {
            canvas.SetActive(false);
        }

        timeSinceLastHit += Time.deltaTime;
    }

    public override void takeHit()
    {
        Debug.Log("Special Crate hit");
        canvas.SetActive(true);
        // Increment number of hits taken
        numHits++;

        float amount = (float)numHits / hitsToBreak;
        healthBar.fillAmount = 1f - amount;

        // If the number of hits equals the number of hits needed to break
        if (numHits == hitsToBreak)
        {
            Vector3 position = transform.position;
            Instantiate(battleAxeDisplayPrefab, position, transform.rotation);
            Destroy(gameObject);
        }

        timeSinceLastHit = 0;

    }
}
