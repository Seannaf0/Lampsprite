using TMPro;
using UnityEngine;

public class EvidenceFormScript : MonoBehaviour
{
    public int[] correctOrder = new int[3];
    public TMP_Dropdown[] dropdowns = new TMP_Dropdown[3];
    public int[] answers = new int[3];
    public TMP_Dropdown nameDropdown;


    private void Start()
    {
        correctOrder = new int[] { 2, 2 , 2};
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