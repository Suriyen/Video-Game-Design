using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heeelp : MonoBehaviour {
    public GameObject truck;
    public GameObject gate;
    public GameObject key;
    public GameObject unlock;
    public GameObject abc;


    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;
    public GameObject obj4;
    public GameObject obj5;
    public GameObject obj6;

    private bool test;
    public GameObject tester;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (tester.activeSelf)
        {
            obj1.SetActive(false);
            obj2.SetActive(false);
            obj3.SetActive(false);
            obj4.SetActive(false);
            obj5.SetActive(false);
            obj6.SetActive(false);
        }
        else if(!tester.activeSelf)
        {
            if (truck.activeSelf)
            {
                obj1.SetActive(true);
                obj2.SetActive(false);
                obj3.SetActive(false);
                obj4.SetActive(false);
                obj5.SetActive(false);
                obj6.SetActive(false);

            }
            if (gate.activeSelf)
            {
                obj1.SetActive(false);
                obj2.SetActive(true);
                obj3.SetActive(false);
                obj4.SetActive(false);
                obj5.SetActive(false);
                obj6.SetActive(false);
            }
            if (key.activeSelf)
            {
                obj1.SetActive(false);
                obj2.SetActive(false);
                obj3.SetActive(true);
                obj4.SetActive(false);
                obj5.SetActive(false);
                obj6.SetActive(false);
            }
            if (unlock.activeSelf)
            {
                obj1.SetActive(false);
                obj2.SetActive(false);
                obj3.SetActive(false);
                obj4.SetActive(true);
                obj5.SetActive(false);
                obj6.SetActive(false);
            }
            if (abc.activeSelf)
            {
                obj1.SetActive(false);
                obj2.SetActive(false);
                obj3.SetActive(false);
                obj4.SetActive(false);
                obj5.SetActive(true);
                obj6.SetActive(false);
                test = true;
            }
            if (abc.activeSelf == false && test == true)
            {
                obj1.SetActive(false);
                obj2.SetActive(false);
                obj3.SetActive(false);
                obj4.SetActive(false);
                obj5.SetActive(false);
                obj6.SetActive(true);
            }
        }
    }
}
