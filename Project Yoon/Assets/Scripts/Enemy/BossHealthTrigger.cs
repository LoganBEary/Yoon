using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealthTrigger : MonoBehaviour
{
    public GameObject bossHealth;
        private void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("Player"))
            bossHealth.SetActive(true);
        }
}
