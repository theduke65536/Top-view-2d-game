using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieScript : MonoBehaviour
{
    private Zombie zombie;

    public float health;
    public float detectionRadius;
    public float speed;
    public LayerMask playerLayer;

    public Transform playerTransform;
    public Transform enemyTransform;

    private bool isPlayerInRange;

    private void Start() {
        zombie = new Zombie(health, detectionRadius, speed, playerLayer, playerTransform, enemyTransform, 2);

    }


    IEnumerator CheckIfPlayerInRange() {
        while (true){
            yield return new WaitForSeconds(0.1f);

            isPlayerInRange = zombie.CheckIfPlayerInRange();
        }
    }


    private void Update() {
        StartCoroutine(CheckIfPlayerInRange());

        if (isPlayerInRange) {
            zombie.LookAtPlayer();
            zombie.MoveTowardsPlayer();
        } else {
            zombie.PlayerNotInRange();
        }
    }

}
