using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;

public class FocusHandler : MonoBehaviour
{
	public dynamic currentGODefaultColor;
	public Interactable focus;	// Our current focus: Item, Enemy etc.

	//public LayerMask movementMask;		// The ground
	public LayerMask interactionMask;
			// Reference to our motor
	Camera cam;

    // void Start()
    // {
    //     movement = GetComponent<DroneMovement1>();
	
    //     cam = Camera.main;
    // }

    // void FixedUpdate()
    // {

    //     if (EventSystem.current.IsPointerOverGameObject())
	// 		return;
    //     movement?.Moving(true);
    //     GetFocus();
    //     GoToFocus();
    // }

    // void SetFocus(Interactable newFocus){
	// 	if (onFocusChangedCallback != null)
	// 		onFocusChangedCallback.Invoke(newFocus);

    //         //  currentGODefaultColor =  newFocus.renderer.material.color;
    //         //  newFocus.renderer.material.color = Color.yellow;

	// 	// If our focus has changed
	// 	if (focus != newFocus)
	// 	{
    //      //    newFocus.renderer.material.color = currentGODefaultColor;
	// 		// Let our previous focus know that it's no longer being focused
	// 		focus?.OnDefocused();
	// 	}

	// 	if (focus != null)
	// 	{
	// 		// Let our focus know that it's being focused
	// 		focus.OnFocused(transform);
	// 	}
	// 	// Set our focus to what we hit
	// 	// If it's not an interactable, simply set it to null
	// 	focus = newFocus;

	// }
	
    // void GetFocus(){
    //     Ray ray = cam.ScreenPointToRay(Input.mousePosition);
    //     RaycastHit hit;
	// 	if (Physics.Raycast(ray, out hit, interactionMask)){
	// 		//movement.move(hit.point);
    //         SetFocus(null);
	// 	}
    // }

    // void GoToFocus(){
    //     Ray ray = cam.ScreenPointToRay(Input.mousePosition);
    //     RaycastHit hit;

	// 	if (Physics.Raycast(ray, out hit, 100f, interactionMask)){
    //         SetFocus(hit.collider.GetComponent<Interactable>());
	// 	}
    // }
}
