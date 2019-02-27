using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControlScript : MonoBehaviour
{

    public int playerHealth = 10;
    public Text playerHealthText;

    void Start()
    {  
    }

    // Update is called once per frame
    void Update()
    {
        if(playerHealth <= 0)
        {
            Debug.Log("You died!");
        }

        playerHealthText.text = "HEALTH: " + playerHealth.ToString();
    }
}
