using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireMage : CharacterMovement, IHitBox
{


    // Start is called before the first frame update
    public override void Start() {
        base.Start();
        stats.OnDead += Dead;
        stats.OnDamaged += Damaged;
    }

    public override void Rotate() {
        if(!stats.isAlive) {
            return;
        }
        if(direction.magnitude > 0f) {
            if(anim.GetCurrentAnimatorStateInfo(0).IsTag("Locomotion")) {
                correctedDirection = cameraController.transform.rotation * new Vector3(direction.x, 0f, direction.y);
                transform.LookAt(transform.position + correctedDirection);
            }
        } else {
            correctedDirection = Vector3.zero;
        }
    }
    public override void Move() {
        if(!stats.isAlive || ((stats.status & StatusEffect.Frozen) != 0)) {
            return;
        }
        if(direction.magnitude > 0f) {
            if(!anim.GetCurrentAnimatorStateInfo(0).IsTag("Locomotion")) {
                locomotionDirection = Vector3.zero;
            } else {
                locomotionDirection = correctedDirection * stats.currentMovement;
            }
        } else {
            locomotionDirection = Vector3.zero;
        }
    }
    Renderer rend;
    public void GetDamage(float damage, Vector3 direction, Stats damageOwner) {
        GetComponent<Stats>().GetDamage(damage);
        StartCoroutine(flash());
    }

    void Dead() {
        anim.SetBool("Dead", true);
    }
    void Damaged() {
        if(!anim.GetBool("Attack") && anim.GetCurrentAnimatorStateInfo(0).IsTag("Locomotion") && !anim.IsInTransition(0)) {
            anim.SetTrigger("Damaged");
        }
    }

    IEnumerator flash() {
        if(rend != null) {
            rend.material.EnableKeyword("_EMISSION");
            rend.material.SetColor("_EmissionColor", Color.white);
            yield return new WaitForSeconds(0.12f);
            rend.material.SetColor("_EmissionColor", Color.black);
        } else {
            rend = GetComponentInChildren<Renderer>();
            rend.material.EnableKeyword("_EMISSION");
            rend.material.SetColor("_EmissionColor", Color.white);
            yield return new WaitForSeconds(0.12f);
            rend.material.SetColor("_EmissionColor", Color.black);
        }
    }
}
