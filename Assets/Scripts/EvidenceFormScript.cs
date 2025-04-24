using TMPro;
using UnityEngine;

public class EvidenceFormScript : MonoBehaviour
{
    public int[] correctOrder = new int[4];
    public TMP_Dropdown[] dropdowns = new TMP_Dropdown[4];
    public int[] answers = new int[4];


    private void Start()
    {
        correctOrder = new int[] { 2, 2, 2, 2 };
    }
    public void PopulateCorrectAnswers(int one, int two, int three, int four)
    {
        correctOrder = new int[4] { one, two, three, four };
    }

    public void SubmitButton()
    {
        bool temp = CheckAnswers();
        if(temp)
        {
            //do stuff when its right
        }
        else
        {
            //tell the player its wrong
        }
    }

    public bool CheckAnswers()
    {
        int correctCounter = 0;
        for(int i = 0; i < 4; i++)
        {
            if(answers[i] == correctOrder[i])
            {
                correctCounter++;
            }
        }

        if(correctCounter == 4)
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