using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

// Script attatched to projectiles.
public class ProjectileScript : MonoBehaviour
{
    public ParticleSystem onCollisionParticles;
    public float projectileDamage;


    private void OnTriggerEnter2D(Collider2D collision) {
        Instantiate(onCollisionParticles, transform.position, Quaternion.identity);

        Destroy(gameObject);

        if (collision.gameObject.layer == LayerMask.NameToLayer("Alive")) {
            HealthSystemScript healthSystemScript = collision.gameObject.GetComponent<HealthSystemScript>();
            healthSystemScript.TakeDamage(projectileDamage);      
        }
    }
}
