using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorActive : MonoBehaviour {
    public TextAsset theText;
    public int startLine;
    public int endLine;
    public TextBoxManL2 theTextBox;
    public bool destroy;
    public GameObject next;
    public GameObject next2;

    public AudioClip saw;
    // Use this for initialization
    void Start()
    {
        theTextBox = FindObjectOfType<TextBoxManL2>();

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

            theTextBox.ReloadScript(theText);
            theTextBox.currentLine = startLine;
            theTextBox.endAtLine = endLine;
            theTextBox.EnableTextBox();
            if (destroy)
            {
                gameObject.SetActive(false);
                next.SetActive(true);
                next2.SetActive(true);
            }
        }
    }
}
