using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CoinSpawner coinSp;
    public Score scoreScript;

    public UImanager UImangerScript;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Spike"))
        {
            Time.timeScale = 0f;
            UImangerScript.EndGameOpen();
        }

        if (collision.gameObject.CompareTag("Coin"))
        {
            coinSp.canSpawn = true;
            Destroy(collision.gameObject);
            scoreScript.score += 1;
        }
    }
}
