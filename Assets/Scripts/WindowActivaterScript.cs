using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowActivaterScript : MonoBehaviour
{
    private GameObject attachedWindow;

    public void WindowExitButton()
    {
        if (attachedWindow.activeSelf)
        {
            attachedWindow.SetActive(false);
        }
        else
        {
            attachedWindow.SetActive(true);
        }
    }
        
}
