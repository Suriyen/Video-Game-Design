using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sizechange : MonoBehaviour {
    public bool speeding = false;
    private double timeStamp;
    private double timePart;
    public double coolDown;
    public GameObject large;
    public GameObject small;
    public GameObject Button1;
    public GameObject Button2;
    public GameObject Button3;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        large.transform.position = small.transform.position;
        if(!speeding)
        {
            small.SetActive(false);
        }
        if (Input.GetKeyDown("space") && timeStamp <= Time.time && !speeding)
        {
            small.SetActive(true);
            Button1.SetActive(false);
            Button3.SetActive(false);
            Button2.SetActive(true);
            large.SetActive(false);
            timeStamp = Time.time + coolDown;
            speeding = true;
        }
        if (Time.time >= timeStamp)
        {
            Button3.SetActive(false);
            Button2.SetActive(false);
            Button1.SetActive(true);
        }
        if (timeStamp - (coolDown / 2) < Time.time && speeding)
        {
            Button1.SetActive(false);
            Button2.SetActive(false);
            Button3.SetActive(true);
            large.SetActive(true);
            speeding = false;
        }
    }
}
