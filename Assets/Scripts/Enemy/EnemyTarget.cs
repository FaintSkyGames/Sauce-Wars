using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]

public class EnemySpawnedEvent : UnityEvent<Transform> { }

public class EnemyTarget : MonoBehaviour {

    public GameObject target;

    // Use this for initialization
    private void Start()
    {
        target = FindClosestTarget();
        if (target != null)
        transform.SendMessage("SetTarget", target.transform, SendMessageOptions.DontRequireReceiver);
    }

    void Update()
    {
        if (target == null)
        {
            target = FindClosestTarget();
            transform.SendMessage("SetTarget", target.transform, SendMessageOptions.DontRequireReceiver);
        }
    }

    public GameObject FindClosestTarget()
    {
        GameObject[] targets;
        targets = GameObject.FindGameObjectsWithTag("Target");
        GameObject closest = null;
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;
        foreach (GameObject t in targets)
        {
            Vector3 diff = t.transform.position - position;
            float currrentDistance = diff.sqrMagnitude;
            if (currrentDistance < distance)
            {
                closest = t;
                distance = currrentDistance;
            }
        }
        return closest;
    }
}
