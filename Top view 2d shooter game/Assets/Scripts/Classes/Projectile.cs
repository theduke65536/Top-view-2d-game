using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Creates a projectile when the player presses mouse 0 and a gun is equiped.
public class Projectile
{
    public GameObject projectileObject; // Projectile object itself
    public float speed;                 // Speed of the projectile

    public Projectile(GameObject _projectileObject, float _speed) {
        projectileObject = _projectileObject;
        speed = _speed;
    }


    public GameObject FireProjectile(Vector3 position, Quaternion rotation, GameObject parent) {
        GameObject instantiatedProjectile = GameObject.Instantiate(projectileObject, position, rotation);
        Rigidbody2D instantiatedProjectileRigidbody = instantiatedProjectile.GetComponent<Rigidbody2D>();

        // Sent in the direction the player is looking
        instantiatedProjectileRigidbody.velocity = instantiatedProjectile.transform.right * speed;

        return instantiatedProjectile;
    }
}
