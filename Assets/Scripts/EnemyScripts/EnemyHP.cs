using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    public int enemyHealth = 20;
    BulletFire bulletFire;


    void Start()
    {
    }

    void Update(){
        if (enemyHealth <= 0) {
            Destroy(gameObject);
        }
    }

    




}
