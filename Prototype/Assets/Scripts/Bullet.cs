using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float moveSpeed = 100.0f;
    public int damage = 1;
    
	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().AddForce(transform.up * moveSpeed);
	}

    // When a collision occurs...
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // ...send a message to reduce the health of what collided...
        collision.transform.SendMessage("TakeDamage", damage, SendMessageOptions.DontRequireReceiver);
        // ...then kills itself.
        Die();
    }

    // When the bullet leaves the screen
    private void OnBecameInvisible()
    {
        Die();
    }

    public void Die()
    {
        Destroy(gameObject);
    }

}
