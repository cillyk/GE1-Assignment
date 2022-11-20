using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSwim: MonoBehaviour {
  public Transform Fish; 
  private float waitTimer = 0.0f;
  public int canMove = 1;
  
  public string SpawnPointTag = "FishSpawnPoint";

  void Start() {
      
    
    
    // transform.position = Vector3.Slerp(transform.position, waypoints[current], Time.deltaTime);
    // transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(toNext, Vector3.up), 180 * Time.deltaTime);

  }

  void Update() 
  {
      if (canMove == 1)
      {
          StartCoroutine(Swim());
      }
      else 
      {
          //lblala
      }
    
     
  }

  IEnumerator Swim()
    {
        Vector3 startingPos  = transform.position;
        Vector3 finalPos = RandomPoint();
        
        float elapsedTime = 0;
     
        while (transform.position != finalPos)
        {
            transform.position = Vector3.Slerp(transform.position, finalPos, Time.deltaTime);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(finalPos, Vector3.up), 180 * Time.deltaTime);
            
        }
        canMove = 0;
        yield return null;
        
    }



  Vector3 RandomPoint() 
  {
    GameObject[] SpawnPoints = GameObject.FindGameObjectsWithTag(SpawnPointTag);
    int randomIndex = Random.Range(0, SpawnPoints.Length);
    Vector3 randomPoint = SpawnPoints[randomIndex].transform.position;
    return randomPoint;
  }
}