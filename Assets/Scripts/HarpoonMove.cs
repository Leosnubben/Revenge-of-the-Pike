using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarpoonMove : MonoBehaviour
{
    bool shoot;
    bool drag;
    float speed;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
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
            rb.velocity = new Vector2(0, 5);
        }

        else if (drag)
        {
            rb.velocity = new Vector2(0, -3);
        }

        else
        {
            rb.velocity = new Vector2(0, 0);
        }
    }
}
