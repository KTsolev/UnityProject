using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

/// <summary>
/// In this state we show how you can utilize the Tick and FixedTick in order to do something
/// over time, without Update. We can't use the traditional Update() because none of our states
/// are MonoBehaviours. We also show how you can use the StateMachine object to hold common info
/// shared across states, and use it for easy access (we do this with the Target and MoveSpeed fields).
/// Technically, it's best practice to send everything you need through the Constructor, but I wanted to
/// show other options in case they're helpful.
/// </summary>

    public class SearchState : IState
    {
        SearchBotSM _searchBotSM;
        Interactable _target;
        DroneMovement1 _drone;

        public SearchState(SearchBotSM searchBotSM, Interactable interactable, DroneMovement1 drone)
        {
            _searchBotSM = searchBotSM;
            _target = interactable;
            _drone = drone;
        }


        public void Enter()
        {
            Debug.Log("STATE CHANGE - Search");
            // _target.isFocused = false;
            // _target.hasInteracted = false;
        }

        public void Exit()
        {

        }

        public void Tick()
        {
         //   _drone.Moving(true);
        }

        public void FixedTick()
        {
        }
    }
