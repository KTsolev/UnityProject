using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class DroneMovement1 : MonoBehaviour
{
    public Rigidbody rb;
    Transform target;
    NavMeshAgent agent;

    Interactable interactable;

    void Start() {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    void Update() {
        Moving(true);
    }


    public void Moving(bool shouldMove) {
        if (shouldMove) {
            //if(OVRInput.Get(OVRInput.Button.PrimaryThumbstickRight)){
            if(Input.GetKey("d")){
                rb.AddForce(500 * Time.deltaTime, 0, 0);
            }

            //if(OVRInput.Get(OVRInput.Button.PrimaryThumbstickLeft)){
            if(Input.GetKey("a")){
                rb.AddForce(-500 * Time.deltaTime, 0, 0);
            }

            //if(OVRInput.Get(OVRInput.Button.PrimaryThumbstickUp)){
            if(Input.GetKey("w")){
                rb.AddForce(0, 0, 500 * Time.deltaTime);
            }

            //if(OVRInput.Get(OVRInput.Button.PrimaryThumbstickDown)){
            if(Input.GetKey("s")){
                rb.AddForce(0, 0, -500 * Time.deltaTime);
            }

        }
    }

    
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("coliding:" + other);
        if (other != null) {
            interactable = other.GetComponentInParent<Interactable>();
            Debug.Log("interactable:" + interactable);
            EventSystem.current.DialogueTrigerEnter(interactable.Id);
            if(Input.GetKey("e")){
                EventSystem.current.DialogueInteracted(interactable.Id); 
            }
        }
    }

    
    private void OnTriggerExit(Collider other)
    {

        if (other != null) {
            interactable = other.GetComponentInParent<Interactable>();
            Debug.Log("uncoliding:" + other);
            EventSystem.current.DialogueTrigerExit(interactable.Id);
        }
        interactable = null;
        
    }

}