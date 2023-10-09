using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogueTextUI : MonoBehaviour
{
    [SerializeField] private GameObject _uiPanel;
    [SerializeField] private TextMeshProUGUI _promptText;
    public bool isDisplayed = false;


    void Start()
    {
        _uiPanel.SetActive(false);
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
