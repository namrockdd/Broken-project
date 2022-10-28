using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Chat/Blueprint")]
public class ChatBluePrint : ScriptableObject
{
    public ChatDetail[] dialogues;
}

[Serializable] 
public class ChatDetail 
{
    public string speakerName;
    [TextArea]public string message;
}

