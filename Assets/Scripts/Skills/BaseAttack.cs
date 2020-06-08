using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class BaseAttack : Skill
{
    public float BaseDamage = 10f;
    public float missileSpeed = 5f;
    bool attack;

    public GameObject missilePrefab;
    public Transform spawnPosition;
    ThirdPersonMovement baseMovement;

    CameraController cameraController;
    public override void Start() {
        //base.Start();
        baseMovement = GetComponent<ThirdPersonMovement>();
        cameraController = FindObjectOfType<CameraController>();
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
        //if(anim.GetCurrentAnimatorStateInfo(0).IsTag("Basic Attack")) {
        //    baseMovement.RotationOverridenFromSkills();
        //}

    }
    public override void ExecuteEnd() {

        FinishEffect();
    }

    public override void StartEffect() {

    }


    public override void FinishEffect() {
        GameObject missile = Instantiate(missilePrefab, spawnPosition.position, spawnPosition.rotation);
        Vector3 dir = cameraController.aimingTargetPosition();
        if(baseMovement.aim == 1f) {
            missile.transform.LookAt(dir);
        }
        missile.GetComponent<Missile>().damage = BaseDamage + stats.currentDamage;
        missile.GetComponent<Missile>().movementSpeed = missileSpeed;
        missile.GetComponent<Missile>().stats = stats;
    }

}
