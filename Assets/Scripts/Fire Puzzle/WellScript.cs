using System.Collections;
using System.Collections.Generic;
using static BucketScript;
using UnityEngine;

public class WellScript : MonoBehaviour, IInteractable
{
    
    public string InteractionPrompt => _prompt;
    [SerializeField] private string _prompt;

    public static bool _hasWater;
    public static bool _wellCanvas;

    [SerializeField] private GameObject _uiPanel1;
    [SerializeField] private GameObject _uiPanel2;

    [SerializeField] GameObject Well;


    void Start()
    {
        _wellCanvas = false;
        _hasWater = false;
        _uiPanel2.SetActive(false);
        
    }

    public void SwitchImages()
    {
        //Well.SetActive(false);
        _wellCanvas = true;

        _hasTheBucket = false;
        _hasWater = true;

        _uiPanel1.SetActive(false);
        _uiPanel2.SetActive(true);
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
