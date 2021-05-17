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

    public float damage = 20f;

    [SerializeField]
    private float gravityVal = -9.81f;
    public float Health = 100f;
    private Rigidbody rb;
    private float movementX;
    private float movementY;
    public int CoinCount;
    private InputManager inputManager;
    private Transform cameraTransform;
    private EnemyController enemyClose;
    private GameObject weapon;

    public AudioSource weaponSound;
    private Animation weaponAnimation;
    public PauseManager pauseManager;
    private EnemyHealth goblinHealth;
    public HealthBar PlayerHealthBar;

    private BreakableCrate crate;

    void SetCountText()
	{
            countText.text = "Yoodles: " + CoinCount.ToString();
    }
    // Start is called before the first frame update
    void Start()
    {
        enemyClose = GetComponent<EnemyController>();
        controller = GetComponent<CharacterController>();
        inputManager = InputManager.Instance;
        cameraTransform = Camera.main.transform;
        Health = GameManager.gameManager.curHealth;
        CoinCount = GameManager.gameManager.yoodles;
        SetCountText();
        //weapon = GameObject.FindGameObjectWithTag("WeaponEquiped");

        updateWeapon(); // Make a call to updateWeapon to assign the 'weapon' gameobject correctly
    }

    // This function is called whenever the player switches their equipped weapon. 
    public void updateWeapon()
    {
        // Retrieve the equipped weapon gameobject from the weaponHolder script. This will allow the player
        // to be able to still attack with the new weapon
        weapon = GameObject.Find("WeaponHolder").GetComponent<WeaponHolder>().selectedWeaponObject;

        weaponAnimation = weapon.GetComponent<Animation>(); // Update the weaponAnimation
        weaponSound = weapon.GetComponent<AudioSource>(); // Update the audioSource
    }


    void Update()
    {
        //Debug.Log(Health);
        if (transform.position.y <= -5)
        {
            pauseManager.reloadScene();
        }
        if(Health <= 0)
        {
            pauseManager.gameOver();
        }
        if (controller.enabled)
        {
            groundedPlayer = controller.isGrounded;
        }
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

    public void OnFire()
    {
        if (!pauseManager.paused && !pauseManager.inInventory)
        {
            //Debug.Log("Attack!");
            Attack();
        }

    }

    public void addYoodles(int yoodles)
    {
        CoinCount += yoodles;
        SetCountText();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            other.gameObject.SetActive(false);
            addYoodles(1);
        }
        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("enemy");
            enemyClose = other.GetComponent<EnemyController>();
        }
        if (other.gameObject.tag == "BreakableObject")
        {
            crate = other.gameObject.GetComponent<BreakableCrate>();
        }
    }

    public void Attack()
    {
       // Debug.Log("In Attack");
        // Not final design - Work in progress for POC
       weaponAnimation.Play("Sword02");
       weaponSound.Play();
       if(enemyClose)
           if(enemyClose.canAttackplayer)
            {
                enemyClose.takeDamage(damage);
            }

       // Separate takehit function for crates so that breaking them is independent of the player's damage. 
       // This can be modified later if needed
       if (crate)
        {
            crate.takeHit();
        }
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

    public void OnSceneChange()
    {
        GameManager.gameManager.curHealth = Health;
        GameManager.gameManager.yoodles = CoinCount;
    }
}