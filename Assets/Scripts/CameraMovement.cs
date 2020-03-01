using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Material defaultMaterial;
    [SerializeField] private string SelectableTag1 = "SelectableKomp";
    public float moveSpeed = 0.5f;
    private int clickCounter = 0;
    private bool clicked;
    public Transform endMarker = null; // create an empty gameobject and assign in inspector
    //public string DoSome(){} ?
    void Update()
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
        if (Input.GetMouseButtonDown(0))
        {
            transform.position = Vector3.Lerp(transform.position, endMarker.position, Time.deltaTime);
        }
    }
}

