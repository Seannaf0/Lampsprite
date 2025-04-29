using UnityEngine;

[System.Serializable]
public class Response
{
    [SerializeField] private string responseText;
    [SerializeField] private DialogueObject dialogueObject;

    public string ResponseText => responseText;

    public DialogueObject DialogueObject => dialogueObject;


}

//pass all the dialogue to an object that will tranfer the data to scene 2(Computer scene) 