﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SceneMenager : MonoBehaviour
{
    private int clickCounter;
    private bool clicked;
   
    void Start()
    {
        clickCounter = 0;
        clicked = false;
    }

    private void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())

            return;


        if (clicked == false)
        {
            Debug.Log("Pressed left click.");
            SceneManager.LoadScene("MapaSwiata");
            clicked = true;
        }
        
        else
        {
            clicked = false;
        }

    }

    public void LoadLevel()
    {
        SceneManager.LoadScene("MenuGlowne");
    }
}
