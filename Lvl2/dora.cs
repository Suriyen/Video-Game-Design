using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dora : MonoBehaviour {
    public AudioClip saw;
    public GameObject test;
    public GameObject test2;
    private int count = 0;
    // Use this for initialization
    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = saw;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Doors"))
        {
            GetComponent<AudioSource>().Play();
            if(count == 1)
            {
                count++;
                test2.tag = "Water";
            }
            if (count == 0)
            {
                count++;
                test.tag = "Water";
            }
        }
    }
}
