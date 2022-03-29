using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

/// <summary>
/// This is the State Machine for the SearchBot. All of its states are created and activated here,
/// and any major data or references that the state needs can be accessed through here as well.
/// Technically, you can create a StateMachine without a MonoBehaviour, but Unity offers a few
/// benefits with MonoBehaviours that works well with state machines (such as component references).
/// In this structure I'm opting for the StateMachine as a MonoBehaviour, and the states as traditional
/// C# classes.
/// </summary>

public class SearchBotSM : StateMachineMB
    {
        public IdleState IdleState { get; private set; }
        public SearchState SearchState { get; private set; }
        public FoundedState FoundedState { get; private set; }

        DroneMovement1 _drone;
        FocusHandler _focus;
        DialogueManager _dialogue;
        Interactable _interactable;


        private void Awake()
        {
            // _drone?.Init();
            // _focus?.Init();
            // _dialogue?.Init();

            IdleState = new IdleState(this, _interactable, _drone);
            // if our state needs specific components, we can send them through the constructor
            SearchState = new SearchState(this, _interactable, _drone);
            FoundedState = new FoundedState(this, _interactable, _drone);
        }

        private void OnEnable()
        {

        }

        private void OnDisable()
        {
           // _drone.Destroy();
        }

        private void Start()
        {
            ChangeState(IdleState);
        }


    }