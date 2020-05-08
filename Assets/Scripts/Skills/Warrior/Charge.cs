using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

public class Charge : Skill
{
    public float baseDamage;
    public LayerMask chargeCollisionmask;
    public ParticleSystem chargeParticle1, chargeParticle2;
    public float chargeSpeed;
    CharacterController cc;
    bool canUse = true;
    Warrior warrior;
    public SpecialEffect miniStunEffect;
    public override void Start() {
        base.Start();
        warrior = GetComponentInParent<Warrior>();
        cc = GetComponentInParent<CharacterController>();
    }

    
    public override void Update() {
        base.Update();
        if(anim.GetCurrentAnimatorStateInfo(0).IsName(animation1)) {
            warrior.RotationOverridenFromSkills();
        }
        
        if(anim.GetCurrentAnimatorStateInfo(0).IsName(animation2)) {
            CheckChargeCollisions();
            cc.Move(transform.parent.forward * chargeSpeed * Time.deltaTime);
        }
    }
    public void CheckChargeCollisions() {
        if(hasColliderInfront()) {
            anim.Play(animation3);
        }
    }
    public bool hasColliderInfront() {
        //RaycastHit hit;
        Ray ray = new Ray();
        ray.origin = transform.position + Vector3.up;
        ray.direction = transform.forward;
        float maxDistance = 1f;
        if(Physics.Raycast(ray, maxDistance, chargeCollisionmask)) {
            return true;
        } else {
            return false;
        }
    }
    public override void ButtonPressed(CallbackContext context) {
        if(!stats.isAlive) {
            return;
        }
        if(context.performed) {
            if(!OnCooldown() && canUse) {
                buttonPressed = context.ReadValue<float>();
                if(buttonPressed >= 0.5f ) {
                    if(canUseSkill()) {
                        anim.Play(animation1);
                        chargeParticle1.Play();
                    }
                } else {
                    if(anim.GetCurrentAnimatorStateInfo(0).IsName(animation1)) {
                        anim.Play(animation2);
                        chargeParticle1.Stop();
                        chargeParticle2.Play();
                        canUse = false;
                    }
                }
            }
        }
    }

    public override void PlayAnimation(string animation) {
        
    }

    public override void ExecuteStart() {

    }

    public override void ExecuteEnd() {
        SetCooldown();
        chargeParticle2.Stop();
        canUse = true;
        FinishEffect();
    }

    public override void StartEffect() {
    }

    public override void FinishEffect() {
        Vector3 center = transform.position + transform.up + transform.forward;
        Vector3 halfextends = new Vector3(1f, 1f, 1f);
        Collider[] colliders = Physics.OverlapBox(center, halfextends, transform.rotation, layerMask);
        foreach(Collider c in colliders) {
            if(c.transform != transform.parent) {
                IHitBox hitbox = c.GetComponent<IHitBox>();
                if(hitbox != null) {
                    hitbox.GetDamage(baseDamage + stats.currentDamage, transform.up);
                }
                IBuffsAndEffects buffsAndEffects = c.GetComponent<IBuffsAndEffects>();
                if(buffsAndEffects != null) {
                    buffsAndEffects.AddEffect(miniStunEffect);
                }
            }
        }
    }
}