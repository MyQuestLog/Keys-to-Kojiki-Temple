using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using static TotemRotation;
using static TotemFace3;

public class Button3 : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;

    [HideInInspector] public static bool _button3;

    public string InteractionPrompt => _prompt;

    //Create a reference to game object totem
    [SerializeField] GameObject totem;

    void Start()
    {
        SetVariable();
    }

    public void SetVariable()
    {
        //Check if face correct
        if (_totemCorrect3 == true)
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

        //Call StartRotation method inside of TotemRotation
        totem.GetComponent<TotemFace3>().StartRotation();
        return true;

    }
    //Fix
}
