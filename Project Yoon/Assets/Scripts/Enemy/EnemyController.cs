using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

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
    public Rigidbody rb;

    // Reference to the player gameobject's transform component
    protected Transform p_transform;

    // Attack/Damage system variables
    [Header("Combat Settings")]
    [Tooltip("Health value greater than zero")]
    public float maxHealth = 100f;
    protected float health;
    protected bool hasAttacked;
    protected float a_timer = 0;
    public float attackCooldown;
    protected Vector3 lookDirection;

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

    protected float m_timer, timeUntilNextRoam;
    protected bool isWalking;

    protected bool dead;

    public int numDefeated;


    // Start is called before the first frame update
    public virtual void Start()
    {

        GameObject p = GameObject.Find("Character");
        p_transform = p.transform;
        playerController = p.GetComponent<MainPlayerController>();
        timeUntilNextRoam = Random.Range(0, maxTimeBetweenRoam);
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
        canAttackplayer = false;
        canSeePlayer = false;

        health = maxHealth;
        dead = false;
    }

    public virtual void Attack()
    {
        return;
    }

    public virtual void Follow()
    {
        return;
    }

    public virtual void Roam()
    {
        return;
    }

    public virtual void takeDamage(float damage)
    {
        return;
    }
}
