using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactionScript : MonoBehaviour
{
    public float moodMeter;
    public bool EmotionalDamage;
    public Response responseChange;

    void Start()
    {
        moodMeter = 0;
    }

     void Update()
    {
        if(moodMeter >= 0)
        {
            //add the sprite for a happy mood

        }
        else
        {
            //the mood of the sprite is the same

        }
        
        if(moodMeter <= 0)
        {
            //add the sprite for a angry or sad mood

        }
        else
        {
            //the mood of the sprite is the same

        }
    }

}
