using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControlScript : MonoBehaviour
{

    public int playerHealth = 10;
    public Text playerHealthText;
    public Text playerCurrencyText;

    //Currency:
    //static will be passed on to new scenes..
    //Therefore we dont hardcode Money to be our startMoney, ex. "public static int Money = 50;"
    //So basically, if we had a "reset game" function(button) that just reloaded the scene to restart eveything, we will carry over the current amount of money.
    public static int Money;
    public int startMoney = 50;

    void Start()
    {
        Money = startMoney;
    }

    // Update is called once per frame
    void Update()
    {
        if(playerHealth <= 0)
        {
            Debug.Log("You died!");
        }

        playerHealthText.text = "HEALTH: " + playerHealth.ToString();
        playerCurrencyText.text = "Money: " + Money.ToString();
    }
}
