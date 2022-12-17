using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Attatched to each gun and is used to fire projectiles out of the gun.
public class GunScript : MonoBehaviour
{
    public float projectileVelocity;    // Speed of the projectile

    public Transform gunBarrel;         // Where the bullet will be instantiated
    public GameObject projectile;       // The projectile itself

    private void Update() {
        if (Input.GetMouseButtonDown(0)) {
            Projectile newProjectile = new Projectile(projectile, projectileVelocity);

            newProjectile.FireProjectile(gunBarrel.position, gunBarrel.rotation, gameObject);
        }
    }
}
