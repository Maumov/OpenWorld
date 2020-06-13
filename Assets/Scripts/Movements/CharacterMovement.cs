using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class CharacterMovement : MonoBehaviour
{
    protected bool inCombat;
    float outOfCombatTime;

    public void InCombat(bool val) {
        inCombat = val;
        outOfCombatTime = Time.time + 5f;
        
    }

    protected Vector2 direction;
    protected float jump;
    
    protected CameraController cameraController;
    protected Stats stats;
    public Animator anim;
    public float jumpSpeed = 10f;
    public float gravity = 20f;
    protected CharacterController characterController;
    protected Vector3 correctedDirection;
    protected Vector3 locomotionDirection;
    protected float locomotionY = 0f;
    //bool landed = false;
    // Start is called before the first frame update
    public virtual void Start()
    {
        stats = GetComponent<Stats>();
        locomotionDirection = Vector3.zero;
        correctedDirection = Vector3.zero;
        characterController = GetComponent<CharacterController>();
        cameraController = FindObjectOfType<CameraController>();
    }

    // Update is called once per frame
    public virtual void Update()
    {
        OutOfCombat();
        Rotate();
        Move();
        Jump();
        Locomotion();
        SetAnimatorValues();
    }

    public void OutOfCombat() {
        if(outOfCombatTime < Time.time) {
            inCombat = false;
        }
    }


    public virtual void Rotate() {
        if(!stats.isAlive) {
            return;
        }
        if(direction.magnitude > 0f) {
            correctedDirection = cameraController.transform.rotation * new Vector3(direction.x, 0f, direction.y);
            transform.LookAt(transform.position + correctedDirection);
        } else {
            correctedDirection = Vector3.zero;
        }
    }

    public virtual void RotationOverridenFromSkills() {
        if(direction.magnitude > 0f) {
            correctedDirection = cameraController.transform.rotation * new Vector3(direction.x, 0f, direction.y);
            transform.LookAt(transform.position + correctedDirection);
        } else {
            correctedDirection = Vector3.zero;
        }
    }

    public virtual void Move() {
        if(!stats.isAlive || ((stats.status & StatusEffect.Frozen) != 0)) {
            return;
        }
        if(direction.magnitude > 0f) {
            locomotionDirection = correctedDirection * (stats.currentMovement);
        } else {
            locomotionDirection = Vector3.zero;
        }
    }

    public virtual void Jump() {
        
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
                        anim.SetBool("Landed", false);
                    }
                    jump = 0;
                } else {
                    if(anim.GetCurrentAnimatorStateInfo(0).IsName("Falling") && !anim.IsInTransition(0)) {
                        anim.SetTrigger("Landed");
                    }

                }
            } else {
                //is falling
                if(!anim.GetCurrentAnimatorStateInfo(0).IsName("Falling") && !anim.IsInTransition(0)) {
                    anim.SetTrigger("Falling");
                }
                locomotionY -= gravity * Time.deltaTime;
                anim.SetBool("Landed", false);
            }
        } else {
            //is still climbing altitude
            locomotionY -= gravity * Time.deltaTime;
            anim.SetBool("Landed", false);
        }

    }

    public virtual void LeftJoystick(InputAction.CallbackContext context) {
        direction = context.ReadValue<Vector2>();
        direction = Vector3.ClampMagnitude(direction, 1f);
    }

    public virtual void JumpButton(InputAction.CallbackContext context) {
        if(context.performed) {
            Debug.Log(context.ReadValue<float>());
            jump = context.ReadValue<float>();
        }
    }

   

    public virtual void Locomotion() {
        Vector3 finalDirection = Vector3.zero;
        if(anim.GetCurrentAnimatorStateInfo(0).IsName("Grounded") && !anim.IsInTransition(0)) {
            finalDirection = new Vector3(0f, 0f, 0f);
        } else {
            finalDirection = new Vector3(locomotionDirection.x, 0f, locomotionDirection.z);
        }
        finalDirection.y = locomotionY;
        characterController.Move(finalDirection * Time.deltaTime);
    }

    public virtual void SetAnimatorValues() {
        anim.SetFloat("Speed", direction.magnitude);
        anim.SetFloat("Horizontal", direction.x);
        anim.SetFloat("Vertical", direction.y);
        
        anim.SetBool("InCombat", inCombat);

        if((stats.status & StatusEffect.Stunned) != 0) {
            anim.SetBool("Stunned", true);
        } else {
            anim.SetBool("Stunned", false);
        }
        if((stats.status & StatusEffect.Injured) != 0) {
            anim.SetBool("Injured", true);
        } else {
            anim.SetBool("Injured", false);
        }

        if((stats.status & StatusEffect.Frozen) != 0) {
            anim.SetFloat("AnimationSpeedMultiplier", 0f);
        } else {
            anim.SetFloat("AnimationSpeedMultiplier", 1f);
        }
    }
    public bool isGrounded2() {
        //RaycastHit hit;
        Ray ray = new Ray();
        ray.origin = transform.position;
        ray.direction = -transform.up;
        float maxDistance = 0.1f; 
        if(Physics.Raycast(ray, maxDistance)) {
            return true;
        } else {
            return false;
        }
    }
    public LayerMask groundedLayerMask;
    public bool isGrounded() {
        //RaycastHit hit;
        //float maxDistance = 0.1f;
       

        if(Physics.CheckSphere(transform.position + new Vector3(0f,0.3f,0f),0.4f,groundedLayerMask)) {
        //}
        //if(Physics.CheckBox(transform.position, new Vector3(0.5f,0.1f,0.5f), transform.rotation, groundedLayerMask)) {
            return true;
        } else {
            return false;
        }
    }
   
}
