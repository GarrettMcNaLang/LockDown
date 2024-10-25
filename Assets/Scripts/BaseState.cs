//using System;
//using UnityEngine;

//public abstract class BaseState<Estate> where Estate : Enum
//{
//    //establishes the state and it's key in the dictionary upon creation
//    //each enum should then have it's own key to be passed and set
//    public BaseState(Estate key)
//    {
//        StateKey = key;
//    }


//    public Estate StateKey { get; private set; }

//    public abstract void EnterState(); //the start method of the state machine
//    public abstract void ExitState();
//    public abstract void UpdateState();
//    //on creating a new instance, they will conform the defined T variable

//    public abstract Estate GetNextState(); //retrieves the next enum state
//    public abstract void OnTriggerEnter2D(Collider2D other);

//    public abstract void OnTriggerStay2D(Collider2D other);
//    public abstract void OnTriggerExit2D(Collider2D other);
//}
