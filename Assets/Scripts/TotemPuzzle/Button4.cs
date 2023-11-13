using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using static TotemRotation;
using static TotemFace4;

public class Button4 : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;

    [HideInInspector] public static bool _button4;

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
        if (_totemCorrect4 == true)
        {
            _button4 = true;
            Debug.Log("_button4 = true");
        }
        else
        {
            _button4 = false;
            Debug.Log("_button4 = false");
        }
    }

    public bool Interact(Interactor interactor)
    {

        //Call StartRotation method inside of TotemRotation
        totem.GetComponent<TotemFace4>().StartRotation();
        return true;

    }
    //Fix
}
