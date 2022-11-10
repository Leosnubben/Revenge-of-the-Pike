using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static int scoreValue = 0;
    Text score;

    HarpoonMove[] harpoons; //Simon
    
    void Start()
    {
        score = GetComponent<Text>();
        score.text = "Score: " + scoreValue;
    }

    
    void Update()
    {
        if (harpoons != null) //Simon
        {
            foreach (HarpoonMove harpoon in harpoons) //Simon
            {
                if (harpoon.giveScore) //Simon
                {
                    scoreValue += 1; //Simon
                    score.text = "Score: " + scoreValue; // Jay
                    harpoon.giveScore = false; //Simon
                }
            }
        }

        harpoons = FindObjectsOfType<HarpoonMove>(); //Simon
    }
    //Score koden - Jay (ALLT SOM INTE ÄR MARKERAT MED //SIMON ÄR JAYS)
}
