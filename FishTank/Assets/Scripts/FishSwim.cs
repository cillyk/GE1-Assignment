using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSwim: MonoBehaviour 
{
  public string spawnPointTag = "FishSpawnPoint";
  private float fishSpeed = 1;
  private float fishCooldown = 1;
  private bool canSwim = false;
  private Vector3 targetPoint;
  private Vector3 currentPoint;
  private Vector3 direction;
  private Quaternion lookRotation;

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
    float timer = 0;
    fishSpeed = Random.Range(10, 20);
    fishCooldown = Random.Range(1, 3);
    targetPoint = RandomPoint();
    currentPoint = transform.position;
    direction = (targetPoint - currentPoint).normalized;
    lookRotation = Quaternion.LookRotation(direction);
    
    //start a timer
    while (timer < fishSpeed)
    {
      timer += Time.deltaTime;
      float t = timer / fishSpeed;

      //rotate and move the fish to the selected point
      transform.position = Vector3.Lerp(currentPoint, targetPoint, t);
      transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, t);
      
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

}