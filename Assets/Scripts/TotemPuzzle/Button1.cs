using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button1 : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;

    public string InteractionPrompt => _prompt;


    public bool Interact(Interactor interactor)
    {
        //Call Own script
        //otherObject.GetComponent<TotemRotation>().RotateObject();
       
        Debug.Log("Rotate");
        return true;

    } 
}