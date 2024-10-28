using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerIcon : MonoBehaviour
{
    private int _playerHealth;

    public int PlayerHealth
    {
        get { return _playerHealth; }

        set { _playerHealth = value;

            if (_playerHealth <= 0)
                Debug.Log("Player died event");
        }
    }

    public int HealthtoSet;

    private bool _IsAlive;
    public bool IsAlive
    {
        get { return _IsAlive; }

        set {
            _IsAlive = value;

            if (!_IsAlive)
                Debug.Log("Initiate GameOver event and restrict player controls");
        }
    }

    void OnEnable()
    {
        PlayerHealth = HealthtoSet;

        IsAlive = true;
        Debug.LogFormat("Health is: {0}", PlayerHealth);
        Debug.LogFormat("Player is alive {0}", IsAlive);
    }

    void OnDisable()
    {
        IsAlive = false;
    }

    public Vector2 DistributeLocation()
    {
        return this.transform.position;
    }
}
