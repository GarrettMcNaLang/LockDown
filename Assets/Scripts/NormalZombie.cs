using UnityEngine;

public class NormalZombie : EnemyBehavior
{

    void Start()
    {
        EnemyHealth = Mathf.Clamp(EnemyHealth,0,100);

        EnemySpeed = 2.0f;

        EnemyAttackRate = 1.0f;


    }

    void Reset()
    {
        
    }

}
