using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFishMovement : MonoBehaviour
{
    
    public float speed = 10;
    public float rotSpeed = 100;
    
    //reset rotation when script is enabled 
    void OnEnable() 
    {
        transform.rotation = Quaternion.Euler(0, 0, 0);   
    }

    //allow for swimming style movement
    void Update()
    {   
        transform.Translate( 0,0, Input.GetAxis("Vertical") * speed * Time.deltaTime);
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime, 0); 

        if (Input.GetKey(KeyCode.LeftControl))
        {    
            GetComponent<Rigidbody>().velocity = transform.up * -2;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            GetComponent<Rigidbody>().velocity = transform.up * 2;
        }

        //when neither key is pressed return upward force to 0
        if(!Input.GetKey(KeyCode.Space) & !Input.GetKey(KeyCode.LeftControl))
        {
            GetComponent<Rigidbody>().velocity = transform.up * 0;
        }
        
    }
}