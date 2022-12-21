using UnityEngine;

// Script called via UnityEvents from multiple other scripts
public class PlayerAnimationScript : MonoBehaviour
{
    public Animator animator;
    CircleCollider2D playerCollider;

    private void Start() {
        playerCollider = gameObject.GetComponent<CircleCollider2D>();
    }


    private void Update() {
        if (   !animator.GetBool("IsMoving")
            && !animator.GetBool("IsShooting")
            && !animator.GetBool("IsReloading"))
        {
            animator.SetBool("IsIdle", true);
        } else {
            animator.SetBool("IsIdle", false);
        }
    }


    public void SetMove(bool condition) {
        animator.SetBool("IsMoving", condition);
    }


    public void SetKnifeEquipped() {
        animator.SetBool("KnifeEquipped", true);
        animator.SetBool("ShotgunEquipped", false);
        animator.SetBool("AssaultrifleEquipped", false);
        animator.SetBool("HandgunEquipped", false);

        playerCollider.offset = new Vector2(-0.03f, -0.03f);
    }


    public void SetShotgunEquipped() {
        animator.SetBool("KnifeEquipped", false);
        animator.SetBool("ShotgunEquipped", true);
        animator.SetBool("AssaultrifleEquipped", false);
        animator.SetBool("HandgunEquipped", false);

        playerCollider.offset = new Vector2(-0.16f, -0.15f);
    }


    public void SetAssaultrifleEquipped() {
        animator.SetBool("KnifeEquipped", false);
        animator.SetBool("ShotgunEquipped", false);
        animator.SetBool("AssaultrifleEquipped", true);
        animator.SetBool("HandgunEquipped", false);

        playerCollider.offset = new Vector2(-0.16f, -0.15f);
    }


    public void SetHandgunEquipped() {
        animator.SetBool("KnifeEquipped", false);
        animator.SetBool("ShotgunEquipped", false);
        animator.SetBool("AssaultrifleEquipped", false);
        animator.SetBool("HandgunEquipped", true);

        playerCollider.offset = new Vector2(-0.16f, -0.15f);
    }
}
