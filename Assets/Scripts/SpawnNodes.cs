using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNodes : MonoBehaviour
{


    public int rowAmount = 41;
    public GameObject nodeRow;
    int zPos = 0;

    void Start()
    {
        for (int i = 0; i < rowAmount; i++)
        {
            Instantiate(nodeRow, new Vector3(0, 2, zPos), Quaternion.identity);
            zPos -= 4;
        }
    }
    // Update is called once per frame
    void Update()
    {
    }
}
