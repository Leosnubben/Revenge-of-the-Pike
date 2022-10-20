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
            transform.position -= new Vector3((Random.Range(1,10)), 0, 0) * Time.deltaTime; //När x > 0 så åker den till vänster - Leo
            //flytta vänster
        }
        else
        {
            transform.position += new Vector3((Random.Range(1, 10)), 0, 0) * Time.deltaTime; //När x < 0 så åker den till höger - Leo
            //höger
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
