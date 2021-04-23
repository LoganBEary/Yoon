using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookAtPlayer : MonoBehaviour
{
    public Transform player;

    private Vector3 m_Axis;
    private Vector3 lookDirection;
    // Start is called before the first frame update
    void Start()
    {
        m_Axis = transform.forward;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        lookDirection.x = player.transform.position.x;
        lookDirection.y = transform.position.y;
        lookDirection.z = player.transform.position.z;
        transform.LookAt(lookDirection);
    }
}
