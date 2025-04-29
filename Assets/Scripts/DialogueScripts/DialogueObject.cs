using UnityEngine;

//Creates a new option called Dialogye with creates the DialogueData Object
[CreateAssetMenu(menuName = "Dialogue/DialogueObject")]

public class DialogueObject : ScriptableObject
{
    //Creates a string area which allows to add dialogue/writing to the text box UI(The heart of the characters voice)
    [SerializeField] [TextArea] private string[] dialogue;


    [SerializeField] private Response[] responses;

    //prevents code from the outside from wriitng tp the script and only allows the dialogue set in unity to be read by the Script
    public string[] Dialogue => dialogue;

    //Checks if the dialogue data has any responses that it should open the dialogue box for
    public bool HasResponses => Responses != null && Responses.Length > 0;

    public Response[] Responses => responses;
}
