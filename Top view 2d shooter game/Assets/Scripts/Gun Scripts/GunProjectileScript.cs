using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Script attatched to each gun.
public class GunProjectileScript : MonoBehaviour
{
    public GameObject projectile;       // Projectile game object
    public Transform gunBarrelPosition; // The position that the projectile will be fired from.
    public float projectileSpeed;       // The speed of the projectile.
    public float cooldown;              // Speed at which the player can fire

    private float ongoingFireCooldown;

    // Fires the projectile.
    public void FireProjectile() {
        GameObject instantiatedProjectile = GameObject.Instantiate(projectile, gunBarrelPosition.position, Quaternion.Euler(gunBarrelPosition.right));
        Rigidbody2D instantiatedProjectileRb = instantiatedProjectile.GetComponent<Rigidbody2D>();

        instantiatedProjectileRb.velocity = gunBarrelPosition.right * projectileSpeed;

        instantiatedProjectile.transform.right = transform.right;
    }


    private void Update() {
        ongoingFireCooldown += Time.deltaTime;
        if (Input.GetButtonDown("Fire1") && ongoingFireCooldown >= cooldown) {
            FireProjectile();
            ongoingFireCooldown = 0;
        }
    }
}
