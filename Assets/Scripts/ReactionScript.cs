using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactionScript : MonoBehaviour
{
    public float moodMeter;
    public Response responseChange;

    public SpriteRenderer SpriteRenderer;
    public Sprite[] reactionSprite;

    void Start()
    {
        moodMeter = 0;
    }

    void Update()
    {

        switch(moodMeter)
        {

            //each case is a different sprite for the expression(In Order: Neutral, Angry, Sad, Happy...) make sure to add the call script to pull from the reaction/moodchange of the reponse script
            case 0:
                SpriteRenderer.sprite = reactionSprite[0];
                break;

            case 1:
                SpriteRenderer.sprite = reactionSprite[1];
                break;

            case 2:
                SpriteRenderer.sprite = reactionSprite[2];
                break;

            case 3:
                SpriteRenderer.sprite = reactionSprite[3];
                break;

            default:
                break;
        }

    }
}
