using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Zombie class
public class Zombie : Enemy
{


    public Zombie
        (
            float _health,
            float _detectionRadius,
            float _speed,
            LayerMask playerLayer,
            Transform _playerTransform,
            Transform _enemyTransform
        )
            : base(_health, _detectionRadius, _speed, playerLayer, _playerTransform, _enemyTransform)
        { }
}
