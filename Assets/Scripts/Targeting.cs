using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targeting : MonoBehaviour
{
    SphereCollider sphereCollider;
    public List<Target> targets;
    public Target currentTarget;
    private void Start() {
        targets = new List<Target>();
        StartCoroutine(TargetUpdates());
    }

    IEnumerator TargetUpdates() {
        while(GetComponentInParent<Stats>().isAlive) {
            UpdateTarget();
            yield return new WaitForSeconds(2f);
        }
        yield return null;
    }
    private void OnTriggerEnter(Collider other) {
        CharacterSetup characterSetup = other.GetComponent<CharacterSetup>();
        if(characterSetup != null) {
            Target t = new Target();
            t.stats = characterSetup.GetComponentInChildren<Stats>();
            if(t.stats != null) {
                if(!targets.Contains(t)) {
                    targets.Add(t);
                }
            }
        }
    }
    public bool hasTarget() {
        if(currentTarget != null) {
            if(currentTarget.stats != null) {
                if(currentTarget.stats.isAlive) {
                    return true;
                }
            }
        }
        return false;
    }
    void UpdateTarget() {
        if(!hasTarget()) {
            currentTarget = GetTarget(); 
        }
        if(currentTarget != null) {
            currentTarget.stats.SetInCombat();
        }
    }

    Target GetTarget(){
        return ClosestPosibleTarget();
    }

    Target ClosestPosibleTarget() {
        Target t;
        float distance;
        List<Target> posibleTargets = new List<Target>();
        posibleTargets.AddRange(PosibleTargets());
        if(posibleTargets.Count > 0) {
            t = posibleTargets[0];
            distance = Vector3.Distance(transform.position, t.stats.transform.position);
        } else {
            return null;
        }
        for( int i = 0 ; i < posibleTargets.Count ; i++ ) {
            float d = Vector3.Distance(transform.position, posibleTargets[i].stats.transform.position);
            if( d < distance  ) {
                t = posibleTargets[i];
            }
        }
        return t;
    }
    List<Target> PosibleTargets() {
        List<Target> posibleTargets = new List<Target>();
        for(int i = 0; i < targets.Count; i++) {
            if(targets[i].stats.isAlive) {
                posibleTargets.Add(targets[i]);
            }
        }
        return posibleTargets;
    }
    public void ClearTargets() {
        targets = new List<Target>();
    }

    private void OnGUI() {
        Vector3 posOffSet = new Vector3(0f,1f,0f);
        foreach(Target t in targets) {
            Debug.DrawLine(transform.position + posOffSet, t.stats.transform.position + posOffSet, Color.green);
        }
        List<Target> posible = new List<Target>();
        posible.AddRange(PosibleTargets());
        foreach(Target t in posible) {
            Debug.DrawLine(transform.position + posOffSet, t.stats.transform.position + posOffSet, Color.red);
        }
        if(hasTarget()) {
            Debug.DrawLine(transform.position + posOffSet, currentTarget.stats.transform.position + posOffSet, Color.white);
        }


    }
}

[System.Serializable]
public class Target{
    public Stats stats;
    public int agroo = 1;
}
