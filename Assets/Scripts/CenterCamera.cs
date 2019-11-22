using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterCamera : MonoBehaviour
{
    private int clickCounter = 0;
    private bool clicked;
    public float moveSpeed = 0.5f;
    public Transform Player = null; // create an empty gameobject and assign in inspector

    private Vector3 kamera;




    void OnMouseDown()
    {
        float posX = 1f;
        float posY = 3f;
        float posZ = 0.2f;

        if (GetComponent<Collider>())
        {
            Player.transform.position = new Vector3(posX, posY, posZ);
        }
      
        Debug.Log("you clicked");
       

    }
   

}

