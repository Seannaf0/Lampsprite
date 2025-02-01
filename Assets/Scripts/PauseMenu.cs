using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject PausePanel;
    public GameObject SettingsPanel;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pause()
    {
        PausePanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void Continue()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void OpenSettings()
    {
        SettingsPanel.SetActive(true);
        PausePanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void CloseSettings()
    {
        SettingsPanel.SetActive(false);
    }
}
