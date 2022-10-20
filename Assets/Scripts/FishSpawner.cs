using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawner : MonoBehaviour
{
    public GameObject[] fishes;
    //Spawn området är mellan x = 8 -> x = -8 och y = 1 -> y = 5

    public GameObject[] spawnPoints;

    float spawnTimer = 1f;
    int fishCount;
    bool spawnFish = true;

    void Start()
    {
        
    }

    
    void Update()
    {
        
        if(fishCount <= 20 && spawnFish)
        {
            if(spawnTimer <= 0)
            {
                Instantiate(fishes[0], spawnPoints[0].transform.position, Quaternion.identity);
            }
        }
    }
}
