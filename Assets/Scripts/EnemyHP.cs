using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{

    public float hp = 2;

    BulletFire bulletFire;

    private float dmg = 1;



    public void Damage()
    {
        Debug.Log("hey hey");
        hp -= dmg;
    }




    // Update is called once per frame
    void Update()
    {
        
        if (hp == 0)
        {
            Destroy(gameObject);
        }
        
        
    }

    




}
