using UnityEngine;

// Script called via UnityEvents from multiple other scripts
public class PlayerAnimationScript : MonoBehaviour
{
    public Animator animator;


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


    public void SetShoot(bool condition) {
        animator.SetBool("IsShooting", condition);


    }


    public void SetReload(bool condition) {
        animator.SetBool("IsReloading", condition);

        
    }



    public void SetKnifeEquipped() {
        animator.SetBool("KnifeEquipped", true);
        animator.SetBool("ShotgunEquipped", false);
        animator.SetBool("AssaultrifleEquipped", false);
        animator.SetBool("HandgunEquipped", false);
    }


    public void SetShotgunEquipped() {
        animator.SetBool("KnifeEquipped", false);
        animator.SetBool("ShotgunEquipped", true);
        animator.SetBool("AssaultrifleEquipped", false);
        animator.SetBool("HandgunEquipped", false);
    }


    public void SetAssaultrifleEquipped() {
        animator.SetBool("KnifeEquipped", false);
        animator.SetBool("ShotgunEquipped", false);
        animator.SetBool("AssaultrifleEquipped", true);
        animator.SetBool("HandgunEquipped", false);
    }


    public void SetHandgunEquipped() {
        animator.SetBool("KnifeEquipped", false);
        animator.SetBool("ShotgunEquipped", false);
        animator.SetBool("AssaultrifleEquipped", false);
        animator.SetBool("HandgunEquipped", true);
    }
}
