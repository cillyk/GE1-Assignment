using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMovement : MonoBehaviour
{
    public Transform Tail;
    public Transform Head;
    public float speed = 10;
    public float rotSpeed = 100;
    [Range(0,5)]
    public int Frequency = 1;
    
    public float TailAmplitude=50; 
    public float HeadAmplitude=50;

    public float theta = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        theta = Time.time * Frequency;
        float y = TailAmplitude * Mathf.Sin(theta);
        float x = HeadAmplitude * Mathf.Sin(theta);
        Tail.localRotation = Quaternion.AngleAxis(y, Vector3.forward);
        Head.localRotation = Quaternion.AngleAxis(x, Vector3.forward);
        transform.Translate(0, 0, Input.GetAxis("Vertical") * speed * Time.deltaTime);
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime, 0);
    }
}