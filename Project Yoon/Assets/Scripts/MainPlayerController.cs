using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class MainPlayerController : MonoBehaviour
{
  public float speed = 0;
  private int spacebarPresses = 0;

  public Vector3 jump;
  public float jumpingForce = 9.0f;

  public bool isGrounded = true;
  private int maxJump = 2;


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
    if(!Keyboard.current.spaceKey.wasPressedThisFrame)
    {
      rb.velocity = Vector3.zero;
    }
    if(Keyboard.current.spaceKey.wasPressedThisFrame)
    {
      spacebarPresses++;
      if(isGrounded || maxJump > spacebarPresses)
      {
          rb.AddForce(Vector3.up * jumpingForce, ForceMode.Impulse);
          isGrounded = false;
      }
    }
  }

  void FixedUpdate()
  {
      Vector3 movement = new Vector3(movementX, 0.0f, movementY);
      rb.AddForce(movement * speed);
  }
}
