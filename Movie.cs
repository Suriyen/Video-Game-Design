using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Movie : MonoBehaviour {
    VideoPlayer video;
    // Use this for initialization
    void Start()
    {
        video = GetComponent<VideoPlayer>();
    }
	// Update is called once per frame
	void Update () {
		if (video.time >= 52.0)
        {
            Application.LoadLevel("Scene1");
        }
	}
}
