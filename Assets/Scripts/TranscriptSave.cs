using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranscriptSave : MonoBehaviour
{
     public Response saveObject;

    public static TranscriptSave Instance;

    private void Awake()
    {
        // Make sure only one instance exists
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Keeps this GameObject alive across scenes
        }
        else
        {
            Destroy(gameObject); // Prevent duplicates if you return to this scene
        }
    }
}
