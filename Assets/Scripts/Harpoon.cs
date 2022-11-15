using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Harpoon : MonoBehaviour
{
    public GameObject harpoon;

    float shootCooldown = 2f;
    void Start()
    {
        
    }

    

    // Update is called once per frame
    void Update()
    {
        shootCooldown -= Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space) && shootCooldown <= 0f)
        {
            Instantiate(harpoon, new Vector3(transform.position.x, 0.3f, 0), Quaternion.identity);
            shootCooldown = 2f;
        }
    }

    //Hela koden skriven av Simon
}
