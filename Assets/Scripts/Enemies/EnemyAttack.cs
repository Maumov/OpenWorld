using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    Stats stats;
    public float baseDamage;
    public LayerMask layerMask;

    public GameObject hitParticle;
    private void Start() {
        stats = GetComponent<Stats>();
    }
    public void ExecuteAttack() {
        Vector3 center = transform.position + transform.up + transform.forward;
        Vector3 halfextends = new Vector3(1f, 1f, 1f);
        Collider[] colliders = Physics.OverlapBox(center, halfextends, transform.rotation, layerMask);
        //Debug.Log(colliders.Length);
        foreach(Collider c in colliders) {
            Ray ray = new Ray();
            ray.origin = transform.position + transform.up;
            ray.direction = c.transform.position - (transform.position);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit, 3f)) {
                IHitBox hitbox = hit.collider.GetComponent<IHitBox>();
                if(hitbox != null) {
                    Instantiate(hitParticle, hit.point, Quaternion.Euler(hit.normal));
                    hitbox.GetDamage(baseDamage + stats.currentDamage, transform.forward);
                }
            }
        }
    }
}
