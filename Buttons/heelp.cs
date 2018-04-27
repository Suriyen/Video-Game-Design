using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heelp : MonoBehaviour
{

    public GameObject truck;
    public GameObject gate;
    public GameObject key;
    public GameObject unlock;

    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;
    public GameObject obj4;
    public GameObject obj5;

    public GameObject tester;
    private bool test;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(tester.activeSelf)
        {
            obj1.SetActive(false);
            obj2.SetActive(false);
            obj3.SetActive(false);
            obj4.SetActive(false);
            obj5.SetActive(false);
        }
        else if (!tester.activeSelf)
        {
            if (truck.activeSelf)
            {
                obj1.SetActive(true);
                obj2.SetActive(false);
                obj3.SetActive(false);
                obj4.SetActive(false);
                obj5.SetActive(false);
            }
            if (gate.activeSelf)
            {
                obj1.SetActive(false);
                obj2.SetActive(true);
                obj3.SetActive(false);
                obj4.SetActive(false);
                obj5.SetActive(false);
            }
            if (key.activeSelf)
            {
                obj1.SetActive(false);
                obj2.SetActive(false);
                obj3.SetActive(true);
                obj4.SetActive(false);
                obj5.SetActive(false);
            }
            if (unlock.activeSelf)
            {
                obj1.SetActive(false);
                obj2.SetActive(false);
                obj3.SetActive(false);
                obj4.SetActive(true);
                obj5.SetActive(false);
                test = true;
            }
            if (unlock.activeSelf == false && test == true)
            {
                obj1.SetActive(false);
                obj2.SetActive(false);
                obj3.SetActive(false);
                obj4.SetActive(false);
                obj5.SetActive(true);
            }
        }
    }
}
