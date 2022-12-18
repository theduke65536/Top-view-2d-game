using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public GameObject projectile;
    public Transform gunBarrelPosition;
    public float projectileSpeed;
    public float projectileDamage;


    public void FireProjectile() {
        GameObject instantiatedProjectile = GameObject.Instantiate(projectile, gunBarrelPosition.position, Quaternion.Euler(gunBarrelPosition.right));
        Rigidbody2D instantiatedProjectileRb = instantiatedProjectile.GetComponent<Rigidbody2D>();

        instantiatedProjectileRb.velocity = gunBarrelPosition.right * projectileSpeed;

        instantiatedProjectile.transform.right = transform.right;
    }


    private void Update() {
        if (Input.GetButtonDown("Fire1")) {
            FireProjectile();
        }
    }
}
