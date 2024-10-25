//using System.Collections.Generic;
//using UnityEngine;
//using System;
//using UnityEngine.InputSystem.XR.Haptics;
////the brain of the state machine that has access to all functions in Enemy Behavior and will be able to call them, transition 
////between them, and ensure the functionality of the active state
//public abstract class StateManager<EState> : MonoBehaviour where EState : Enum
//{
//    //Dictionary for the different states that, 

//    protected Dictionary<EState, BaseState<EState>> EStates = new Dictionary<EState, BaseState<EState>>();

//    //Active states are states whose functionality is being performed

//    protected BaseState<EState> CurrState;


//    protected bool IsTransitionState = false;
//    void Start()
//    {
//        //calls it once
//        CurrState.EnterState();
//    }

//    void Update()
//    {
//        EState nextStateKey = CurrState.GetNextState();

//        if (!IsTransitionState && nextStateKey.Equals(CurrState.StateKey))
//        {
//            //ensures the current state logic each frame
//            CurrState.UpdateState();
//        }
//      else if(!IsTransitionState)
//        {
//            //a state transition is defined by the exit function being called, cleaning things up before the Enter State function
//            //in the suceeding function is called
//            TransitionToNextState(nextStateKey);
//        }
       
//    }
//    /// <summary>
//    /// a function that ensures the transition from one state to another
//    /// </summary>
//    /// <param name="statekey"> the state to transition to</param>
//    public void TransitionToNextState(EState statekey)
//    {
//        IsTransitionState = true;
//        CurrState.ExitState();

//        CurrState = EStates[statekey];

//        CurrState.EnterState();
//        IsTransitionState = false;
//    }

//    void OnTriggerEnter2D(Collider2D other) {

//        CurrState.OnTriggerEnter2D(other);
//    }

//    void OnTriggerStay2D(Collider2D other)
//    {
//        CurrState.OnTriggerStay2D(other);
//    }

//    void OnTriggerExit2D(Collider2D other)
//    {
//        CurrState.OnTriggerExit2D(other);
//    }
//}
