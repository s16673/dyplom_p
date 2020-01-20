﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CenterCameraSzuflada : MonoBehaviour
{
    private int clickCounter;
    private bool clicked;
    public float moveSpeed = 0.5f;
    public Transform player;
    private Vector3 previousPosition;

    private void Start()
    {
        clickCounter = 0;
        clicked = false;
    }

    private void Update()
    {
        if (EventSystem.current.IsPointerOverGameObject())

            return;
    }

    void OnMouseDown()
    {
        if (clicked == false)
        {
            float posX = 1.22f;
            float posY = 2.35f;
            float posZ = -1.49f;

            if (GetComponent<Collider>())
            {
                previousPosition = player.transform.position;
                player.transform.position = new Vector3(posX, posY, posZ);
                clicked = true;
            }
        }
        else
        {
            float posX = previousPosition.x;
            float posY = previousPosition.y;
            float posZ = previousPosition.z;
            player.transform.position = new Vector3(posX, posY, posZ);
            clicked = false; //odkomentować jeżeli chcemy wiele razy przybliżać i oddalać ;)
        }
    }

}