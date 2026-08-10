using UnityEngine;
using TMPro;
using System.Collections.Generic;
public class DialogueControler : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI NPCNameText;
    [SerializeField] private TextMeshProUGUI NPCDialogueText;

    private Queue<string> paragraphs = new Queue<string>();

    private bool conversationEnded;

    private string p;
    public void DisplayNextParagraphs(DialogueText dialogueText)
    {
        // if theres is nothing in the queue
        if(paragraphs.Count == 0)
        {
            if (!conversationEnded)
            {
                // start a conversation
                StartConversation(dialogueText);
            }
            else
            {
                // end the conversation
                EndConversation();
                return;
            }
        }
        // if there is something in the queue
        p = paragraphs.Dequeue();

        //update conversation text
        NPCDialogueText.text = p;

        // update conversationEnded bool
        if(paragraphs.Count == 0)
        {
            conversationEnded = true;
        }
    }

    private void StartConversation(DialogueText dialogueText)
    {
        if(!gameObject.activeSelf)
        {
            gameObject.SetActive(true);
        }
        // speaker name
        NPCNameText.text = dialogueText.speakerName;

        // dialogue text to the queue

        for (int i = 0; i < dialogueText.paragraphs.Length; i++)
        {
            paragraphs.Enqueue(dialogueText.paragraphs[i]);
        }
    }
    void EndConversation()
    {
        // clear the queue

        paragraphs.Clear();

        // return bool to false 
        conversationEnded = false;

        // doactive gameobject
        if(gameObject.activeSelf)
        {
            gameObject.SetActive(false);
        }
    }
}
