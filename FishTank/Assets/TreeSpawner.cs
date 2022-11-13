using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeSpawner : SpectrumMonitor
{
    public GameObject cubePrefab;
    public Rigidbody rb;

    void Update()
    {
        base.Update();
		

    }
    public override void Beat()
	{
        base.Beat();
		// Vector3 randomSpawnPosition = new Vector3(Random.Range(-3, 13), 5, Random.Range(-8, 8));
            
        // GameObject newcubePrefab = Instantiate(cubePrefab, randomSpawnPosition, Quaternion.identity);
        
        // Destroy(cubePrefab, 0f);
        // cubePrefab = newcubePrefab;
        rb.AddForce(new Vector3(0f, 100f, 0f), ForceMode.Force);
        

      
	}
   
            
        
    
}