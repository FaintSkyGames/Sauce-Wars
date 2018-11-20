using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour {

    public Transform target;

    public int distanceToFireTarget = 50;

    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public float fireTime = 0.5f;

    public bool isFiring = true;


    public void SetFiring()
    {
        print("Weapon - SetFiring");

        isFiring = false;
    }

    public void Fire()
    {
        print("Weapon - Fire");

        isFiring = true;
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
