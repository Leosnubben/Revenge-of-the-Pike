using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMovement : MonoBehaviour
{
    Vector3 dir;
    // Start is called before the first frame update
    void Start()
    {
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
        transform.position += dir * Random.Range(3,8) * Time.deltaTime; 
        if (transform.position.x > 5 )
        {
            dir.x = -1; //N�r x > 5 s� �ker den till v�nster - Leo
        } else if (transform.position.x < -5)
        {
            dir.x = 1;  //N�r x < -5 s� �ker den till h�ger - Leo
        }
    }
}
