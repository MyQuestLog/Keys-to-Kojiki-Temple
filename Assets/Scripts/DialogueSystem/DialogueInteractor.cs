using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DialogueInteractor : MonoBehaviour
{

    [SerializeField] private Transform _dialogueInteractionPoint;
    [SerializeField] private float _dialogueInteractionPointRadius = 0.5f;
    [SerializeField] private LayerMask _dialogueMask;
    [SerializeField] private DialogueTextUI _dialoguePromptUI;

    private readonly Collider[] _colliders = new Collider[4];
    [SerializeField] private int _diaglogueNumFound;

    private IDialogue _dialogueinteractable;

    private void Update()
    {
        _diaglogueNumFound = Physics.OverlapSphereNonAlloc(_dialogueInteractionPoint.position, _dialogueInteractionPointRadius, _colliders, _dialogueMask);

        if (_diaglogueNumFound > 0)
        {
            _dialogueinteractable = _colliders[0].GetComponent<IDialogue>();

            if (_dialogueinteractable != null)
                {
                    if (!_dialoguePromptUI.isDisplayed) _dialoguePromptUI.SetUp(_dialogueinteractable.DialoguePrompt);

                if (Keyboard.current.eKey.wasPressedThisFrame) _dialogueinteractable.Dialogue(this);
                }
        }
        else
        {
            if (_dialogueinteractable != null) _dialogueinteractable = null;
            if (_dialoguePromptUI.isDisplayed) _dialoguePromptUI.Close();
        }
    }

}
