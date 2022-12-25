using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Script attatched to the Zombie prefab.
public class ZombieScript : MonoBehaviour
{
    private Zombie zombie;               // Zombie class

    public float detectionRadius;        // The radius at which the player is seen by the zombie
    public float speed;                  // How fast the zombie moves
    public float attackRadius;           // Range at which the enemy can attach the player
    public float attackDamage;           // Damage which is dealt to the player
    public float attackCooldown;         // Time between each zombie attack
    public float lingeringDamageSpeed;   // Rate at which the player takes lingering damage
    public float lingeringDamageDuration;// How long lingering damage lasts

    public EnemyAnimationScript animationScript;
    public Canvas canvas;

    public Transform playerTransform;
    public Transform enemyTransform;

    private bool isPlayerInViewRange;
    private bool isPlayerInAtkRange;
    private float ongoingAttackCooldown;
    private float lingeringDamageOngoingTimer;


    private void Start()
    {
        zombie = new Zombie(detectionRadius, speed, playerTransform, enemyTransform, attackRadius, attackDamage, animationScript);
    }


    private void Update()
    {
        isPlayerInAtkRange = zombie.CheckIfPlayerInAtkRange();

        // Attacks the player if they're in range and cooldown has finished
        ongoingAttackCooldown += Time.deltaTime;
        if (isPlayerInAtkRange && ongoingAttackCooldown >= attackCooldown) {
            zombie.Attack();

            // Will only start lingering damage timer if there isn't one already running
            // So the player cant get x2 lingering damage
            if (!zombie.playerHealthScript.lingerDamageActive) {
                StartCoroutine(LingeringDamageTimer());
            }
            else {
                lingeringDamageOngoingTimer = 0;
            }
            ongoingAttackCooldown = 0;
        }

        
        isPlayerInViewRange = zombie.CheckIfPlayerInRange();

        if (isPlayerInViewRange) {
            zombie.LookAtPlayer();
            zombie.MoveTowardsPlayer();
        } else {
            zombie.PlayerNotInRange();
        }

        canvas.transform.position = transform.position;
    }

    // When the zombie attacks the player, they slowly continue taking damage overtime
    // Like an infection
    IEnumerator LingeringDamageTimer() {
        zombie.playerHealthScript.lingerDamageActive = true;


        while (lingeringDamageOngoingTimer <= lingeringDamageDuration) {
            // Acts the same as a timer
            lingeringDamageOngoingTimer += lingeringDamageSpeed;

            yield return new WaitForSeconds(lingeringDamageSpeed);

            zombie.Attack(1f);
        }

        zombie.playerHealthScript.lingerDamageActive = false;
        lingeringDamageOngoingTimer = 0;
    }

}
