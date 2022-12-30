using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Health system attatched to all alive GameObjects.
public class HealthSystemScript : MonoBehaviour
{
    public float maxHealth;                  // Maximum health the GameObject can have
    private float health;                    // Current health the GameObject has.
    [HideInInspector] public bool lingerDamageActive;
    public GameObject thisInstance;

    // The UI script to call to (will have different variable values on different gameobjs)
    public HealthUIScript targetUIScript;


    public void Awake()
    {
        health = maxHealth;

        targetUIScript.SetMaxHealth(maxHealth);
    }


    public void TakeDamage(float damage)
    {
        health -= damage;

        // Kills the GameObject once it's health is zero.
        if (health <= 0)
        {
            Destroy(thisInstance);
        }

        // Changes the gui
        targetUIScript.SetHealth(health);
    }
}
