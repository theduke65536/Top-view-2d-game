using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Script attatched to each gun.
public class Shotgun
{
    public GameObject projectile;              // Projectile game object
    public Transform gunBarrelPosition;        // The position that the projectile will be fired from.
    public float projectileSpeed;              // The speed of the projectile.
    public float directionalDeviationRange;    // The spread of the projectiles
    public int projectileCount;                // The number of projectiles


    public Shotgun(GameObject _projectile,
        Transform _gunBarrelPosition,
        float _projectileSpeed,
        float _directionalDeviationRange,
        int _projectileCount
        )
    {
        projectile = _projectile;
        gunBarrelPosition = _gunBarrelPosition;
        projectileSpeed = _projectileSpeed;
        directionalDeviationRange = _directionalDeviationRange;
        projectileCount = _projectileCount;
    }


    // Fires the projectile.
    public void FireProjectile() {
        for (int i = 0; i < projectileCount; i++)
        {
            float directionalDeviationAmount = Random.Range(-directionalDeviationRange, directionalDeviationRange);
            float randomAngularStep = Random.Range(-directionalDeviationRange, directionalDeviationRange);

            Quaternion directionalDeviationQuaternion = Quaternion.AngleAxis(directionalDeviationAmount, Vector3.forward);

            GameObject instantiatedProjectile = GameObject.Instantiate(projectile, gunBarrelPosition.position, gunBarrelPosition.rotation);
            Rigidbody2D instantiatedProjectileRb = instantiatedProjectile.GetComponent<Rigidbody2D>();

            instantiatedProjectile.transform.rotation = Quaternion.RotateTowards(instantiatedProjectile.transform.rotation, directionalDeviationQuaternion, randomAngularStep);
            instantiatedProjectileRb.velocity = instantiatedProjectile.transform.right * projectileSpeed;


        }
    }
}

