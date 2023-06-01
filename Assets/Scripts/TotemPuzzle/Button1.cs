using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static TotemRotation;

public class Button1 : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;

    [HideInInspector] public static bool _button1;

    public string InteractionPrompt => _prompt;

    //Create a reference to game object totem
    [SerializeField] GameObject totem;

    void Start()
    {
        _button1 = false;
    }

    public void SetVaraible()
    {
        //Check if face correct
        if (_totemCorrect == true)
        {
            _button1 = true;
            Debug.Log("_button1 = true");
        }
        else
        {
            _button1 = false;
            Debug.Log("_button1 = false");
        }
    }

    public bool Interact(Interactor interactor)
    {

        //Call StartRotation method inside of TotemRotation
        totem.GetComponent<TotemRotation>().StartRotation();
        return true;

    } 
}