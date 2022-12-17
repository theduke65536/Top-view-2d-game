using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Script attatched to each projectile
public class ProjectileScript : MonoBehaviour
{
    public ParticleSystem particlesOnCollision; // The particle effect that's instantiated on the projectile's collision
    public static float damage;                        // Damage dealt by the projectile


    private void Update() {

    }


    private void OnCollisionEnter2D(Collision2D collision) {
        Instantiate(particlesOnCollision, transform.position, Quaternion.identity);

        Destroy(gameObject);
    }
}
