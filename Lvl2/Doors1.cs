using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors1 : MonoBehaviour {
    Animator animator;
    public GameObject door;
    private bool test;
    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (door.activeSelf)
        {
            test = true;
        }
        if (test && !door.activeSelf)
        {
            animator.SetBool("Key1", true);
        }
    }
}
