using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimationScript : MonoBehaviour {
    public Animator animator;

    public void SetMove(bool condition) {
        animator.SetBool("IsMoving", condition);
    }

    public void SetAttack(bool condition) {
        animator.SetBool("IsAttacking", condition);
    }

    private void Update() {
        if (   !animator.GetBool("IsMoving")
            && !animator.GetBool("IsAttacking"))
        {
            animator.SetBool("IsIdle", true);
        }
        else {
            animator.SetBool("IsIdle", false);
        }
    }
}
