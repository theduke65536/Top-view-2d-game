using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Script attatched to the Zombie prefab.
public class ZombieScript : MonoBehaviour
{
    private Zombie zombie;  // Zombie class

    public float health;            // Health of the zombie
    public float detectionRadius;   // The radius at which the player is seen by the zombie
    public float speed;             // How fast the zombie moves
    public LayerMask playerLayer;   // The LayerMask of the player

    public Transform playerTransform;
    public Transform enemyTransform;

    private bool isPlayerInRange;   

    // Creates a zombie object
    private void Start() {
        zombie = new Zombie(health, detectionRadius, speed, playerLayer, playerTransform, enemyTransform);
    }


    private void Update() {

        isPlayerInRange = zombie.CheckIfPlayerInRange();

        if (isPlayerInRange) {
            zombie.LookAtPlayer();
            zombie.MoveTowardsPlayer();
        } else {
            zombie.PlayerNotInRange();
        }
    }

}
