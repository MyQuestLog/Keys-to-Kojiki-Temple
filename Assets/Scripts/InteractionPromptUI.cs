using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InteractionPromptUI : MonoBehaviour
{

    private Camera _mainCam;
    public bool isDisplayed = false;
    [SerializeField] private GameObject _uiPanel;
    [SerializeField] private TextMeshProUGUI _promptText;

    private void Start()
    {
        _mainCam = Camera.main;
        _uiPanel.SetActive(false);
    }

    
    private void LateUpdate()
    {
        var rotation = _mainCam.transform.rotation;
        transform.LookAt(transform.position + rotation * Vector3.forward, worldUp: rotation * Vector3.up);
    }

    
    public void SetUp(string promptText)
    {
        _promptText.text = promptText;
       _uiPanel.SetActive(true);
       isDisplayed = true;
    }
    public void Close()
    {
       _uiPanel.SetActive(false);
        isDisplayed = false;

    }
}
