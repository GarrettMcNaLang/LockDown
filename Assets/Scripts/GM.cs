using UnityEngine;

public class GM : MonoBehaviour
{

    public static GM instance;

    void Awake()
    {
        instance = this;

        DontDestroyOnLoad(gameObject);
    }
}
