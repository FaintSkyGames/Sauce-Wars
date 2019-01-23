using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsTarget : MonoBehaviour {

    public Transform target;
    public float speed = 5.0f;

    // Use this for initialization
    void Start () {
        PlayerPrefs.SetFloat("EnemySpeed", speed);
    }
	
	// Update is called once per frame
	void Update () {

        // Upodates the speed
        speed = PlayerPrefs.GetFloat("EnemySpeed");

        // Addjusts the position to get closer to the target
        if (target != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * 0.01f);
        }
    }

    // Sets a new target should the last have been killed
    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }
}
