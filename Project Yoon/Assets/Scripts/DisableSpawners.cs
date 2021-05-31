using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableSpawners : MonoBehaviour
{
    private GameObject[] spawners;
    // Update is called once per frame
    private void Start()
    {
        spawners = GameObject.FindGameObjectsWithTag("Spawner");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            for(int x = 0; x < spawners.Length; x++)
            {
                spawners[x].SetActive(false);
            }
        }
    }
}
