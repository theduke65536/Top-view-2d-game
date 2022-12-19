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

    private bool permitShoot = true;           // Whether or not the player can shoot


    IEnumerator FireCooldown() {
        permitShoot = false;
        yield return new WaitForSeconds(cooldown);
        permitShoot = true;
    }


    // Fires the projectile.
    public void FireProjectile() {
        StartCoroutine(FireCooldown());

        GameObject instantiatedProjectile = GameObject.Instantiate(projectile, gunBarrelPosition.position, Quaternion.Euler(gunBarrelPosition.right));
        Rigidbody2D instantiatedProjectileRb = instantiatedProjectile.GetComponent<Rigidbody2D>();

        instantiatedProjectileRb.velocity = gunBarrelPosition.right * projectileSpeed;

        instantiatedProjectile.transform.right = transform.right;
    }


    private void Update() {
        if (Input.GetButtonDown("Fire1") && permitShoot) {
            FireProjectile();
        }
    }
}
