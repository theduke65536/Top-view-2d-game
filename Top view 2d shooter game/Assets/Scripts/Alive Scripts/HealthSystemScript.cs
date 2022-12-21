using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

// Health system attatched to all alive GameObjects.
public class HealthSystemScript : MonoBehaviour
{
    public float maxHealth;                  // Maximum health the GameObject can have
    private float health;                    // Current health the GameObject has.
    [HideInInspector] public bool lingerDamageActive;
    public GameObject thisInstance;


    private void Start() {
        health = maxHealth;
    }


    public void TakeDamage(float damage) {
        health -= damage;

        if (thisInstance.CompareTag("Player")) {
            print(health);
        }
        // Kills the GameObject once it's health is zero.
        if (health <= 0) {
            Destroy(thisInstance);
        }
    }
}
