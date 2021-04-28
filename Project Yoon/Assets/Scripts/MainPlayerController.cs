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

    public PauseManager pauseManager;

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
        CoinCount = 0;
        SetCountText();
    }


    void Update()
    {
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

    public void OnFire()
    {
        if (!pauseManager.paused)
        {
            Debug.Log("Attack!");
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
    }

    public void Attack()
    {
        //enemyClose = GetComponent<EnemyController>();
        // Not final design - Work in progress for POC
        //if(enemyClose.canAttackplayer)
        //    enemyClose.takeDamage(20f);

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