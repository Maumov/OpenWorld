using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public float lifeTime = 10f;
    public float damage;
    public float movementSpeed;

    public ParticleSystem missileHitParticle;
    private void Start() {
        Destroy(gameObject,lifeTime);
    }

    // Update is called once pe
    public virtual void Update()
    {
        transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other) {
        Instantiate(missileHitParticle, transform.position, transform.rotation);
        IHitBox hitbox = other.GetComponent<IHitBox>();
        if(hitbox != null) {
            hitbox.GetDamage(damage , transform.forward);
        }
        Destroy(gameObject);
    }
}
