using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFishCamera : MonoBehaviour
{
    public Transform player;
    public float speed = 0.125f;
    public float FOV;

    //have camera follow fish when player is controlling it
    void LateUpdate()
    {
        transform.position = player.transform.position - player.transform.forward * FOV;
        transform.LookAt (player.transform.position);
        transform.position = new Vector3 (transform.position.x , transform.position.y +1, transform.position.z );
    }
}
