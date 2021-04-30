using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowPlayer : MonoBehaviour
{
    Vector3 dest = new Vector3(1, 0, 1);

    public Transform player;
    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.destination = player.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dis = player.position - transform.position;
        float mag = dis.magnitude;
        if (mag > agent.stoppingDistance)
        {
            agent.destination = player.position;
        }
    }


}