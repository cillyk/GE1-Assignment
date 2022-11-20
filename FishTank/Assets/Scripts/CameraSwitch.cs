using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{

    public Camera mainCam;
    public Camera fishCam ;
    
    //enable main camera by defaault
    void Start()
    {
        mainCam.GetComponent<Camera>().enabled = true;
        fishCam.GetComponent<Camera>().enabled = false;
        
    }

    //if e is pressed switched camera
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            mainCam.GetComponent<Camera>().enabled = !mainCam.GetComponent<Camera>().enabled;
            fishCam.GetComponent<Camera>().enabled = !fishCam.GetComponent<Camera>().enabled; 
        }    
    }
}
