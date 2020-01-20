using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OkienkoKalkulator : MonoBehaviour
{
    private int clickCounter;
    private bool clicked;
    public GameObject abc;//Its your button
                          // Use this for initialization
    void Start()
    {
        clickCounter = 0;
        clicked = false;
    }


    private void OnMouseDown()
    {

        //if (Input.GetMouseButtonDown(0))
        if (clicked == false)
        {
            Debug.Log("Pressed left click.");
            abc.SetActive(true);
            clicked = true;

        }
        //if (Input.GetMouseButtonDown(1))
        else
        {
            clicked = false;
            //abc.SetActive(false);
        }

    }
}
