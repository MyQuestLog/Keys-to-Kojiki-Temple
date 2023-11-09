using System.Collections;
using System.Collections.Generic;
using static WellScript;
using UnityEngine;

public class FireScript : MonoBehaviour, IInteractable
{
    public string InteractionPrompt => _prompt;
    [SerializeField] private string _prompt;

    [SerializeField] private GameObject _uiPanel2;

    [SerializeField] GameObject Fire;

    public void ExtinguishFire()
    {
        Fire.SetActive(false);

        _uiPanel2.SetActive(false);
    }

    public bool Interact(Interactor interactor)
    {
        if (_hasWater == true)
        {
            ExtinguishFire();
        }

        if (_hasWater == false)
        {
            Debug.Log("No Water?");
        }

        return true;

    }
}
