using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftGate : MonoBehaviour {
    Animator animator;
    public GameObject gate;
    private bool test;
    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
        
	}
	
	// Update is called once per frame
	void Update () {
        if (gate.activeSelf)
        {
            test = true;
        }
        if(!gate.activeSelf && test)
        {
            animator.SetBool("Key", true);
        }
	}
}
