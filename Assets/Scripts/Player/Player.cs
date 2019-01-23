using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private Animator shootAnim;

	// Use this for initialization
    // Gets the animation
	void Start () {
        shootAnim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
    // Allows the animation to play if player is firing
	void Update () {
        if (Input.GetMouseButton(0))
        {
            shootAnim.SetBool("isFiring", true);
        }
        else
        {
            shootAnim.SetBool("isFiring", false);
        }
		
	}
}
