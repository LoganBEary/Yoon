using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    // Determines the amount of damage the enemy does to the player
    public float damage;
    
    // Reference to the player's transform
    public Transform player;

    // Reference to the projectile prefab that the enemy will instantiate everytime it attacks if it is a ranged enemy
    public Transform projectile;

    // Determines which attack the enemy will use. 0 for long range, 1 for close range
    public int attackType;

    // This function defines how a long range enemy will attack
    private void longRangeAttack()
    {
        // Maybe in the future, call a coroutine right here to add a charge time for charged attack such as wizard fireball

        // Instantiate a projectile
        Transform p = Instantiate(projectile, transform.position, transform.rotation);

        // Set the projectile damage for when it makes contact with the player
        p.GetComponent<Projectile>().damage = damage;
    }

    // This function defines how a close range enemy will attack
    private void closeAttack()
    {
        // Send raycast to determine if player still in range
        Ray ray = new Ray(transform.position, transform.forward);

        RaycastHit raycastHit;

        if (Physics.Raycast(ray, out raycastHit))
        {
            if (raycastHit.transform == player) // If player still in range
            {
                // Play attack animation here

                // Deal damage to the player
                player.GetComponent<MainPlayerController>().takeDamage(damage);
            }
        }
    }

    public void attack()
    {
        // call the correct attack function based on the enemy type
        switch (attackType)
        {
            case 0: longRangeAttack(); break;
            case 1: closeAttack(); break;
        }
    }
}
