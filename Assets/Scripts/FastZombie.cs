using UnityEngine;

public class FastZombie : EnemyBehavior
{

    private int _FZHealth;

    public int FZHealth
    {
        get { return _FZHealth; }

        set { _FZHealth = value; }


    }

    void Reset()
    {
        
    }
}
