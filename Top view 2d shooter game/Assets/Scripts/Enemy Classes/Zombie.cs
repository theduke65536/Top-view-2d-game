using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : Enemy
{
    public float heightIncrease;


    public Zombie
        (
            float _health,
            float _detectionRadius,
            float _speed,
            LayerMask playerLayer,
            Transform _playerTransform,
            Transform _enemyTransform,

            float _heightIncrease
        )
            :base(_health, _detectionRadius, _speed, playerLayer, _playerTransform, _enemyTransform)
    {
        heightIncrease = _heightIncrease;
    }


    public void IncreaseHeight() {
        base.enemyTransform.Translate(new Vector3(0.1f,0.1f,0.1f));
    }
}
