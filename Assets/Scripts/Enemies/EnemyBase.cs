using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBase : MonoBehaviour, IAttack, IHitBox
{
    public EnemySpawnArea spawnArea;
    Targeting targeting;
    public GameObject target;
    float distanceFromTarget;
    Animator FSMAnimator;
    SkinnedMeshRenderer rend;

    EnemyBaseAnimationControl animationControl;
    private void Start() {

        rend = GetComponentInChildren<SkinnedMeshRenderer>();
        FSMAnimator = GetComponent<Animator>();
        animationControl = GetComponent<EnemyBaseAnimationControl>();
        targeting = GetComponentInChildren<Targeting>();
        GetComponent<Stats>().OnDead += Dead;

    }

    private void Update() {
        if(targeting.hasTarget()) {
            target = targeting.currentTarget.stats.gameObject;
            distanceFromTarget = Vector3.Distance(transform.position, target.transform.position);
            animationControl.InCombat(true);
        } else {
            animationControl.InCombat(false);
            target = null;
        }
        SetFSMValues();
    }


    void SetFSMValues() {
        FSMAnimator.SetBool("hasTarget", target != null? true : false);
        FSMAnimator.SetFloat("distanceFromTarget", distanceFromTarget);
    }

    
    public float timeBetweenAttacks;
    float nextAttack = 0;
    public void Attack() {
        if(nextAttack < Time.time) {
            animationControl.Attack();
            nextAttack = Time.time + timeBetweenAttacks;
        }
        LookAtTarget();
    }

    
    public void LookAtTarget() {
        if(target != null) {
            Vector3 position = transform.position + (target.transform.position - transform.position);
            position.y = transform.position.y;
            transform.LookAt(position);
        }
    }
    void Dead() {
        FSMAnimator.SetTrigger("Dead");
        GetComponent<CapsuleCollider>().enabled = false;
        targeting.enabled = false;
    }

    public void GetDamage(float damage, Vector3 direction) {
        GetComponent<Stats>().GetDamage(damage);
        StartCoroutine(flash(direction));
    }
    
    IEnumerator flash(Vector3 direction) {
        rend.material.EnableKeyword("_EMISSION");
        rend.material.SetColor("_EmissionColor", Color.white);
        GetComponent<EnemyMovement>().HitKickBack();
        yield return new WaitForSeconds(0.12f);
        //Debug.Log("asdsad");
        rend.material.SetColor("_EmissionColor", Color.black);
        yield return null;
    }
}
