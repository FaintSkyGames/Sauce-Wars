using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private Animator gunAnim;

	// Use this for initialization
	private void Start () {
        // Stores gun animator
        gunAnim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        // If mouse button pressed
        if (Input.GetMouseButton(0))
        {
            // Set animation to firing
            gunAnim.SetBool("isFiring", true);
        }
        else
        {
            // Set the animation to not firing
            gunAnim.SetBool("isFiring", false);
        }
	}
}
