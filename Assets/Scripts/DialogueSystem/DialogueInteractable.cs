using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDialogue
{
    public string DialoguePrompt { get; }
    public bool Dialogue(DialogueInteractor dialogue);


}
