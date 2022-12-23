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

    public EnemyAnimationScript animationScript;

    private float ongoingCooldownTimer = 0;
    private bool isPlayerInViewRange;

    private void Awake()
    {
        soldier = new Soldier(detectionRadius, speed, playerTransform, enemyTransform, attackRadius, animationScript, shotgunScript);
    }


    void Update()
    {
        isPlayerInViewRange = soldier.CheckIfPlayerInRange();

        if (isPlayerInViewRange)
        {
            soldier.LookAtPlayer();

            ongoingCooldownTimer += Time.deltaTime;
            if (ongoingCooldownTimer >= fireCooldown)
            {
                soldier.Attack();
                ongoingCooldownTimer = 0f;

            }
        }
        else
        {
            ongoingCooldownTimer = 0f;
        }
    }
}
