using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DialogueUI : MonoBehaviour
{
    [SerializeField] private TMP_Text textLabel;
    //[SerializeField] private DialogueObject testDialogue;

    private void Start()
    {
        GetComponent<TypeWriterEffect>().Run("This a text test!\n Hello... its me.", textLabel);
      
        // ShowDialogue(testDialogue);
    }

    public void ShowDialogue(DialogueObject dialogueObject)
    {
        //StartCoroutine(dialogueObject);
    }

}
