using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void LoadScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }
    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        //To end a game you Build, comment the previous line
        //And uncomment the following line.
        //Application.Quit();
    }
}
