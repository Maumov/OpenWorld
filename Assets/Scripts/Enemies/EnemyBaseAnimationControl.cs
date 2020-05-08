using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBaseAnimationControl : MonoBehaviour
{
    public Animator visuals;
    NavMeshAgent agent;
    Stats stats;
    private void Start() {
        stats = GetComponentInParent<Stats>();
        agent = GetComponent<NavMeshAgent>();
        GetComponent<Stats>().OnDead += Dead;
        GetComponent<Stats>().OnDamaged += Damaged;
    }

    private void Update() {
        visuals.SetFloat("Speed", agent.velocity.magnitude);

        if((stats.status & StatusEffect.Stunned) != 0) {
            visuals.SetBool("Stunned", true);
        } else {
            visuals.SetBool("Stunned", false);
        }
        if((stats.status & StatusEffect.Injured) != 0) {
            visuals.SetBool("Injured", true);
        } else {
            visuals.SetBool("Injured", false);
        }
        if((stats.status & StatusEffect.Frozen) != 0) {
            visuals.SetFloat("AnimationSpeedMultiplier", 0f);
        } else {
            visuals.SetFloat("AnimationSpeedMultiplier", 1f);
        }
    }

    public void Attack() {
        visuals.SetTrigger("Attack");
    }

    public void Damaged() {
        if(!visuals.GetBool("Attack") && visuals.GetCurrentAnimatorStateInfo(0).IsTag("Locomotion") && !visuals.IsInTransition(0) ) {
            visuals.SetTrigger("Damaged");
        }
    }

    public void Dead() {
        visuals.SetTrigger("Dead");
    }

    public void Stunned(bool value) {
        visuals.SetBool("Stunned", value);
        visuals.SetBool("Attack",false);
    }

    public void Injured(bool value) {
        visuals.SetBool("Injured", value);
    }
    
    public void InCombat(bool value) {
        visuals.SetBool("InCombat", value);
    }
}
