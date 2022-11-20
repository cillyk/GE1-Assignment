using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{

    public Camera mainCam;
    public Camera fishCam ;
    // Start is called before the first frame update
    void Start()
    {
        mainCam.GetComponent<Camera>().enabled = true;
        fishCam.GetComponent<Camera>().enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            mainCam.GetComponent<Camera>().enabled = !mainCam.GetComponent<Camera>().enabled;
            fishCam.GetComponent<Camera>().enabled = !fishCam.GetComponent<Camera>().enabled; 
        }    
    }
}
