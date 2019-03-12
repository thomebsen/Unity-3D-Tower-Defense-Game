using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAIScript : MonoBehaviour
{

    public Transform finishPoint;
    private NavMeshAgent agent;
    private NavMeshPath path;


    private FindNearestTurret fntScript;


    void Start()
    {        
        path = new NavMeshPath();
    }

    private void Update()
    {
        CalculatePathAndMoveAgent();
    }

    public void CalculatePathAndMoveAgent()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.CalculatePath(finishPoint.transform.position, path);

        if (path.status == NavMeshPathStatus.PathComplete)
        {
            agent.SetDestination(finishPoint.transform.position);
        }
        else if (path.status == NavMeshPathStatus.PathInvalid)
        {
            print("Path invalid");
        }
        else if (path.status == NavMeshPathStatus.PathPartial)
        {
            print("Path partial (GETTING BLOCKED)");
            fntScript = GetComponent<FindNearestTurret>();

            if (fntScript.target == null) {
                agent.SetDestination(finishPoint.transform.position);
            } else {
                Destroy(fntScript.target.gameObject);
            }
        }

    }
}
    


