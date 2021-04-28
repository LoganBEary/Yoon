using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AttackClick : MonoBehaviour
{
    [SerializeField]
    private Camera gameCam;
    private InputAction click;
    public EnemyController enemy;

    void Start() {
    }
    void Awake()
    {
        click = new InputAction(binding: "<Mouse>/leftButton");
        click.performed += ctx => {
            RaycastHit hit; 
            Vector3 coor = Mouse.current.position.ReadValue();
            if (Physics.Raycast(gameCam.ScreenPointToRay(coor), out hit)) 
            {
                 enemy.health -= 20f;
            }
        };
        click.Enable();
    }
}
