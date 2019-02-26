using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{

    public GameObject enemy;
    public GameObject spawnPoint;
    public int spawnAmount = 5;

    void Start()
    {
        StartCoroutine(SpawnEnemies(spawnAmount)); //Spawn X amount of enemies
    }

    IEnumerator SpawnEnemies(int number)
    {
        int i = 1;
        while (i <= number)
        {
            yield return 0; //wait 1 frame
            Instantiate(enemy, spawnPoint.transform.position, Quaternion.identity); //Spawn enemy
            yield return new WaitForSeconds(1.0f); //wait 1 second per interval
            i++;
        }
    }

}
