using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy
{
    public float health;
    public Transform playerTransform;
    public float detectionRadius;
    public Transform enemyTransform;
    public float speed;
    public LayerMask playerLayer;

    private Vector3 playerLookVector;
    private Rigidbody2D enemyRb;

    public Enemy(float _health, float _detectionRadius, float _speed, LayerMask _playerLayer, Transform _playerTransform, Transform _enemyTransform) {
        health = _health;
        playerTransform = _playerTransform;
        detectionRadius = _detectionRadius;
        enemyTransform = _enemyTransform;
        playerLayer = _playerLayer;
        speed = _speed;

        enemyRb = enemyTransform.GetComponent<Rigidbody2D>();
    }


    public bool CheckIfPlayerInRange() {
        Collider2D collider = Physics2D.OverlapCircle(enemyTransform.position, detectionRadius, playerLayer);

        if (collider != null) {
            return true;
        }
        return false;
    }


    public void PlayerNotInRange() {
        enemyRb.velocity = Vector2.zero;
        enemyTransform.right = playerLookVector;
    }


    public void LookAtPlayer() {

        playerLookVector = playerTransform.position - enemyTransform.position;
        enemyTransform.right = Vector3.Slerp(enemyTransform.right, playerLookVector, 0.2f);

    }


    public void MoveTowardsPlayer() {
        enemyRb.velocity = enemyTransform.right * speed;
    }
}
