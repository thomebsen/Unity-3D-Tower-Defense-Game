using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{

    public GameObject enemy;
    public GameObject spawnPoint;
    public int spawnAmount = 5;

    void Start()
    {
        Debug.Log("Spawned an enemy!");
        for (int i = 0; i < spawnAmount; i++)
        {
            GameObject expl = Instantiate(enemy, spawnPoint.transform.position, Quaternion.identity) as GameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
