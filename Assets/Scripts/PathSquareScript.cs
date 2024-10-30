using UnityEngine;

public class PathSquareScript : MonoBehaviour
{

    bool isOccupied;

    void Awake()
    {
        isOccupied = false;
        //Clear
    }

    public enum NewPlacement
    {
        Neutral,
        Door,
        Turret,
        Shutter
    }

    private NewPlacement Currplacement;

    public void ChangeTileState(bool ChosenTile)
    {
        switch (ChosenTile)
        {
            case true:
                {
                    Currplacement = NewPlacement.Door;
                    break;
                }
            case false: {
                    Currplacement = NewPlacement.Turret;
                    break; }

        }
    }

    void Update()
    {
        switch(Currplacement)
        {
            case NewPlacement.Neutral:
            {
                NeutralState();
                break;
            }
            case NewPlacement.Door:
            {
                DoorStateFunction();
                break;
            }
            case NewPlacement.Turret:
            {
                    TurretStateFunction(); 
                    break;
            }
            case NewPlacement.Shutter:
                {

                    break;
                }
        }
    }

    public void ShutterStateFunction()
    {
        isOccupied = true;
    }

    public void TurretStateFunction()
    {
        isOccupied = true;
    }

    public void DoorStateFunction()
    {
        isOccupied = true;
    }

    public void NeutralState()
    {
        isOccupied = false;
    }
    void OnEnable()
    {
        //ClearOccupations();

    }

    void OnDisable()
    {
        
    }
}
