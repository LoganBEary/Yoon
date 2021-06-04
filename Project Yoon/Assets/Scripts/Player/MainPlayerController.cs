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

    [SerializeField]
    private float gravityVal = -9.81f;

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


    // ++++++++++++++++++++ Combat Variables +++++++++++++++++++++++
    private GameObject weapon; // Reference to currently equipped weapon
    public AudioSource weaponSound; // Sound weapon makes on attack
    private Animation weaponAnimation; // Attack animation

    public AudioClip coinSound;

    public float Health = 100f; // Player current health
    public float Energy = 100f;

    public float damage; // Total damage dealt to each enemy. Made up of base damage and weapon damage

    public float baseDamage = 10f; // player base damage. Affected by damage stat
    public float weaponDamage = 0f; // Bonus damage added by currently equipped weapon

    public float coolDownTime; // How long the player must wait between attacks

    public float AttackEnergyCost = 15; // How much energy each attack takes away

    public float defense = 0f; // decimal value representing percent. Range from 0 to 0.4

    public EnergyBar energy; // Energy bar displays how much energy the player currently has

    public int currentAttackType;

    public Transform spellAttackPrefab;

    public bool isInvincible;

    [SerializeField]
    public AudioSource jumpSound;
    public PauseManager pauseManager;
    private EnemyHealth goblinHealth;
    public HealthBar PlayerHealthBar;
    private float attackTimer = 1.0f;
    public bool isSprinting;
    public PauseManager PauseM;
    // Array - to access multiple quests at once
    public GeneralQuest quest;
    public int currentQuest;
    private CrateBase crate;

    // For Quest Checking
    public int numOfDefeated;
    public bool KingDefeated;
    public bool DragonKilled;
    private bool set;
    private bool set2;
    private GameObject quest1;
    private GameObject quest2;

    public void SetCountText()
    {
        countText.text = "Yoodles: " + CoinCount.ToString();
    }
    // Start is called before the first frame update
    void Start()
    {
        KingDefeated = false;
        DragonKilled = false;
        if (GameManager.gameManager.currentScene == "SecondLevel")
        {
            GameObject quest1 = GameObject.FindGameObjectWithTag("Quest3");
            GameObject quest2 = GameObject.FindGameObjectWithTag("Quest4");
          //  GameObject KingG = GameObject.FindGameObjectWithTag("KingGoblin");
        }
        enemyClose = GetComponent<EnemyController>();
        controller = GetComponent<CharacterController>();
        inputManager = InputManager.Instance;
        cameraTransform = Camera.main.transform;
        Health = GameManager.gameManager.curHealth;
        CoinCount = GameManager.gameManager.yoodles;
        currentQuest = GameManager.gameManager.currentQ;
        SetCountText();
        set = false;
        set2 = false;
        if(currentQuest == 5)
            set2 = true;
        if (currentQuest == 3)
            set = true;
        //weapon = GameObject.FindGameObjectWithTag("WeaponEquiped");

        baseDamage = GameManager.gameManager.statsList[1];
        defense = Mathf.Lerp(0, 40, GameManager.gameManager.statsList[2] / 20) / 100;
        coolDownTime = (100 - GameManager.gameManager.statsList[3]) / 100;
        AttackEnergyCost = 15 - (GameManager.gameManager.statsList[3] / 10);

        updateWeapon(0); // Make a call to updateWeapon to assign the 'weapon' gameobject correctly

        isInvincible = GameManager.gameManager.playerIsInvincible;
        pauseManager.playerInvincibleToggle(isInvincible);
    }

    // This function is called whenever the player switches their equipped weapon. 
    public void updateWeapon(int type)
    {
        // Retrieve the equipped weapon gameobject from the weaponHolder script. This will allow the player
        // to be able to still attack with the new weapon
        WeaponHolder w = GameObject.Find("WeaponHolder").GetComponent<WeaponHolder>();
        weapon = w.selectedWeaponObject;
        currentAttackType = w.currentAttackType;

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
        if (currentQuest == 2 || (currentQuest == 3 && numOfDefeated == 5))
            set = false;
        else
            //Quest 2 is done - and QuestUI has popped up
            set = true;
        if (currentQuest == 3 && quest1 != null)
            quest1.GetComponent<GeneralQuest>().isActive = true;
        if (currentQuest == 4 && quest2 != null)
            quest2.GetComponent<GeneralQuest>().isActive = true;

        if (attackTimer < coolDownTime)
            attackTimer += Time.deltaTime;
        if (Health <= 0)
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

        //GameObject obs = GameObject.FindGameObjectWithTag("Observer");
        if (numOfDefeated == 5 && currentQuest == 2)
        {
            int yoons = GetComponent<QuestObserver>().Q2.yoodlesRewarded;
            int exp = GetComponent<QuestObserver>().Q2.expRewarded;
            GetComponent<QuestObserver>().QuestComplete(yoons, exp);
        }
        if (currentQuest == 3 && !set)
        {
            if (!PauseM.paused && (!GetComponent<QuestObserver>().Q3.isActive
                || !GetComponent<QuestObserver>().Q3.isComplete))
            {
                set = true;
                numOfDefeated++;
                Debug.Log("Q comp");
                StartCoroutine(QuestPopUpDelay());
                PauseM.OnPause();
                GetComponent<QuestObserver>().OpenQuestUI(3);
            }

        }

        if (KingDefeated == true && set2 == false)
        { 
            GetComponent<QuestObserver>().QuestComplete(20, 650);
            
            KingDefeated = false;
            
        }
        if (set2 == true)
            GetComponent<QuestObserver>().QuestOffer2.SetActive(true);

    }

    public void OnFire()
    {
        if (!pauseManager.paused && !pauseManager.inInventory && !pauseManager.inShop && !pauseManager.inCheatMenu)
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
            AudioSource.PlayClipAtPoint(coinSound, transform.position);
            other.gameObject.SetActive(false);
            addYoodles(1);
        }
        if (other.gameObject.CompareTag("Enemy"))
        {
            enemyClose = other.GetComponent<EnemyController>();
        }
        if (other.gameObject.tag == "BreakableObject")
        {
            crate = other.gameObject.GetComponent<CrateBase>();
        }
        if (other.gameObject.tag == "OutOfBounds")
        {
            transform.position = new Vector3(xPos, yPos, zPos);
        }
    }

    public void Attack()
    {
        if (Energy > 19.5f && attackTimer >= coolDownTime)
        {
            if (energy.Regenerating)
            {
                energy.StopCoroutine(energy.energyCoroutine);
                energy.Regenerating = !energy.Regenerating;
            }
            attackTimer = 0;
            weaponAnimation.Play("Sword02");
            weaponSound.Play();
            Energy -= AttackEnergyCost;
            if (currentAttackType == 0)
            {
                if (enemyClose)
                {
                    if (enemyClose.canAttackplayer)
                        enemyClose.takeDamage(damage);
                }
            }
            else
            {
                Transform cm = transform.Find("Main Camera");
                Transform proj = Instantiate(spellAttackPrefab, transform.position, cm.rotation);
                proj.gameObject.GetComponent<PlayerRangedAttack>().damage = damage;
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
        GameManager.gameManager.currentQ = currentQuest;
    }


    public void AddCount()
    {
        numOfDefeated++;
    }

    private IEnumerator QuestPopUpDelay()
    {
        yield return new WaitForSeconds(3);
    }
}