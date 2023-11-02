using System.Collections;
using System.Collections.Generic;
using static WellScript;
using UnityEngine;

public class Puzzle2Step2 : MonoBehaviour
{
    [SerializeField] private GameObject _uiPanel;
    public bool isDisplayed = false;



    void Start()
    {
        _uiPanel.SetActive(false);
    }


    void Update()
    {
        if (_wellCanvas == true)
        {
            _uiPanel.SetActive(true);
            //Debug.Log("Show da image");
        }
    }
}
