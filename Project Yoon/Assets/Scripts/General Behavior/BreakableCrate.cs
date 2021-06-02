using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BreakableCrate : CrateBase
{
    // Percentage chance that the crate will drop coins when broken
    public float coinDropChance = 40;

    public int minCoins;
    public int maxCoins;

    // Reference to the coin prefab
    public Transform coinPrefab;

    public void Awake()
    {
        canvas.SetActive(false);

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

    //  This function increments the number of hits a crate has taken
    public override void takeHit()
    {
        //canvas.SetActive(true);
        // Increment number of hits taken
        numHits++;

        float amount = (float)numHits / hitsToBreak;
        healthBar.fillAmount =  1f - amount;

        // If the number of hits equals the number of hits needed to break
        if (numHits == hitsToBreak)
        {
            // Start the coroutine for destroying the crate object
            StartCoroutine(breakCrate());
        }

        timeSinceLastHit = 0;
        //StartCoroutine(hideHealthBar());

    }

    private IEnumerator hideHealthBar()
    {
        yield return new WaitForSeconds(3f);
        canvas.SetActive(false);
    }

    // This function defines the behavior of the crate when broken
    private IEnumerator breakCrate()
    {
        // crate break animation

        // Deternime if this crate will drop coins
        if (Random.Range(0, 100) <= coinDropChance)
        {
            // Determine the number of coins to be spawned
            int numCoins = Random.Range(minCoins, maxCoins);

            for (int i = 0; i < numCoins; i++)
            {
                // Find a random position near the crate to spawn the coin
                Vector3 randPosition = transform.position + (Vector3.right * Random.Range(-.1f, .1f)) + (Vector3.forward * Random.Range(-.1f, .1f));

                // Spawn the coin
                Instantiate(coinPrefab, randPosition, transform.rotation);
            }
        }

        // Destroy the crate
        Destroy(gameObject);
        yield return null;
    }
}
