using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBoundsScript : MonoBehaviour
{
    public GameObject player;
    public float x;
    public float y;
    public float z;

    bool collided = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            collided = true;
        }
    }

    private void Update()
    {
        if(collided)
        {
            player.transform.position = new Vector3(x,y,z);
            collided = false;
        }
    }
}
