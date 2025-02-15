using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenCutScene : MonoBehaviour
{
   void OnEnable()
    {
       SceneManager.LoadScene("3rdLevel", LoadSceneMode.Single) ;
    }
}
