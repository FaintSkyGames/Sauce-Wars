using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMovement : MonoBehaviour {

    Rigidbody2D rb2D; // Needs rigidbody to add the forces too.
    public float speed = 1f; // Speed
    Vector2 Movement;
    int continousMovement = 0;

    // Use this for initialization
    void Start() {
        rb2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (continousMovement < 3)
            continousMovement += 1;
        else
        {
            Movement = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)); // Gives a random vector to move to.
            continousMovement = 0;
        }
            
    }

    void FixedUpdate()
    {
        // code from https://answers.unity.com/questions/1369351/unity-2d-random-movement.html

        rb2D.AddForce(Movement * speed); // Adds the force to the rigidbody with the decided speed.

        // If you need to test the random movement values use 
        print(Movement);
    }

}
