using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour
{
    public Transform enemyPrefab;
    public Transform spawnPoint;
    public Text currentWaveText;
    public Text waveCountdownText;

    public float timeBetweenWaves = 5.5f;
    private float countdown = 2f;
    private int waveIndex = 0;

    private void Update()
    {
        if(countdown <= 0f)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
        }

        countdown -= Time.deltaTime;
        currentWaveText.text = "WAVE: " + waveIndex.ToString();
        waveCountdownText.text = "NEXT WAVE IN: " + Mathf.Round(countdown).ToString() + "s";
    }


    IEnumerator SpawnWave()
    {
        waveIndex++;
        switch (waveIndex)
        {
            case 5:
                print("Why hello there good sir! Let me teach you about Trigonometry!");
                break;
            case 4:
                print("Hello and good day!");
                break;
            case 3:
                print("3");
                break;
            case 2:
                print("2");
                break;
            case 1:
                print("Wave 1");
                for (int i = 0; i < waveIndex; i++)
                {
                    SpawnEnemy();
                }
                break;
            default:
                print("Incorrect intelligence level.");
                break;
        }
        yield return new WaitForSeconds(0.5f);
    }

    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation); //Spawn enemy at spawnPoint's position
    }
}
