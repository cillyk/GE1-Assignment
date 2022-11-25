using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{

    public Camera mainCam;
    public Camera fishCam ;
    public GameObject playerFish;
    
    //enable main camera by defaault
    void Start()
    {
        mainCam.GetComponent<Camera>().enabled = true;
        fishCam.GetComponent<Camera>().enabled = false;
        playerFish.GetComponent<PlayerFishMovement>().enabled = false; 
        playerFish.GetComponent<FishSwim>().enabled = true; 
        
    }

    //if e is pressed switched camera
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            mainCam.GetComponent<Camera>().enabled = !mainCam.GetComponent<Camera>().enabled;
            fishCam.GetComponent<Camera>().enabled = !fishCam.GetComponent<Camera>().enabled; 
            playerFish.GetComponent<PlayerFishMovement>().enabled = !playerFish.GetComponent<PlayerFishMovement>().enabled; 
            playerFish.GetComponent<FishSwim>().enabled = !playerFish.GetComponent<FishSwim>().enabled; 
        }    
    }
}
