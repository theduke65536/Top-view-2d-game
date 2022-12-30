using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Soldier : Enemy
{
    private SoldierShotgunScript shotgunScript;


    public Soldier
        (
            float _detectionRadius,
            float _speed,
            Transform _playerTransform,
            Transform _enemyTransform,
            float _attackRadius,
            EnemyAnimationScript _animationScript,

            SoldierShotgunScript _shotgunScript


        ) : base(_detectionRadius, _speed, _enemyTransform, _animationScript, _attackRadius)
    {
        shotgunScript = _shotgunScript;
    }


    public void Attack()
    {
        shotgunScript.shotgun.FireProjectile();
    }
}
