using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    // Will be used to send the health of the player
    public delegate void UpdateHealth(int newHealth);
    // An event attached to UpdateHealth
    public static event UpdateHealth OnUpdateHealth;

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

    private void SendHealthData(int health)
    {
        // Listens to OnUpdateHealth message
        if (OnUpdateHealth != null)
        {
            // Sends the health value
            OnUpdateHealth(health);
        }
    }
}
