using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static TotemRotation;

public class Button3 : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;

    [HideInInspector] public static bool _button3;

    public string InteractionPrompt => _prompt;

    //Create a reference to game object totem
    [SerializeField] GameObject totem;

    void Start()
    {
        _button3 = false;
    }
    void Update()
    {
        //Check if face correct
        if (_totemCorrect == true)
        {
            _button3 = true;
            Debug.Log("_button3 = true");
        }
        else
        {
            _button3 = false;
            Debug.Log("_button3 = false");
        }
    }
    public bool Interact(Interactor interactor)
    {
        //Check if face correct
        if (_totemCorrect == true)
        {
            _button3 = true;
            Debug.Log("_button3 = true");
        }
        else
        {
            _button3 = false;
        }

        //Call StartRotation method inside of TotemRotation
        totem.GetComponent<TotemRotation>().StartRotation();
        return true;

    }
}
