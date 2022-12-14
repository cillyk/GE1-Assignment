using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishPath: MonoBehaviour
{
    public float radius;
    public int numWaypoints ;
    public int current;
    List<Vector3> waypoints = new List<Vector3>();
    public float speed;
    public Transform fish; 
    public GameObject swimRing;  
   
    public void OnDrawGizmos()
    {
        if (!Application.isPlaying)
        {
            // Create the ring of the waypoints around the fish
            float theta = (Mathf.PI * 2.0f) / numWaypoints;
            for(int i = 0 ; i < numWaypoints ; i ++)
            {
                float angle = theta * i;
                Vector3 pos = new Vector3(Mathf.Sin(angle) * radius, 0, Mathf.Cos(angle) * radius);
                pos = transform.TransformPoint(pos);
                Gizmos.color = Color.red;
                Gizmos.DrawWireSphere(pos, 1); 
            }
        }
    }

    void Awake () {
        //Create the list contianing the wayypoints and spawn the fish rings on theese waypoìnts
        float theta = (Mathf.PI * 2.0f) / numWaypoints;
        for(int i = 0 ; i < numWaypoints ; i ++)
        {
            float angle = theta * i;
            Vector3 pos = new Vector3(Mathf.Sin(angle) * radius, 0, Mathf.Cos(angle) * radius);
            pos = transform.TransformPoint(pos);
            waypoints.Add(pos); 
            float angleDegrees = -angle*Mathf.Rad2Deg;
            //also rotate the rings around the point
            Quaternion rot = Quaternion.Euler(0, angleDegrees, 0);
            Instantiate(swimRing, pos, rot);
        }
    }

    //move the fish between the waypoints/rings
    void Update () 
    {
        Vector3 pos = transform.position;
        Vector3 toNext = waypoints[current] - pos;
        float dist = toNext.magnitude;
        if (dist < 1)
        {
            current = (current + 1) % waypoints.Count;
        }
        Vector3 direction = toNext / dist;
        transform.position = Vector3.Slerp(transform.position, waypoints[current], Time.deltaTime);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(toNext, new Vector3(0,0,0)), 180 * Time.deltaTime);
    }

  

}
