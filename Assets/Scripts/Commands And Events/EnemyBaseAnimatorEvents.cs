using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBaseAnimatorEvents : AnimatorEvents
{
    EnemyAttack enemyAttack;
    private void Start() {
        enemyAttack = GetComponentInParent<EnemyAttack>();
    }
    public void Attack() {
        enemyAttack.ExecuteAttack();
    }
    public void Shoot() {
        enemyAttack.ExecuteShoot();
    }
}
