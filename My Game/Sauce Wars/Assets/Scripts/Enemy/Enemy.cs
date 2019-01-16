

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

    private void Start()
    {
        shootAnim = GetComponent<Animator>();
    }



    public void SetFiring()
    {
        print("Weapon - SetFiring");

        isFiring = false;
        shootAnim.SetBool("isFiring", false);
    }

    public void Fire()
    {
        print("Weapon - Fire");

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
    private void Update()
    {
        print("Weapon - Update");

        if (target != null)
        {
            Vector3 position = transform.position;
            Vector3 diff = target.transform.position - position;
            float currrentDistance = diff.sqrMagnitude;

            if (currrentDistance <= distanceToFireTarget)
            {
               
                if (!isFiring)
                {
                    print("!!!!!!");
                    Fire();
                }
            }
        }
    }


    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }

}
