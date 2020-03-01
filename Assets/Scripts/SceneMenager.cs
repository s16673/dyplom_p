using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SceneMenager : MonoBehaviour
{
    private bool clicked;
   
    void Start()
    {
        clicked = false;
    }

    public void OnMouseDownAction(PointerEventData eventData)
    {
        //if (EventSystem.current.IsPointerOverGameObject())

            //return;


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

    public void QuitApp()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("You quit the application");
            Application.Quit();
        }

    }
}
