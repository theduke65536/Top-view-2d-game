using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierScript : MonoBehaviour
{
    private Soldier soldier;

    public SoldierShotgunScript shotgunScript;
    public float detectionRadius;
    public float speed;
    public Transform playerTransform;
    public Transform enemyTransform;
    public float attackRadius;
    public float fireCooldown;
    public Canvas canvas;

    public EnemyAnimationScript animationScript;

    private float ongoingCooldownTimer = 0;
    private bool isPlayerInViewRange;
    private bool isPlayerInAttackRange;

    private void Awake()
    {
        soldier = new Soldier(detectionRadius, speed, playerTransform, enemyTransform, attackRadius, animationScript, shotgunScript);
    }


    void Update()
    {
        canvas.transform.position = transform.position;

        isPlayerInViewRange = soldier.CheckIfPlayerInRange();
        isPlayerInAttackRange = soldier.CheckIfPlayerInAtkRange();
        
        // Soldier will move towards player until in attack range 
        // Where it will stop moving and shoot at them
        if (isPlayerInAttackRange)
        {
            ongoingCooldownTimer += Time.deltaTime;
            if (ongoingCooldownTimer >= fireCooldown)
            {
                soldier.Attack();
                ongoingCooldownTimer = 0f;
            }
            soldier.LookAtPlayer();
            soldier.PlayerNotInRange();
        }
        else if (isPlayerInViewRange)
        {
            soldier.LookAtPlayer();
            soldier.MoveTowardsPlayer();
        }
        else
        {
            ongoingCooldownTimer = 0f;
        }
    }
}
