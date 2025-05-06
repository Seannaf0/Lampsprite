using System;
using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DialogueUI : MonoBehaviour
{
    [SerializeField] private GameObject dialogueBox;
    [SerializeField] private TMP_Text textLabel;
    [SerializeField] private DialogueObject testDialogue;


    private ResponseHandler responseHandler;
    private TypeWriterEffect typeWriterEffect;

    [SerializeField] private GameObject dialoguePanel;


    private void Start()
    {
        typeWriterEffect = GetComponent<TypeWriterEffect>();
        responseHandler = GetComponent<ResponseHandler>();

        CloseDialogueBox();
        ShowDialogue(testDialogue);
    }

    public void ShowDialogue(DialogueObject dialogueObject)
    {
        dialogueBox.SetActive(true);
        StartCoroutine(StepThroughDialogue(dialogueObject));
    }

    private IEnumerator StepThroughDialogue(DialogueObject dialogueObject)
    {
        for(int i = 0; i < dialogueObject.Dialogue.Length; i++)
        {
            string dialogue = dialogueObject.Dialogue[i];
            yield return typeWriterEffect.Run(dialogue, textLabel);

            if (i == dialogueObject.Dialogue.Length - 1 && dialogueObject.HasResponses) break;

            yield return new WaitUntil(() => (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0)) && !IsPointerOverAllowedUI());
        }
        
        if(dialogueObject.HasResponses)
        {
            responseHandler.ShowResponse(dialogueObject.Responses);
        }
        else
        {
            CloseDialogueBox();

            //changes to the next scene in line in the build(MAKE SURE THAT THE COMPUTER IS AFTER EACH LEVEL!!!!)
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentSceneIndex + 1, LoadSceneMode.Single);
        }
    }

    private void CloseDialogueBox()
    {
        dialogueBox.SetActive(false);
        textLabel.text = string.Empty;
    }

    //detects if the mouse in a UI panel or button
    private bool IsPointerOverAllowedUI()
{
    PointerEventData pointerData = new PointerEventData(EventSystem.current)
    {
        position = Input.mousePosition
    };

    var raycastResults = new System.Collections.Generic.List<RaycastResult>();
    EventSystem.current.RaycastAll(pointerData, raycastResults);

    foreach (var result in raycastResults)
    {
        // If it's over a button or input on the settings/pause panel, block input
        if (result.gameObject.GetComponent<Selectable>() != null &&
            !IsChildOfDialoguePanel(result.gameObject))
        {
            return true; // Block input
        }
    }

    return false; // Safe to continue dialogue
}

private bool IsChildOfDialoguePanel(GameObject obj)
{
    return obj.transform.IsChildOf(dialogueBox.transform);
}
}
