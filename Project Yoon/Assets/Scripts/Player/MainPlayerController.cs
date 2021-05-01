using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class MainPlayerController : MonoBehaviour
{
    public TextMeshProUGUI countText;
    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    
    [SerializeField]
    public float speed = 10f;

    [SerializeField]
    private float jumpingHeight = 3.0f;

    [SerializeField]
    private float gravityVal = -9.81f;
    public float Health = 100f;
    private Rigidbody rb;
    private float movementX;
    private float movementY;
    private int CoinCount;
    private InputManager inputManager;
    private Transform cameraTransform;
    private EnemyController enemyClose;
    private GameObject weapon;
    private Animation weaponAnimation;
    public PauseManager pauseManager;
    private EnemyHealth goblinHealth;
    public HealthBar PlayerHealthBar;
    void SetCountText()
	{
            countText.text = "Yoodles: " + CoinCount.ToString();
    }
    // Start is called before the first frame update
    void Start()
    {
        weapon = GameObject.FindGameObjectWithTag("WeaponEquiped");
        weaponAnimation = weapon.GetComponent<Animation>();
        enemyClose = GetComponent<EnemyController>();
        controller = GetComponent<CharacterController>();
        inputManager = InputManager.Instance;
        cameraTransform = Camera.main.transform;
        CoinCount = 0;
        SetCountText();
    }


    void Update()
    {
        //Debug.Log(Health);
        if(Health <= 0)
        {
            pauseManager.gameOver();
        }

        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        Vector2 movement = inputManager.GetPlayerMovement();
        Vector3 move = new Vector3(movement.x, 0.0f, movement.y);
        move = cameraTransform.forward * move.z + cameraTransform.right * move.x;
        controller.Move(move * Time.deltaTime * speed);
        // Changes the height position of the player..
        if (inputManager.PlayerJumpedThisFrame() && groundedPlayer)
        {
            playerVelocity.y += Mathf.Sqrt(jumpingHeight * -3.0f * gravityVal);
        }

        playerVelocity.y += gravityVal * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
    }

    void LateUpdate()
    {
        if(Health <= 0)
        {
            //Time.timeScale = 0;
            //Application.Quit();
        }
    }
    public void OnFire()
    {
        if (!pauseManager.paused && !pauseManager.inInventory)
        {
            //Debug.Log("Attack!");
            Attack();
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            other.gameObject.SetActive(false);
            CoinCount += 1;
            SetCountText();
        }
        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("enemy");
            enemyClose = other.GetComponent<EnemyController>();
        }
    }

    public void Attack()
    {
       // Debug.Log("In Attack");
        // Not final design - Work in progress for POC
       if(enemyClose)
           if(enemyClose.canAttackplayer)
            {
                enemyClose.takeDamage(20f);
            }

        weaponAnimation.Play("Sword02");
        // Maybe have an attack cooldown so the player can only attack <X> times per second?
        // If canAttack:

        // Figure out if looking at enemey:
        // Probably use physics raycast directly foward from player to find enemy. Similar to one of the scripts in haunted jaunt game

        // If raycast found an enemy, damage the enemy:
        // Something along these lines:
        // enemy.getComponent<EnemyController>().takeDamage(20f);
        
        // Reset attack cooldown
        // canAttack = false;
        // StartCoroutine(resetAttack());
    }

    public void takeDamage(float damage)
    {
        if(PlayerHealthBar.Regenerating)
        {
            PlayerHealthBar.StopCoroutine(PlayerHealthBar.coroutine);
            PlayerHealthBar.Regenerating = !PlayerHealthBar.Regenerating;
        }
       Health -= damage;
    }
}