using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderSound : MonoBehaviour {
    public AudioClip saw;
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
        if (other.gameObject.CompareTag("Ball"))
        {
            GetComponent<AudioSource>().Play();

        }
    }
}
