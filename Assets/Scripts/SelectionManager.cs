using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    [SerializeField] private string SelectableTag1 = "SelectableKomp";
    [SerializeField] private string SelectableTag2 = "SelectableSegregatory";
    [SerializeField] private Material active;
    [SerializeField] private Material defaultMaterial;
    [SerializeField] private Material defaultMaterial2;

    private Transform _selection;
    private Transform _selection2;
    
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
        }
    }
}
