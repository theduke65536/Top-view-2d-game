using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

// Script attatched to projectiles.
public class ProjectileScript : MonoBehaviour
{
    public float projectileDamage;

    private void OnTriggerEnter2D(Collider2D collision) {
        print("Hell");

        if (!collision.gameObject.CompareTag("Projectile"))
        
        {
        print("Hell2");
            Destroy(gameObject);

            if (collision.gameObject.layer == LayerMask.NameToLayer("Alive")) {
                HealthSystemScript healthSystemScript = collision.gameObject.GetComponent<HealthSystemScript>();
                healthSystemScript.TakeDamage(projectileDamage);      
            }
        }
    }
}
