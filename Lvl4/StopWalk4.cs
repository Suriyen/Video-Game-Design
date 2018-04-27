using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopWalk4 : MonoBehaviour {
    public Ballscript SoccerBall;
    public bool test;
    // Use this for initialization
    void Start()
    {
        SoccerBall = FindObjectOfType<Ballscript>();
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
