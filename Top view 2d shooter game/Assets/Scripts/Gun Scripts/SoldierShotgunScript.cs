using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierShotgunScript : MonoBehaviour
{
    public Shotgun shotgun;

    public GameObject projectile;              // Projectile game object
    public Transform gunBarrelPosition;        // The position that the projectile will be fired from.
    public float projectileSpeed;              // The speed of the projectile.
    public float directionalDeviationRange;    // The spread of the projectiles
    public int projectileCount;                // The number of projectiles

    [HideInInspector] public bool playerInRange;



    private void Start()
    {
        shotgun = new Shotgun(projectile, gunBarrelPosition, projectileSpeed, directionalDeviationRange, projectileCount);
    }
}
