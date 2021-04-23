using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class MainPlayerController : MonoBehaviour
{
    public float speed = 10;
    public float jumpingForce = 9.0f;

    private bool isGrounded = true;
    private Rigidbody rb;
    private float movementX;
    private float movementY;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Debug.Log("space");
            if (isGrounded)
            {
                rb.AddForce(Vector3.up * jumpingForce, ForceMode.Impulse);
                isGrounded = false;
            }
        }
        /*else if (!isGrounded)
		{   TODO: fix fall speed 
            rb.AddForce(Vector3.down * jumpingForce/5, ForceMode.Impulse);
        }*/
        else if (!Keyboard.current.anyKey.wasPressedThisFrame)
        {
            rb.velocity = Vector3.zero;
        }
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement * speed);
    }
    void OnCollisionStay()
    {
        isGrounded = true;
    }

}
