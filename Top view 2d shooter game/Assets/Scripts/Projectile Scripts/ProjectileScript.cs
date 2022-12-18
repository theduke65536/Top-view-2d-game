using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ProjectileScript : MonoBehaviour
{
    public ParticleSystem onCollisionParticles;


    private void OnCollisionEnter2D(Collision2D collision) {
        Instantiate(onCollisionParticles, transform.position, Quaternion.identity);

        Destroy(gameObject);
    }
}
