using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorAnimatorEvents : AnimatorEvents
{
    
    void Taunt() {
        GetComponent<Taunt>().ExecuteEnd();
    }
    void ThunderClap() {
        GetComponent<ThunderClap>().ExecuteEnd();
    }
    void ShieldBash() {
        GetComponent<ShieldBash>().ExecuteEnd();
    }

    void ChargeEnd() {
        GetComponent<Charge>().ExecuteEnd();
    }

    void Attack() {
        GetComponent<WarriorAttack>().ExecuteEnd();
    }

    void SlashStart() {
        GetComponent<WarriorAttack>().SlashStart();
    }

    void SlashEnd() {
        GetComponent<WarriorAttack>().SlashEnd();
    }
}
