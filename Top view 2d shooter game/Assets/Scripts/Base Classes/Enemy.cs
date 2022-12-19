using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Enemy base class. Inherited by all enemy types.
public abstract class  Enemy
{
    public float health;                // Health of the enemy
    public float detectionRadius;       // The radius at which the player is seen by the enemy
    public float speed;                 // How fast the enemy moves

    public Transform enemyTransform;
    public Transform playerTransform;   

    private Vector3 playerLookVector;   // Direction pointing at the player
    private Rigidbody2D enemyRb;

    public Enemy(float _health, float _detectionRadius, float _speed, LayerMask _playerLayer, Transform _playerTransform, Transform _enemyTransform) {
        health = _health;
        playerTransform = _playerTransform;
        detectionRadius = _detectionRadius;
        enemyTransform = _enemyTransform;
        speed = _speed;

        enemyRb = enemyTransform.GetComponent<Rigidbody2D>();
    }

    // Checks if the player is currently within detectionRadius.
    public bool CheckIfPlayerInRange() {
<<<<<<< Updated upstream
        Collider2D[] colliderArr = Physics2D.OverlapCircleAll(enemyTransform.position, detectionRadius);

        if (colliderArr != null) {
            foreach(Collider2D collider in colliderArr)
            {
                if (collider.gameObject.CompareTag("Player"))
                {
                    return true;
                }
=======
        Collider2D[] colliders = Physics2D.OverlapCircleAll(enemyTransform.position, detectionRadius);

        foreach(Collider2D collider in colliders) {
            if (collider.gameObject.CompareTag("Player")) {
                return true;
>>>>>>> Stashed changes
            }
        }

        return false;
    }

    // This is called when the player isn't in range
    // to stop the zombie from continuously moving forward 
    public void PlayerNotInRange() {
        enemyRb.velocity = Vector2.zero;
        enemyTransform.right = playerLookVector;
    }

    // Points the transform.right of the zombie to the player.
    public void LookAtPlayer() {

        playerLookVector = playerTransform.position - enemyTransform.position;
        enemyTransform.right = Vector3.Slerp(enemyTransform.right, playerLookVector, 0.2f);

    }

    // Moves towards the player.
    public void MoveTowardsPlayer() {
        enemyRb.velocity = enemyTransform.right * speed;
    }
}
