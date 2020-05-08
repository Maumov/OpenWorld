using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WarriorAttack : Skill
{

    public float BaseDamage = 10f;
    bool attack;
    public ParticleSystem /*attackParticle1,*/ swordHitParticle;
    public TrailRenderer trail;
    public ParticleSystem baseParticleSystem2;
    //public LayerMask layerMask;
    public override void ButtonPressed(InputAction.CallbackContext context) {
        if(!stats.isAlive) {
            return;
        }
        if(context.performed) {
            buttonPressed = context.ReadValue<float>();
            if(canUseSkill() && !OnCooldown()) {
                
                anim.SetTrigger("Attack");
                anim.SetBool("Attack1", attack);
                attack = !attack;
                SetCooldown();
            }
        }
    }

    public override void ExecuteEnd() {
        //Debug.Log("The basic attack !!!");
        //attackParticle1.Play();
        FinishEffect();
    }

    public override void ExecuteStart() {

    }

    public override void StartEffect() {

    }


    public override void FinishEffect() {
        Vector3 center = transform.position + transform.up + transform.forward;
        Vector3 halfextends = new Vector3(1f, 1f, 1f);
        Collider[] colliders = Physics.OverlapBox(center, halfextends, transform.rotation, layerMask);
        Debug.Log(colliders.Length);
        foreach(Collider c in colliders) {
            Ray ray = new Ray();
            ray.origin = transform.position + transform.up;
            ray.direction = c.transform.position - (transform.position);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit, 3f)) {
                IHitBox hitbox = hit.collider.GetComponent<IHitBox>();
                if(hitbox != null) {
                    Instantiate(swordHitParticle, hit.point, Quaternion.Euler(hit.normal));
                    hitbox.GetDamage(BaseDamage + stats.currentDamage, transform.forward);
                }
            }
        }

    }

    public void SlashStart() {
        if(!attack) {
            baseParticleSystem2.Play();
        } else {
            baseParticleSystem.Play();
        }
        trail.emitting = true;
    }

    public void SlashEnd() {
        trail.emitting = false;
        baseParticleSystem.Stop();
        baseParticleSystem2.Stop();
    }
}
