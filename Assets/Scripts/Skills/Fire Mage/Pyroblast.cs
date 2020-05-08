using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Pyroblast : Skill
{
    public float BaseDamage = 10f;
    public float missileSpeed = 5f;

    public GameObject missilePrefab;
    public Transform spawnPosition;
    FireMage fireMage;
    bool canUse = true;
    public ParticleSystem chargeParticle1, chargeParticle2;
    public override void Start() {
        base.Start();
        fireMage = GetComponentInParent<FireMage>();
    }

    public override void ButtonPressed(InputAction.CallbackContext context) {
        if(!stats.isAlive) {
            return;
        }

        if(context.performed) {
            if(!OnCooldown() && canUse) {
                buttonPressed = context.ReadValue<float>();
                if(buttonPressed >= 0.5f) {
                    if(canUseSkill()) {
                        anim.Play(animation1);
                        chargeParticle1.Play();
                        chargeParticle2.Play();
                    }
                } else {
                    if(anim.GetCurrentAnimatorStateInfo(0).IsName(animation1)) {
                        anim.Play(animation3);
                        chargeParticle1.Stop();
                        chargeParticle2.Stop();
                        //canUse = false;
                    }
                }
            }
        }
    }

    public override void Update() {
        base.Update();
        if(anim.GetCurrentAnimatorStateInfo(0).IsName(animation1) ) {
            fireMage.RotationOverridenFromSkills();
        }

    }
    public override void ExecuteEnd() {
        SetCooldown();
        //canUse = true;
        FinishEffect();
    }

    public override void StartEffect() {

    }


    public override void FinishEffect() {
        GameObject missile = Instantiate(missilePrefab, spawnPosition.position, spawnPosition.rotation);
        missile.GetComponent<Missile>().damage = BaseDamage + stats.currentDamage;
        missile.GetComponent<Missile>().movementSpeed = missileSpeed;
    }

}
