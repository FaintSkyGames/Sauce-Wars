using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{


    public GameObject prefabToSpawn;

    // Corrects artwork to face correct direction
    public float adjustmentAngle = 0.0f;

    public void Spawn()
    {
        // Ensure there are no more than 50 targets before spawning another
        if (GameObject.FindGameObjectsWithTag("Target").Length < 50)
        {
        // Get current rotation in degrees
        Vector3 rotationInDegrees = transform.eulerAngles;
        // Add adjustment angle to z axis
        rotationInDegrees.z += adjustmentAngle;

        // Convert rotation into radians
        Quaternion rotationInRadians = Quaternion.Euler(rotationInDegrees);

        // Spawn prefab into scene
        Instantiate(prefabToSpawn, transform.position, rotationInRadians);
        }

        // Check the number of objects
        //print(GameObject.FindGameObjectsWithTag("Target").Length);
        

    }
}
