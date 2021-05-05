using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableCrate : MonoBehaviour
{
    // Number of hits needed to break the crate
    private int hitsToBreak;
    
    // Current number of hits the crate has taken
    private int numHits;

    // Percentage chance that the crate will drop coins when broken
    private float coinDropChance = 40;

    // Reference to the coin prefab
    public Transform coinPrefab;

    void Start()
    {
        // Initialize the number of hits needed to break with a random number between 3 and 10
        hitsToBreak = Random.Range(3, 10);

        // Initialize the number of hits taken to 0
        numHits = 0;
    }

    //  This function increments the number of hits a crate has taken
    public void takeHit()
    {
        // Increment number of hits taken
        numHits++;

        // If the number of hits equals the number of hits needed to break
        if (numHits == hitsToBreak)
        {
            // Start the coroutine for destroying the crate object
            StartCoroutine(breakCrate());
        }
    }

    // This function defines the behavior of the crate when broken
    private IEnumerator breakCrate()
    {
        // crate break animation

        // Deternime if this crate will drop coins
        if (Random.Range(0, 100) <= coinDropChance)
        {
            // Determine the number of coins to be spawned
            int numCoins = Random.Range(1, 3);

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
