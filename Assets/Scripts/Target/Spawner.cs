﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{


    public GameObject prefabToSpawn;
    // Allows for a second type of prefab to be spawned
    public GameObject secondPrefabToSpawn;

    public int rndNumber = 0;

    // Corrects artwork to face correct direction
    public float adjustmentAngle = 0.0f;

    public void Spawn()
    {
        // Ensure there are no more than 40 targets before spawning another
        if (GameObject.FindGameObjectsWithTag("Target").Length < 40)
        {
            // Get current rotation in degrees
            Vector3 rotationInDegrees = transform.eulerAngles;
            // Add adjustment angle to z axis
            rotationInDegrees.z += adjustmentAngle;

            // Convert rotation into radians
            Quaternion rotationInRadians = Quaternion.Euler(rotationInDegrees);

            //If there is more than one prefab, randomly choose which of the two to spawn
            if (secondPrefabToSpawn != null)
            {
                rndNumber = Random.Range(0, 10);
                if (rndNumber < 5)
                {
                    // Spawn prefab into scene
                    Instantiate(prefabToSpawn, transform.position, rotationInRadians);
                }
                else
                {
                    // Spawn prefab into scene
                    Instantiate(secondPrefabToSpawn, transform.position, rotationInRadians);
                }
            }
            else
            {
                // Spawn prefab into scene
                Instantiate(prefabToSpawn, transform.position, rotationInRadians);
            }
        } 

    }
}
