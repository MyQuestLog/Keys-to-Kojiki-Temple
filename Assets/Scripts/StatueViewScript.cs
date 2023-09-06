using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StatueViewScript : MonoBehaviour, IInteractable
{

    [SerializeField] GameObject Canvas;
    private bool _view;
    [SerializeField] private string _prompt;
    public string InteractionPrompt => _prompt;


    // Start is called before the first frame update
    void Start()
    {
        _view = false;
    }

    private void Update()
    {
       if (_view == false)
        {
            Canvas.SetActive(false);
        }

       else if (_view == true)
        {
            Canvas.SetActive(true);
        }     
    }

    public bool Interact(Interactor interactor)
    {
        if (_view == false)
        {
            _view = true;
            Time.timeScale = 0f;
        }
        else
        {
            _view = false;
            Time.timeScale = 1f;
        }
        return true;

    }
}
