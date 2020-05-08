
using UnityEngine;
using UnityEngine.InputSystem;

public abstract class Skill : MonoBehaviour
{
    public float cooldown;
    public float cooldownRemaining;
    public float buttonPressed;

    public string animation1, animation2, animation3;
    protected Animator anim;

    public LayerMask layerMask;
    public ParticleSystem baseParticleSystem;
    protected Stats stats;
    public virtual void Start() {
        stats = GetComponentInParent<Stats>();
        anim = GetComponent<Animator>();
    }

    public virtual void Update() {
        cooldownRemaining -= Time.deltaTime;
    }
    public virtual void ButtonPressed(InputAction.CallbackContext context) {
        if(!stats.isAlive) {
            return;
        }
        if(context.performed) {
            buttonPressed = context.ReadValue<float>();
            if(buttonPressed >= 0.5f) {
                if(canUseSkill() && !OnCooldown()) {
                    PlayAnimation(animation3);
                    SetCooldown();
                }
            }
        }
    }

    public virtual void PlayAnimation(string animation) {
        anim.Play(animation);
    }

    public virtual void ExecuteStart() {
        StartEffect();
    }
    public virtual void ExecuteEnd() {
        if(baseParticleSystem != null) {
            baseParticleSystem.Play();
        }
        FinishEffect();
    }


    public abstract void StartEffect();
    public abstract void FinishEffect();

    public void SetCooldown() {
        cooldownRemaining = cooldown;
    }

    public bool OnCooldown() {
        return cooldownRemaining >= 0f;
    }

    public bool canUseSkill() {
        if((anim.GetCurrentAnimatorStateInfo(0).IsName("Locomotion") ||
                anim.GetCurrentAnimatorStateInfo(0).IsName("Locomotion_inCombat") ||
                anim.GetCurrentAnimatorStateInfo(0).IsName("Grounded") ||
                anim.GetCurrentAnimatorStateInfo(0).IsTag("Basic Attack")) &&
                !anim.IsInTransition(0)) {
            return true;
        }
        else{
          return false;
        }
    }
}
