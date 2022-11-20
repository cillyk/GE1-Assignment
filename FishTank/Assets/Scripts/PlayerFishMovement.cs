using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFishMovement : MonoBehaviour
{
    
    public float speed = 10;
    public float rotSpeed = 100;
    
    //allow for swimming style movement
    void Update()
    {
        transform.Translate( 0,0, Input.GetAxis("Vertical") * speed * Time.deltaTime);
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime, 0); 

        if (Input.GetKey(KeyCode.LeftControl))
        {    
            GetComponent<Rigidbody>().velocity = transform.up * -1;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            GetComponent<Rigidbody>().velocity = transform.up * 1;
        }

        //when neither key is pressed return upward force to 0
        if(!Input.GetKey(KeyCode.Space) & !Input.GetKey(KeyCode.LeftControl))
        {
            GetComponent<Rigidbody>().velocity = transform.up * 0;
        }
        
    }
}