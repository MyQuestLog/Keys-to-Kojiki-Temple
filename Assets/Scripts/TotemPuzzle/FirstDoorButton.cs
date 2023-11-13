using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using static Button1;
using static Button2;
using static Button3;
using static Button4;

public class FirstDoorButton : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;

    [HideInInspector] static public bool _puzzleCorrect1;

    public string InteractionPrompt => _prompt;

    //Create a reference to game object totem
    [SerializeField] GameObject door;

    //pls fix
    void Start()
    {
        _puzzleCorrect1 = false;
    }


    public bool Interact(Interactor interactor)
    {
        //Check if all faces are correct
        if (_button1 == true)
        {
            _puzzleCorrect1 = true;
            Debug.Log("Puzzle correct true");
        }

        if (_puzzleCorrect1 == true)
        {
           transform.position = new Vector3(200, 200, 200) * Time.deltaTime;
            Debug.Log("Work");
        }



        //Call StartRotation method inside of TotemRotation
        //door.GetComponent<TotemRotation>().StartRotation();

        return true;

    }
}
