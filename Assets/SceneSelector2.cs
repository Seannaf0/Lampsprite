using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class SceneSelector2 : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public int correctIndex = 1; // The index of the correct answer
    public string correctSceneName = "Right Answer";
    public string wrongSceneName = "Wrong Awsner";

    public void OnSubmitAnswer()
    {
        int selectIndex = dropdown.value;

        if (selectIndex == correctIndex)
        {
            // Get the current scene index and load the next one
            int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;

            // Make sure the next scene exists in build settings
            if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
            {
                SceneManager.LoadScene(nextSceneIndex);
            }
            else
            {
                Debug.LogWarning("No next scene found in build settings.");
            }
        }
        else
        {
            SceneManager.LoadScene(wrongSceneName);
        }
    }
}