using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    public int enemyHealth = 20;
    BulletFire bulletFire;
    public int enemyMoney = 10;


    void Start()
    {
    }

    void Update(){
        if (enemyHealth <= 0) {
            PlayerControlScript.Money += enemyMoney;
            Destroy(gameObject);
        }
    }

    




}
