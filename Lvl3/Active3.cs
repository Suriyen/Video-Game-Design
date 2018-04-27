using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Active3 : MonoBehaviour {
    public TextAsset theText;
    public int startLine;
    public int endLine;
    public TBM3 theTextBox;
    public bool destroy;
    public GameObject next;
    // Use this for initialization
    void Start()
    {
        theTextBox = FindObjectOfType<TBM3>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            
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
