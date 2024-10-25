using System.Threading;
using UnityEngine;

public class GM : MonoBehaviour
{
    #region Variables


    #endregion
    public static GM instance;

    void Awake()
    {
        instance = this;

        DontDestroyOnLoad(gameObject);
    }

    //will be 100
    private int _PlayerHP;

    public int PlayerHP
    {
        get
        {
            return _PlayerHP;
        }

        set { _PlayerHP = value; }
    }

    private int timer;

    public int Timer
    {
        get { return timer; }

        set { timer = value; }
    }

    private int availablePower;

    public int AvailablePower
    {
        get { return availablePower; }

        set { availablePower = value; }

    }

    /// <summary>
    /// Function that handles all necessary funcitonality for when the player starts the game, no matter if it's the first time or any nth time in the future
    /// </summary>
    public void OnPlay()
    {
        
    }

    public void OnEnable()
    {
           
    }

    public void OnDisable()
    {
         
    }


}
