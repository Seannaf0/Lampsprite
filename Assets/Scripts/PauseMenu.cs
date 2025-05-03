using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject PausePanel;
    public GameObject SettingsPanel;

    [SerializeField] private TypeWriterEffect typeWriterEffect;

    // Base Text speeds
    private const float SlowSpeed = 50f;
    private const float FastSpeed = 100f;
    private const float InstantSpeed = 10000f;

    //Text speeds
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
    }

    public void CloseSettings()
    {
        SettingsPanel.SetActive(false);
        Time.timeScale = 1;
    }
}
