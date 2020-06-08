using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    
    public bool isAiming;
    public LayerMask aimLayerMask;

    //public Transform spellSpawnPosition;

    public Vector3 aimingTargetPosition() {

        Ray ray = new Ray();
        ray.origin = transform.position;
        ray.direction = transform.forward;
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, 1000f, aimLayerMask)) {
            return hit.point;
        } else {
            return transform.position + (transform.forward * 100f);
        }

    }

}
