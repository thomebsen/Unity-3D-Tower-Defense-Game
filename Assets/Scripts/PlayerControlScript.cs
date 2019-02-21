using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlScript : MonoBehaviour
{

    public int health = 10;

    void Start()
    {  
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            Debug.Log("You died!");
        }
    }

    void OnGUI()
    {
        GUI.color = Color.black;
        GUI.skin.label.fontSize = 20;
        GUI.Label(new Rect(10, 10, 200, 40), "Health:" + health);
    }
}
