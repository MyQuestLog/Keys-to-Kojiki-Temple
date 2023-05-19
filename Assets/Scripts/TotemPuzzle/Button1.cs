using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button1 : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;

    public string InteractionPrompt => _prompt;

    public GameObject otherObject; // Creates a reference for the Totem to call

    //private TotemRotation tr;

    //refernce to owens script

    //TotemRotation tr = gameObject.GetComponent<TotemRotation>();

   /* void Start()
    {
        tr = GameObject.FindWithTag("Totem1").GetComponent<TotemRotation>();
    }
   */
    

    public bool Interact(Interactor interactor)
    {
        //Call Own script
        otherObject.GetComponent<TotemRotation>().RotateObject();

        //tr.RotateObject();
       
        Debug.Log("Rotate");
        return true;

    }
}