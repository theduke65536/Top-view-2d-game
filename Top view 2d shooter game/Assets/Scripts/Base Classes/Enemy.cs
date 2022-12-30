using UnityEngine;

// Enemy base class. Inherited by all enemy types.
abstract class Enemy
{
    protected float detectionRadius;       // The radius at which the player is seen by the enemy
    protected float speed;                 // How fast the enemy moves
    protected float attackRadius;          // Radius which the enemy will attack the player

    protected Transform enemyTransform;
    protected Transform playerTransform;

    protected Vector3 playerLookVector;   // Direction pointing at the player
    protected Rigidbody2D enemyRb;

    protected EnemyAnimationScript animationScript;


    public Enemy(float _detectionRadius, float _speed, Transform _enemyTransform, EnemyAnimationScript _animationScript, float _attackRadius)
    {
        playerTransform = GameObject.Find("Player").transform;
        detectionRadius = _detectionRadius;
        enemyTransform = _enemyTransform;
        speed = _speed;

        enemyRb = enemyTransform.GetComponent<Rigidbody2D>();
        animationScript = _animationScript;
        attackRadius = _attackRadius;

    }


    // Checks if the player is currently within detectionRadius.
    public bool CheckIfPlayerInRange()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(enemyTransform.position, detectionRadius);

        foreach (Collider2D collider in colliders)
        {
            if (collider.gameObject.CompareTag("Player"))
            {
                return true;
            }
        }
        return false;
    }


    // This is called when the player isn't in range
    // to stop the zombie from continuously moving forward 
    public void PlayerNotInRange()
    {
        enemyRb.velocity = Vector2.zero;
        enemyTransform.right = playerLookVector;
        animationScript?.SetMove(false);
    }


    // Points the transform.right of the zombie to the player.
    public void LookAtPlayer()
    {
        playerLookVector = playerTransform.position - enemyTransform.position;
        enemyTransform.right = Vector3.Slerp(enemyTransform.right, playerLookVector, 0.2f);
    }


    // Moves towards the player.
    public void MoveTowardsPlayer()
    {
        enemyRb.velocity = enemyTransform.right * speed;
        animationScript?.SetMove(true);
    }

    // Checks if the player is in range to be attacked
    public bool CheckIfPlayerInAtkRange()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(enemyTransform.position, attackRadius);

        foreach (Collider2D collider in colliders)
        {
            if (collider.gameObject.CompareTag("Player"))
            {
                return true;
            }
        }

        return false;
    }
}
