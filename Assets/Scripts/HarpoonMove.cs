using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarpoonMove : MonoBehaviour
{
    bool shoot;
    bool drag;
    float speed;
    Rigidbody2D rb;
    public bool giveScore = false;

    public GameObject harpoonDeleter;
    BoxCollider2D bc;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        bc = GetComponent<BoxCollider2D>();
    }

    
    void Update()
    {
        if(transform.position.y >= 10)
        {
            shoot = false;
            drag = true;
        }

        if (transform.position.y <= 10 && drag == false)
        {
            shoot = true;
        }

        if (shoot)
        {
            rb.velocity = new Vector2(0, 30);
            bc.enabled = true;
        }

        else if (drag)
        {
            rb.velocity = new Vector2(0, -3);
            bc.enabled = false;
        }

        else
        {
            rb.velocity = new Vector2(0, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Fish")
        {
            collision.gameObject.transform.parent = gameObject.transform;
            collision.gameObject.GetComponent<FishMovement>().enabled = false;
            giveScore = false;
        }

        if (collision.gameObject.tag == "HarpoonDeleter")
        {
            
            giveScore = true;
            Destroy(gameObject, 1);
        }
    }

    //Hela koden skriven av Simon
}
