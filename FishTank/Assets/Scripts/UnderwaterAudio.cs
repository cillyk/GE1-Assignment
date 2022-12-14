using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnderwaterAudio : MonoBehaviour
{   
    private AudioLowPassFilter lowPassFilter;
    private AudioSource bubbleSource;
    private bool isUnderwater = false;
    private bool canPlayBubbles = true;
    public AudioClip bubbleClip;

    // add the low pass filter and bubble noise 
    void Start()
    {
        lowPassFilter = gameObject.AddComponent<AudioLowPassFilter>();
        bubbleSource = gameObject.AddComponent<AudioSource>();
        bubbleSource.bypassEffects = true;
    }

    // if underwater filter music and play bubble noise
    void Update()
    {
        if(isUnderwater)
        {
            if(canPlayBubbles)
            {
                PlayBubbles();
            }
            
            lowPassFilter.cutoffFrequency = 100;
        }
        else
        {
            lowPassFilter.cutoffFrequency = 0;
        }
        if(Input.GetKeyDown(KeyCode.E))
        {
          bubbleSource.Stop();
          isUnderwater = !isUnderwater;
          canPlayBubbles = true;
        }     
    }

    void PlayBubbles()
    {
        bubbleSource.clip = bubbleClip;
        bubbleSource.Play();
        canPlayBubbles = false;
    }
}
