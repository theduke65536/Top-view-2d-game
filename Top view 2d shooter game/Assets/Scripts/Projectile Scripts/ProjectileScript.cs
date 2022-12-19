using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

// Script attatched to projectiles.
public class ProjectileScript : MonoBehaviour
{
    public ParticleSystem onCollisionParticles;
    public float projectileDamage;

    // Plays a particle effect on collision then destroys itself.
    private void OnCollisionEnter2D(Collision2D collision) {
        Instantiate(onCollisionParticles, transform.position, Quaternion.identity);

        Destroy(gameObject);
    }
}
