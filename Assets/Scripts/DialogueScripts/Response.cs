using UnityEngine;

[System.Serializable]
public class Response
{
    [SerializeField] private string responseText;
    [SerializeField] private DialogueObject dialogueObject;

    [SerializeField] private int moodValue;
    public int MoodValue => moodValue;


    public string ResponseText => responseText;

    public DialogueObject DialogueObject => dialogueObject;

}

//pass all the dialogue to an object that will tranfer the data to scene 2(Computer scene) 