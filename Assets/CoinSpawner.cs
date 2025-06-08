using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coin;      
    public Transform[] spawnPoints;       

    public bool canSpawn;  

    void Start()
    {
        canSpawn = true;
    }

    void Update()
    {
        if (canSpawn)
        {
            canSpawn = false;
            Spawn();
        }
    }

    void Spawn()
    {
        Transform point = spawnPoints[Random.Range(0, spawnPoints.Length)];

        Instantiate(coin, point.position, Quaternion.identity);
    }
}
