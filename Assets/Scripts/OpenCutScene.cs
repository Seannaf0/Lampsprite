using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenCutScene : MonoBehaviour
{
   void OnEnable()
    {
       SceneManager.LoadScene("Level 1 Interview", LoadSceneMode.Single) ;
    }
}
