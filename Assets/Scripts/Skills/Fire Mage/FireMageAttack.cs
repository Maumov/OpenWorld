using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FireMageAttack : Skill
{
    public float BaseDamage = 10f;
    public float missileSpeed = 5f;
    bool attack;

    public GameObject missilePrefab;
    public Transform spawnPosition;
    FireMage fireMage;

    public override void Start() {
        //base.Start();
        fireMage = GetComponentInParent<FireMage>();
        stats = GetComponent<Stats>();
        anim = GetComponent<Animator>();
    }
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

    public override void Update() {
        base.Update();
        if(anim.GetCurrentAnimatorStateInfo(0).IsTag("Basic Attack")) {
            fireMage.RotationOverridenFromSkills();
        }

    }
    public override void ExecuteEnd() {
        
        FinishEffect();
    }

    public override void StartEffect() {

    }


    public override void FinishEffect() {
        GameObject missile = Instantiate(missilePrefab, spawnPosition.position, spawnPosition.rotation);
        missile.GetComponent<Missile>().damage = BaseDamage + stats.currentDamage;
        missile.GetComponent<Missile>().movementSpeed = missileSpeed;
        missile.GetComponent<Missile>().stats = stats;
    }

    
}
