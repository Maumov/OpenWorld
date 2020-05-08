using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BuffsAndEffects : MonoBehaviour, IBuffsAndEffects
{
    public List<Transform> particlePositions;
    public List<Effect> buffsAndEffects;
    Stats stats;
    private void Start() {

        stats = GetComponent<Stats>();
        buffsAndEffects = new List<Effect>();
        stats.OnDead += Dead;
    }
    public void AddEffect(Effect buffEffect) {
        Effect newEffectInstance = buffEffect.Copy();
        newEffectInstance.SetBuff();
        newEffectInstance.ApplyEffect(stats);
        //Vector3 position = GetEffectPosition(newEffectInstance);
        if(newEffectInstance.start != null) {
            newEffectInstance.startInstance = Instantiate(newEffectInstance.start, GetEffectPosition(newEffectInstance.startPosition));
            //newEffectInstance.startInstance.transform.localPosition = position;
        }
        if(newEffectInstance.tick != null) {
            newEffectInstance.tickInstance = Instantiate(newEffectInstance.tick, GetEffectPosition(newEffectInstance.tickPosition));
            //newEffectInstance.tickInstance.transform.localPosition = position;
        }
        buffsAndEffects.Add(newEffectInstance);
    }

    Transform GetEffectPosition(EffectPosition e) {
        switch(e) {
            case EffectPosition.Base:
                return particlePositions[0];
            case EffectPosition.Chest:
                return particlePositions[1];
            case EffectPosition.Head:
                return particlePositions[2];
        }
        return transform;
    }

    private void Update() {

        Ticks();
        RefreshBuffs();
        SetSpecialStats();
    }

    void Ticks() {
        foreach(Effect bf in buffsAndEffects) {
            bf.Tick(stats);
            bf.UpdateRemainingTime();
        }
    }

    void RefreshBuffs() {
        List<Effect> newList = new List<Effect>();
        foreach(Effect bf in buffsAndEffects) {
            if(bf.isActive()) {
                newList.Add(bf);
            } else {
                if(bf.tickInstance != null) {
                    Destroy(bf.tickInstance);
                }
                bf.RemoveEffect(stats);
            }
        }
        buffsAndEffects = new List<Effect>();
        buffsAndEffects.AddRange(newList);
    }

    void SetSpecialStats() {
        foreach(Effect bf in buffsAndEffects) {
            bf.Special(stats);
        }
    }
    public void Dead() {
        foreach(Effect bf in buffsAndEffects) {
            bf.RemoveEffect(stats);
        }
        buffsAndEffects = new List<Effect>();
    }
}
public interface IBuffsAndEffects
{
    void AddEffect(Effect buffEffect);
}

[System.Serializable]
public class Effect
{
    public StatusEffect statusChange;
    public float duration;
    protected float remainingTime;
    protected Stats stats;
    public GameObject start, tick;
    public EffectPosition startPosition, tickPosition;
    [HideInInspector]
    public GameObject startInstance, tickInstance;
    public void SetBuff() {
        remainingTime = duration;
    }
    public void UpdateRemainingTime() {
        remainingTime -= Time.deltaTime;
    }
    public bool isActive() {
        return remainingTime > 0f;
    }
    public virtual void ApplyEffect(Stats s) {
        s.status |= statusChange;
    }

    public virtual void RemoveEffect(Stats s) {
        s.status &= ~statusChange;
    }

    public virtual void Special(Stats s) {
        s.status |= statusChange;
    }

    public virtual void Tick(Stats s) {

    }

    public virtual Effect Copy() {
        Effect clone = new Effect();
        clone.statusChange = statusChange;
        clone.duration = duration;
        clone.remainingTime = remainingTime;
        clone.stats = stats;
        clone.start = start;
        clone.tick = tick;
        clone.startPosition = startPosition;
        clone.tickPosition = tickPosition;
        return clone;
    }

}

[System.Serializable]
public class DOT : Effect
{
    public float amount;
    public override void ApplyEffect(Stats s) {
        base.ApplyEffect(s);
    }

    public override void RemoveEffect(Stats s) {
        base.RemoveEffect(s);
    }

    public override void Special(Stats s) {
        base.Special(s);
    }

    public override void Tick(Stats s) {
        s.GetDamage( (amount / duration) * Time.deltaTime);
    }

    public override Effect Copy() {
        DOT clone = new DOT();
        clone.statusChange = statusChange;
        clone.duration = duration;
        clone.remainingTime = remainingTime;
        clone.stats = stats;
        clone.start = start;
        clone.tick = tick;
        clone.amount = amount;
        clone.startPosition = startPosition;
        clone.tickPosition = tickPosition;
        return clone;
    }
}

[System.Serializable]
public class HOT : Effect
{
    public float amount;
    public override void ApplyEffect(Stats s) {
        base.ApplyEffect(s);
    }

    public override void RemoveEffect(Stats s) {
        base.RemoveEffect(s);
    }

    public override void Special(Stats s) {
        base.Special(s);
    }

    public override void Tick(Stats s) {
        s.GetHealed((amount / duration) * Time.deltaTime);
    }
    public override Effect Copy() {
        HOT clone = new HOT();
        clone.statusChange = statusChange;
        clone.duration = duration;
        clone.remainingTime = remainingTime;
        clone.stats = stats;
        clone.start = start;
        clone.tick = tick;
        clone.amount = amount;
        clone.startPosition = startPosition;
        clone.tickPosition = tickPosition;
        return clone;
    }

}

[System.Serializable, System.Flags]
public enum StatusEffect{
    Stunned = 1, Frozen = 2, Injured = 4
}

public enum EffectPosition
{
    Head, Base, Chest
}

[System.Serializable]
public class Buff : Effect
{
    public float movementSpeedModifier;
    public float attackDamageModifier;
    public float HPRegenModifier;
    public float CooldownSpeedMofier;

    public override void ApplyEffect(Stats s) {
        base.ApplyEffect(s);
        s.currentMovement += movementSpeedModifier;
        s.currentDamage += attackDamageModifier;
        s.currentHPRegen += HPRegenModifier;
        s.currentCooldownSpeed += CooldownSpeedMofier;
    }

    public override void RemoveEffect(Stats s) {
        base.RemoveEffect(s);
        s.currentMovement -= movementSpeedModifier;
        s.currentDamage -= attackDamageModifier;
        s.currentHPRegen -= HPRegenModifier;
        s.currentCooldownSpeed -= CooldownSpeedMofier;
    }

    public override void Special(Stats s) {
        base.Special(s);
    }

    public override void Tick(Stats s) {
        base.Tick(s);
    }

    public override Effect Copy() {
        Buff clone = new Buff();
        clone.statusChange = statusChange;
        clone.duration = duration;
        clone.remainingTime = remainingTime;
        clone.stats = stats;
        clone.start = start;
        clone.tick = tick;
        clone.movementSpeedModifier = movementSpeedModifier;
        clone.attackDamageModifier = attackDamageModifier;
        clone.HPRegenModifier = HPRegenModifier;
        clone.CooldownSpeedMofier = CooldownSpeedMofier;
        clone.startPosition = startPosition;
        clone.tickPosition = tickPosition;
        return clone;
    }
}

[System.Serializable]
public class SpecialEffect : Effect
{   
    public override void ApplyEffect(Stats s) {
        base.ApplyEffect(s);
    }

    public override void RemoveEffect(Stats s) {
        base.RemoveEffect(s);
    }

    public override void Special(Stats s) {
        base.Special(s);
    }

    public override void Tick(Stats s) {
        base.Tick(s);
    }
    public override Effect Copy() {
        SpecialEffect clone = new SpecialEffect();
        clone.statusChange = statusChange;
        clone.duration = duration;
        clone.remainingTime = remainingTime;
        clone.stats = stats;
        clone.start = start;
        clone.tick = tick;
        clone.startPosition = startPosition;
        clone.tickPosition = tickPosition;
        return clone;
    }

}
