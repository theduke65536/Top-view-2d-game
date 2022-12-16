using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile
{
    public float damage;

    public GameObject projectileObject;
    public SpriteRenderer spriteRenderer;
    public Sprite projectileSprite;

    public Projectile(float _damage, GameObject _projectileObject, Sprite _projectileSprite) {
        damage = _damage;
        projectileObject = _projectileObject;
        projectileSprite = _projectileSprite;
    }


    public GameObject FireProjectile(Vector3 position, Quaternion rotation, Vector2 velocity) {
        GameObject instantiatedProjectile = GameObject.Instantiate(projectileObject, position, rotation);
        Rigidbody2D instantiatedProjectileRigidbody = instantiatedProjectile.GetComponent<Rigidbody2D>();

        instantiatedProjectileRigidbody.velocity = velocity;

        return instantiatedProjectile;
    }
}
