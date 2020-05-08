using UnityEngine.InputSystem;
using UnityEngine;
public class ThunderClap : Skill
{
    public float radius = 2f;
    public float baseDamage;
    public Buff effect;
    public override void StartEffect() {

    }
    public override void FinishEffect() {
        Vector3 center = transform.position + transform.forward;
        Collider[] colliders = Physics.OverlapSphere(center,radius, layerMask);
        foreach(Collider c in colliders) {
            Debug.Log(c.name);
            if(c.transform != transform.parent) {
                IHitBox hitbox = c.GetComponent<IHitBox>();
                if(hitbox != null) {
                    hitbox.GetDamage(baseDamage + stats.currentDamage, transform.up);
                }
                IBuffsAndEffects buffsAndEffects = c.GetComponent<IBuffsAndEffects>();
                if(buffsAndEffects != null) {
                    buffsAndEffects.AddEffect(effect);
                }
            }
        }
    }
}