using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeSpaner : MonoBehaviour
{
    public GameObject cubePrefab;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-3, 13), 5, Random.Range(-8, 8));
            Instantiate(cubePrefab, randomSpawnPosition, Quaternion.identity);
        }
    }
}