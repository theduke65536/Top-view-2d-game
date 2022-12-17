using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile
{
    public GameObject projectileObject;
    public float speed;
    public float damage;
    public ParticleSystem particlesOnDeath;

    public Projectile(GameObject _projectileObject, float _speed, float _damage, ParticleSystem _particlesOnDeath) {
        projectileObject = _projectileObject;
        speed = _speed;
        damage = _damage;
        particlesOnDeath = _particlesOnDeath;
    }


    public GameObject FireProjectile(Vector3 position, Quaternion rotation) {
        GameObject instantiatedProjectile = GameObject.Instantiate(projectileObject, position, rotation);
        Rigidbody2D instantiatedProjectileRigidbody = instantiatedProjectile.GetComponent<Rigidbody2D>();

        instantiatedProjectileRigidbody.velocity = instantiatedProjectile.transform.right * speed;

        return instantiatedProjectile;
    }
}
