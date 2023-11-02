using System.Collections;
using System.Collections.Generic;
using static BucketScript;
using UnityEngine;

public class Puzzle2Step1 : MonoBehaviour
{
    [SerializeField] private GameObject _uiPanel;
    public bool isDisplayed = false;


    
    void Start()
    {
        _uiPanel.SetActive(false);
    }

    
    void Update()
    {
        
        if (_bucketCanvas == true)
        {
            _uiPanel.SetActive(true);
            //Debug.Log("Show da image");
        }
    }

    
}
