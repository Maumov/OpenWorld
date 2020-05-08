using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    public StatusEffect status;
    public bool isAlive = true;
    public float baseHitPoints = 100;
    public float baseHPRegen = 0;
    public float baseDamage = 10f;
    public float baseMovement = 3f;
    public float baseCooldownSpeed;
    public float currentCooldownSpeed;
    public float currentHPRegen;
    public float currentHitPoints;
    public float HitPoints;
    public float currentDamage;
    public float currentMovement;

    public delegate void StatsChange();
    public event StatsChange OnDamaged, OnDead, OnHealed;

    public void SetInCombat() {
        CharacterMovement[] cm = GetComponentsInChildren<CharacterMovement>();
        foreach(CharacterMovement c in cm) {
            c.InCombat(true);
        }
    }
    void Start() {
        HitPoints = baseHitPoints;
        currentHitPoints = HitPoints;
        currentHPRegen = baseHPRegen;
        currentDamage = baseDamage;
        currentMovement = baseMovement;
        currentCooldownSpeed = baseCooldownSpeed;
    }

    private void Update() {
        GetHealed(currentHPRegen);
    }

    public void GetDamage(float amount) {
        currentHitPoints -= amount;
        currentHitPoints = Mathf.Clamp(currentHitPoints, 0, HitPoints);
        if(currentHitPoints <= 0) {
            Dead();
        } else {
            if(OnDamaged != null) {
                OnDamaged();
            }
        }
    }

    public void GetHealed(float amount) {
        currentHitPoints += amount;
        currentHitPoints = Mathf.Clamp(currentHitPoints, 0, HitPoints);
        if(OnHealed != null) {
            OnHealed();
        }
    }

    public void Dead() {
        isAlive = false;
        if(OnDead != null) {
            OnDead();
        }
    }
}
