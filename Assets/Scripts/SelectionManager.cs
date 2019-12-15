using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    [SerializeField] private string SelectableTag1 = "SelectableKomp";
    [SerializeField] private string SelectableTag2 = "SelectableSegregatory";
    [SerializeField] private string SelectableTag3 = "SelectableMapa";
    [SerializeField] private string SelectableTag4 = "SelectableKsiazka";
    [SerializeField] private Material active;
    [SerializeField] private Material defaultMaterial;
    [SerializeField] private Material defaultMaterial2;
    [SerializeField] private Material defaultMaterial3;
    [SerializeField] private Material defaultMaterial4;

    private Transform _selection;
    private Transform _selection2;
    private Transform _selection3;
    private Transform _selection4;

    private void Update()
    {
        if (_selection != null)
        {
            var selectionRenderer = _selection.GetComponent<Renderer>();
            selectionRenderer.material = defaultMaterial;
            _selection = null;

        }
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
                    selectionRenderer.material = active;
                } 
                
                _selection = selection;
            }
           // podswietlenie segregatorow
            if (_selection2 != null)
            {
                var selectionRenderer = _selection2.GetComponent<Renderer>();
                selectionRenderer.material = defaultMaterial2;
                _selection2 = null;
            }
            var selection2 = hit.transform;
            if (selection2.CompareTag(SelectableTag2))
            {
                var selectionRenderer = selection2.GetComponent<Renderer>();
                if (selection2.CompareTag(SelectableTag2))
                {
                    selectionRenderer.material = active;
                }
                _selection2 = selection2;
            }
            //podswietlenie mapy
            if (_selection3 != null)
            {
                var selectionRenderer = _selection3.GetComponent<Renderer>();
                selectionRenderer.material = defaultMaterial3;
                _selection3 = null;
            }
            var selection3 = hit.transform;
            if (selection3.CompareTag(SelectableTag3))
            {
                var selectionRenderer = selection3.GetComponent<Renderer>();
                if (selection3.CompareTag(SelectableTag3))
                {
                    selectionRenderer.material = active;
                }
                _selection3 = selection3;
            }
            //podswietlenie ksiazki
            if (_selection4 != null)
            {
                var selectionRenderer = _selection4.GetComponent<Renderer>();
                selectionRenderer.material = defaultMaterial4;
                _selection4 = null;
            }
            var selection4 = hit.transform;
            if (selection4.CompareTag(SelectableTag4))
            {
                var selectionRenderer = selection3.GetComponent<Renderer>();
                if (selection4.CompareTag(SelectableTag4))
                {
                    selectionRenderer.material = active;
                }
                _selection4 = selection4;
            }
        }
    }
}
