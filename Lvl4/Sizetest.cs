using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sizetest : MonoBehaviour {
    // Use this for initialization
    public float timestamp = 0.0f;
    Collider col;
	void Start () {
        col = GetComponent<Collider>();
	}
	
	// Update is called once per frame
	void Update () {
        if(Time.time >= timestamp)
        {
            col.isTrigger = false;

        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("InsideBall"))
        {
            col.isTrigger = true;
            timestamp = Time.time;
            timestamp += 1;
        }
    }
}
