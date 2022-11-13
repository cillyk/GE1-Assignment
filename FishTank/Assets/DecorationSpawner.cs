using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    
    public class DecorationSpawner : MonoBehaviour
    {
        public string SpawnPointTag = "SpawnPoint";
	    public List<GameObject> decorations;

        void Start()
        {
            GameObject[] SpawnPoints = GameObject.FindGameObjectsWithTag(SpawnPointTag);
            foreach(GameObject SpawnPoint in SpawnPoints)
            {
                int RandomDecoration = Random.Range(0, decorations.Count);
                int SpawnHere = Random.Range(0, 1);
                if(SpawnHere == 0)
                {
                    GameObject Decoration = Instantiate(decorations[RandomDecoration]);
                    Decoration.transform.position = SpawnPoint.transform.position;
                }
            }

        }
    }
