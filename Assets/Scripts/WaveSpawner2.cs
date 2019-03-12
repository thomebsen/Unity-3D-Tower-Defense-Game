using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner2 : MonoBehaviour
{
    class Wave
    {
        string name;
        GameObject[] enemies;
    }

    class Level
    {
        string name;
        Wave[] waves;
    }

    Level[] levels;



    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
}
