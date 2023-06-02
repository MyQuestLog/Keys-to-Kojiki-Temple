using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using static TotemRotation;
using static TotemFace1;

public class Button1 : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;

    [HideInInspector] public static bool _button1;

    public string InteractionPrompt => _prompt;

    //Create a reference to game object totem
    [SerializeField] GameObject totem;

    void Start()
    {
        SetVariable();
    }

    public void SetVariable()
    {
        _button1 = false;

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

    void Update()
    {
        
    }

    public bool Interact(Interactor interactor)
    {

        //Call StartRotation method inside of TotemRotation
        totem.GetComponent<TotemFace1>().StartRotation();
        return true;

    } 
    //Fix
}