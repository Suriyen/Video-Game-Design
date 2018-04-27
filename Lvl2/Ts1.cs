using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ts1 : MonoBehaviour {
    public AudioClip saw;

    public TextBoxManager text;
    // Use this for initialization
    void Start()
    {
        GetComponent<AudioSource>().clip = saw;
        GetComponent<AudioSource>().mute = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (text.isTyping == true)
        {
            GetComponent<AudioSource>().mute = false;

        }
        if (text.isTyping == false)
        {
            GetComponent<AudioSource>().mute = true;

        }
    }
}
