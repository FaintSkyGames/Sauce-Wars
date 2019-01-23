

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public Transform target;

    public int distanceToFireTarget = 50;

    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public float fireTime = 0.5f;

    public bool isFiring = false;
    private Animator shootAnim;

    // Gets the animation
    private void Start()
    {
        shootAnim = GetComponent<Animator>();
    }


    // plays the animation when firing
    public void SetFiring()
    {
        isFiring = false;
        shootAnim.SetBool("isFiring", false);
    }

    // Spawns a bullet and plays chosen sound
    public void Fire()
    {
        isFiring = true;
        shootAnim.SetBool("isFiring", true);

        Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);

        if (GetComponent<AudioSource>() != null)
        {
            GetComponent<AudioSource>().Play();
        }
        Invoke("SetFiring", fireTime);
    }

    // Update is called once per frame
    // When the enemy is within range of the target, fire
    private void Update()
    {
        if (target != null)
        {
            Vector3 position = transform.position;
            Vector3 diff = target.transform.position - position;
            float currrentDistance = diff.sqrMagnitude;

            if (currrentDistance <= distanceToFireTarget)
            {
                if (!isFiring)
                {
                    Fire();
                }
            }
        }
    }

    // Sets a new target when the last dies
    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }

}
