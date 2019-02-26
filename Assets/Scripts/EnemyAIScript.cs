using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAIScript : MonoBehaviour
{

    public Transform finishPoint;
    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        InvokeRepeating("MoveToDist", 0, 1f); //Run MoveToDist() function ½ second (I hope this is not performance heavy :))
    }

    void MoveToDist()
    {
        agent.destination = finishPoint.position; //Make enemy move to the goals position
    }
}
