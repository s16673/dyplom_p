﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterCameraRamka : MonoBehaviour
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

    void OnMouseDown()
    {
        if (clicked == false)
        {
            float posX = 0.47f;
            float posY = 2.76f;
            float posZ = -0.9f;

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
