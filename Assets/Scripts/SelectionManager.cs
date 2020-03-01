using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SelectionManager : MonoBehaviour
{
    [SerializeField] private string SelectableTag1 = "SelectableKomp";
    [SerializeField] private string SelectableTag2 = "SelectableSegregatory";
    [SerializeField] private string SelectableTag3 = "SelectableMapa";
    [SerializeField] private string SelectableTag4 = "SelectableKsiazka";
    [SerializeField] private string SelectableTag5 = "SelectableKalkulator";
    [SerializeField] private string SelectableTag6 = "SelectableSzuflada";
    [SerializeField] private string SelectableTag7 = "SelectableRamka";
    [SerializeField] private Material active;
    [SerializeField] private Material defaultMaterial;
    [SerializeField] private Material defaultMaterial2;
    [SerializeField] private Material defaultMaterial3;
    [SerializeField] private Material defaultMaterial4;
    [SerializeField] private Material defaultMaterial5;
    [SerializeField] private Material defaultMaterial6;
    [SerializeField] private Material defaultMaterial7;

    private Transform _selection;
    private Transform _selection2;
    private Transform _selection3;
    private Transform _selection4;
    private Transform _selection5;
    private Transform _selection6;
    private Transform _selection7;

    private void Update()
    {
        if (EventSystem.current.IsPointerOverGameObject())
           return;

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
                var selectionRenderer = selection4.GetComponent<Renderer>();
                if (selection4.CompareTag(SelectableTag4))
                {
                    selectionRenderer.material = active;
                }
                _selection4 = selection4;
            }
            //podswietlenie kalkulatora
            if (_selection5 != null)
            {
                var selectionRenderer = _selection5.GetComponent<Renderer>();
                selectionRenderer.material = defaultMaterial5;
                _selection5 = null;
            }
            var selection5 = hit.transform;
            if (selection5.CompareTag(SelectableTag5))
            {
                var selectionRenderer = selection5.GetComponent<Renderer>();
                if (selection5.CompareTag(SelectableTag5))
                {
                    selectionRenderer.material = active;
                }
                _selection5 = selection5;
            }
            //podswietlenie szuflady
            if (_selection6 != null)
            {
                var selectionRenderer = _selection6.GetComponent<Renderer>();
                selectionRenderer.material = defaultMaterial6;
                _selection6 = null;
            }
            var selection6 = hit.transform;
            if (selection6.CompareTag(SelectableTag6))
            {
                var selectionRenderer = selection6.GetComponent<Renderer>();
                if (selection6.CompareTag(SelectableTag6))
                {
                    selectionRenderer.material = active;
                }
                _selection6 = selection6;
            }
            //podswietlenie ramki
            if (_selection7 != null)
            {
                var selectionRenderer = _selection7.GetComponent<Renderer>();
                selectionRenderer.material = defaultMaterial7;
                _selection7 = null;
            }
            var selection7 = hit.transform;
            if (selection7.CompareTag(SelectableTag7))
            {
                var selectionRenderer = selection7.GetComponent<Renderer>();
                if (selection7.CompareTag(SelectableTag7))
                {
                    selectionRenderer.material = active;
                }
                _selection7 = selection7;
            }
        }
    }
}
