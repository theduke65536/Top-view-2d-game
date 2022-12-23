using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShotgunScript : MonoBehaviour
{
    Shotgun shotgun;

    public GameObject projectile;              // Projectile game object
    public Transform gunBarrelPosition;        // The position that the projectile will be fired from.
    public float projectileSpeed;              // The speed of the projectile.
    public float cooldown;                     // Speed at which the player can fire
    public float directionalDeviationRange;    // The spread of the projectiles
    public int projectileCount;                // The number of projectiles

    private float ongoingCooldownTimer;


    private void Start()
    {
        shotgun = new Shotgun(projectile, gunBarrelPosition, projectileSpeed, directionalDeviationRange, projectileCount);
    }


    private void Update()
    {
        ongoingCooldownTimer += Time.deltaTime;
        if (ongoingCooldownTimer >= cooldown && Input.GetButtonDown("Fire1"))
        {
            ongoingCooldownTimer = 0;
            shotgun.FireProjectile();
        } 
    }
}   
