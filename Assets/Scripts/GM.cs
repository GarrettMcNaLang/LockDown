using System.Threading;
using UnityEngine;

public class GM : MonoBehaviour
{
    #region Variables

    public GameObject MainMenu;

    public GameObject PauseMenu;

    public GameObject MainUI;

    #endregion
    public static GM instance;

    void Awake()
    {
        instance = this;

        DontDestroyOnLoad(gameObject);

        MainMenu.SetActive(true);
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

    void Update()
    {
        bool Esc = Input.GetKeyDown(KeyCode.Escape);

        if(Input.GetKeyDown(KeyCode.Escape)) {
        
            PauseMenu.SetActive(true);
            MainUI.SetActive(false);
            Time.timeScale = 0.0f;
        }
        Esc = false;
        
    }

    public void Resume()
    {
        Time.timeScale = 1.0f;
        PauseMenu.SetActive(false);
        MainUI.SetActive(true);
    }

    public void ReturnToMain()
    {
        MainMenu.SetActive(true);
        PauseMenu.SetActive(false);
        MainUI.SetActive(false);
        Time.timeScale = 0.0f;
    }

    /// <summary>
    /// Function that handles all necessary funcitonality for when the player starts the game, no matter if it's the first time or any nth time in the future
    /// </summary>
    public void OnPlay()
    {
        MainMenu.SetActive(false);
        MainUI.SetActive(true);

    }

  

    public void ExitGame()
    {
        Application.Quit();
    }

    public void OnEnable()
    {
           
    }

    public void OnDisable()
    {
         
    }


}
