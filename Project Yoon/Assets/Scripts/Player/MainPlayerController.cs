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
    public float default_speed = 3f;

    public float sprint_speed = 7f;

    [SerializeField]
    private float jumpingHeight = 3.0f;

    public float damage;

    public float baseDamage = 10f;
    public float weaponDamage = 0f;

    public float defense = 0f; // decimal value representing percent. Range from 0 to 0.4


    [SerializeField]
    private float gravityVal = -9.81f;
    public float Health = 100f;
    public float Energy = 100f;
    public float xPos;
    public float yPos;
    public float zPos;
    private Rigidbody rb;
    private float movementX;
    private float movementY;
    public int CoinCount;
    private InputManager inputManager;
    private Transform cameraTransform;
    private EnemyController enemyClose;
    private GameObject weapon;

    public AudioSource weaponSound;
    [SerializeField]
    public AudioSource jumpSound;
    private Animation weaponAnimation;
    public PauseManager pauseManager;
    private EnemyHealth goblinHealth;
    public HealthBar PlayerHealthBar;
    public EnergyBar energy;
    public float coolDownTime;
    private float attackTimer = 1.0f;
    public bool isInvincible;
    public bool isSprinting;

    private BreakableCrate crate;

    public void SetCountText()
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

        baseDamage = GameManager.gameManager.statsList[1];
        defense = Mathf.Lerp(0, 40, GameManager.gameManager.statsList[2] / 20) / 100;

        updateWeapon(); // Make a call to updateWeapon to assign the 'weapon' gameobject correctly

        isInvincible = GameManager.gameManager.playerIsInvincible;
        pauseManager.playerInvincibleToggle(isInvincible);
    }

    // This function is called whenever the player switches their equipped weapon. 
    public void updateWeapon()
    {
        // Retrieve the equipped weapon gameobject from the weaponHolder script. This will allow the player
        // to be able to still attack with the new weapon
        weapon = GameObject.Find("WeaponHolder").GetComponent<WeaponHolder>().selectedWeaponObject;

        weaponAnimation = weapon.GetComponent<Animation>(); // Update the weaponAnimation
        weaponSound = weapon.GetComponent<AudioSource>(); // Update the audioSource
        weaponDamage = weapon.GetComponent<WeaponScript>().weaponDamage;

        damage = baseDamage + weaponDamage;
    }

    // This function determines if shift button is held down to sprint
    public void OnSprintStart()
    {
        isSprinting = true;
    }

    // This function determines if shift button was released to disable sprint
    public void OnSprintFinish()
    {
        isSprinting = false;
    }

    void Update()
    {
        Debug.Log("attack timer: " + attackTimer);
        Debug.Log("CoolDown timer: " + coolDownTime);
        if(attackTimer < coolDownTime)
            attackTimer += Time.deltaTime;
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

        // Determines sprinting or not
        if (isSprinting)
        {
            controller.Move(move * Time.deltaTime * sprint_speed);
        }
        else
        {
            controller.Move(move * Time.deltaTime * default_speed);
        }

        // Changes the height position of the player..
        if (inputManager.PlayerJumpedThisFrame() && groundedPlayer)
        {
            jumpSound.Play();
            playerVelocity.y += Mathf.Sqrt(jumpingHeight * -3.0f * gravityVal);
        }

        playerVelocity.y += gravityVal * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
    }

    public void OnFire()
    {
        if (!pauseManager.paused && !pauseManager.inInventory &&!pauseManager.inShop && !pauseManager.inCheatMenu)
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
        if (other.gameObject.tag == "OutOfBounds")
        {
            transform.position = new Vector3(xPos,yPos,zPos);
        }
    }

    public void Attack()
    {
        if(Energy > 19.5f && attackTimer > coolDownTime)
        {
            if(energy.Regenerating)
            {
                energy.StopCoroutine(energy.energyCoroutine);
                energy.Regenerating = !energy.Regenerating;
            }
            attackTimer = 0;
            weaponAnimation.Play("Sword02");
            weaponSound.Play();
            Energy -= 20.4f;
            if(enemyClose)
                if(enemyClose.canAttackplayer)
                    enemyClose.takeDamage(damage);
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
    }

    public void takeDamage(float damage)
    {
        if (!isInvincible)
        {
            if (PlayerHealthBar.Regenerating)
            {
                PlayerHealthBar.StopCoroutine(PlayerHealthBar.coroutine);
                PlayerHealthBar.Regenerating = !PlayerHealthBar.Regenerating;
            }
            float damageAfterDefense = damage - (damage * defense);
            Health -= damageAfterDefense;
        }
    }

    public void OnSceneChange()
    {
        GameManager.gameManager.curHealth = Health;
        GameManager.gameManager.yoodles = CoinCount;
        GameManager.gameManager.playerIsInvincible = isInvincible;
    }
}