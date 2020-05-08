using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBox : MonoBehaviour,IHitBox
{
    
    Renderer rend;

    void Start() {
        //rend = GetComponentInChildren<Renderer>();
    }
    public void GetDamage(float damage, Vector3 direction) {
        GetComponent<Stats>().GetDamage(damage);
        StartCoroutine(flash());
    }

    IEnumerator flash() {
        if(rend != null) {
            rend.material.EnableKeyword("_EMISSION");
            rend.material.SetColor("_EmissionColor", Color.white);
            yield return new WaitForSeconds(0.12f);
            rend.material.SetColor("_EmissionColor", Color.black);
        } else {
            
            rend = GetComponentInChildren<Renderer>();
            rend.material.EnableKeyword("_EMISSION");
            rend.material.SetColor("_EmissionColor", Color.white);
            yield return new WaitForSeconds(0.12f);
            rend.material.SetColor("_EmissionColor", Color.black);
        }
    }
}


