using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Script attatched to each gun.
public class ShotgunProjectileScript : MonoBehaviour
{
    public GameObject projectile;              // Projectile game object
    public Transform gunBarrelPosition;        // The position that the projectile will be fired from.
    public float projectileSpeed;              // The speed of the projectile.
    public float cooldown;                     // Speed at which the player can fire
    public float directionalDeviationRange;    // The spread of the projectiles
    public int projectileCount;                // The number of projectiles

    private float ongoingFireCooldown;

    // Fires the projectile.
    public void FireProjectile() {
        for (int i = 0; i < projectileCount; i++)
        {
            // Generates a random vector pointing to the direction the projectile will go in
            float directionalDeviationAmount = Random.Range(-directionalDeviationRange, directionalDeviationRange);
            Vector3 directionalDeviationVector = new Vector3(directionalDeviationAmount, directionalDeviationAmount, 0);

            // We don't have to worry about the rotation now, we'll just set it later on.
            GameObject instantiatedProjectile = GameObject.Instantiate(projectile, gunBarrelPosition.position, Quaternion.identity);
            Rigidbody2D instantiatedProjectileRb = instantiatedProjectile.GetComponent<Rigidbody2D>();

            // Adds spread to the bullet like in a shotgun in real life.
            Vector3 travelDirectionVector = gunBarrelPosition.right + directionalDeviationVector;
            instantiatedProjectileRb.velocity = travelDirectionVector.normalized * projectileSpeed;

            instantiatedProjectile.transform.right = instantiatedProjectileRb   .velocity;

        }
    }


    private void Update() {
        ongoingFireCooldown += Time.deltaTime;
        if (Input.GetButtonDown("Fire1") && ongoingFireCooldown >= cooldown) {
            FireProjectile();
            ongoingFireCooldown = 0;
        }
    }
}

