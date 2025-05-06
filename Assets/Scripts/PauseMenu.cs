using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public GameObject PausePanel;
    public GameObject SettingsPanel;

    public Button PauseButton;

    [SerializeField] private TypeWriterEffect typeWriterEffect;

    // Base Text speeds
    private const float SlowSpeed = 50f;
    private const float FastSpeed = 100f;
    private const float InstantSpeed = 10000f;

    void Start()
    {
        PauseButton.onClick.AddListener(Pause);
    }

    // Text speeds
    public void SetTextSpeedSlow()
    {
        typeWriterEffect.SetWriterSpeed(SlowSpeed);
    }

    public void SetTextSpeedFast()
    {
        typeWriterEffect.SetWriterSpeed(FastSpeed);
    }

    public void SetTextSpeedInstant()
    {
        typeWriterEffect.SetWriterSpeed(InstantSpeed);
    }

    //Game pause and continuation
    public void Pause()
    {
        if (SettingsPanel.activeInHierarchy)
        {
            CloseSettings();
        }
        else
        {
            PausePanel.SetActive(true);
            Time.timeScale = 0;
        }
    }

    //ZA WARUDO
    public void Continue()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1;
    }

    //Activates the settings Panel which will then turn off the Pause Panel, however the game will not continue
    public void OpenSettings()
    {
        SettingsPanel.SetActive(true);
        PausePanel.SetActive(false);
    }

    public void CloseSettings()
    {
        SettingsPanel.SetActive(false);
        Time.timeScale = 1;
        PauseButton.interactable = true;
    }

    void Update()
    {
        //Disable the PauseButton while SettingsPanel is active
        PauseButton.interactable = !SettingsPanel.activeInHierarchy;
    }
}
