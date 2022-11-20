using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSwim : MonoBehaviour
{
    enum fishStates
    { 
        idle,
        swimming
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (curState)
        {
            case fishStates.swimming:
                Swim();
                break;
            case fishStates.idle:
                Idle();
                break;
        } 
        
    }
}
