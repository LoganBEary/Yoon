using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Base class for breakable crates
public class CrateBase : MonoBehaviour
{
    // Number of hits needed to break the crate
    protected int hitsToBreak;

    // Current number of hits the crate has taken
    protected int numHits;

    protected float timeSinceLastHit = 0;

    protected Transform player;

    public Image healthBar;

    public GameObject canvas;

    void Start()
    {
        // Initialize the number of hits needed to break with a random number between 3 and 10
        hitsToBreak = Random.Range(2, 4);

        // Initialize the number of hits taken to 0
        numHits = 0;

        player = GameObject.Find("Character").transform;
    }

    //  This function increments the number of hits a crate has taken
    public virtual void takeHit()
    {
        return;
    }
}

