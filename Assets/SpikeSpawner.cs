using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeSpawner : MonoBehaviour
{
    public GameObject Spike; 
    
    public float MaxY;
    public float MinY;

    private float spawnY;

    public float spawnTime;    

    private float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnTime)
        {
            Spawn();
            timer = 0f;
        }
        
    }

    void Spawn()
    {
        spawnY = Random.Range(MinY, MaxY);
        Vector2 spawnPoint = new Vector2(transform.position.x, spawnY);

        Instantiate(Spike, spawnPoint, Quaternion.Euler(0, 0, 90f));
    }

    
}
