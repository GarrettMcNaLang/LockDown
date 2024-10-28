using UnityEngine;
using System;

//IHeartGameDev state machine video
//an abstract state machine that ensures that all instances will deal with enums
public class EnemyBehavior : MonoBehaviour
{

    Rigidbody2D rb;

    protected int EnemyHealth
    {
        get;

        set;
    }

    protected float EnemySpeed;

    protected float EnemyAttackRate;

    public int EnemyDamage = 5;

    public enum EnemyStates
    {
        
        MovingToPlayer,
        Attacking,
        Dead,

    }

    private EnemyStates currEState;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    private void MovingToPlayer()
    {
        var PlayerLocation = GameObject.Find("Player").transform.position;
        

    }

    private void Attacking()
    {

    }

    private void Dead()
    {

    }

}
