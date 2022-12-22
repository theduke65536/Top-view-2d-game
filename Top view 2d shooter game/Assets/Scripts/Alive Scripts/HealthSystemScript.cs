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
    public PlayerUIScript playerUIScript;


    private void Start() {
        health = maxHealth;
    }


    public void Awake()
    {
        if (gameObject.CompareTag("Player"))
        {
            playerUIScript.SetMaxHealth(maxHealth);
        }
    }


    public void TakeDamage(float damage) {
        health -= damage;

        health = Mathf.Round(health);

        if (thisInstance.CompareTag("Player")) {
            playerUIScript.OnTakeDamage(damage);
        }
        // Kills the GameObject once it's health is zero.
        if (health <= 0) {
            Destroy(thisInstance);
        }
    }
}
