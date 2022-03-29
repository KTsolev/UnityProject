using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

/// <summary>
/// In this state we just want to wait for a length of time, then transition back to idle
/// Because IState is not inheriting from MonoBehaviour, we don't have access to Coroutines
/// This means that we're going to have to implement our own simple timer system.
/// </summary>

 public class FoundedState : IState
    {
        SearchBotSM _searchBotSM;
        Interactable _target;
        DroneMovement1 _drone;

        float _foundDelayDuration = 5f;
        float _elapsedTime = 0;
        bool _timerActive = false;

        public FoundedState(SearchBotSM searchBotSM, Interactable interactable, DroneMovement1 drone)
        {
            _searchBotSM = searchBotSM;
            _target = interactable;
            _drone = _drone;
        }

        public void Enter()
        {
            Debug.Log("STATE CHANGE - Found");

            // _target.hasInteracted = true;
            // _target.isFocused = true;
            StartTimer();
        }

        public void Exit()
        {
            // // stop 'found' visual
            // _target.hasInteracted = true;
            // _target.isFocused = true;
        }

        public void FixedTick()
        {
            //
        }

        public void Tick()
        {
            // if timer is active, increment time
            if (_timerActive)
            {
                _elapsedTime += Time.deltaTime;
               // _drone.Moving(false);
            }

            // if our elapsed time has met our required duration, then go back to Idle
            if (_elapsedTime > _foundDelayDuration)
            {
                StopTimer();
                _searchBotSM.ChangeState(_searchBotSM.IdleState);
            }
        }

        void StartTimer()
        {
            _timerActive = true;
            _elapsedTime = 0;
        }

        void StopTimer()
        {
            _timerActive = false;
        }
    }