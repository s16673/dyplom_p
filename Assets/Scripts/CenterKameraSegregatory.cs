using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CenterKameraSegregatory : MonoBehaviour, IPointerClickHandler {
    private int clickCounter;
    private bool clicked;
    public float moveSpeed = 0.5f;
    public Transform player;
    private Vector3 previousPosition;

    private void Start() {
        clickCounter = 0;
        clicked = false;
    }

    public void OnPointerClick(PointerEventData eventData) {
        //mozna sprawdzic który przycisk ponizej czy pracy czy lewy przycisk myszki
        //if( eventData.button == PointerEventData.InputButton.Left );
        OnMouseDownAction();

    }
    void OnMouseDownAction() {
        if (clicked == false) {
            float posX = 0.06f;
            float posY = 2.59f;
            float posZ = -1.57f;

            if (GetComponent<Collider>()) {
                previousPosition = player.transform.position;
                player.transform.position = new Vector3(posX, posY, posZ);
                clicked = true;
            }
        } else {
            float posX = previousPosition.x;
            float posY = previousPosition.y;
            float posZ = previousPosition.z;
            player.transform.position = new Vector3(posX, posY, posZ);
            clicked = false; //odkomentować jeżeli chcemy wiele razy przybliżać i oddalać ;)
        }
    }
}
