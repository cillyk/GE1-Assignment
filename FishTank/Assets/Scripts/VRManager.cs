using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class VRManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(("VR Device active: " +XRSettings.isDeviceActive));
        Debug.Log(("VR Device namee " +XRSettings.loadedDeviceName));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
