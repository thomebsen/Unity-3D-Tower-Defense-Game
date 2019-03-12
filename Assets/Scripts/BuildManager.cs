using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BuildManager : MonoBehaviour
{

    public static BuildManager instance;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("More than one BuildManager in scene!");
            return;
        }
        instance = this;
    }

    public GameObject standardTurretPrefab;
    public GameObject missileLauncherPrefab;

    private TurretBlueprint turretToBuild;
    private NodeScript selectedTurret;

    public NodeUI nodeUI;

    //This syntax is a "property" 
    public bool CanBuild { get { return turretToBuild != null; } }
    public bool HasMoney { get { return PlayerControlScript.Money >= turretToBuild.cost; } }

    public void SelectNode(NodeScript node)
    {
        if(selectedTurret == node)
        {
            DeselectNode();
            return;
        }

        selectedTurret = node;
        turretToBuild = null;

        nodeUI.SetTarget(node);
    }

    public void DeselectNode()
    {
        selectedTurret = null;
        nodeUI.Hide();
    }

    public void SelectTurretToBuild(TurretBlueprint turret)
    {
        turretToBuild = turret;
        DeselectNode();
    }

    public TurretBlueprint GetTurretToBuild()
    {
        return turretToBuild;
    }
}
