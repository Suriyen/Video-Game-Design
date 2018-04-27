using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopWalk3 : MonoBehaviour {
    public Pool SoccerBall;
    public bool test;
    // Use this for initialization
    void Start()
    {
        SoccerBall = FindObjectOfType<Pool>();
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
