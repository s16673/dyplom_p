using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;


// To jest nowy event bazujący na unitowych eventach
[System.Serializable] //to jest po to by w inspectorze było widać event
public class ClickEvent : UnityEvent<PointerEventData> { }

public class ObjectClickDetector : MonoBehaviour, IPointerClickHandler {

    [SerializeField] private ClickEvent onClick = null;

    public void OnPointerClick(PointerEventData eventData) {
        //po wykryciu kliknięcia, event onClick i przekaż wszystkie dane kliknięcia
        //skrypt który jest podpiętu może sam sprawdzić czy to lewy czy prawy przycisk
        if (onClick != null) {
            onClick.Invoke(eventData);
        }
    }

}