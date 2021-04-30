using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Roam : MonoBehaviour
{
    private float timeBeforeNextMove;
    public float minTimeBeforeNextMove;
    public float maxTimeBeforeNextMove;

    private float m_timer;

    public float min_x, max_x, min_y, max_y;

    Vector3 dest = new Vector3(1, 0, 1);

    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        timeBeforeNextMove = Random.Range(minTimeBeforeNextMove, maxTimeBeforeNextMove);
    }

    // Update is called once per frame
    void Update()
    {
        if (agent.remainingDistance < agent.stoppingDistance)
        {
            m_timer += Time.deltaTime;

            if (m_timer > timeBeforeNextMove)
            {
                float goalx = Random.Range(min_x, max_x);
                float goaly = Random.Range(min_y, max_y);

                dest.x = goalx;
                dest.z = goaly;

                agent.destination = dest;

                m_timer = 0;
                timeBeforeNextMove = Random.Range(minTimeBeforeNextMove, maxTimeBeforeNextMove);
            }

        }
    }


}
