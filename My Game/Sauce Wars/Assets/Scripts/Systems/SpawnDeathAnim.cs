using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDeathAnim : MonoBehaviour {

    public GameObject prefabToSpawn;
    public float adjustmentAngle = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Spawn()
    {
        // Get current rotation in degrees
        Vector3 rotationInDegrees = transform.eulerAngles;
        // Add adjustment angle to z axis
        rotationInDegrees.z += adjustmentAngle;

        // Convert rotation into radians
        Quaternion rotationInRadians = Quaternion.Euler(rotationInDegrees);

        Instantiate(prefabToSpawn, transform.position, rotationInRadians);
    }
}
