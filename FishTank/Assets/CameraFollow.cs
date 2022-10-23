using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float Speed = 0.125f;
    public Vector3 FOV;
    void LateUpdate()
    {
    Vector3 desiredPos = player.position + FOV;
    Vector3 smoothPos = Vector3.Lerp(transform.position, desiredPos, Speed);
    transform.position= smoothPos;
    transform.LookAt(player);
    }
}
