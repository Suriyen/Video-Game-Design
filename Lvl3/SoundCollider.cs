using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundCollider : MonoBehaviour {
    public AudioClip saw;
    // Use this for initialization
    void Start () {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = saw;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ballie"))
        {
            GetComponent<AudioSource>().Play();

        }
    }
}
