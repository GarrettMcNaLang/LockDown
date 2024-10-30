using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerIcon : MonoBehaviour
{
    //door equals true, tower equals false
    private bool CurrSelectedTower;

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

    public void SelectedTower()
    {

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

              Debug.DrawRay(ray.origin, ray.direction * Mathf.Infinity, Color.red, 5f);
            //starting this ray for this distance
            //when you pass a variable to an out, every change will change the actual object
            //If the ray hits something, put the hit information in the hit variable
            if (Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity))
            {
                if(hit.transform.TryGetComponent<PathSquareScript>(out PathSquareScript tile))
                {
                    //ChangeTileState(CurrSelectedTower);
                }
            }

        }
    }
}
