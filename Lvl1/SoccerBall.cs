using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoccerBall : MonoBehaviour {

    public float coolDown;
    public float dashTime;
    Vector3 movement;
    Rigidbody playerRigidbody;
    public MovementSoc player;
    private float timeStamp;
    private float startTime;
    public bool speeding;
    private bool gotKey;
    public GameObject hitDoor;
    public bool door;

    public Texture2D fadeOutTexture; // the texture that will overlay the screen. This can be a black image or a loading graphic
    public float fadeSpeed = 0.8f;  // the fading speed

    private int drawDepth = -1000;  // the texture's order in the draw hierarchy: a low number means it renders on top
    private float alpha = 1.0f;   // the texture's alpha value between 0 and 1
    private int fadeDir = -1;
    private bool exit;
    private bool restart;

    public GameObject Button1;
    public GameObject Button2;
    public GameObject Button3;
    public TextBoxManager Box;
    public bool final = false;

    public GameObject gate;
    public bool test;
    public AudioClip saw;

    public StopWalk walk;
    public GameObject me;
    public GameObject origin;
    // Use this for initialization
    void Start () {
        player = FindObjectOfType<MovementSoc>();
        Box = FindObjectOfType<TextBoxManager>();
        walk = FindObjectOfType<StopWalk>();
        timeStamp = Time.time + coolDown;
        Button2.SetActive(false);
        Button3.SetActive(false);

        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = saw;
    }
	
	// Update is called once per frame
	void Update () {
        if(gate.activeSelf == true)
        {
            test = true;
        }
        if(gate.activeSelf == false && test == true)
        {
            if (Time.timeScale == 1)
            {
                GetComponent<AudioSource>().Play();
                test = false;
            }

        }
        if (Input.GetKeyDown("space") && timeStamp <= Time.time && !speeding)
        {
            Button1.SetActive(false);
            Button3.SetActive(false);
            Button2.SetActive(true);
            player.speed*=1.5f;
            timeStamp = Time.time + coolDown;
            speeding = true;
        }
            if (Box.test)
            {
                BeginFade(1);
                restart = true;
            }
        if(Time.time >= timeStamp)
        {
            Button3.SetActive(false);
            Button2.SetActive(false);
            Button1.SetActive(true);
        }
        if (timeStamp - (coolDown / 2) < Time.time && speeding)
        {
            Button1.SetActive(false);
            Button2.SetActive(false);
            Button3.SetActive(true);
            player.speed /= 1.5f;
            speeding = false;
        }
        if (hitDoor.activeSelf)
        {
            door = true;
        }
        if (alpha == 1 && exit)
        {
            Application.LoadLevel("Transition1");
        }
        if(alpha == 1 && restart)
        {
            restart = false;
            final = false;
            Box.test = false;
            walk.test = true;
            BeginFade(-1);
            origin.transform.position = me.transform.position;
            origin.transform.rotation = me.transform.rotation;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Key") && door)
        {
            other.gameObject.SetActive(false);
            gotKey = true;
        }
        if (other.gameObject.CompareTag("Box"))
        {
            BeginFade(1);
            exit = true;
        }
        if (other.gameObject.CompareTag("People"))
        {
            final = true;
        }
        if (other.gameObject.CompareTag("Water"))
        {
            BeginFade(1);
            restart = true;
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
