using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubmarineCamera : MonoBehaviour
{
    public Transform player;
    public float Speed = 0.125f;
    public float FOV;
    void LateUpdate()
    {
        transform.position = player.transform.position - player.transform.forward * FOV;
        transform.LookAt (player.transform.position);
        transform.position = new Vector3 (transform.position.x , transform.position.y +1, transform.position.z );
    }
}
