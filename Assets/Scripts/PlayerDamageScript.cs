using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamageScript : MonoBehaviour
{
    public string finishCollider = "Enemy";
    public int damage = 1;
    PlayerControlScript psc;
    // Start is called before the first frame update
    void Start()
    {
        GameObject thePlayer = GameObject.Find("Player");
        psc = thePlayer.GetComponent<PlayerControlScript>();
    }


    // Update is called once per frame
    void Update()
    {
        
    }


    void OnCollisionEnter(Collision col)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (col.gameObject.tag == finishCollider)
        {
            psc.health -= damage;
            Debug.Log(psc.health);
            Destroy(col.gameObject, 0.2f);
        }

    }
}
