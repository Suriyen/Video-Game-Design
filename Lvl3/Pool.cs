using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Pool : MonoBehaviour {
    // Use this for initialization
    public Texture2D fadeOutTexture; // the texture that will overlay the screen. This can be a black image or a loading graphic
    public float fadeSpeed = 0.8f;  // the fading speed

    private int drawDepth = -1000;  // the texture's order in the draw hierarchy: a low number means it renders on top
    public float alpha = 1.0f;   // the texture's alpha value between 0 and 1
    private int fadeDir = -1;   // the direction to fade: in = -1 or out = 1
    private bool roll = false;
    public bool final = false;
    public bool exit = false;

    public TBM3 Box;

    public AudioClip saw;
    public GameObject hole1;
    public GameObject hole2;
    public GameObject hole3;
    public GameObject hole4;
    public GameObject hole5;
    public GameObject hole6;
    private bool test1;
    private bool test2;
    private bool test3;
    private bool test4;
    private bool test5;
    private bool test6;

    public StopWalk3 walk;
    public GameObject me;
    public GameObject origin;
    public TBM3 box;
    void Start () {
        Box = FindObjectOfType<TBM3>();

        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = saw;
        walk = FindObjectOfType<StopWalk3>();
        box = FindObjectOfType<TBM3>();



    }

    // Update is called once per frame
    void Update () {
        if (hole1.activeSelf == false && test1 == false)
        {
            GetComponent<AudioSource>().Play();
            test1 = true;
        }
        if (hole2.activeSelf == false && test2 == false)
        {
            GetComponent<AudioSource>().Play();
            test2 = true;
        }
        if (hole3.activeSelf == false && test3 == false)
        {
            GetComponent<AudioSource>().Play();
            test3 = true;
        }
        if (hole4.activeSelf == false && test4 == false)
        {
            GetComponent<AudioSource>().Play();
            test4 = true;
        }
        if (hole5.activeSelf == false && test5 == false)
        {
            GetComponent<AudioSource>().Play();
            test5 = true;
        }
        if (hole6.activeSelf == false && test6 == false)
        {
            GetComponent<AudioSource>().Play();
            test6 = true;
        }
        if (roll && alpha == 1)
        {
            roll = false;
            final = false;
            box.test = false;
            walk.test = true;
            BeginFade(-1);
            origin.transform.position = me.transform.position;
            origin.transform.rotation = me.transform.rotation;
            origin.tag = "Ballie";

        }
        if (Box.test)
        {
            roll = true;
            origin.tag = "Wod";
            BeginFade(1);
        }
        if(exit && alpha == 1)
        {
            Application.LoadLevel("Transition3");
        }
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("RollOut"))
        {
            GetComponent<AudioSource>().Play();
            roll = true;
            fadeSpeed = 0.5f;
            BeginFade(1);
        }
        if (other.gameObject.CompareTag("People"))
        {
            final = true;
        }
        if (other.gameObject.CompareTag("Box"))
        {
            BeginFade(1);
            exit = true;
        }
        if (other.gameObject.CompareTag("CorrectHole"))
        {
            GetComponent<AudioSource>().Play();
        }
    }
    void OnGUI()
    {
        // fade out/in the alpha value using a direction, a speed and Time.deltaTime to convert the operation to seconds
        alpha += fadeDir * fadeSpeed * Time.deltaTime;
        // force (clamp) the number to be between 0 and 1 because GUI.color uses Alpha values between 0 and 1
        alpha = Mathf.Clamp01(alpha);

        // set color of our GUI (in this case our texture). All color values remain the same & the Alpha is set to the alpha variable
        GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, alpha);
        GUI.depth = drawDepth;                // make the black texture render on top (drawn last)
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), fadeOutTexture);  // draw the texture to fit the entire screen area
    }

    // sets fadeDir to the direction parameter making the scene fade in if -1 and out if 1
    public float BeginFade(int direction)
    {
        fadeDir = direction;
        return (fadeSpeed);
    }

    // OnLevelWasLoaded is called when a level is loaded. It takes loaded level index (int) as a parameter so you can limit the fade in to certain scenes.
    void OnLevelWasLoaded()
    {
        // alpha = 1;  // use this if the alpha is not set to 1 by default
        BeginFade(-1);  // call the fade in function
    }
}