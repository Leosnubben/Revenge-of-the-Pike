using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawner : MonoBehaviour
{
    public GameObject[] fishes;
    //Spawn området är mellan x = 8 -> x = -8 och y = 1 -> y = 5

    public GameObject[] spawnPoints;

    float spawnTimer = 1f;
    public int fishCount = 0;
    bool spawnFish = true;

    void Start()
    {
        
    }

    
    void Update()
    {
        spawnTimer -= Time.deltaTime;
        if(spawnFish)
        {
            if(fishCount <= 20 && spawnTimer <= 0)
            {
                Instantiate(fishes[Random.Range(0, fishes.Length)], spawnPoints[Random.Range(0, spawnPoints.Length)].transform.position, Quaternion.identity);
                spawnTimer = 1f;
                fishCount += 1;
            }
            print(fishCount);
        }

    }

    //Hela koden skriven av Simon
}
