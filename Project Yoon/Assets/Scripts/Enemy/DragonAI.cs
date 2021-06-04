using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonAI : EnemyController
{

    public float timeSinceLastHit = 0;

    private int moveType = 0;

    public Vector3 distToPlayer;

    public override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        canSeePlayer = Physics.CheckSphere(transform.position, sightRange, p_layerMask);
        canAttackplayer = Physics.CheckSphere(transform.position, attackRange, p_layerMask);

        // Since the enemy is controlled by a navmeshagent, and the knockback functionality needs to override 
        // the navmeshagent movement, we need to make sure the enemy isnt currently being knocked back before
        // trying to set the current enemy behavior

        // If enemy can see player and can attack
        if (canSeePlayer && canAttackplayer)
        {
            navMeshAgent.enabled = false;
            Attack(); // call the attack behavior function
        }
        // If enemy can see player but can't attack
        if (canSeePlayer && !canAttackplayer)
        {
            navMeshAgent.enabled = true;
            Follow(); // call the follow behavior function
            a_timer = 0; // reset attack charge timer
        }
        // If enemy can't see player and can't attack
        if (!canSeePlayer && !canAttackplayer)
        {
            navMeshAgent.enabled = true;
            moveType = 0;
            Roam(); // call the roam behavior function
            a_timer = 0; // reset attack charge timer
        }

        if (navMeshAgent.velocity.sqrMagnitude >= 0.1f) // if the enemy is moving
        {
            setMovementAnimation(moveType); // enable the walking animation
        }
        else // if the enemy is not moving
        {
            anim.SetBool("Walking", false); // disable the walking animation
        }

        updateHealthBar();
        timeSinceLastHit += Time.deltaTime;

        if (health <= 0 && !dead)
        {
            if (enemyID == 1)
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
            GetComponent<GameOverScript>().GameOver();
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

    private void FixedUpdate()
    {
        if (canAttackplayer && canSeePlayer)
        {
            lookDirection.x = p_transform.position.x;
            lookDirection.y = transform.position.y;
            lookDirection.z = p_transform.position.z;
            transform.LookAt(lookDirection);
        }

        distToPlayer = p_transform.position - transform.position;
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

    private IEnumerator resetAttack()
    {
        // Wait for the attackCooldown to finish
        yield return new WaitForSeconds(attackCooldown);

        // Set hasAttacked to false so the enemy can attack
        hasAttacked = false;
    }

    private IEnumerator dragonAttack(int type)
    {
        switch (type)
        {
            case 0:
                anim.SetTrigger("Basic Attack");
                yield return new WaitForSeconds(.75f);
                if (timeSinceLastHit <= .75)
                {
                    // If the player hit the dragon while the dragon was charging the bite attack
                    // then there will be a 25% chance that the dragon's attack is cancelled 
                    int attackCancelChance = Random.Range(0, 100);

                    if (attackCancelChance < 25)
                    {
                        // Reset attack cooldown, so dragon can try to attack again after <attackCooldown> seconds
                        StartCoroutine(resetAttack());
                        // Exit the coroutine so attackScript.Attack() is not called
                        yield break;
                    }
                }
                // Call attackScript.attack() which is set up to call the correct attack function for each enemy
                attackScript.attack();
                // Start the resetAttack coroutine to make the enemy attack again after the attack cooldown
                StartCoroutine(resetAttack());
                break;
            default:
                break;
        }
        yield return null;
    }

    public override void Attack()
    {
        // Set the destination to the enemies current position so it doesnt move
        //navMeshAgent.destination = transform.position;

        // Make sure enemy is always looking at player so player can't attack enemy from behind, since enemy can't deal
        // damage to the player if the player is behind the enemy

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
                StartCoroutine(dragonAttack(0));

                // Set hasAttacked to true so the enemy doesnt attack once per frame
                hasAttacked = true;


                a_timer = 0; // Reset the attack charge timer
            }
        }
        return;
    }

    private void setMovementAnimation(int type)
    {
        if (type == 1)
        {
            navMeshAgent.speed = 6.5f;
            anim.SetBool("Running", true);
            anim.SetBool("Walking", false);
        }
        else
        {
            navMeshAgent.speed = 3.5f;
            anim.SetBool("Walking", true);
            anim.SetBool("Running", false);
        }
    }

    public override void Follow()
    {
        navMeshAgent.destination = p_transform.position;

        if (distToPlayer.sqrMagnitude >= 25)
        {
            moveType = 1;
        }
        else
        {
            moveType = 0;
        }     
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

    public override void Roam()
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

    public override void takeDamage(float damage)
    {
        // Play animation here
        anim.SetTrigger("Get Hit");


        // Decrement health
        health -= damage;

        timeSinceLastHit = 0;
    }
}
