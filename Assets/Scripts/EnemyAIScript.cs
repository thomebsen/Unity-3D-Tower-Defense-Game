using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAIScript : MonoBehaviour
{

    public NavMeshAgent enemyMesh;
    public string finishPointTag = "FinishPoint";

    // Update is called once per frame
    void Update()
    {
            enemyMesh.SetDestination(GameObject.FindWithTag(finishPointTag).transform.position);
       // GetComponent<PlayerScript>().health -= damage;
    }
}
