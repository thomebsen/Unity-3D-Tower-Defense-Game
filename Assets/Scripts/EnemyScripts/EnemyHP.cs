using UnityEngine;
using UnityEngine.UI;

public class EnemyHP : MonoBehaviour
{
    public float startHealth = 100f;
    private float health;
    BulletFire bulletFire;
    public int enemyMoney = 10;
    public Image healthBar;
    private bool isDead = false;


    void Start()
    {
        health = startHealth;
    }


    public void TakeDamage(float amount)
    {
        health -= amount;
        healthBar.fillAmount = health / startHealth;

        if (health <= 0 && !isDead)
        {
            Die();
        }
    }


    void Die()
    {
        isDead = true;
        PlayerControlScript.Money += enemyMoney;
        Destroy(gameObject);

    }







}
