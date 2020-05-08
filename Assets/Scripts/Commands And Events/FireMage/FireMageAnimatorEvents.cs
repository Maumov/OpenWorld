using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireMageAnimatorEvents : AnimatorEvents
{
    void Attack() {
        GetComponent<FireMageAttack>().ExecuteEnd();
    }

    void Pyroblast() {
        GetComponent<Pyroblast>().ExecuteEnd();
    }
    void FrostNova() {
        GetComponent<FrostNova>().ExecuteEnd();
    }
}
