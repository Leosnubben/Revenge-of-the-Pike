using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMovement : MonoBehaviour  //Leos kod
{
    public GameObject[] sprites;
    SpriteRenderer fiskbilder;
    Vector3 dir;
    float gupptimer = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        fiskbilder = GetComponent<SpriteRenderer>();
        int x = Random.Range(0, 2);
        if (x == 0)
        {
            x = -1;
        }
        dir = new Vector3(x, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        gupptimer -= Time.deltaTime;
        Vector3 tempPos = transform.position;
         tempPos += dir * Random.Range(3, 8) * Time.deltaTime;  //Leo
        tempPos.y = transform.position.y + Mathf.Sin(tempPos.x *1) * 0.001f; //Leo
        if (transform.position.x > 12)
        {
            dir.x = -1; //N�r x > 5 s� �ker den till v�nster - Leo
            fiskbilder.flipX = false;
        } else if (transform.position.x < -12)
        {
            dir.x = 1;  //N�r x < -5 s� �ker den till h�ger - Leo
            fiskbilder.flipX = true;
        }
        transform.position = new Vector3(0, 1, 0);
        if (gupptimer <= 0)
        {
            transform.position *= -1;
            gupptimer = 0.5f;
        }
        transform.position = tempPos;
    }
} 
