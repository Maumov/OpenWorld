using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class ThirdPersonMovement : CharacterMovement
{
    public CinemachineStateDrivenCamera freeLook;
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;
    public float aim;

    CinemachineFreeLook fl;
    Vector2 direction2;
    public override void Start() {
        anim = GetComponentInChildren<Animator>();
        stats = GetComponent<Stats>();
        locomotionDirection = Vector3.zero;
        correctedDirection = Vector3.zero;
        characterController = GetComponent<CharacterController>();
        cameraController = FindObjectOfType<CameraController>();
        freeLook = FindObjectOfType<CinemachineStateDrivenCamera>();
    }

    public override void LeftJoystick(InputAction.CallbackContext context) {
        direction = context.ReadValue<Vector2>();
        direction = Vector3.ClampMagnitude(direction, 1f);
    }
    
    public void RightJoyStick(InputAction.CallbackContext context) {

        direction2 = context.ReadValue<Vector2>();
        direction2 = Vector3.ClampMagnitude(direction2, 1f);
        fl = freeLook.LiveChild.VirtualCameraGameObject.GetComponent<CinemachineFreeLook>();
        if(aim == 1f) {
            fl.m_YAxis.m_InputAxisValue = direction2.y;
        } else {
            fl.m_XAxis.m_InputAxisValue = direction2.x;
            fl.m_YAxis.m_InputAxisValue = direction2.y;
        }
        //direction2 = Vector2.zero;
    }
    public override void Update() {
        OutOfCombat();
        Rotate();
        Move();
        Jump();
        Locomotion();
        SetAnimatorValues();
    }

    public override void Rotate() {
        if(!stats.isAlive) {
            return;
        }
        if(!isAiming) {
            if(direction.magnitude > 0f) {
                float targetAngle = Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg + cameraController.transform.eulerAngles.y;

                float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);

                transform.rotation = Quaternion.Euler(0f, angle, 0f);
                //Vector3 rotation = cameraController.transform.rotation * new Vector3(direction.x , 0f, direction.y);

                //transform.rotation = Quaternion.Euler(rotation.x, rotation.y, rotation.z);
            } else {
                correctedDirection = Vector3.zero;
            }

        } else {
            transform.Rotate(0f, direction2.x * 300f * Time.deltaTime, 0f);
        }
    }
    public override void Move() {
        if(!stats.isAlive || ((stats.status & StatusEffect.Frozen) != 0)) {
            return;
        }
        if(direction.magnitude > 0f) {
            locomotionDirection = correctedDirection * (stats.currentMovement);
        } else {
            locomotionDirection = Vector3.zero;
        }
    }

    public override void RotationOverridenFromSkills() {
        if(direction.magnitude > 0f) {
            correctedDirection = cameraController.transform.rotation * new Vector3(direction.x, 0f, direction.y);
            transform.LookAt(transform.position + correctedDirection);
        } else {
            correctedDirection = Vector3.zero;
        }
    }
    public override void Jump() {
        if(locomotionY <= 0f) {
            //is falling
            if(isGrounded()) {
                //has floor under him
                locomotionY = -gravity * Time.deltaTime;
                if(jump == 1) {
                    if(anim.GetCurrentAnimatorStateInfo(0).IsName("Locomotion") ||
                        anim.GetCurrentAnimatorStateInfo(0).IsName("Locomotion_inCombat") ||
                        anim.GetCurrentAnimatorStateInfo(0).IsName("Grounded")) {
                        locomotionY = jumpSpeed;
                        anim.SetTrigger("Jump");
                        //anim.SetBool("Landed", false);
                    }
                    jump = 0;
                } else {
                    if(anim.GetCurrentAnimatorStateInfo(0).IsName("Falling") && !anim.IsInTransition(0)) {
                        //anim.SetTrigger("Landed");
                    }

                }
            } else {
                //is falling
                if(!anim.GetCurrentAnimatorStateInfo(0).IsName("Falling") && !anim.IsInTransition(0)) {
                    //anim.SetTrigger("Falling");
                }
                locomotionY -= gravity * Time.deltaTime;
                //anim.SetBool("Landed", false);
            }
        } else {
            //is still climbing altitude
            locomotionY -= gravity * Time.deltaTime;
            //anim.SetBool("Landed", false);
        }

    }

    public override void Locomotion() {
        Vector3 finalDirection = Vector3.zero;
        if(anim.GetCurrentAnimatorStateInfo(0).IsName("Grounded") && !anim.IsInTransition(0)) {
            finalDirection = new Vector3(0f, 0f, 0f);
        } else {
            finalDirection = new Vector3(locomotionDirection.x, 0f, locomotionDirection.z);
        }
        finalDirection.y = locomotionY;
        //characterController.Move(finalDirection * Time.deltaTime);
    }

    
    //bool aimInCooldown;
    public bool isAiming;
    public virtual void AimOrTarget(InputAction.CallbackContext context) {
        if(context.performed) {
            //Debug.Log(context.ReadValue<float>());
      //      if(!aimInCooldown) {
                aim = context.ReadValue<float>();
                if(aim == 1f) {
                    transform.rotation = Quaternion.Euler(0f, cameraController.transform.eulerAngles.y, 0f);
        //            isAiming = true;
      //          } else {
          //          if(isAiming) {
            //            aimInCooldown = true;
              //          Invoke("ResetAimCooldown", 1f);
                //        isAiming = false;
                  //  }
                }
          //  }
            
        }
    }

    //void ResetAimCooldown() {
     //   aimInCooldown = false;
    //}


    public override void SetAnimatorValues() {
        anim.SetFloat("Speed", direction.magnitude);
        anim.SetFloat("Horizontal", direction.x);
        anim.SetFloat("Vertical", direction.y);

        anim.SetFloat("Aiming", aim);
        anim.SetBool("InCombat", inCombat);

        //if((stats.status & StatusEffect.Stunned) != 0) {
        //    anim.SetBool("Stunned", true);
        //} else {
        //    anim.SetBool("Stunned", false);
        //}
        //if((stats.status & StatusEffect.Injured) != 0) {
        //    anim.SetBool("Injured", true);
        //} else {
        //    anim.SetBool("Injured", false);
        //}

        //if((stats.status & StatusEffect.Frozen) != 0) {
        //    anim.SetFloat("AnimationSpeedMultiplier", 0f);
        //} else {
        //    anim.SetFloat("AnimationSpeedMultiplier", 1f);
        //}
    }
    
}
