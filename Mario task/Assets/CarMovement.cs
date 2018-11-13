using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour {

    Rigidbody2D body;

    public float turnspeed = 150;
    public float fwdspeed = 20;

    [Range(0, 1)]
    public float drift = 0.5f;

    public float maxGripSpeed = 2.5f;



    // Use this for initialization
    void Start () {
        body = GetComponent<Rigidbody2D>();
        
		
	}
	
	// Update is called once per frame
	void Update () {
        float fwdinput = Input.GetAxis("Vertical");
        float turninput = Input.GetAxis("Horizontal");

        float driftAmount = 1;

        if (RightVelocity().magnitude > maxGripSpeed)
        {
            driftAmount = drift;
        }

        body.velocity = FwdVelocity() + RightVelocity() * driftAmount;

        //This prevents reversing.
        if (fwdinput > 0)
        {
            body.AddForce(transform.up * fwdspeed * fwdinput);
        }

        //This is for the turning.
        float tf = Mathf.Lerp(0, -turnspeed, body.velocity.magnitude * 0.5f);
        body.angularVelocity = turninput * tf;


        //body.AddForce(transform.up * fwdinput * fwdspeed);
        //body.AddTorque(turnspeed * turninput);
		
	}

    Vector2 FwdVelocity()
    {
        return transform.up * Vector2.Dot(body.velocity, transform.up);
    }

    Vector2 RightVelocity()
    {
        return transform.right * Vector2.Dot(body.velocity, transform.right);
    }
}
