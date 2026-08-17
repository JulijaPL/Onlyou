using System.Runtime.CompilerServices;
using UnityEngine;
using System.Collections.Generic;

public class Wraith : NPC_, ITalkable
{
    [SerializeField] private DialogueText dialogueText;
    [SerializeField] private DialogueControler dialogueControler;
    public override void Interact()
    {
        Talk(dialogueText);
    }

    public void Talk(DialogueText dialogueText)
    {
        Debug.Log("WRAITH: PRÓBUJÊ URUCHOMIÆ DIALOG");
        dialogueControler.DisplayNextParagraphs( dialogueText, transform);
    }
}
