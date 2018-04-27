using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jey : MonoBehaviour {
    public GameObject key;
    public GameObject me;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(key.activeSelf == true)
        {
            me.SetActive(false);

        }
	}
}
