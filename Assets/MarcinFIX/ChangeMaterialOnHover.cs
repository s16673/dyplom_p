using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ChangeMaterialOnHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {
    [SerializeField] private Material baseMaterial;
    [SerializeField] private Material hoverMaterial;
    [SerializeField] private Renderer rend;

    void Start() {
        Init();
    }

    //
    void Init() {
        if (rend == null) {
            rend = GetComponent<Renderer>();   /////////ja zazwyczaj przeciągam w inspectorze, ale to gdybyś zapomniał o tym                                  //to po to żeby nie używać ciągle GetComponent<>()
        }
        ///pobierz aktualny materiał i używaj go jako bazowy
        if (baseMaterial == null) {
            baseMaterial = rend.sharedMaterial;
        }
    }

    //po najechaniu kursorem
    public void OnPointerEnter(PointerEventData eventData) {
        if (rend == null) {
            return;
        }
        rend.sharedMaterial = hoverMaterial;
    }

    //po zjechaniu kursorem
    public void OnPointerExit(PointerEventData eventData) {
        if (rend == null) {
            return;
        }
        rend.sharedMaterial = baseMaterial;
    }


    //Ta metoda się odpala po dodaniu nowego skryptu, albo po wybreaniu opcji reset w insepctorze
    //fajne do inicjalizacji obiektu itd
    //ja sobie tutaj pobiore Renderer i materiał by ręcznie tego nie robić na scenie
    void Reset() {
        Init();
    }
}
