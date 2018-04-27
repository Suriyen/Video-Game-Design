using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TBM3 : MonoBehaviour {
    public TextAsset textfile;
    public GameObject textBox;
    public Text theText;
    public string[] textLines;
    public int currentLine;
    public int endAtLine;
    public bool isActive;
    public Mov player;
    public bool stopPlayerMovement;
    public bool isTyping = false;
    public bool test = false;
    private bool cancelTyping = false;
    public float typeSpeed;

    public Pool ball;
    // Use this for initialization 
    void Start()
    {
        player = FindObjectOfType<Mov>();
        ball = FindObjectOfType<Pool>();


        if (textfile != null)
        {
            textLines = (textfile.text.Split('\n'));
        }
        if (endAtLine == 0)
        {
            endAtLine = textLines.Length - 1;
        }
        if (isActive)
        {
            EnableTextBox();
        }
        else
        {
            DisableTextBox();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!isActive)
        {
            return;
        }
        //theText.text = textLines[currentLine];
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (!isTyping)
            {
                currentLine++;
                if (currentLine > endAtLine)
                {
                    if (ball.final == true)
                    {
                        test = true;
                        Time.timeScale = 1;
                    }
                    DisableTextBox();

                }
                else
                {
                    StartCoroutine(TextScroll(textLines[currentLine]));
                }
            }
            else if (isTyping && !cancelTyping)
            {
                cancelTyping = true;
            }
        }
    }
    private IEnumerator TextScroll(string lineOfText)
    {
        int letter = 0;
        theText.text = "";
        isTyping = true;
        cancelTyping = false;
        while (isTyping && !cancelTyping && (letter < lineOfText.Length - 1))
        {
            theText.text += lineOfText[letter];
            letter++;
            yield return new WaitForSeconds(typeSpeed);
        }
        theText.text = lineOfText;
        isTyping = false;
        cancelTyping = false;
    }
    public void EnableTextBox()
    {
        textBox.SetActive(true);
        isActive = true;
        if (stopPlayerMovement)
        {
            player.canMove = false;
        }
        StartCoroutine(TextScroll(textLines[currentLine]));
    }
    public void DisableTextBox()
    {
        textBox.SetActive(false);
        player.canMove = true;
        isActive = false;
    }
    public void ReloadScript(TextAsset theText)
    {
        if (theText != null)
        {
            textLines = new string[1];
            textLines = (theText.text.Split('\n'));
        }
    }
}
