using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySpin : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(0.0f, 60, 0.0f) * Time.deltaTime);
    }
}
    