using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Health system attatched to all alive GameObjects.
public class HealthSystemScript : MonoBehaviour
{
    public float maxHealth; // Maximum health the GameObject can have
    private float health;   // Current health the GameObject has.


    private void Start() {
        health = maxHealth;
    }


    private void TakeDamage(float damage) {
        health -= damage;
    }

    // Responsible for applying damage to the GameObject
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Projectile")) {
            var projectileScript = collision.gameObject.GetComponent<ProjectileScript>();
            TakeDamage(projectileScript.projectileDamage);
        }

        // Kills the GameObject once it's health is zero.
        if (health <= 0) {
            Destroy(gameObject);
        }
    }
}
