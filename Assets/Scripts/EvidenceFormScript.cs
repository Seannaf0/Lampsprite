using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.Collections;

public class EvidenceFormScript : MonoBehaviour
{
    public int[] correctOrder = new int[3];
    public TMP_Dropdown[] dropdowns = new TMP_Dropdown[3];
    public int[] answers = new int[3];
    public TMP_Dropdown nameDropdown;
    public int levelAnswerAmount;

    private void Start()
    {
        correctOrder = new int[] { 2, 2 , 2};
        if (SceneManager.GetActiveScene().name == "Level 1 Computer")
        {
            levelAnswerAmount = 3;
        }
        else
        {
            levelAnswerAmount = 4;
        }
    }
    public void PopulateCorrectAnswers(int one, int two, int three)
    {
        correctOrder = new int[3] { one, two, three };
    }

    public void SubmitButton()
    {
        if (nameDropdown.value == 2)
        {
            bool temp = CheckAnswers();
            if (temp)
            {
                Debug.Log("YUH HUH");
                //do stuff when its right
            }
            else
            {
                Debug.Log("NUH UH");
                //do stuff when wrong
            }
        }
        else
        {
            //do stuff when wrong
            Debug.Log("NUH UH but #1");
        }
    }

    public bool CheckAnswers()
    {
        int correctCounter = 0;
        for(int i = 0; i < 3; i++)
        {
            if(answers[i] == correctOrder[i])
            {
                correctCounter++;
            }
        }

        if(correctCounter >= 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void Answer(int index)
    {
        answers[index] = dropdowns[index].value;    
    }
}