using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (transform.position.x > 0 ) 
        {
            transform.position -= new Vector3((Random.Range(1,10)), 0, 0) * Time.deltaTime; //N�r x > 0 s� �ker den till v�nster - Leo
            //flytta v�nster
        }
        else
        {
            transform.position += new Vector3((Random.Range(1, 10)), 0, 0) * Time.deltaTime; //N�r x < 0 s� �ker den till h�ger - Leo
            //h�ger
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
