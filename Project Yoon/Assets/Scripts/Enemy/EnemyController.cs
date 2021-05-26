using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    [Header("References")]
    [Tooltip("Game layer in which the player resides")]
    public LayerMask p_layerMask; // Used in physics.checkSphere as layermask to determine distance from enemy to player
    public Transform coinPrefab; // Used to spawn a random number of coins on death
    public EnemyAttack attackScript;
    public Image enemyHealthBar;
    public GameObject healthBarUI;
    public Animator anim;
    public MainPlayerController playerController;
    public int enemyID;
    // Reference to the player gameobject's transform component
    private Transform p_transform;

    // Attack/Damage system variables
    [Header("Combat Settings")]
    [Tooltip("Health value greater than zero")]
    public float maxHealth = 100f;
    public float health;
    [Tooltip("Number of hitpoints of damage the enemy will do to the player")]
    private bool hasAttacked;
    private float a_timer = 0;
    public float attackCooldown;
    public float knockBackFactor;

    [Header("Loot Settings")]
    [Tooltip("The percentage chance that the enemy will drop coins upon death: (must be between 0 and 100)")]
    public float coinDropChance;
    [Tooltip("The minimum amount of coins that an enemy can spawn")]
    public int minCoinDrop;
    [Tooltip("The maximum amount of coins that an enemy can spawn")]
    public int maxCoinDrop;
    public int experience;

    // Used to determine enemy action state
    [Header("Enemy Aggro Settings")]
    public float sightRange; // How far away the enemy can see the player
    public float attackRange; // How far away the enemy can inflict damage to the player
    public bool canSeePlayer, canAttackplayer;

    // Variables used for enemy roam behavior
    [Header("Enemy Movement Settings")]
    public NavMeshAgent navMeshAgent; // Reference to navMeshAgent on the enemy. Used for enemies pathfinding and movement
    public float roamRange; // How far away can the enemy roam from its current position
    public float maxTimeBetweenRoam; // the maximum time between roams
    private float m_timer, timeUntilNextRoam;
    private bool isWalking;
    private Vector3 lookDirection;

    private bool dead;

    public Rigidbody rb;
    public bool knockback;
    public float k_timer = 0;
    public int numDefeated;

    // Start is called before the first frame update
    void Start()
    {
        rb.isKinematic = true;
        p_transform = GameObject.Find("Character").transform;
        timeUntilNextRoam = Random.Range(0, maxTimeBetweenRoam);
        canAttackplayer = false;
        canSeePlayer = false;

        health = maxHealth;
        dead = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(numDefeated > 0)
        {
            playerController.AddCount();
            numDefeated = 0;
        }
        canSeePlayer = Physics.CheckSphere(transform.position, sightRange, p_layerMask);
        canAttackplayer = Physics.CheckSphere(transform.position, attackRange, p_layerMask);

        // Since the enemy is controlled by a navmeshagent, and the knockback functionality needs to override 
        // the navmeshagent movement, we need to make sure the enemy isnt currently being knocked back before
        // trying to set the current enemy behavior

        if (!knockback) // If the enemy is not being knocked back
        {
            // If enemy can see player and can attack
            if (canSeePlayer && canAttackplayer)
            {
                attack(); // call the attack behavior function
            }
            // If enemy can see player but can't attack
            if (canSeePlayer && !canAttackplayer)
            {
                follow(); // call the follow behavior function
                a_timer = 0; // reset attack charge timer
            }
            // If enemy can't see player and can't attack
            if (!canSeePlayer && !canAttackplayer)
            {
                roam(); // call the roam behavior function
                a_timer = 0; // reset attack charge timer
            }

            if (navMeshAgent.velocity.sqrMagnitude >= 0.1f) // if the enemy is moving
            {
                anim.SetBool("Walking", true); // enable the walking animation
            }
            else // if the enemy is not moving
            {
                anim.SetBool("Walking", false); // disable the walking animation
            }
        }
        else // The enemy is being knocked back
        {
            if (k_timer == 0) // if the knockback force hasn't been set yet
            {
                rb.isKinematic = false; // temporarily disable kinematic setting on rigidbody so it can be affected by forces
                navMeshAgent.enabled = false; // temporarily disable navmeshagent

                Vector3 d = transform.position - p_transform.position; // Find vector from player to enemy
                d.Normalize(); // Normalize because we only care about direction

                float k_mag = Random.Range(100, 200) * knockBackFactor; // Create semi-random magnitude for the knockback

                // Use lerp to set the knockback to launch the enemy straigh back and upwards a little
                Vector3 k = Vector3.Lerp(d, transform.up, 0.5f) * k_mag;

                rb.AddForce(k); // Add the force to the rigidbody
                k_timer += Time.deltaTime; // Increment the knockBack timer
            }
            else if (k_timer < .3f) // If the knockback duration is not over
            {
                k_timer += Time.deltaTime; // Increment the knockback timer
            }
            else // If the knockback duration is over
            {
                rb.isKinematic = true; // enable kinematic on the rigidbody so it can't be affected by forces
                navMeshAgent.enabled = true; // enable the navmeshagent
                knockback = false; // disable the enemy's ability to be knocked back
                k_timer = 0; // reset the knockback timer to 0
            }
        }

        updateHealthBar();

        if (health <= 0 && !dead)
        {
            if(enemyID == 1)
               numDefeated++;

            dead = true;
            //Debug.Log("Ded");

            // Call death behavior coroutine
            navMeshAgent.speed = 0;
            attackScript.damage = 0;
            healthBarUI.SetActive(false);
            StartCoroutine(enemyDeath());
        }
    }

    // All enemy death behavior goes in here
    private IEnumerator enemyDeath()
    {
        // Play enemy death animation
        anim.SetTrigger("Death");
        // Let the animation play exactly once
        yield return new WaitForSeconds(1f);

        // wait for animation to finish

        // Determine if this enemy will drop coins
        if (Random.Range(0, 100) <= coinDropChance)
        {
            // Determine the number of coins to be dropped
            int numCoins = Random.Range(minCoinDrop, maxCoinDrop);

            for (int i = 0; i < numCoins; i++)
            {
                // Find a random position near the enemy to drop the coin
                Vector3 randPosition = transform.position + (Vector3.right * Random.Range(-.5f, .5f)) + (Vector3.forward * Random.Range(-.5f, .5f));

                // Spawn the coin in the correct position
                Instantiate(coinPrefab, randPosition, transform.rotation);
            }
        }

        // Give the player experience
        if (dead)
        {
            GameManager.gameManager.addXP(experience);
            if (gameObject.layer == 11)
            {
                gameObject.GetComponent<EnemyQuest>().onDeath();
                Destroy(gameObject);
            }
            //dead = false;
        }

        // Destroy enemy
        Destroy(gameObject);
        yield return null;
    }

    private void updateHealthBar()
    {
        Vector3 d = p_transform.position - transform.position;

        if (d.sqrMagnitude <= (sightRange * sightRange))
        {
            // This is a really complicated way of updating the health bar. It could be made a lot
            // cleaner by using fill size, but at least it works
            healthBarUI.SetActive(true);
            float x = Mathf.Lerp(0, 0.3f, health / maxHealth);
            enemyHealthBar.GetComponent<RectTransform>().sizeDelta = (Vector2.right * x) + (Vector2.up * 0.05f);
        }
        else
        {
            healthBarUI.SetActive(false);
        }

    }

    // This coroutine is used to reset the enemies attack after 'attackCooldown' seconds
    private IEnumerator resetAttack()
    {
        // Wait for the attackCooldown to finish
        yield return new WaitForSeconds(attackCooldown);

        // Set hasAttacked to false so the enemy can attack
        hasAttacked = false;
    }

    // This function makes the enemy attack the player
    private void attack()
    {
        // Set the destination to the enemies current position so it doesnt move
        navMeshAgent.destination = transform.position;

        // Make sure enemy is always looking at player so player can't attack enemy from behind, since enemy can't deal
        // damage to the player if the player is behind the enemy
        lookDirection.x = p_transform.position.x;
        lookDirection.y = transform.position.y;
        lookDirection.z = p_transform.position.z;
        transform.LookAt(lookDirection);

        // If enemy hasnt already attacked then attack
        if (!hasAttacked)
        {
            // Enemy must wait .2 seconds before every attack. Gives the player a chance to 'dodge'

            if (a_timer <= .2f) // if the enemy attack has not 'charged'
            {
                a_timer += Time.deltaTime; // Increment the timer
            }
            else // The attack is charged and the enemy will now attack
            {
                // Call attackScript.attack() which is set up to call the correct attack function for each enemy
                attackScript.attack();

                // Set hasAttacked to true so the enemy doesnt attack once per frame
                hasAttacked = true;

                // Start the resetAttack coroutine to make the enemy attack again after the attack cooldown
                StartCoroutine(resetAttack());

                a_timer = 0; // Reset the attack charge timer
            }
        }
        return;
    }

    // This function makes the enemy follow the player
    private void follow()
    {
        navMeshAgent.destination = p_transform.position;
    }

    // This function finds a random destination for the enemy to roam to
    private void findDest()
    {
        // Use Random.Range to find random x,y components of destination
        float x = Random.Range(-roamRange, roamRange);
        float z = Random.Range(-roamRange, roamRange);

        // Create new destination vector
        Vector3 dest = (Vector3.right * x) + (Vector3.forward * z) + transform.position;

        // Assign walking to true
        isWalking = true;
        // Set the NavMeshAgent destination to make enemy walk
        navMeshAgent.destination = dest;
    }

    // This function determines the enemy's roaming patterns
    private void roam()
    {
        // If the enemy is not currently walking, call function to set new destination
        if (!isWalking)
        {
            findDest();
        }

        // If the enemy is currently walking
        if (isWalking)
        {
            // Check the enemy's distance from the destination
            if (navMeshAgent.remainingDistance <= navMeshAgent.stoppingDistance) // If the enemy has reached the destination
            {
                // Increment timer each time function is called
                m_timer += Time.deltaTime;

                if (m_timer >= timeUntilNextRoam) // If roam cooldown is finished
                {
                    isWalking = false; // Assign walking to false
                    m_timer = 0; // Reset timer
                    timeUntilNextRoam = Random.Range(0, maxTimeBetweenRoam); // Generate new random roam cooldown
                }
                
            }
        }
    }

    public void takeDamage(float damage)
    {
        // Play take damage animation here

        // Enable the enemy to be knocked back
        knockback = true;

        // Decrement health
        health -= damage;
    }
}
