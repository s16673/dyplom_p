using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Material defaultMaterial;
    [SerializeField] private string SelectableTag1 = "SelectableKomp";
    private int clickCounter = 0;
    private bool clicked;
    public float moveSpeed = 0.5f;
    public Transform endMarker = null; // create an empty gameobject and assign in inspector
                                       //public string DoSome(){} ?
    Camera MainCamera;
    
    public float shift;

    private Vector3 kamera;

    public float smoothTimeY;
    public float smoothTimeX;
    public float smoothTimeZ;

    

   
    
    void OnMouseDown()
     {
        float posX = Mathf.SmoothDamp(1, Camera.main.transform.position.x + shift, ref kamera.x, smoothTimeX);
        float posY = Mathf.SmoothDamp(3, Camera.main.transform.position.y + shift, ref kamera.y, smoothTimeY);
        float posZ = Mathf.SmoothDamp(0, Camera.main.transform.position.z + shift, ref kamera.z, smoothTimeZ);

        if (GetComponent<Collider>())
        {
            transform.position = new Vector3(posX, posY, posZ);
        }
       

        
        //if (GetComponent<Collider>())
        //{
        //Camera.main.transform.position = Vector3.Lerp(transform.position, );
        Debug.Log("you clicked");
        //Kamera();
        //}

    }
    public void Kamera()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                var selection = hit.transform;
                if (selection.CompareTag(SelectableTag1))
                {
                    var selectionRenderer = selection.GetComponent<Renderer>();
                    if (selectionRenderer != null)
                    {
                        selectionRenderer.material = defaultMaterial;

                    }
                }
            }

            
        }
        
    }
    
}

    // public void FixedOnMouseDown(Collider col)
    // {
    //   if (col.isTrigger)
    //     {
    //       Debug.Log("you clicked");
    //      Kamera();
    //  }


    // }


