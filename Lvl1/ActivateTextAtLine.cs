using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateTextAtLine : MonoBehaviour {
    public TextAsset theText;
    public int startLine;
    public int endLine;
    public TextBoxManager theTextBox;
    public bool destroy;
    public GameObject next;

    public bool test;

    public AudioClip saw;
    // Use this for initialization
    void Start () {
        theTextBox = FindObjectOfType<TextBoxManager>();

        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = saw;
        test = true;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            if (test)
            {
                //Time.timeScale = 0;
                GetComponent<AudioSource>().Play();

                theTextBox.ReloadScript(theText);
                theTextBox.currentLine = startLine;
                theTextBox.endAtLine = endLine;
                theTextBox.EnableTextBox();
                if (destroy)
                {
                    gameObject.SetActive(false);
                    next.SetActive(true);
                }
                test = false;
            }
        }
        test = true;
    }
}
