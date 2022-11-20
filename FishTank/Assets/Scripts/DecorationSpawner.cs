using System.Collections;
using System.Collections.Generic;
using UnityEngine;
  
    public class DecorationSpawner : MonoBehaviour
    {
        public string spawnPointTag = "SpawnPoint";
	    public List<GameObject> decorations;

        void Start()
        {
            //create array containg decorations
            GameObject[] SpawnPoints = GameObject.FindGameObjectsWithTag(spawnPointTag);
            foreach(GameObject SpawnPoint in SpawnPoints)
            {
                //randomly decide how many to spawn and where
                int randomDecoration = Random.Range(0, decorations.Count);
                int spawnHere = Random.Range(0, 2);
                if(spawnHere == 0)
                {
                    GameObject decoration = Instantiate(decorations[randomDecoration]);
                    decoration.transform.position = SpawnPoint.transform.position;
                }
            }
        }
    }
