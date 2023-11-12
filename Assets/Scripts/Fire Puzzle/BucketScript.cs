using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucketScript : MonoBehaviour, IInteractable
{

    [SerializeField] private string _prompt;
    [SerializeField] GameObject Bucket;
    [SerializeField] private GameObject _uiPanel1;

    public static bool _hasTheBucket;
    public static bool _bucketCanvas;
    public string InteractionPrompt => _prompt;

   
    void Start()
    {
        _uiPanel1.SetActive(false);
        _bucketCanvas = false;
        _hasTheBucket = false;
    }

    

    public void HideTheBucket()
    {

        Bucket.SetActive(false);
        _uiPanel1.SetActive(true);
        _bucketCanvas = true;
        _hasTheBucket = true;
    }


    public bool Interact(Interactor interactor)
    {

       
        HideTheBucket();
        return true;

    }
}
