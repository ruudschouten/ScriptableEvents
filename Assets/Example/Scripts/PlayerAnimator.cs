using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    public Animator Animator;

    public void PlayHealAnimation()
    {
        Animator.Play("HealAnimation");
    }

    public void PlayDamageAnimation()
    {
        Animator.Play("DamageAnimation");
    }
    
    public void PlayDeathAnimation()
    {
        Animator.Play("DamageAnimation");
        Animator.SetBool("PlayerDied", true);
    }

    public void Respawn()
    {
        Animator.SetBool("PlayerDied", false);
    }
}
