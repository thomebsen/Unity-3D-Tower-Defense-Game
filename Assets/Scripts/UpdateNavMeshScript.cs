using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class UpdateNavMeshScript : MonoBehaviour
{
    // Start is called before the first frame update
    public NavMeshSurface level;
    void Start()
    {
        level.BuildNavMesh();
    }
}
