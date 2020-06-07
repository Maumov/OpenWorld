using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimatorEvents : AnimatorEvents
{
    void Attack() {
        GetComponent<BaseAttack>().ExecuteEnd();
    }
}
