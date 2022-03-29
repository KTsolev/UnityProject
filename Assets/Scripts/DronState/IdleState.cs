using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

    
    public class IdleState : IState
    {
        SearchBotSM _searchBotSM;
        Interactable _target;
        DroneMovement1 _drone;


        public IdleState(SearchBotSM searchBotSM, Interactable interactable, DroneMovement1 drone)
        {
            _searchBotSM = searchBotSM;
            _target = interactable;
            _drone = _drone;
        }

        
        public void Enter()
        {
            Debug.Log("STATE CHANGE - Idle");
            // _target.isFocused = false;
            // _target.hasInteracted = false;

        }

        public void Exit()
        {
            //
        }

        public void FixedTick()
        {
            //
        }

        public void Tick()
        {
           // _drone.Moving(true);
        }
    }
