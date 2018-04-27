using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BacktoMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void LoadMenu() {
        Application.LoadLevel("Scene0");
    }
}
