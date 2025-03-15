using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EvidenceFormScript : MonoBehaviour
{
    public TMP_Dropdown Dropdown;
    public int[] correctOrder = new int[4];
    public int[] answers = new int[4];

    private void Start()
    {
        
    }
    public void GetDropDownValue(int questionNumber)
    {
        int pickedEntryIndex = Dropdown.value;
        answers[questionNumber] = pickedEntryIndex;
        Debug.Log(pickedEntryIndex);
    }

    public void populateCorrectAnswers(int one, int two, int three, int four)
    {
        correctOrder = new int[4]{one, two, three, four};
    }

    public bool checkAnswers(int[] answers)
    {
        if(correctOrder.Equals(answers))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}