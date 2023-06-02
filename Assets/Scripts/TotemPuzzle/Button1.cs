using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button1 : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;

    public string InteractionPrompt => _prompt;

    //Create a reference to game object totem
    [SerializeField] GameObject totem;




    public bool Interact(Interactor interactor)
    {
        //Call StartRotation method inside of TotemRotation
        totem.GetComponent<TotemRotation>().StartRotation();
        return true;

    } 
}