using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Lets gameobjects talk to each other
using UnityEngine.Events;

[System.Serializable]
public class OnDamagedEvent : UnityEvent<int> { }

public class HealthSystem : MonoBehaviour {

    public int health = 10;

    // A unity event
    public UnityEvent onDie;

    public OnDamagedEvent onDamaged;

    // When damage is taken, if the targets health is less than 1 it will die.
    public void TakeDamage(int damage)
    {
        health -= damage;
        onDamaged.Invoke(health);
        if (health < 1)
        {
            onDie.Invoke();
        }
    }

}
