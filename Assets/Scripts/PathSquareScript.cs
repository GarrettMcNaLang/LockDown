using UnityEngine;

public class PathSquareScript : MonoBehaviour
{

    bool isOccupied;

    void Awake()
    {
        isOccupied = false;
        //Clear
    }

    void OnEnable()
    {
        //ClearOccupations();

    }

    void OnDisable()
    {
        
    }
}
