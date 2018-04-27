using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopWalk2 : MonoBehaviour {
    public BasketBall SoccerBall;
    public bool test;
    // Use this for initialization
    void Start()
    {
        SoccerBall = FindObjectOfType<BasketBall>();
        test = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (SoccerBall.final == true)
        {
            if (test)
            {
                Time.timeScale = 0;
                test = false;
            }
        }

    }
}
