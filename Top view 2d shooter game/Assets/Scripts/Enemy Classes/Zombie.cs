using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Zombie class
class Zombie : Enemy
{
    private float attackDamage;             // Damage dealt to player 

    public HealthSystemScript playerHealthScript;


    public Zombie
        (
            float _detectionRadius,
            float _speed,
            Transform _playerTransform,
            Transform _enemyTransform,

            float _attackRadius,
            float _attackDamage,
            EnemyAnimationScript _animationScript
        )
            : base(_detectionRadius, _speed, _playerTransform, _enemyTransform, _animationScript, _attackRadius)
    {
        attackDamage = _attackDamage;

        playerHealthScript = playerTransform.GetComponent<HealthSystemScript>();
    }


    // Attacks the player if they're in range
    public void Attack(float damage = 0) {
        if (playerHealthScript is not null) {
            // Simply another way to make an optional parameter without using consts
            // As 0 will never be used as an arguement
            if (damage == 0) {
                damage = attackDamage;

            }

            playerHealthScript.TakeDamage(damage);
        }
    }
}
