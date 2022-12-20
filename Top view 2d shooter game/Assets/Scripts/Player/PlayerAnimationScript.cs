using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Script called via UnityEvents from multiple other scripts
public class PlayerAnimationScript : MonoBehaviour
{
    public Animator animator;


    public void Move() {
        animator.SetBool("IsMoving",true);
    }


    public void Shoot() {
        animator.SetBool("IsShooting", true);
    }


    public void Reload() {
        animator.SetBool("IsReloading", true);
    }


    public void KnifeEquipped() {
        animator.SetBool("KnifeEquipped", true);
    }


    public void ShotgunEquipped() {
        animator.SetBool("ShotgunEquipped", true);
    }


    public void AssaultrifleEquipped() {
        animator.SetBool("AssaultrifleEquipped", true);
    }


    public void HandgunEquipped() {
        animator.SetBool("HandgunEquipped", true);
    }
}
