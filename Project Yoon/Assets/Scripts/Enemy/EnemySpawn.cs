using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemy;
    public GameObject thePlayer;
    public GameObject spawner;
    public float spawnTimer;
    public float randomSpawnTime;
    public int maxNumOfEnemies;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        ResetSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        spawnTimer -= Time.deltaTime;
        if(spawnTimer <= 0.0f && (enemies.Length < maxNumOfEnemies))
        {
            Instantiate(enemy, spawner.transform.position, Quaternion.identity);
            ResetSpawn();
        }
        // Need to find better method of setting transform
        for(int x = 0; x < enemies.Length; x++)
        {
            enemies[x].GetComponent<EnemyAttack>().player = thePlayer.transform;
        }
    }

    private void ResetSpawn()
    {
        spawnTimer = (float)(spawnTimer + Random.Range(0, randomSpawnTime*100)/100.0);
    }
}
