using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlaytestTransition : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("Level 1 Computer");
    }
}
