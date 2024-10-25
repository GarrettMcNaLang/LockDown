using UnityEngine;
using System;

//IHeartGameDev state machine video
//an abstract state machine that ensures that all instances will deal with enums
public class EnemyBehavior : MonoBehaviour
{
    protected enum EnemyStates
    {
        
        Moving,
        Attacking,
        Dead,

    }

}
