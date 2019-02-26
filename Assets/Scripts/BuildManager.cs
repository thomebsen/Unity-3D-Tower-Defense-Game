using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BuildManager : MonoBehaviour
{

    public static BuildManager instance;
    private GameObject turretToBuild;
    public NavMeshSurface surface;

    void Awake()
    {
        if (instance != null)
        {
            Debug.Log("More than one build manager in scene!");
            return;
        }
        instance = this;
    }

    public GameObject standardTurretPrefab;

    void Start()
    {
        turretToBuild = standardTurretPrefab;
        surface.BuildNavMesh();
    }
    public GameObject GetTurretToBuild() => turretToBuild;
}
