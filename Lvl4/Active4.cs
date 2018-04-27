using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Active4 : MonoBehaviour {
    public TextAsset theText;
    public int startLine;
    public int endLine;
    public TBM4 theTextBox;
    public bool destroy;
    public GameObject next;
    public bool test;

    public AudioClip saw;
    // Use this for initialization
    void Start()
    {
        theTextBox = FindObjectOfType<TBM4>();

        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = saw;
        test = true;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("InsideBall"))
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
                }
        }
        if (other.gameObject.CompareTag("OutsideBall"))
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
                }
        }
    }
}
