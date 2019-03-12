 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
using UnityEngine.EventSystems;

public class NodeScript : MonoBehaviour
{
    public Color hoverColor;
    public Color notEnoughMoneyColor;
    public Vector3 positionOffset;

    [Header("Optional")]
    public GameObject turret;

    private Renderer rend;
    private Color startColor;

    BuildManager buildManager;


    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
        GetComponent<Renderer>().enabled = false;

        buildManager = BuildManager.instance;
    }

    public Vector3 GetBuildPosition()
    {
        return transform.position + positionOffset;
    }

    void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }

        if (!buildManager.CanBuild)
        {
            return;
        }

        if(turret != null)
        {
            Debug.Log("Can't build here!");
            return;
        }

        buildManager.BuildTurretOn(this);
    }


    void OnMouseEnter()
    {
        if(EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }
        if (!buildManager.CanBuild)
        {
            return;
        }
        rend.enabled = true;
        rend.material.color = hoverColor;

    }

    void OnMouseExit()
    {
        rend.enabled = false;
        // rend.material.color = Color.clear;
    }
}
