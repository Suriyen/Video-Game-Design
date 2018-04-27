using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow : MonoBehaviour {
    public MovementSoc mo;
    public GameObject tast;
    public bool test = false;
    Animator anim;
	// Use this for initialization
	void Start () {
        mo = FindObjectOfType<MovementSoc>();
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update () {
		if(mo.canMove == false && tast.activeSelf == false)
        {
            anim.SetBool("ar", true);
            test = true;
        }
        else if (mo.canMove == true && test == true)
        {
            anim.SetBool("ar", false);
        }
    }
}
