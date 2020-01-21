using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OkienkoKsiazka : MonoBehaviour
{
    private int clickCounter;
    private bool clicked;
    public GameObject abc;//Its your button
                          // Use this for initialization
                          // public GameObject def;

    void Start()
    {
        clickCounter = 0;
        clicked = false;
    }


    public void OnMouseDownAction(PointerEventData eventData)
    {

        //if (Input.GetMouseButtonDown(0))
        if (clicked == false)
        {
            Debug.Log("Pressed left click.");
            abc.SetActive(true);
            //def.SetActive(true);
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
