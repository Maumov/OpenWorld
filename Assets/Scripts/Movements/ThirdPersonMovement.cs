using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class ThirdPersonMovement : CharacterMovement
{
    public CinemachineFreeLook freeLook;
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;
    public override void Start() {
        anim = GetComponentInChildren<Animator>();
        stats = GetComponent<Stats>();
        locomotionDirection = Vector3.zero;
        correctedDirection = Vector3.zero;
        characterController = GetComponent<CharacterController>();
        cameraController = FindObjectOfType<CameraController>();
        freeLook = FindObjectOfType<CinemachineFreeLook>();
    }

    public virtual void LeftJoystick(InputAction.CallbackContext context) {
        direction = context.ReadValue<Vector2>();
        direction = Vector3.ClampMagnitude(direction, 1f);
    }

    public override void Update() {
        OutOfCombat();
        Rotate();
        Move();
        //Jump();
        Locomotion();
        SetAnimatorValues();
    }

    public override void Rotate() {
        if(!stats.isAlive) {
            return;
        }
        if(direction.magnitude > 0f) {
            float targetAngle = Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg + cameraController.transform.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            correctedDirection = Quaternion.Euler(0f,targetAngle,0f) * Vector3.forward;
            correctedDirection = correctedDirection.normalized;
            //transform.LookAt(transform.position + correctedDirection);
        } else {
            correctedDirection = Vector3.zero;
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

    public override void Locomotion() {
        Vector3 finalDirection = Vector3.zero;
        if(anim.GetCurrentAnimatorStateInfo(0).IsName("Grounded") && !anim.IsInTransition(0)) {
            finalDirection = new Vector3(0f, 0f, 0f);
        } else {
            finalDirection = new Vector3(locomotionDirection.x, 0f, locomotionDirection.z);
        }
        finalDirection.y = locomotionY;
        characterController.Move(finalDirection * Time.deltaTime);
    }

    

    public void Look(InputAction.CallbackContext context) {


        freeLook.m_XAxis.m_InputAxisValue = context.ReadValue<Vector2>().x;
        freeLook.m_YAxis.m_InputAxisValue = context.ReadValue<Vector2>().y;

    }
}
