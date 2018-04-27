using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toggle : MonoBehaviour {
    public GameObject button;
    public GameObject button1;
    public FadeOut FadeOut;
    public GameObject image;
	// Use this for initialization
	void Start () {
        FadeOut = FindObjectOfType<FadeOut>();

    }

    // Update is called once per frame
    void Update () {
		if(FadeOut.alpha == 0)
        {
            button.SetActive(true);
            button1.SetActive(true);
            image.SetActive(true);
        }
	}
}
