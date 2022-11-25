using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class FishSwim: MonoBehaviour 
{
  public string spawnPointTag = "FishSpawnPoint";
  private float fishSpeed;
  private float fishCooldown;
  private bool canSwim = false;
  private bool isCurrentlyColliding = false;
  private Vector3 targetPoint;
  private Vector3 currentPoint;
  private Vector3 direction;
  private Quaternion lookRotation;
  private Rigidbody rb;

  
  //if the fish has finished its last swim run the swim routine
  void Update() 
  { 
    if(!canSwim)
    {
      canSwim = true;
      StartCoroutine(Swim());
    }
  }

  IEnumerator Swim()
  {
    rb = GetComponent<Rigidbody>();
    float timer = 0;
    fishSpeed = Random.Range(3, 12);
    fishCooldown = Random.Range(1, 5);
    targetPoint = RandomPoint();
    currentPoint = rb.transform.position;
    direction = (targetPoint - currentPoint).normalized;
    lookRotation = Quaternion.LookRotation(direction);
    
    
    //start a timer
    while (timer < fishSpeed)
    {
      timer += Time.deltaTime;
      float t = timer / fishSpeed;

      //rotate and move the fish to the selected point
      rb.transform.position = Vector3.Lerp(currentPoint, targetPoint, t);
      rb.transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, t);

      //if fish is colliding with an object exit the coruotine and try again
      if (isCurrentlyColliding) 
      {
        break;
      }

      yield return null;
    
    }

    //have the fish wait for a random time
    yield return new WaitForSeconds(fishCooldown);
    canSwim = false;
  
  }

  //pick one of the points planned that the fihs can travel to
  Vector3 RandomPoint() 
  {
    GameObject[] SpawnPoints = GameObject.FindGameObjectsWithTag(spawnPointTag);
    int randomIndex = Random.Range(0, SpawnPoints.Length);
    Vector3 randomPoint = SpawnPoints[randomIndex].transform.position;
    return randomPoint;
  }

  void OnCollisionEnter(Collision CollisionObject) 
  {
    isCurrentlyColliding = true;
  }

  void OnCollisionExit(Collision col) 
  {
    isCurrentlyColliding = false;
  }

  //if script is diabled ( disabled when enabling the fish player controller) 
  //end the movement coroutine by saying the fish is colliding
  void OnDisable()
  {
    isCurrentlyColliding = true;
  }

  void OnEnable()
  {
    isCurrentlyColliding = false;
  }


}