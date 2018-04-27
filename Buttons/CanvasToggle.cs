using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasToggle : MonoBehaviour {
    public GameObject menu;
    public bool isShowing;
    public Movement player;
	// Use this for initialization
	void Start () {
        menu.SetActive(isShowing);
        player = FindObjectOfType<Movement>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("escape")) {
            isShowing = !isShowing;
            menu.SetActive(isShowing);
            player.canMove = !isShowing;
        }
    }
    public void Resume()
    {
        isShowing = !isShowing;
        menu.SetActive(isShowing);
        player.canMove = true;
    }
}
