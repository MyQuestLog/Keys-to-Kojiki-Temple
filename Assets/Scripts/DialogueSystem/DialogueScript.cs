using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueScript : MonoBehaviour, IDialogue
{
    [SerializeField] private string _dialoguePrompt;

    public string DialoguePrompt => _dialoguePrompt;

    public bool Dialogue(DialogueInteractor dialogue)
    {
        Debug.Log("DoThing");
        return true;
    }

}
