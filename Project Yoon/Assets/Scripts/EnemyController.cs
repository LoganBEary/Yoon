using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    [Header("References")]
    [Tooltip("Game layer in which the player resides")]
    public LayerMask p_layerMask;
    private Transform p_transform;

    // Attack/Damage system variables
    [Header("Combat Settings")]
    [Tooltip("Health value greater than zero")]
    public float health = 100f;
    [Tooltip("Number of hitpoints of damage the enemy will do to the player")]
    public float damage;
    private bool hasAttacked;
    public float attackCooldown;
    public Transform fireball;

    // Used to determine enemy action state
    [Header("Enemy Aggro Settings")]
    public float sightRange;
    public float attackRange;
    public bool canSeePlayer, canAttackplayer;

    // Variables used for enemy roam behavior
    [Header("Enemy Movement Settings")]
    public NavMeshAgent navMeshAgent;
    public float roamRange;
    public float maxTimeBetweenRoam;
    private float m_timer, timeUntilNextRoam;
    private bool isWalking;
    private MainPlayerController player;

    // Start is called before the first frame update
    void Start()
    {
        p_transform = GameObject.Find("Character").transform;
        timeUntilNextRoam = Random.Range(0, maxTimeBetweenRoam);
        player = FindObjectOfType<MainPlayerController>();
        canAttackplayer = false;
        canSeePlayer = false;
    }

    // Update is called once per frame
    void Update()
    {
        canSeePlayer = Physics.CheckSphere(transform.position, sightRange, p_layerMask);
        canAttackplayer = Physics.CheckSphere(transform.position, attackRange, p_layerMask);

        if (canSeePlayer && canAttackplayer)
        {
            attack();
        }
        if (canSeePlayer && !canAttackplayer)
        {
            follow();
        }
        if (!canSeePlayer && !canAttackplayer)
        {
            roam();
        }

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    private IEnumerator resetAttack()
    {
        yield return new WaitForSeconds(attackCooldown);
        hasAttacked = false;
    }

    private void attack()
    {
        navMeshAgent.destination = transform.position;

        if (!hasAttacked)
        {
            Transform f = Instantiate(fireball, transform.position, transform.rotation);
            f.GetComponent<Rigidbody>().velocity = (player.transform.position - transform.position);
            player.Health -= damage;
            hasAttacked = true;
            StartCoroutine(resetAttack());
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
        Vector3 dest = (Vector3.right * x) + (Vector3.forward * z);

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
        health -= damage;
    }
}
