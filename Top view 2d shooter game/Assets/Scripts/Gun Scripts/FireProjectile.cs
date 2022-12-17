using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireProjectile : MonoBehaviour
{
    public float damage;
    public float projectileVelocity;

    public Transform gunBarrel;
    public ParticleSystem projectileParticles;
    public GameObject projectile;


    private void Update() {
        if (Input.GetMouseButtonDown(0)) {
            Projectile newProjectile = new Projectile(projectile, projectileVelocity, damage, projectileParticles);

            newProjectile.FireProjectile(gunBarrel.position, gunBarrel.rotation);
        }
    }
}
