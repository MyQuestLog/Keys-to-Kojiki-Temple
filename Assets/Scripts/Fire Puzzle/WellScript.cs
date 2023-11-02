using System.Collections;
using System.Collections.Generic;
using static BucketScript;
using UnityEngine;

public class WellScript : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;
    [SerializeField] GameObject Well;

    public static bool _hasWater;
    public static bool _wellCanvas;
    public string InteractionPrompt => _prompt;

   
    void Start()
    {
        _wellCanvas = false;
        _hasWater = false;
    }

    public void SwitchImages()
    {
        Well.SetActive(false);
        _wellCanvas = true;

    }


    public bool Interact(Interactor interactor)
    {
        if (_hasTheBucket == true)
        {
            SwitchImages();
        }

        if (_hasTheBucket == false)
        {
            Debug.Log("No Bucket?");
        }
        
        return true;

    }
}
