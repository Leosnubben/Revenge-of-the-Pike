using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMovement : MonoBehaviour
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
        transform.position += dir * Random.Range(3,8) * Time.deltaTime; 
        if (transform.position.x > 12)
        {
            dir.x = -1; //N�r x > 5 s� �ker den till v�nster - Leo
            fiskbilder.flipX = false;
        } else if (transform.position.x < -12)
        {
            dir.x = 1;  //N�r x < -5 s� �ker den till h�ger - Leo
            fiskbilder.flipX = true;
        }
    }
}
