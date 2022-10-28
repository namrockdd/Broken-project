using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DailogDis : MonoBehaviour
{
    [SerializeField] private ChatBluePrint activeChat;
    [SerializeField] private TMP_Text chatDisplay;
    [SerializeField, Range(0f , 0.1f)] private float textSpeed;
    private int line;

    void Start()
    {
        StartChat();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ChatInteraction();
        }
    }

    void StartChat()
    {
        line = 0;

        StartCoroutine(Typeline());
    }

    void NextLine()
    {
        line += 1;
        if(line < activeChat.dialogues.Length) StartCoroutine(Typeline());
    }

    void ChatInteraction()
    {
        if(line == activeChat.dialogues.Length - 1 && chatDisplay.text == activeChat.dialogues[line].message) ConversationEnded();
        else if(chatDisplay.text == activeChat.dialogues[line].message)
        {
            NextLine();
        }
        else
        {
            StopAllCoroutines();
            chatDisplay.text = activeChat.dialogues[line].message;
        }
    }
    void ConversationEnded()
    {
        Debug.Log("IT ENDED");       
    }

    IEnumerator Typeline()
    {
        chatDisplay.text = String.Empty;
        
        foreach(char c in activeChat.dialogues[line].message)
        {
            chatDisplay.text += c;
            yield return new WaitForSeconds(textSpeed);
        } 
    }








}


