using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{

    public int health = 2;
    BulletFire bulletFire;

    void Update(){if (health == 0){Destroy(gameObject);}}

    




}
