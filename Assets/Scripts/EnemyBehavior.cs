using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
  public enum ZombieStates {MovingtoPlayer, Attacking, Damaged, Dead};

    public ZombieStates CurrState;


}
