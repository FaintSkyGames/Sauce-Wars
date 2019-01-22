using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCharacterController : MonoBehaviour {

    //controls movement speed
    public float speed = 5.0f;
    Rigidbody2D rigidbody2D;

    // Use this for initialization
    void Start()
    {
        print("TopDownCharacterController - Start");

        //Gets the rigidbody from the character
        rigidbody2D = GetComponent<Rigidbody2D>();

        PlayerPrefs.SetFloat("PlayerSpeed", speed);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        print("TopDownCharacterController - FixedUpdate");

        speed = PlayerPrefs.GetFloat("PlayerSpeed");

        //gets input along x-axis
        float x = Input.GetAxis("Horizontal");
        //gets input along y-axis
        float y = Input.GetAxis("Vertical");

        //sets velocity * speed
        rigidbody2D.velocity = new Vector2(x, y) * speed;
        //prevents player spin in reation to game physics
        rigidbody2D.angularVelocity = 0.0f;
    }
}
