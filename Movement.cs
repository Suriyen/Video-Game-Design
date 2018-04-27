using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 6f;
    public float turn = 1f;
    public bool canMove;
    public float or;
    //public Animator animator;

    private bool abcde = false;

    public Animation anim;

    public AnimationState tra;

    public AnimationClip Socc;
    public Transform bal;
    // Use this for initialization
    void Start()
    {
        or = speed;
        anim.AddClip(Socc, "Socc");
        tra = anim["Socc"];
        bal.GetComponent<Animation>()["Socc"].wrapMode = WrapMode.Loop;
        bal.GetComponent<Animation>().Play("Socc");
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetAxisRaw("Vertical") == 0)
        {
            if (bal.GetComponent<Animation>()["Socc"].speed != 0)
            {
                if (abcde)
                {
                    //animator.speed -= 0.01f;
                    if (Input.GetAxis("Vertical") > 0)
                    {
                        bal.GetComponent<Animation>()["Socc"].speed -= 0.01f;
                    }
                    if (Input.GetAxis("Vertical") < 0)
                    {
                        bal.GetComponent<Animation>()["Socc"].speed += 0.01f;
                    }
                    abcde = false;
                }
                else
                {
                    abcde = true;
                }
            }
        }
        if (!canMove)
        {
            bal.GetComponent<Animation>()["Socc"].speed = 0f;
            //animator.SetBool("Back", false);
            if (Input.GetAxis("Vertical") == 0)
            {
                //animator.speed = 0f;
                bal.GetComponent<Animation>()["Socc"].speed = 0;
            }
            return;
        }
        else if (Input.GetAxisRaw("Horizontal") != 0 && Input.GetAxis("Vertical") == 0)
        {
            //animator.speed = 0f;
            bal.GetComponent<Animation>()["Socc"].speed = 0;

        }
        else if (Input.GetAxisRaw("Vertical") != 0)
        {
            
            if (Input.GetAxisRaw("Vertical") < 0)
            {
                bal.GetComponent<Animation>()["Socc"].speed = -0.4f;
                //animator.SetBool("Back", true);
                //animator.speed = 0.3f;

            }
            else if (Input.GetAxisRaw("Vertical") > 0)
            {
                //animator.SetBool("Back", false);
                //animator.speed = 0.3f;
                bal.GetComponent<Animation>()["Socc"].speed = 0.4f;
            }

        }
        if(Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") == 0)
        {
            //animator.speed = 0f;
            bal.GetComponent<Animation>()["Socc"].speed = 0;

            transform.Translate(0.0f, 0.0f, 0.0f);
        }
            float translation = Input.GetAxis("Vertical") * speed;
            float rotation = Input.GetAxis("Horizontal") * turn;
            translation *= Time.deltaTime;
            rotation *= Time.deltaTime;
            transform.Translate(0.0f, 0.0f, translation);
            transform.Rotate(0, rotation, 0);
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Wod"))
        {
            speed = 13f;
        }
        
        else
        {
            speed = or;
        }
    }
}