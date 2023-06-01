using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static TotemRotation;

public class Button2 : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;

    [HideInInspector] public static bool _button2;

    public string InteractionPrompt => _prompt;

    //Create a reference to game object totem
    [SerializeField] GameObject totem;

    void Start()
    {
        _button2 = false;
    }
    void Update()
    {
        //Check if face correct
        if (_totemCorrect == true)
        {
            _button2 = true;
            Debug.Log("_button2 = true");
        }
        else
        {
            _button2 = false;
            Debug.Log("_button2 = false");
        }
    }
    public bool Interact(Interactor interactor)
    {
        //Check if face correct
        if (_totemCorrect == true)
        {
            _button2 = true;
            Debug.Log("_button2 = true");
        }
        else
        {
            _button2 = false;
        }

        //Call StartRotation method inside of TotemRotation
        totem.GetComponent<TotemRotation>().StartRotation();
        return true;

    }
}
