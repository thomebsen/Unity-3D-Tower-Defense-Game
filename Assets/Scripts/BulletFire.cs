using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFire : MonoBehaviour
{

    private Transform target;
    public float speed = 70f;
    public int turretDamage = 1;
    public GameObject impactEffect;

    public void Seek(Transform _target)
    {
        target = _target;
    }

    void Update()
    {
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 dir = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;

        if (dir.magnitude <= distanceThisFrame)
        {
            HitTarget();
            return;
        }

        transform.Translate(dir.normalized * distanceThisFrame, Space.World);
    }

    void HitTarget()
    {
        GameObject effectIns = (GameObject) Instantiate(impactEffect, transform.position, transform.rotation); //Spawn a bullet shatter effect
        Destroy(effectIns, 1.5f); //Destroy bullet shatter effect
        Destroy(gameObject); //Destroy bullet
        target.gameObject.GetComponent<EnemyHP>().enemyHealth -= turretDamage; //Damage the target
    }


   
}
